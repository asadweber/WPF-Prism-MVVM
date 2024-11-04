using System;
using System.Collections.Generic;
using System.Text;

namespace KAF.Service.Proxy.Dto
{
    public static class ApplicationState
    {
        private static AccessTokenDto currentUser;

        public static AccessTokenDto CurrentUser { get => currentUser; set => currentUser = value; }
    }
}
