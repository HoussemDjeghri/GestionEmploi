using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
    [Serializable]
    public class UtilisateurObj
    {

        public int id_utilisateur { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String type { get; set; }
        public int? specialite { get; set; }
    }
}
