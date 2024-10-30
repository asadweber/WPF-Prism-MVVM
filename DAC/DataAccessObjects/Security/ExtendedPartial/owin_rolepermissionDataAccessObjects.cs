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

namespace DAC.Core.DataAccessObjects.Security
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_rolepermissionDataAccessObjects 
	{
		
		/// <summary>
		/// GetRolesPermissionByParams
		/// </summary>
		/// <param name="owin_rolepermission"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		async Task<IList<owin_rolepermissionExtEntity>> Iowin_rolepermissionDataAccessObjects.GetRolesPermissionByParams(owin_rolepermissionExtEntity entity, CancellationToken cancellationToken)
		{
            try
            {
                const string SP = "KAFGetUserPermissionByRole";
                IList<owin_rolepermissionExtEntity> itemList = new List<owin_rolepermissionExtEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillSequrityParameters(entity.BaseSecurityParam, cmd, Database);

                    Database.AddInParameter(cmd, "@RoleIDArray", DbType.String, entity.rolename);
                    Database.AddInParameter(cmd, "@ControllerName", DbType.String, entity.ControllerName);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_rolepermissionExtEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList.Count > 0 ? itemList : null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetRolesPermissionByParams"));
            }
        }

	}
}