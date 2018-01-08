using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
    [Serializable]
   public class EmploiObj
    {
      
        public int id_creaneau { get; set; }
        public String type { get; set; }
        public String module { get; set; }
        public int salle { get; set; }
        public int niveau { get; set; }
        public int group { get; set; }
    }
}
