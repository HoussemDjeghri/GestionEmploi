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
        public ArrayList acceder_emploi(int id_enseignant)
        {
            using (var dbContext = new sql11213826Entities())
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
                                 groupe= emp.groupe
                                 
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
                    lt.Add(n);

                }

                return lt;
            }
        }
    }
}
