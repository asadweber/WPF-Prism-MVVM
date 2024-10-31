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
    public partial interface Igen_batchcandidatecertificateDataAccessObjects
    {

        Task<long> AddExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);

        Task<IList<gen_batchcandidatecertificateEntity>> GetAllExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);

        Task<gen_batchcandidatecertificateEntity> GetSingleExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
        
        Task<IList<gen_batchcandidatecertificateEntity>> GAPgListViewExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
    }
}
