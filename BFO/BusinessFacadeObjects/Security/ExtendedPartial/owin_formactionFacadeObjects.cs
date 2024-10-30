using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.Security
{
    public sealed partial class owin_formactionFacadeObjects
    {
        async Task<IList<Owin_ProcessGetFormActionistEntity>> Iowin_formactionFacadeObjects.GetFormActionByRole(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createowin_formactionDataAccess().GetFormActionByRole(owin_formaction, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GetFormActionByRole"));
            }
        }

        async Task<long> Iowin_formactionFacadeObjects.AssignPermission(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createowin_formactionDataAccess().AssignPermission(owin_rolepermission, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_rolepermissionFacade.Updateowin_rolepermission"));
            }
        }

        async Task<IList<Owin_ProcessGetFormActionistEntity>> Iowin_formactionFacadeObjects.GetFormActionListByMasterUserId(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createowin_formactionDataAccess().GetFormActionListByMasterUserId(owin_formaction, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GetFormActionByRole"));
            }
        }
    }
}
