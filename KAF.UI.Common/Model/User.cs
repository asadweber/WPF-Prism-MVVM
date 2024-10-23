using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Common.Model
{
    public class User : BaseModel
    {
        private string _userName;
        private string _password;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
