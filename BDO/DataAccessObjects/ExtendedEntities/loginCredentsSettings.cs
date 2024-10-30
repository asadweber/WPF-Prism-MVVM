using System;
using System.Runtime.Serialization;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "loginCredentsSettings", Namespace = "http://www.KAF.com/types")]


    public class loginCredentsSettings
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
