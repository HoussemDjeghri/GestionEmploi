using EmploiDuTempsDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurEmploi
{
    class Authentification : MarshalByRefObject, IAuthentification
    {
        public UtilisateurObj authentification(int id, string password)
        {
            using (emploiEntities db = new emploiEntities())
            {

                utilisateur user = db.utilisateurs.FirstOrDefault(u => u.id_utilisateur == id && u.mot_de_passe == password);
                if (user != null)
                {
                    UtilisateurObj us = new UtilisateurObj();
                    us.id_utilisateur = user.id_utilisateur;
                    us.nom = user.nom;
                    us.prenom = user.prenom;
                    us.type = user.type;
                    us.specialite = user.id_specialite;

                    return us;

                }
                else {





                    return null; }


            }


        }
        public string acceder_desing_specialite(int? id_specialite)
        {
            using (var dbContext = new emploiEntities())
            {

                String designation = dbContext.specialites
           .Where(m => m.id_specialite == id_specialite).Select(e => e.designation).FirstOrDefault();




                return designation;


            }
        }

        public string acceder_specialite_etudiant(int id_etudiant)
        {
            Dictionary<String, int> listcr = new Dictionary<String, int>();
            using (var dbContext = new emploiEntities())
            {
                String  designation = (from isc in dbContext.inscriptions
                             join m in dbContext.modules on isc.id_module equals m.id_module
                             join s in dbContext.specialites on m.id_specialite equals s.id_specialite
                             where isc.id_etudiant == id_etudiant
                             select

                              s.designation
                             ).FirstOrDefault();
               
                return designation;
            }
        }
    }
}
