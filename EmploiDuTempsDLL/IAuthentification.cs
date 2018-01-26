using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
    public interface IAuthentification
    {

        UtilisateurObj authentification(int id, String password);

        String acceder_desing_specialite(int? id_specialite);
        String acceder_specialite_etudiant(int id_etudiant);

    }
}
