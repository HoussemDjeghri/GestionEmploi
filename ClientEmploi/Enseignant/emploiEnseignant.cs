using Bunifu.Framework.UI;
using ClientEmploi.Enseignant;
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

namespace ClientEmploi
{
    public partial class emploiEnseignant : Form
    {
        
        public emploiEnseignant()
        {

            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public TableLayoutPanel get_emploi()
        {
            return emploiPanel;
        }

        public void AddToEmploiPanel(BunifuThinButton2 bt, int ligne, int col,int id_seance)
        {
          
            emploiPanel.Controls.Add(bt, ligne, col);
           
            bt.Click += (sender, EventArgs) => { signaler_Click(sender, EventArgs, id_seance); };

        }

        public void signaler_Click(object  sender, EventArgs e, int id_seance) {


         if (signalerSeance.ShowBox())
            {

                MessageBox.Show("Séance signalé");

            }
            else
            {

                MessageBox.Show("Séance non signalé");

            }

           

        }
        private void bunifuDropdown1_onItemSelected_1(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
       
        public void showModal(Object sender, EventArgs e)
        {
            


        }

        public void OnEmploiChanged(int id_en, String notif)
        {

            if (loginForm.user.id_utilisateur == id_en)
            {

                MessageBox.Show(notif);

            }

        }

    }
}
