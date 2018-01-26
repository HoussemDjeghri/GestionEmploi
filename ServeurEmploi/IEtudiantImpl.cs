using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploiDuTempsDLL;


namespace ServeurEmploi
{
    class IEtudiantImpl : MarshalByRefObject, IEtudiant
    {
        public ArrayList acceder_emploi(int id_etudiant)
        {
             using (var dbContext = new emploiEntities()) {

                  Console.WriteLine("in");
                  var liste = (from ep in dbContext.utilisateurs
                                    join e in dbContext.inscriptions on ep.id_utilisateur equals e.id_etudiant
                                    join t in dbContext.modules on e.id_module equals t.id_module
                                    join m in dbContext.emplois on t.id_module equals m.id_module
                                    join s in dbContext.salles on m.id_salle equals s.id_salle
                               where e.id_etudiant == id_etudiant
                               select new
                                    {
                                        creneau = m.id_creneau,
                                        titre_module = t.designation,
                                        type = s.type,
                                        salle = s.num_salle
                                   }).ToList();

                  ArrayList lt = new ArrayList();
                  foreach (var item in liste)
                  {
                      EmploiObj n = new EmploiObj();
                      n.id_creaneau = item.creneau;
                      n.module = item.titre_module;
                      n.type = item.type;
                      n.salle =item.salle;
                      lt.Add(n);

                  }

                  return lt;

              }

                    

            

            
        }
    }
}
