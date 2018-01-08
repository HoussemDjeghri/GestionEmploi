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
    public partial class dashBoardScolarite : Form
    {
        public dashBoardScolarite()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           gestionEmploiFom emp = new gestionEmploiFom();
            emp.TopLevel = false;
            emp.AutoScroll = true;
            container.Controls.Clear();
           container.Controls.Add(emp);
            emp.Show();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
