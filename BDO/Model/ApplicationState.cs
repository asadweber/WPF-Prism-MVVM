using BDO.Core.DataAccessObjects.ExtendedEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Model
{
    public static class ApplicationState
    {
        private static AccessToken currentUser;

        public static AccessToken CurrentUser { get => currentUser; set => currentUser = value; }
    }
}
