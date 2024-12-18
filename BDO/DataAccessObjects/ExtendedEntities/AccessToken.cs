﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public sealed class AccessToken
    {
        public string Token { get;set; }
        public int ExpiresIn { get;set; }

        public string RefreshToken   { get;set; }

        public AccessToken(){}
        public AccessToken(string token, int expiresIn,string refreshToken)
        {
            Token = token;
            ExpiresIn = expiresIn;
            RefreshToken = refreshToken;
        }
    }
}
