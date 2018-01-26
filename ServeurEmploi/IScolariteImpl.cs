using EmploiDuTempsDLL;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ServeurEmploi
{
    class IScolariteImpl : MarshalByRefObject, IScolarite
    {
        public Dictionary<string, int> acceder_creneaux(int id_salle)
        {
            Dictionary<String, int> listcr = new Dictionary<String, int>();
            using (var dbContext = new emploiEntities())
            {

                var emp = dbContext.emplois.Where(m=> m.id_salle == id_salle).Select(e => e.id_creneau);
                var items = dbContext.creneaux
            .Where(c => !emp.Contains(c.id_creneau))
            .ToList();
                
                
                foreach (var item in items)
                {

                  
                    listcr.Add(item.jour+" "+item.heure, item.id_creneau);


                }
               

                return listcr;
            }
        }

        public Dictionary<string, int> acceder_creneaux(int? id_specialite, int niveau, int section)
        {
            Dictionary<String, int> listcr = new Dictionary<String, int>();
            using (var dbContext = new emploiEntities())
            {
                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             where m.id_specialite == id_specialite &&
                              m.niveau == niveau && emp.section == section
                             select 
                             
                                 emp.id_creneau

                             ).ToList();
                var cren= dbContext.creneaux
            .Where(c => !items.Contains(c.id_creneau))
            .ToList();

              
                foreach (var item in cren)
                {

                 
                    listcr.Add(item.jour + " " + item.heure, item.id_creneau);


                }
               

                return listcr;
            }
        }

        public Dictionary<string, int> acceder_creneaux(int? id_specialite, int niveau, int section, int id_enseignant)
        {
            Dictionary<String, int> listcr = new Dictionary<String, int>();
            using (var dbContext = new emploiEntities())
            {
                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             where (m.id_specialite == id_specialite &&
                              m.niveau == niveau && emp.section == section) || (emp.id_enseignant==id_enseignant)
                             select

                                 emp.id_creneau

                             ).ToList();
                var cren = dbContext.creneaux
            .Where(c => !items.Contains(c.id_creneau))
            .ToList();

                foreach (var item in cren)
                {

                   
                    listcr.Add(item.jour + " " + item.heure, item.id_creneau);


                }
             
                return listcr;
            }
        }

    
        public ArrayList acceder_emploi(int? id_specialite, int niveau, int section)
        {
            ArrayList liste = new ArrayList();
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             join s in dbContext.salles on emp.id_salle equals s.id_salle
                             where m.id_specialite == id_specialite &&
                              m.niveau == niveau && emp.section == section
                             select new
                             {
                                 creneau = emp.id_creneau,
                                 titre_module = m.designation,
                                 type = s.type,
                                 salle = s.num_salle,
                                 niveau = m.niveau,
                                 groupe = emp.groupe,
                                 id_seance = emp.id_seance,
                                 section =emp.section,
                                 id_en = emp.id_enseignant

                             }).ToList();
                ArrayList lt = new ArrayList();
                foreach (var item in items)
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
                    n.id_en = item.id_en;
                    lt.Add(n);

                }

                return lt;


            }
        }

        public List<UtilisateurObj> acceder_enseignants(int? id_specialite)
        {
            List<UtilisateurObj> listen = new List<UtilisateurObj>();
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             join u in dbContext.utilisateurs on emp.id_enseignant equals u.id_utilisateur
                             where m.id_specialite == id_specialite


                             select new
                             {
                                 id_ensignant = u.id_utilisateur,
                                 nom = u.nom,
                                 prenom =u.prenom
                             }).Distinct();
               
                foreach (var item in items)
                {

                    UtilisateurObj user = new UtilisateurObj();
                    user.id_utilisateur = item.id_ensignant;
                    user.nom = item.nom;
                    user.prenom = item.prenom;
                    listen.Add(user);


                }

              
                return listen;


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
                             where m.id_specialite == id_specialite && m.niveau==niveau && emp.groupe==groupe
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

        public ArrayList acceder_Groupes(int id_module, int section)
        {
            ArrayList liste = new ArrayList();
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                            
                             where emp.id_module == id_module &&
                              emp.section == section
                             select new
                             {
                                 groupe = emp.groupe
                             }).Distinct();
               
                foreach (var item in items)
                {

                 
                    liste.Add(item.groupe.ToString());


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
                              m.id_specialite== specialite orderby emp.groupe
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

        public Dictionary<String, int> acceder_modules(int? id_specialite)
        {
            Dictionary<String, int> listem = new Dictionary<String, int>();
            using (var dbContext = new emploiEntities())
            {

                var items = (from m in dbContext.modules
                             where m.id_specialite == id_specialite
                             orderby m.id_module ascending
                             select new
                             {
                                id_module = m.id_module,
                                designation = m.designation,
                             }).ToList();

                foreach (var item in items)
                {


                    listem.Add(item.designation,item.id_module);


                }


                return listem;
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

        public int acceder_Niveaux(int id_module)
        {
          
            using (var dbContext = new emploiEntities())
            {

                int niveau = dbContext.modules
           .Where(m => m.id_module == id_module).Select(e => e.niveau).FirstOrDefault();
          

             

                return niveau;


            }
        }

        public int acceder_nombre_enseignants(int? id_specialite)
        {

            using (var dbContext = new emploiEntities())
            {

                int enseignants = dbContext.utilisateurs
           .Where(us => us.id_specialite == id_specialite && us.type=="Enseignant").Count();




                return enseignants;


            }
        }

        public int acceder_nombre_etudiants(int? id_specialite)
        {
          
            using (var dbContext = new emploiEntities())
            {

                var items = (from md in dbContext.modules
                             join ins in dbContext.inscriptions on md.id_module equals ins.id_module
                             where md.id_specialite == id_specialite 
                             
                            
                             select new
                             {
                                 id_etudiant = ins.id_etudiant
                             }).Distinct().Count();

               

                return items;


            }
        }

        public int acceder_nombre_modules(int? id_specialite)
        {

            using (var dbContext = new emploiEntities())
            {

                int modules = dbContext.modules
           .Where(md => md.id_specialite == id_specialite).Count();




                return modules;


            }
        }

        public Dictionary<int, int> acceder_salles(string type)
        {
            Dictionary<int, int> salles = new Dictionary<int, int>();
            using (var dbContext = new emploiEntities())
            {

                var items = (from sl in dbContext.salles
                          
                             where sl.type == type orderby sl.num_salle


                             select new
                             {
                                id_salle=sl.id_salle,
                                num_salle=sl.num_salle
                             }).ToList();

                foreach (var item in items)
                {


                    salles.Add(item.num_salle, item.id_salle);


                }


                return salles;


            }
        }

        public Dictionary<int, int> acceder_salles_Dispo(string type, int id_creneau)
        {
            Dictionary<int, int> salles = new Dictionary<int, int>();
            using (var dbContext = new emploiEntities())
            {

                var sl = (from emp in dbContext.emplois
                             join s in dbContext.salles on emp.id_salle equals s.id_salle
                             where emp.id_creneau == id_creneau &&
                              s.type == type
                             select s.id_salle).ToList();



                var items = dbContext.salles
                  .Where(s => !sl.Contains(s.id_salle) && s.type==type)
                   .ToList();
                

                foreach (var item in items)
                {
                    var temps = (from s in dbContext.salles
                                where s.id_salle == item.id_salle
                                select s).First();
                   
                    salles.Add(temps.num_salle, temps.id_salle);

                }
       
               
               

                return salles;


            }
        }

        public ArrayList acceder_Section(int? id_specialite, int id_module)
        {

            ArrayList liste = new ArrayList();
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             where m.id_specialite == id_specialite &&
                              m.id_module == id_module

                             select new
                             {
                                 section = emp.section,
                             }).Distinct();
              
                foreach (var item in items)
                {
                   

                    liste.Add(item.section.ToString());


                }

                return liste;


            }

        }

        public ArrayList acceder_Section_par_niveau(int? id_specialite, int niveau)
        {
            ArrayList liste = new ArrayList();
            using (var dbContext = new emploiEntities())
            {

                var items = (from emp in dbContext.emplois
                             join m in dbContext.modules on emp.id_module equals m.id_module
                             where m.id_specialite == id_specialite &&
                              m.niveau == niveau

                             select new
                             {
                                 section = emp.section,
                             }).Distinct();
              
                foreach (var item in items)
                {
                    

                    liste.Add(item.section.ToString());


                }

              
                return liste;


            }
        }

        public double acceder_volumeHoraire(int id_en)
        {
          
            using (var dbContext = new emploiEntities())
            {

                double vmh = (from emp in dbContext.emplois

                             where emp.id_enseignant == id_en select emp
                            ).Count();

                vmh = vmh * 1.5;

                return vmh;


            }
        }

        public bool InsererEmploi(List<EmploiObj> emplois)
        {

            using (var dbContext = new emploiEntities())
            {
                dbContext.Database.ExecuteSqlCommand("delete from emploi");
                foreach (var item in emplois)
                {
                    emploi emp = new emploi();
                
                    emp.id_enseignant = item.id_en;
                    emp.id_creneau = item.id_creaneau;
                    emp.id_salle = item.salle;
                    emp.groupe = item.group;
                    emp.section = item.section;
                    emp.id_module = item.id_module;
                    emp.est_supp = 0;
                    dbContext.emplois.Add(emp);
                }

                int changed = dbContext.SaveChanges();



                if (changed == 0) { return false; } else { return true; }

            }
        }

       

        public bool InsererSeance(EmploiObj seance)
        {
            using (var dbContext = new emploiEntities())
            {


                emploi emp = new emploi();
               
                emp.id_enseignant = seance.id_en;
                emp.id_creneau = seance.id_creaneau;
                emp.id_salle = seance.salle;
                emp.groupe = seance.group;
                emp.section = seance.section;
                emp.id_module = seance.id_module;
                emp.est_supp = seance.est_supp;
                dbContext.emplois.Add(emp);


                int changed = dbContext.SaveChanges();



                if (changed == 0) { return false; } else { return true; }

            }
        }

        public bool Maj_Seance(int id_seance, int id_creneau, int id_salle)
        {
            
            using (var dbContext = new emploiEntities())
            {

                emploi seance = dbContext.emplois.Where(m => m.id_seance == id_seance).FirstOrDefault();

                seance.id_creneau = id_creneau;
                seance.id_salle = id_salle;

                int changed = dbContext.SaveChanges();



                if (changed == 0) { return false; } else { return true; }
            }
        }
    }
}

