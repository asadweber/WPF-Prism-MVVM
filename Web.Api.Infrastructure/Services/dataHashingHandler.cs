using AppConfig.EncryptionHandler;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Web.Api.Infrastructure.Interfaces;
using Web.Core.Frame.Interfaces;

namespace Web.Api.Infrastructure.Services
{
    internal sealed class dataHashingHandler : IdataHashing
    {
        private readonly IJwtTokenHandler _jwtTokenHandler;

        internal dataHashingHandler(IJwtTokenHandler jwtTokenHandler)
        {
            _jwtTokenHandler = jwtTokenHandler;
        }

        public bool GetComaredDataData(string endData, string decData, string salt)
        {
            bool flg = false;
            string encstring = string.Empty;

            EncryptionHelper objenc = new EncryptionHelper();
            if (endData.Equals(objenc.EncodePassword(decData, salt).Digest))
            {
                flg = true;
            }
            return flg;
        }


        public HashWithSaltResult GetEncData(string decData)
        {
            string salt = string.Empty;
            EncryptionHelper objenc = new EncryptionHelper();
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                salt = System.Convert.ToBase64String(randomNumber);
            }
            return objenc.EncodePassword(decData, salt);
        }
    }
}
