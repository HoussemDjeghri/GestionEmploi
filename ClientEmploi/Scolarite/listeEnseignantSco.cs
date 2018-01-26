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
    public partial class listeEnseignantSco : Form
    {
        IScolarite obj;
        List<UtilisateurObj> ens;
        public listeEnseignantSco(IScolarite obj)
        {
            this.obj = obj;
            InitializeComponent();
            List<UtilisateurObj> ens = obj.acceder_enseignants(loginForm.user.specialite);
           
            foreach (UtilisateurObj item in ens)
            {
                double vmh = obj.acceder_volumeHoraire(item.id_utilisateur);
                string[] row = { item.nom, item.prenom,vmh.ToString()+" H/S" };
                var Item = new ListViewItem(row);
                 listeEn.Items.Add(Item);
            }

        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listeEn.Columns[e.ColumnIndex].Width;
        }

        private void listeEtud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
