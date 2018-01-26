using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
    public class EventProxy : MarshalByRefObject
    {

        #region Event Declarations

       event EmploiChangedEvent EmploiChanged;

        #endregion

        #region Lifetime Services

        public override object InitializeLifetimeService()
        {
            return null;            //Returning null holds the object alive until it is explicitly destroyed
        }

        #endregion

        #region Local Handlers

        public void OnEmploiChanged(int id_en, string notif)
        {
            if (EmploiChanged != null)
            {

                EmploiChanged(id_en, notif);


            }
        }

        #endregion

    }
}
