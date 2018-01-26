using EmploiDuTempsDLL;
using System;
using System.Collections;
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
    public partial class listeEtudiantSco : Form
    {
        IScolarite obj;
        List<UtilisateurObj> listet;
        public listeEtudiantSco(IScolarite obj)
        {
            this.obj = obj;
        
            InitializeComponent();
            this.ajouterNiveaux();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listeEtud.Columns[e.ColumnIndex].Width;
        }

        private void listeEtud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ajouterNiveaux()
        {

            ArrayList niveaux = obj.acceder_Niveaux(loginForm.user.specialite);
            if (niveaux != null)
            {
                niveauDrop.Clear();
                foreach (String item in niveaux)
                {

                    niveauDrop.AddItem(item);
                }



            }


        }

        private void niveauDrop_onItemSelected(object sender, EventArgs e)
        {
            this.ajouterGroupes();
            groupeDrop.Enabled = true;
        }
        private void ajouterGroupes()
        {

            ArrayList groupes = obj.acceder_Groupes_par_niveau(Int32.Parse(niveauDrop.selectedValue), loginForm.user.specialite);
            if (groupes != null)
            {
                groupeDrop.Clear();
                foreach (int item in groupes)
                {

                    groupeDrop.AddItem(item.ToString());
                }




            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if(niveauDrop.selectedIndex!=-1 && groupeDrop.selectedIndex != -1)
            {
                listet = obj.acceder_etudiants(loginForm.user.specialite, Int32.Parse(niveauDrop.selectedValue), Int32.Parse(groupeDrop.selectedValue));

                foreach (UtilisateurObj item in listet)
                {
                   
                    string[] row = { item.nom, item.prenom };
                    var Item = new ListViewItem(row);
                    listeEtud.Items.Add(Item);
                }



            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
