using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Igen_countryDataAccessObjects
    {
        Task<long> AddExt(gen_countryEntity gen_country, CancellationToken cancellationToken);

        Task<IList<gen_countryEntity>> GetAllExt(gen_countryEntity gen_country, CancellationToken cancellationToken);
        Task<IList<gen_countryEntity>> GetCountryDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken);

        Task<gen_countryEntity> GetSingleByCountryId(gen_countryEntity gen_country, CancellationToken cancellationToken);

        Task<IList<gen_dropdownEntity>> GetNationalityForDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken);
    }
}