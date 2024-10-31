
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
    public sealed partial class gen_professionFacadeObjects
    {
		
       async Task<long> Igen_professionFacadeObjects.AddExt(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().AddExt(gen_profession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_professionFacade.Addgen_profession"));
            }
		}
       
		async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GetAllExt(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().GetAllExt(gen_profession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetAllgen_profession"));
            }
		}

        async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GAPgListViewExt(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_professionDataAccess().GAPgListViewExt(gen_profession, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GAPgListViewExtgen_profession"));
            }
        }


        async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GetProfessionDropDown(BDO.Core.DataAccessObjects.Models.gen_professionEntity gen_profession, System.Threading.CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_professionDataAccess().GetProfessionDropDown(gen_profession, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetDataForDropDown"));
            }
        }

        //For Web Admin
        async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GetBatchCandidateTypeWiseProfessionDropDown(BDO.Core.DataAccessObjects.Models.gen_professionEntity gen_profession, System.Threading.CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_professionDataAccess().GetBatchCandidateTypeWiseProfessionDropDown(gen_profession, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetBatchCandidateTypeWiseProfessionDropDown"));
            }
        }

        async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GetMultiBatchCandidateTypeWiseProfessionDropDown(BDO.Core.DataAccessObjects.Models.gen_professionEntity gen_profession, System.Threading.CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_professionDataAccess().GetMultiBatchCandidateTypeWiseProfessionDropDown(gen_profession, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetMultiBatchCandidateTypeWiseProfessionDropDown"));
            }
        }

        async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GetAllProfessionbyProfessionGroupID(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_professionDataAccess().GetAllProfessionbyProfessionGroupID(gen_profession, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetAllProfessionbyProfessionGroupIDgen_profession"));
            }
        }

    }
}