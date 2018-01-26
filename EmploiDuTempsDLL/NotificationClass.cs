using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
    [Serializable]
    [ComVisible(true)]
    public delegate void EmploiChangedEvent(int id_en, String notif);

    public class NotificationClass : MarshalByRefObject
    {


        public event EmploiChangedEvent EmploiChanged;


      
        private EmploiChangedEvent notifDelegate;

      
        public NotificationClass()
        {
            notifDelegate = new EmploiChangedEvent(OnEmploiChanged);
        }

 
        public override object InitializeLifetimeService()
        {
            return null;
        }

        private delegate void WrapperDelegate(int id_en ,string notification, EmploiChangedEvent notifDelegate);

        public void OnEmploiChanged(int id_en, string notification)
        {
            if (EmploiChanged != null)
            {
                EmploiChangedEvent notifDelegate = null;
                Delegate[] invocationList_ = null;
                try
                {
                    invocationList_ = EmploiChanged.GetInvocationList();
                }
                catch (MemberAccessException ex)
                {
                    throw ex;
                }
                if (invocationList_ != null)
                {
                    lock (this)
                    {
                        foreach (Delegate del in invocationList_)
                        {
                            notifDelegate = (EmploiChangedEvent)del;
                            WrapperDelegate wrDel = new WrapperDelegate(BeginSend);
                            AsyncCallback callback = new AsyncCallback(EndSend);
                            wrDel.BeginInvoke(id_en,notification, notifDelegate, callback, wrDel);
                        }
                    }
                }
            }
        }

        private void BeginSend(int id_en, string notification, EmploiChangedEvent notifDelegate)
        {
            try
            {
                notifDelegate(id_en,notification);

            }
            catch (Exception e)
            {
                EmploiChanged -= notifDelegate;
            }
        }

        private void EndSend(IAsyncResult result)
        {
            WrapperDelegate wrDel = (WrapperDelegate)result.AsyncState;
            wrDel.EndInvoke(result);
        }

    }





}

