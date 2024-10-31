
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Igen_batchcandidatetypemapDataAccessObjects
    {

        #region Save Update Delete List Single Entity	

        Task<long> Add(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<long> Update(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<long> Delete(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<long> SaveList(IList<gen_batchcandidatetypemapEntity> listAdded, IList<gen_batchcandidatetypemapEntity> listUpdated, IList<gen_batchcandidatetypemapEntity> listDeleted, CancellationToken cancellationToken);

        #endregion Save Update Delete List


        #region GetAll	
        Task<IList<gen_batchcandidatetypemapEntity>> GetAll(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<IList<gen_batchcandidatetypemapEntity>> GetAllByPages(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        #endregion GetAll

        #region SaveMasterDetails
        Task<long> SaveMasterDetgen_batchcandidatecertificate(gen_batchcandidatetypemapEntity masterEntity, IList<gen_batchcandidatecertificateEntity> listAdded, IList<gen_batchcandidatecertificateEntity> listUpdated, IList<gen_batchcandidatecertificateEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_batchcandidatereqfile(gen_batchcandidatetypemapEntity masterEntity, IList<gen_batchcandidatereqfileEntity> listAdded, IList<gen_batchcandidatereqfileEntity> listUpdated, IList<gen_batchcandidatereqfileEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_batchcandprofession(gen_batchcandidatetypemapEntity masterEntity, IList<gen_batchcandprofessionEntity> listAdded, IList<gen_batchcandprofessionEntity> listUpdated, IList<gen_batchcandprofessionEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails

        #region Simple load Single Row
        Task<gen_batchcandidatetypemapEntity> GetSingle(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
        #endregion

        #region ForListView Paged Method
        Task<IList<gen_batchcandidatetypemapEntity>> GAPgListView(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion


        #region for Dropdown 
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
        #endregion





    }
}
