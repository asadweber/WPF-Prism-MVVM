using KAF.UI.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Service
{
    public class UserService : IUserService
    {
        public User CurrentUser { get; set; }
    }
}
