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
		public static void FillParametersExt(owin_rolepermissionExtEntity entity, DbCommand cmd, Database Database, bool forDelete = false)
		{

			if (!(string.IsNullOrEmpty(entity.code)))
				Database.AddInParameter(cmd, "@RoleIDArray", DbType.String, entity.code);

			if (entity.rolepremissionid.HasValue)
				Database.AddInParameter(cmd, "@RolePremissionID", DbType.Int64, entity.rolepremissionid);
			if (entity.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, entity.roleid);
			if (!(string.IsNullOrEmpty(entity.rolename)))
				Database.AddInParameter(cmd, "@RoleName", DbType.String, entity.rolename);

			if (entity.formactionid.HasValue)
				Database.AddInParameter(cmd, "@FormActionID", DbType.Int64, entity.formactionid);
			if ((entity.status != null))
				Database.AddInParameter(cmd, "@Status", DbType.Boolean, entity.status);

			if (!(string.IsNullOrEmpty(entity.displayname)))
				Database.AddInParameter(cmd, "@DisplayName", DbType.String, entity.displayname);

			if (!(string.IsNullOrEmpty(entity.displaynamear)))
				Database.AddInParameter(cmd, "@DisplayNameAr", DbType.String, entity.displaynamear);
			if (entity.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, entity.parentid);

			if (!(string.IsNullOrEmpty(entity.actionname)))
				Database.AddInParameter(cmd, "@ActionName", DbType.String, entity.actionname);
			if (!(string.IsNullOrEmpty(entity.actiontype)))
				Database.AddInParameter(cmd, "@ActionType", DbType.String, entity.actiontype);
		}

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
					FillParametersExt(entity, cmd, Database);

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
					return itemList.Count>0? itemList : null;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetRolesPermissionByParams"));
			}
		}

	}
}