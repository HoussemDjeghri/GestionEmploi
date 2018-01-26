using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
   public interface IEnseignant
    {
        ArrayList Acceder_emploi(int id_enseignant);
        ArrayList acceder_Niveaux(int? id_specialite);
        ArrayList acceder_Groupes_par_niveau(int niveaun, int? specialite);
        List<UtilisateurObj> acceder_etudiants(int? id_specialite, int niveau, int groupe);
        double acceder_volumeHoraire(int id_en);
        int acceder_nombre_cours(int id_enseignant);
        int acceder_nombre_td_tp(int id_enseignant);

    }
}
