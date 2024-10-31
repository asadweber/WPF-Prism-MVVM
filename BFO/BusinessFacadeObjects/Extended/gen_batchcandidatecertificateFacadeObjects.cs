
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
    public sealed partial class gen_batchcandidatecertificateFacadeObjects
    {
		
       async Task<long> Igen_batchcandidatecertificateFacadeObjects.AddExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().AddExt(gen_batchcandidatecertificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatecertificateFacade.Addgen_batchcandidatecertificate"));
            }
		}
       
		async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateFacadeObjects.GetAllExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().GetAllExt(gen_batchcandidatecertificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateFacade.GetAllgen_batchcandidatecertificate"));
            }
		}

        async Task<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateFacadeObjects.GetSingleExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().GetSingleExt(gen_batchcandidatecertificate, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandidatecertificateEntity Igen_batchcandidatecertificateFacade.GetSingleExtgen_batchcandidatecertificate"));
            }
        }

        async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateFacadeObjects.GAPgListViewExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().GAPgListViewExt(gen_batchcandidatecertificate, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateFacade.GAPgListViewExtgen_batchcandidatecertificate"));
            }
        }

    }
}