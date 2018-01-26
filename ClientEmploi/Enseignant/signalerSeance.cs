using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientEmploi.Enseignant
{
    public partial class signalerSeance : Form
    {
        static signalerSeance sBox ;
        static Boolean supp;
        public signalerSeance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signalerModal_Paint(object sender, PaintEventArgs e)
        {

        }
        public static Boolean ShowBox()
        {
            sBox = new signalerSeance();
            sBox.ShowDialog();
            return supp;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            supp = true;
            this.Dispose();
        }

        private void signalB_Click(object sender, EventArgs e)
        {
           this.Dispose();
            supp = false;
        }
    }
}
