using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_fileconfignameDataAccessObjects
    {
        Task<IList<cnf_fileconfignameEntity>> GetAllByBatchID(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);

    }
}
