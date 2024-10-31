using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Igen_newsDataAccessObjects
    {

        #region Save Update Delete List Single Entity	

        Task<long> Add_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);

        Task<long> Update_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);

        Task<long> Delete_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);
        #endregion Save Update Delete List

        #region GetAll	
        Task<IList<gen_newsEntity>> GetAll_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);

        #endregion GetAll

        #region Simple load Single Row
        Task<gen_newsEntity> GetSingle_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);
        #endregion

    }
}
