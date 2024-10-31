
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace BFO.Core.BusinessFacadeObjects.General
{
    public sealed partial class gen_faqcategoryFacadeObjects
    {
		
       async Task<long> Igen_faqcategoryFacadeObjects.AddExt(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().AddExt(gen_faqcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_faqcategoryFacade.Addgen_faqcategory"));
            }
		}
       
		async Task<IList<gen_faqcategoryEntity>> Igen_faqcategoryFacadeObjects.GetAllExt(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().GetAllExt(gen_faqcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqcategoryEntity> Igen_faqcategoryFacade.GetAllgen_faqcategory"));
            }
		}
        
	}
}