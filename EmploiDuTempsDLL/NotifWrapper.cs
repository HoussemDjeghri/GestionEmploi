using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
  public class NotifWrapper : MarshalByRefObject
    {

        public event EmploiChangedEvent WrapperNotificationReceived;
       
        public void WrapperNotificationReceivedHandler(int id_en ,string notification)
        {
           
            if (WrapperNotificationReceived != null)
                WrapperNotificationReceived(id_en,notification);
        }

        
        public override object InitializeLifetimeService()
        {
          
            return null;
        }
    }





}


