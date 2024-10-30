using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BDO.Model
{
    public class User : BaseModel
    {
        private string _userName;
        private string _password;

        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }


        [DataType(DataType.Password)]
        public string Password { get => _password; set => SetProperty(ref _password, value); }
    }
}
