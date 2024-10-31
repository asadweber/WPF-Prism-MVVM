

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_certificateFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_certificateEntity>> GetAllExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_certificateEntity>> GAPgListViewExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_certificateEntity>> GetCertificatebyCertificateLevel(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);

        //For Web Admin
        [OperationContract]
        Task<IList<gen_certificateEntity>> GetBatchCandidateTypeWiseCertificateDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
    }
}
