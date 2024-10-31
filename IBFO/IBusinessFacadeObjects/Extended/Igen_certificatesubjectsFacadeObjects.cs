

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_certificatesubjectsFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_certificatesubjectsEntity>> GetAllExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_certificatesubjectsEntity>> GAPgListViewExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);


        [OperationContract]
        Task<IList<gen_certificatesubjectsEntity>> GetMajorSubjectByCertificateIdForDropdown(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
    }
}
