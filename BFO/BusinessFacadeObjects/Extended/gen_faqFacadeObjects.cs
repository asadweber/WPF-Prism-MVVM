
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
    public sealed partial class gen_faqFacadeObjects
    {
		
       async Task<long> Igen_faqFacadeObjects.AddExt(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().AddExt(gen_faq, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_faqFacade.Addgen_faq"));
            }
		}
       
		async Task<IList<gen_faqEntity>> Igen_faqFacadeObjects.GetAllExt(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().GetAllExt(gen_faq, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqEntity> Igen_faqFacade.GetAllgen_faq"));
            }
		}
        
	}
}