using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
    public interface IScolarite
    {
        Boolean InsererEmploi(List<EmploiObj> emplois);
        Boolean InsererSeance(EmploiObj seance);
       
        ArrayList acceder_Section_par_niveau(int? id_specialite, int niveau);
        ArrayList acceder_Section(int? id_specialite , int id_module);
        ArrayList acceder_Groupes(int id_module, int section);
        ArrayList acceder_Niveaux(int? id_specialite);
        int acceder_Niveaux(int id_module);
        ArrayList acceder_Groupes_par_niveau(int niveaun, int? specialite);
        List<UtilisateurObj> acceder_etudiants(int? id_specialite, int niveau, int groupe);
        double acceder_volumeHoraire(int id_en);
        ArrayList acceder_emploi(int? id_specialite, int niveau, int section);
        Dictionary<String, int> acceder_modules(int? id_specialite);
        Boolean Maj_Seance(int id_seance, int id_creneau, int id_salle);
        Dictionary<int, int> acceder_salles(String type);
        Dictionary<int, int> acceder_salles_Dispo(String type,int id_creneau);
        Dictionary<String, int> acceder_creneaux(int id_salle);
        Dictionary<String, int> acceder_creneaux(int? id_specialite, int niveau, int section);
        Dictionary<String, int> acceder_creneaux(int? id_specialite, int niveau, int section,int id_enseignant);
        List<UtilisateurObj> acceder_enseignants(int? id_specialite);

        int acceder_nombre_modules(int? id_specialite);
        int acceder_nombre_enseignants(int? id_specialite);
        int acceder_nombre_etudiants(int? id_specialite);
   

    }
}
