using EmploiDuTempsDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Windows.Shell;
using System.Collections;
using System.Runtime.Serialization.Formatters;

namespace ClientEmploi
{
    public partial class loginForm : Form
    {
        public static UtilisateurObj user;
        public static  IAuthentification obj;
        
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

        public loginForm()
        {
            user = null;
            this.ConnectToServer();
            InitializeComponent();
         
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


        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           if(idField.Text.Equals("") || passwordField.Text.Equals(""))
            {

                MessageBox.Show("Veuillez remplir tout les champs");

            }else
            {
             
                    user = obj.authentification(Int32.Parse(idField.Text), passwordField.Text);
                    if (user != null)
                    {
                        

                        switch (user.type)
                        {
                            case "Etudiant":
                                IEtudiant et = (IEtudiant)Activator.GetObject(typeof(IEtudiant), "tcp://localhost:1235/ObjEtudiant");
                            if (et == null)
                            {

                                MessageBox.Show("Problem du Serveur");

                            }
                                menuEtudiant me = new menuEtudiant(et);
                                this.Hide();
                                me.Closed += (s, args) => this.Close();
                                me.Show();


                                break;
                            case "Enseignant":
                                IEnseignant en = (IEnseignant)Activator.GetObject(typeof(IEnseignant), "tcp://localhost:1235/ObjEnseignant");
                            if (en == null)
                            {

                                MessageBox.Show("Problem du Serveur");

                            }

                            menuEnseignant men = new menuEnseignant(en);
                                this.Hide();
                                men.Closed += (s, args) => this.Close();

                                men.Show();
                                break;
                            case "AgentScolarite":
                                IScolarite sc = (IScolarite)Activator.GetObject(typeof(IScolarite), "tcp://localhost:1235/ObjScolarite");
                            if (sc == null)
                            {

                                MessageBox.Show("Problem du Serveur");

                            }
                            menuScolarite msc = new menuScolarite(sc);
                                this.Hide();
                                msc.Closed += (s, args) => this.Close();
                                msc.Show();
                                break;


                            default:
                                break;
                        }



                    }
                    else
                    {


                        erreurLabel.Visible = true;



                    }












            }
        }

        private void idField_Click(object sender, EventArgs e)
        {
            if (erreurLabel.Visible) { erreurLabel.Visible = false;  }
           
        }

        private void passwordField_Click(object sender, EventArgs e)
        {

          

            if (erreurLabel.Visible) { erreurLabel.Visible = false; }
        }

        private void passwordField_OnValueChanged(object sender, EventArgs e)
        {

        }

        public void ConnectToServer()
        {

            BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();
            provider.TypeFilterLevel = TypeFilterLevel.Full;
            IDictionary props = new Hashtable();
            props["port"] = 0;

            TcpChannel chnl = new TcpChannel(props, null, provider);


            ChannelServices.RegisterChannel(chnl, false);

            Console.WriteLine("Client : Canal Enregistré");
            obj = (IAuthentification)Activator.GetObject(typeof(IAuthentification), "tcp://localhost:1235/ObjAuthentification");

            if (obj == null)
            {
                Console.WriteLine("Problem du Serveur");

            }
            else
            {
                Console.WriteLine("Reference Aquise avec succés");
            }

            Console.WriteLine("Serveur Démarré");


        }


    }
    }

