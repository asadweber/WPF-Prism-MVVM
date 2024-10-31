

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_trainingjoinnotificationFacadeObjects")]
    public partial interface Itran_trainingjoinnotificationFacadeObjects : IDisposable
    {
        #region Save Update Delete List 


        [OperationContract]
        Task<long> Add(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> Update(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> Delete(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveList(List<tran_trainingjoinnotificationEntity> list, CancellationToken cancellationToken);


        #endregion Save Update Delete List

        #region GetAll	

        [OperationContract]
        Task<IList<tran_trainingjoinnotificationEntity>> GetAll(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<tran_trainingjoinnotificationEntity>> GetAllByPages(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        #endregion GetAll

        #region Save Master/Details	

        #endregion Save Master/Details	

        #region Simple load Single Row
        [OperationContract]
        Task<tran_trainingjoinnotificationEntity> GetSingle(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);
        #endregion

        #region ForListView Paged Method
        [OperationContract]
        Task<IList<tran_trainingjoinnotificationEntity>> GAPgListView(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion



    }
}
