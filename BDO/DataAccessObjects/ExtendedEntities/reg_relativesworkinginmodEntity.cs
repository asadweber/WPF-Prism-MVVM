using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class reg_relativesworkinginmodEntity
    {
        private bool _hasMODRelative=false;

        [DataMember]
        public bool HasMODRelative { get => _hasMODRelative; set => _hasMODRelative = value; }
    }
}
