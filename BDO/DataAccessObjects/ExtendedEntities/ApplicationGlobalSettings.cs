﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class ApplicationGlobalSettings
    {
        public string PassResetURL { get; set; }
        public string ApplicationID { get; set; }
        public string AccountVarificationURL { get; set; }

        public string SpecialRegistrationURL { get; set; }

    }
}
