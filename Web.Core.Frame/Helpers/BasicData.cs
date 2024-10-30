using BDO.Core.DataAccessObjects.Models;
using CLL.LLClasses.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Core.Frame.Helpers
{
	public static class BasicData
	{

		public static kns_batchEntity GetCurrentBatch(IHttpContextAccessor _contextAccessor, CancellationToken cancellationToken)
		{
			var kns_batchEntity = new kns_batchEntity();
			var kns_batchEntityList = (List<kns_batchEntity>)BFC.Core.FacadeCreatorObjects.General.kns_batchFCC.GetFacadeCreate(_contextAccessor)
			   .GetAll(new kns_batchEntity() { isactive = 1 }, cancellationToken).Result;
			if (kns_batchEntityList != null && kns_batchEntityList.Count() > 0)
			{
				kns_batchEntity = kns_batchEntityList.FirstOrDefault();
			}
			return kns_batchEntity;
		}
	}
}
