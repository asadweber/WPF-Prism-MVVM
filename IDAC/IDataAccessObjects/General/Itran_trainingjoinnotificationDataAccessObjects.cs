using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Itran_trainingjoinnotificationDataAccessObjects
    {

        #region Save Update Delete List Single Entity	

        Task<long> Add(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        Task<long> Update(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        Task<long> Delete(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        Task<long> SaveList(IList<tran_trainingjoinnotificationEntity> listAdded, IList<tran_trainingjoinnotificationEntity> listUpdated, IList<tran_trainingjoinnotificationEntity> listDeleted, CancellationToken cancellationToken);

        #endregion Save Update Delete List


        #region GetAll	
        Task<IList<tran_trainingjoinnotificationEntity>> GetAll(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        Task<IList<tran_trainingjoinnotificationEntity>> GetAllByPages(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);

        #endregion GetAll

        #region SaveMasterDetails
        #endregion SaveMasterDetails

        #region Simple load Single Row
        Task<tran_trainingjoinnotificationEntity> GetSingle(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);
        #endregion

        #region ForListView Paged Method
        Task<IList<tran_trainingjoinnotificationEntity>> GAPgListView(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion







    }
}
