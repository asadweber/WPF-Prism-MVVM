
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
    public sealed partial class gen_certificatesubjectsFacadeObjects
    {
		
       async Task<long> Igen_certificatesubjectsFacadeObjects.AddExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().AddExt(gen_certificatesubjects, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatesubjectsFacade.Addgen_certificatesubjects"));
            }
		}
       
		async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsFacadeObjects.GetAllExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().GetAllExt(gen_certificatesubjects, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatesubjectsEntity> Igen_certificatesubjectsFacade.GetAllgen_certificatesubjects"));
            }
		}

        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsFacadeObjects.GAPgListViewExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().GAPgListViewExt(gen_certificatesubjects, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatesubjectsEntity> Igen_certificatesubjectsFacade.GAPgListViewExtgen_certificatesubjects"));
            }
        }


        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsFacadeObjects.GetMajorSubjectByCertificateIdForDropdown(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().GetMajorSubjectByCertificateIdForDropdown(gen_certificatesubjects, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatesubjectsEntity> Igen_certificatesubjectsFacade.GetMajorSubjectByCertificateIdForDropdown"));
            }
        }

    }
}