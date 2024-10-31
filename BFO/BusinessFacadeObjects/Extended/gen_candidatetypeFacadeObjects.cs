
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
    public sealed partial class gen_candidatetypeFacadeObjects
    {
		
       async Task<long> Igen_candidatetypeFacadeObjects.AddExt(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().AddExt(gen_candidatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_candidatetypeFacade.Addgen_candidatetype"));
            }
		}
       
		async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeFacadeObjects.GetAllExt(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetAllExt(gen_candidatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GetAllgen_candidatetype"));
            }
		}

        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeFacadeObjects.GetBatchWiseCandidateTypeDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetBatchWiseCandidateTypeDropDown(gen_candidatetype, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GetAllgen_candidatetype"));
            }
        }

        //For Web Admin
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeFacadeObjects.GetBatchWiseCandidateTypeListDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetBatchWiseCandidateTypeListDropDown(gen_candidatetype, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GetAllBatchWisegen_candidatetype"));
            }
        }

        //For Web Admin
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeFacadeObjects.GetMultiBatchWiseCandidateTypeListDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetMultiBatchWiseCandidateTypeListDropDown(gen_candidatetype, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GetAllMultiBatchWisegen_candidatetype"));
            }
        }

        async Task<gen_candidatetypeEntity> Igen_candidatetypeFacadeObjects.GetSingleById(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetSingleById(gen_candidatetype, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_candidatetypeEntity Igen_candidatetypeFacade.GetSinglegen_candidatetype"));
            }
        }


    }
}