using EmploiDuTempsDLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurEmploi
{
    class IEnseignantImpl : MarshalByRefObject, IEnseignant
    {
        public ArrayList Acceder_emploi(int id_enseignant)
        {
            using (var dbContext = new emploiEntities())
             {


                var liste = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             join s in dbContext.salles on emp.id_salle equals s.id_salle

                             where emp.id_enseignant == id_enseignant orderby m.niveau ascending
                             select new
                             {
                                 creneau = emp.id_creneau,
                                 titre_module = m.designation,
                                 type = s.type,
                                 salle = s.num_salle,
                                 niveau = m.niveau,
                                 groupe = emp.groupe,
                                 id_seance = emp.id_seance,
                                  section=emp.section
                              }).ToList();

                 ArrayList lt = new ArrayList();
                 foreach (var item in liste)
                 {
                     EmploiObj n = new EmploiObj();
                     n.id_creaneau = item.creneau;
                     n.module = item.titre_module;
                     n.type = item.type;
                     n.salle = item.salle;
                     n.niveau = item.niveau;
                     n.group = item.groupe;
                     n.id_seance = item.id_seance;
                     n.section = item.section;
                     lt.Add(n);

                 }

                 return lt;

        }
      
        }

        public ArrayList acceder_Niveaux(int? id_spec)
        {
            ArrayList liste = new ArrayList();
            using (var dbContext = new emploiEntities())
            {

                var items = (from m in dbContext.modules
                             where m.id_specialite == id_spec
                             orderby m.niveau ascending
                             select new
                             {
                                 niveau = m.niveau,
                             }).Distinct();

                foreach (var item in items)
                {


                    liste.Add(item.niveau.ToString());


                }


                return liste;


            }

        }

        public ArrayList acceder_Groupes_par_niveau(int niveau, int? specialite)
        {
            ArrayList liste = new ArrayList();
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             where m.niveau == niveau &&
                              m.id_specialite == specialite
                             orderby emp.groupe
                             select new
                             {
                                 groupe = emp.groupe
                             }).Distinct();

                foreach (var item in items)
                {


                    liste.Add(item.groupe);


                }

                return liste;


            }
        }

        public List<UtilisateurObj> acceder_etudiants(int? id_specialite, int niveau, int groupe)
        {

            List<UtilisateurObj> listet = new List<UtilisateurObj>();
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             join insc in dbContext.inscriptions on m.id_module equals insc.id_module
                             join u in dbContext.utilisateurs on insc.id_etudiant equals u.id_utilisateur
                             where m.id_specialite == id_specialite && m.niveau == niveau && emp.groupe == groupe
                             select new
                             {
                                 id_etudiant = u.id_utilisateur,
                                 nom = u.nom,
                                 prenom = u.prenom
                             }).Distinct();

                foreach (var item in items)
                {

                    UtilisateurObj user = new UtilisateurObj();
                    user.id_utilisateur = item.id_etudiant;
                    user.nom = item.nom;
                    user.prenom = item.prenom;
                    listet.Add(user);


                }


                return listet;


            }
        }

        public double acceder_volumeHoraire(int id_en)
        {
            using (var dbContext = new emploiEntities())
            {

                double vmh = (from emp in dbContext.emplois

                              where emp.id_enseignant == id_en
                              select emp
                            ).Count();

                vmh = vmh * 1.5;

                return vmh;


            }
        }

        public int acceder_nombre_cours(int id_enseignant)
        {
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join sl in dbContext.salles on emp.id_salle equals sl.id_salle
                            where emp.id_enseignant == id_enseignant && sl.type=="amphi"


                             select emp.id_seance).Count();



                return items;


            }
        }

        public int acceder_nombre_td_tp(int id_enseignant)
        {
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join sl in dbContext.salles on emp.id_salle equals sl.id_salle
                             where emp.id_enseignant == id_enseignant && sl.type != "amphi"


                             select emp.id_seance).Count();



                return items;


            }
        }
    }
}
