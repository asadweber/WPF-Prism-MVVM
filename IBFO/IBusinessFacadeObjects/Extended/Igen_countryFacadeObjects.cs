

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_countryFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_countryEntity gen_country, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_countryEntity>> GetAllExt(gen_countryEntity gen_country, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_countryEntity>> GetCountryDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken);


        [OperationContract]
        Task<gen_countryEntity> GetSingleByCountryId(gen_countryEntity gen_country, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetNationalityForDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken);
    }
}
