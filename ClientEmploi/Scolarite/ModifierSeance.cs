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
    public partial class ModifierSeance : Form
    {
        static  IScolarite obj;
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
        Dictionary<String, int> listcr;
        Dictionary<int, int> salles;
        static ModifierSeance sBox;
        static Boolean supp;
        static EmploiObj seance;
        public ModifierSeance(IScolarite obj, EmploiObj seance)
        {


            ModifierSeance.seance = seance;
            m_aeroEnabled = false;
            ModifierSeance.obj = obj;
            InitializeComponent();
            
            listcr = obj.acceder_creneaux(loginForm.user.specialite,seance.niveau,seance.section);

            CreneauDrop.Clear();
            foreach (var item in listcr)
            {

                CreneauDrop.AddItem(item.Key);


            }




        }


        private void annlerAjoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void setObj()
        {

          

        }
        public static Boolean ShowBox(EmploiObj seance, IScolarite obj)
        {

          
          
            sBox = new ModifierSeance(obj,seance);
            sBox.ShowDialog();
            return supp;
        }




        private void ajouterSeaBtn_Click(object sender, EventArgs e)
        {
            if(CreneauDrop.selectedIndex!=-1 && salleDrop.selectedIndex != -1)
            {
                String[] temp = salleDrop.selectedValue.Split(' ');
                int id_sl = salles[Int32.Parse(temp[temp.Length - 1])];
                if (obj.Maj_Seance(seance.id_seance, listcr[CreneauDrop.selectedValue], id_sl))
                {

                    supp = true;
                    this.Dispose();

                }
                else
                {
                    supp = false;
                    this.Dispose();


                }


            }
            else
            {

                MessageBox.Show("Veuillez remplir tout les champs");

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
           
           
        }

   

      

        private void salleDrop_onItemSelected(object sender, EventArgs e)
        {
            

        }

        private void CreneauDrop_onItemSelected(object sender, EventArgs e)
        {
           salles = new Dictionary<int, int>();

            salleDrop.Clear();
          
            if ((!seance.type.Equals("amphi")))
            {
               
                
                if (seance.type.Equals("td"))
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
    }
}
