using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Igen_applicanttablesDataAccessObjects
    {

        #region Save Update Delete List Single Entity	

        Task<long> Add(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);

        Task<long> Update(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);

        Task<long> Delete(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);

        Task<long> SaveList(IList<gen_applicanttablesEntity> listAdded, IList<gen_applicanttablesEntity> listUpdated, IList<gen_applicanttablesEntity> listDeleted, CancellationToken cancellationToken);

        #endregion Save Update Delete List


        #region GetAll	
        Task<IList<gen_applicanttablesEntity>> GetAll(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);

        Task<IList<gen_applicanttablesEntity>> GetAllByPages(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);

        #endregion GetAll

        #region SaveMasterDetails
        Task<long> SaveMasterDetreg_datachecked(gen_applicanttablesEntity masterEntity, IList<reg_datacheckedEntity> listAdded, IList<reg_datacheckedEntity> listUpdated, IList<reg_datacheckedEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails

        #region Simple load Single Row
        Task<gen_applicanttablesEntity> GetSingle(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
        #endregion

        #region ForListView Paged Method
        Task<IList<gen_applicanttablesEntity>> GAPgListView(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion


        #region for Dropdown 
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
        #endregion





    }
}
