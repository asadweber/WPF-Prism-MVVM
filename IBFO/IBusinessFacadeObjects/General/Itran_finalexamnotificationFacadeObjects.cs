using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_finalexamnotificationFacadeObjects")]
    public partial interface Itran_finalexamnotificationFacadeObjects : IDisposable
    {
        #region Save Update Delete List 


        [OperationContract]
        Task<long> Add(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> Update(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> Delete(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveList(List<tran_finalexamnotificationEntity> list, CancellationToken cancellationToken);


        #endregion Save Update Delete List

        #region GetAll	

        [OperationContract]
        Task<IList<tran_finalexamnotificationEntity>> GetAll(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<tran_finalexamnotificationEntity>> GetAllByPages(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        #endregion GetAll

        #region Save Master/Details	

        #endregion Save Master/Details	

        #region Simple load Single Row
        [OperationContract]
        Task<tran_finalexamnotificationEntity> GetSingle(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);
        #endregion

        #region ForListView Paged Method
        [OperationContract]
        Task<IList<tran_finalexamnotificationEntity>> GAPgListView(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion



    }
}