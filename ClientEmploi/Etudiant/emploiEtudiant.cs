using Bunifu.Framework.UI;
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
    public partial class emploiEtudiant : Form
    {
        public emploiEtudiant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void emploiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        public void AddToEmploiPanel(BunifuThinButton2 bt,int ligne,int col) {


            emploiPanel.Controls.Add(bt,col,ligne);
            

        }
        public TableLayoutPanel getEmploi() { return emploiPanel; }
    }
}
