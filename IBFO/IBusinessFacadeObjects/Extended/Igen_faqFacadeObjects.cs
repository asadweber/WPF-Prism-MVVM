

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_faqFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_faqEntity gen_faq, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_faqEntity>> GetAllExt(gen_faqEntity gen_faq, CancellationToken cancellationToken);
         
    }
}
