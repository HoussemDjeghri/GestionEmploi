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
    public partial class listeEtudiant : Form
    {
        public listeEtudiant()
        {
            InitializeComponent();

        
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listeEtud.Columns[e.ColumnIndex].Width;
        }

        private void listeEtud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
