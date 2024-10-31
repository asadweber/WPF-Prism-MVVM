using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;



namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_faqcategoryDataAccessObjects
    {
		
         Task<long> AddExt(gen_faqcategoryEntity gen_faqcategory,CancellationToken cancellationToken);
       
         Task<IList<gen_faqcategoryEntity>> GetAllExt(gen_faqcategoryEntity gen_faqcategory,CancellationToken cancellationToken);
    }
}
