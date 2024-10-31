using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class SignalRWebApiSettings
    {
        public string signalRUrl { get; set; }
        public string apiUrl { get; set; }
        public int secondsVisibilityBallonTime { get; set; }
        public bool showBallonWithNotificationsOpen { get; set; }
        public string settingsFileName { get; set; }
        public string settingsFileFullPath { get; set; }
        public string DataLogFileFullPath { get; set; }
    }
}
