
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
    public sealed partial class reg_studentfilestorageFacadeObjects
    {
		
       async Task<long> Ireg_studentfilestorageFacadeObjects.AddExt(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().AddExt(reg_studentfilestorage, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_studentfilestorageFacade.Addreg_studentfilestorage"));
            }
		}
       
		async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageFacadeObjects.GetAllExt(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().GetAllExt(reg_studentfilestorage, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_studentfilestorageEntity> Ireg_studentfilestorageFacade.GetAllreg_studentfilestorage"));
            }
		}

        async Task<long> Ireg_studentfilestorageFacadeObjects.DeletebyBasicInfoIDFileConfigID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_studentfilestorageDataAccess().DeletebyBasicInfoIDFileConfigID(reg_studentfilestorage, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_studentfilestorageFacade.DeletebyBasicInfoIDFileConfigIDreg_studentfilestorage"));
            }
        }

        async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageFacadeObjects.GetAllByBasicInfoID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_studentfilestorageDataAccess().GetAllByBasicInfoID(reg_studentfilestorage, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_studentfilestorageEntity> Ireg_studentfilestorageFacade.GetAllByBasicInfoID"));
            }
        }

    }
}