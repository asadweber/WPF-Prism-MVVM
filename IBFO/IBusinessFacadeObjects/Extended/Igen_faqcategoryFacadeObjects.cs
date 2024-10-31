

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_faqcategoryFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_faqcategoryEntity>> GetAllExt(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
         
    }
}
