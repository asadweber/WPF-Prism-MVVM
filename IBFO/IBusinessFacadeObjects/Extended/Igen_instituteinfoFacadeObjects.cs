

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_instituteinfoFacadeObjects
    {
        [OperationContract]
        Task<long> AddExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_instituteinfoEntity>> GetAllExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_instituteinfoEntity>> GetInstituteInfoDataForDropDown(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_instituteinfoEntity>> GAPgListViewExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
    }
}
