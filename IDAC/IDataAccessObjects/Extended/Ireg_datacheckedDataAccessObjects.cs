using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Report;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_datacheckedDataAccessObjects
    {

        Task<IList<reg_datacheckedEntity>> GetAllRegDataCheckedListByRegistrationID(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
        Task<reg_datacheckedEntity> GetRegDataCheckedByBasicinfoRegistrationID(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);

    }
}
