using EmploiDuTempsDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientEmploi
{
    public partial class dashboardScolarite : Form
    {
        IScolarite obj;
        public dashboardScolarite(IScolarite obj)
        {
            InitializeComponent();

            int nbr_modules = obj.acceder_nombre_modules(loginForm.user.specialite);
            moduleLbl.Text = nbr_modules.ToString();
            int nbr_enseignants = obj.acceder_nombre_enseignants(loginForm.user.specialite);
            enseignantLbl.Text = nbr_enseignants.ToString();
            int nbr_etudiants = obj.acceder_nombre_etudiants(loginForm.user.specialite);
            etudiantsLbl.Text = nbr_etudiants.ToString();

          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void dashboardEnseignant_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
