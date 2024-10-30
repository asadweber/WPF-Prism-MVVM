using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using AppConfig.HelperClasses;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.Security;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace DAC.Core.DataAccessObjects.Security
{
    internal sealed partial class owin_formactionDataAccessObjects
    {
        async Task<IList<Owin_ProcessGetFormActionistEntity>> Iowin_formactionDataAccessObjects.GetFormActionByRole(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "Owin_ProcessGetFormActionList_Ext";
                IList<Owin_ProcessGetFormActionistEntity> itemList = new List<Owin_ProcessGetFormActionistEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    //AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    //FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    //FillParameters(owin_formaction, cmd, Database);
                    if (owin_formaction.roleid.HasValue)
                        Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_formaction.roleid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new Owin_ProcessGetFormActionistEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetAllowin_formaction"));
            }
        }

        async Task<long> Iowin_formactionDataAccessObjects.AssignPermission(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "Owin_RolePermission_UpdExt";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                Database.AddInParameter(cmd, "@FormActionID", DbType.String, owin_rolepermission.ActionName);
                Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_rolepermission.roleid);
                //FillParameters(owin_rolepermission, cmd, Database);
                FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    //returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.Updateowin_rolepermission"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        async Task<IList<Owin_ProcessGetFormActionistEntity>> Iowin_formactionDataAccessObjects.GetFormActionListByMasterUserId(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetMenuWiseFormActionList_Ext";
                IList<Owin_ProcessGetFormActionistEntity> itemList = new List<Owin_ProcessGetFormActionistEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    //AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    //FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    //FillParameters(owin_formaction, cmd, Database);
                    if (owin_formaction.masteruserid.HasValue)
                        Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_formaction.masteruserid);
                    if (owin_formaction.actionname != String.Empty)
                        Database.AddInParameter(cmd, "@ActionName", DbType.String, "%" + owin_formaction.actionname + "%");

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new Owin_ProcessGetFormActionistEntity(reader, "KAF_GetMenuWiseFormActionList_Ext"));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetAllowin_formaction"));
            }
        }
    }
}
