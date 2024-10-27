using KAF.UI.Common.Model;
using KAF.UI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Service.Services
{
    public class UserService : IUserService
    {
        public User CurrentUser { get; set; }
    }
}
