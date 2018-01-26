using EmploiDuTempsDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace ClientEmploi
{
    public partial class AjouterSeanceForm2 : Form
    {
        IScolarite obj;
        private bool Drag;
        private int MouseX;
        private int MouseY;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        Dictionary<String, int> modules;
        Dictionary<int, int> salles;
        Dictionary<String, int> listcr;
        List<UtilisateurObj> enseignants;
     
        public AjouterSeanceForm2(IScolarite obj)
        {
           
            m_aeroEnabled = false;
            this.obj = obj;
            InitializeComponent();
            modules = obj.acceder_modules(loginForm.user.specialite);
            moduleDrop.Clear();
            foreach (var item in modules)
            {
                moduleDrop.AddItem(item.Key);

            }

            enseignants = obj.acceder_enseignants(loginForm.user.specialite);
            enDrop.Clear();
            foreach (var item in enseignants)
            {
                
                enDrop.AddItem(item.id_utilisateur+" - "+item.nom+" "+item.prenom);

            }


        }

        
        private void annlerAjoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ajouterSeaBtn_Click(object sender, EventArgs e)
        {
            if( moduleDrop.selectedIndex!=-1 && sectionDrop.selectedIndex != -1 && typeDrop.selectedIndex != -1 &&
                grDrop.selectedIndex != -1 && enDrop.selectedIndex != -1 && salleDrop.selectedIndex != -1 &&
                CreneauDrop.selectedIndex != -1 || moduleDrop.selectedIndex != -1 && sectionDrop.selectedIndex != -1 && typeDrop.selectedIndex != -1 &&
                grDrop.selectedIndex == -1 && enDrop.selectedIndex != -1 && salleDrop.selectedIndex != -1 &&
                CreneauDrop.selectedIndex != -1)
            {


                Boolean ajoute = true;
                EmploiObj seance = new EmploiObj();
                String[] tbl = enDrop.selectedValue.Split(' ');
                seance.id_en = Int32.Parse(tbl[0]);
                seance.id_module = modules[moduleDrop.selectedValue];
                seance.section = Int32.Parse(sectionDrop.selectedValue);
                 tbl = salleDrop.selectedValue.Split(' ');
                MessageBox.Show(tbl[tbl.Length - 1]);
                seance.salle = salles[Int32.Parse(tbl[tbl.Length - 1])];
                seance.id_creaneau = listcr[CreneauDrop.selectedValue];
                if (est_suppBox.Checked) { 
                    seance.est_supp = 1;
                }
                if (typeDrop.selectedValue.Equals("Cours"))
                {
                    ArrayList groupes = obj.acceder_Groupes(modules[moduleDrop.selectedValue], Int32.Parse(sectionDrop.selectedValue));
                    foreach (String item in groupes)
                    {

                        seance.group = Int32.Parse(item);
                        if (! obj.InsererSeance(seance))
                        {
                            ajoute = false;

                        }
                    }

                }
                else
                {

                    seance.group = Int32.Parse(grDrop.selectedValue);
                    if (!obj.InsererSeance(seance)) { 
                        ajoute = false;
                    }

                }
                if (ajoute)
                {
                    MessageBox.Show("Seance ajoutée avec succés");
                    this.Close();


                }
                else MessageBox.Show("Seance non ajoutée");
            }
            else
            {


                    MessageBox.Show("veuillez remplir tout les champs");

            }



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }
        private void PanelMove_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Drag = false;
        }

        private void moduleDrop_onItemSelected(object sender, EventArgs e)
        {
           
            ArrayList sections = obj.acceder_Section(loginForm.user.specialite, modules[moduleDrop.selectedValue]);
            sectionDrop.Clear();
            foreach (String item in sections)
            {
               
                sectionDrop.AddItem(item);
            }
            sectionDrop.Enabled = true;

            if (enDrop.selectedIndex != -1)
            {
                int niveau = obj.acceder_Niveaux(modules[moduleDrop.selectedValue]);
                String[] tbl = enDrop.selectedValue.Split(' ');
                int id_en = Int32.Parse(tbl[0]);
                listcr = obj.acceder_creneaux(loginForm.user.specialite, niveau,Int32.Parse(sectionDrop.selectedValue), id_en);

                CreneauDrop.Clear();
                foreach (var item in listcr)
                {

                    CreneauDrop.AddItem(item.Key);


                }

                CreneauDrop.Enabled = true;

            }
        }

        private void typeDrop_onItemSelected(object sender, EventArgs e)
        {
             

            if ((!typeDrop.selectedValue.Equals("Cours")))
            {
                if(sectionDrop.selectedIndex != -1) { 
                ArrayList groupes = obj.acceder_Groupes(modules[moduleDrop.selectedValue],Int32.Parse(sectionDrop.selectedValue));
                grDrop.Clear();
                foreach (String item in groupes)
                {
                 
                    grDrop.AddItem(item);

                }
                grDrop.Enabled = true;
                }
                

            }
            else
            {
                grDrop.Clear();
                grDrop.Enabled = false;
     
            }
          
        }

        private void sectionDrop_onItemSelected(object sender, EventArgs e)
        {
            if (typeDrop.selectedIndex!=-1)
            {


                ArrayList groupes = obj.acceder_Groupes(modules[moduleDrop.selectedValue], Int32.Parse(sectionDrop.selectedValue));
                grDrop.Clear();
                foreach (String item in groupes)
                {
                   
                    grDrop.AddItem(item);

                }
                grDrop.Enabled = true;
            }
        }

        private void salleDrop_onItemSelected(object sender, EventArgs e)
        {
            String[] tbl = salleDrop.selectedValue.Split(' ');
            MessageBox.Show(tbl[tbl.Length - 1]);
            listcr = obj.acceder_creneaux(salles[Int32.Parse(tbl[tbl.Length-1])]);

            CreneauDrop.Clear();
            foreach (var item in listcr)
            {

                CreneauDrop.AddItem(item.Key);


            }

            CreneauDrop.Enabled = true;

        }

        private void CreneauDrop_onItemSelected(object sender, EventArgs e)
        {
            salles = new Dictionary<int, int>();

            salleDrop.Clear();

            if ((!typeDrop.Equals("Cours")))
            {


                if (typeDrop.Equals("TD"))
                {
                    salles = obj.acceder_salles_Dispo("td", listcr[CreneauDrop.selectedValue]);

                    foreach (var item in salles)
                    {
                        salleDrop.AddItem("Salle TD " + item.Key);

                    }

                }
                else
                {

                    salles = obj.acceder_salles_Dispo("tp", listcr[CreneauDrop.selectedValue]);
                    foreach (var item in salles)
                    {
                        salleDrop.AddItem("Salle TP " + item.Key);

                    }

                }


            }
            else
            {

                salles = obj.acceder_salles_Dispo("amphi", listcr[CreneauDrop.selectedValue]);
                foreach (var item in salles)
                {
                    salleDrop.AddItem("Amphi " + item.Key);

                }



            }
            salleDrop.Enabled = true;

        }

        private void salleDrop_onItemSelected_1(object sender, EventArgs e)
        {

        }

        private void enDrop_onItemSelected(object sender, EventArgs e)
        {

            if (moduleDrop.selectedIndex != -1)
            {
                int niveau = obj.acceder_Niveaux(modules[moduleDrop.selectedValue]);
                String[] tbl = enDrop.selectedValue.Split(' ');
                int id_en = Int32.Parse(tbl[0]);
                listcr = obj.acceder_creneaux(loginForm.user.specialite, niveau, Int32.Parse(sectionDrop.selectedValue), id_en);

                CreneauDrop.Clear();
                foreach (var item in listcr)
                {

                    CreneauDrop.AddItem(item.Key);


                }
                CreneauDrop.Enabled = true;


            }

        }
    }
}
