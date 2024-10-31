using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Itran_finalexamnotificationDataAccessObjects
    {

        #region Save Update Delete List Single Entity	

        Task<long> Add(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        Task<long> Update(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        Task<long> Delete(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        Task<long> SaveList(IList<tran_finalexamnotificationEntity> listAdded, IList<tran_finalexamnotificationEntity> listUpdated, IList<tran_finalexamnotificationEntity> listDeleted, CancellationToken cancellationToken);

        #endregion Save Update Delete List


        #region GetAll	
        Task<IList<tran_finalexamnotificationEntity>> GetAll(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        Task<IList<tran_finalexamnotificationEntity>> GetAllByPages(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);

        #endregion GetAll

        #region SaveMasterDetails
        #endregion SaveMasterDetails

        #region Simple load Single Row
        Task<tran_finalexamnotificationEntity> GetSingle(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);
        #endregion

        #region ForListView Paged Method
        Task<IList<tran_finalexamnotificationEntity>> GAPgListView(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion







    }
}
