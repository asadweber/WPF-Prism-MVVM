
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
    public sealed partial class gen_certificateFacadeObjects
    {
		
       async Task<long> Igen_certificateFacadeObjects.AddExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().AddExt(gen_certificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificateFacade.Addgen_certificate"));
            }
		}
       
		async Task<IList<gen_certificateEntity>> Igen_certificateFacadeObjects.GetAllExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().GetAllExt(gen_certificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GetAllgen_certificate"));
            }
		}

        async Task<IList<gen_certificateEntity>> Igen_certificateFacadeObjects.GAPgListViewExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_certificateDataAccess().GAPgListViewExt(gen_certificate, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GAPgListViewExtgen_certificate"));
            }
        }


        async Task<IList<gen_certificateEntity>> Igen_certificateFacadeObjects.GetCertificatebyCertificateLevel(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_certificateDataAccess().GetCertificatebyCertificateLevel(gen_certificate, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GetCertificateBy_CertificateLabel_BatchCandidateTypeMapIdForDropDown"));
            }
        }

        //For Web Admin
        async Task<IList<gen_certificateEntity>> Igen_certificateFacadeObjects.GetBatchCandidateTypeWiseCertificateDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_certificateDataAccess().GetBatchCandidateTypeWiseCertificateDropDown(gen_certificate, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GetBatchCandidateTypeWiseCertificateForDropDown"));
            }
        }

    }
}