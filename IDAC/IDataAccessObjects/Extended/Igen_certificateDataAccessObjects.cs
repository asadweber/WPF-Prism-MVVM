using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;



namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Igen_certificateDataAccessObjects
    {

        Task<long> AddExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);

        Task<IList<gen_certificateEntity>> GetAllExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);

        Task<IList<gen_certificateEntity>> GAPgListViewExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);

        Task<IList<gen_certificateEntity>> GetCertificatebyCertificateLevel(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);

        //For Web Admin
        Task<IList<gen_certificateEntity>> GetBatchCandidateTypeWiseCertificateDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
    }
}
