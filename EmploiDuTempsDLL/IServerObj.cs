using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploiDuTempsDLL
{
    public interface IServerObj
    {

        #region Events

        event EmploiChangedEvent EmploiChanged;

        #endregion

        #region Methods

        void PublishNotification(int id_en, String notif);

        #endregion

    }
}
