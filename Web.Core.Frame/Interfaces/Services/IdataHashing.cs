using BDO.Core.DataAccessObjects.ExtendedEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Core.Frame.Interfaces
{
    public interface IdataHashing
    {
        HashWithSaltResult GetEncData(string decData);

        bool GetComaredDataData(string endData, string decData, string salt);

    }
}
