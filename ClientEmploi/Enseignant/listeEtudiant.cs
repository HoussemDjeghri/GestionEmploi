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
    public partial class listeEtudiant : Form
    {
        IEnseignant obj;
        List<UtilisateurObj> listet;
        public listeEtudiant(IEnseignant obj)
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
                    switch (item)
                    {
                        case "1":
                            niveauDrop.AddItem("1er License");
                            break;
                        case "2":
                            niveauDrop.AddItem("2éme License");
                            break;
                        case "3":
                            niveauDrop.AddItem("3éme License");
                            break;
                        case "4":
                            niveauDrop.AddItem("1er Master");
                            break;
                        case "5":
                            niveauDrop.AddItem("2éme Master");
                            break;
                    }

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
            int niveau = 0;
            switch (niveauDrop.selectedValue)
            {
                case "1er License": niveau = 1; break;
                case "2éme License": niveau = 2; break;
                case "3éme License": niveau = 3; break;
                case "1er Master": niveau = 4; break;
                case "2éme Master": niveau = 5; break;
            }

            ArrayList groupes = obj.acceder_Groupes_par_niveau(niveau, loginForm.user.specialite);
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
                int niveau = 0;
                switch (niveauDrop.selectedValue)
                {
                    case "1er License": niveau = 1; break;
                    case "2éme License": niveau = 2; break;
                    case "3éme License": niveau = 3; break;
                    case "1er Master": niveau = 4; break;
                    case "2éme Master": niveau = 5; break;
                }


                listet = obj.acceder_etudiants(loginForm.user.specialite, niveau, Int32.Parse(groupeDrop.selectedValue));

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
