using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.Security;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Security.Cryptography;

namespace DAC.Core.DataAccessObjects.Security
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_userDataAccessObjects : BaseDataAccess, Iowin_userDataAccessObjects
	{
		
        async Task<owin_userEntity> Iowin_userDataAccessObjects.GetSinglebyUsername(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "KAF_GetOwinUser_GS_byUsername";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (!(string.IsNullOrEmpty(owin_user.username)))
                        Database.AddInParameter(cmd, "@UserName", DbType.String, owin_user.username);
                    if (!(string.IsNullOrEmpty(owin_user.emailaddress)))
                        Database.AddInParameter(cmd, "@EmailAddress", DbType.String, owin_user.emailaddress);
                    if (!(string.IsNullOrEmpty(owin_user.mobilenumber)))
                        Database.AddInParameter(cmd, "@MobileNumber", DbType.String, owin_user.mobilenumber);
                    if (owin_user.roleid.HasValue)
                        Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_user.roleid);
                    if (owin_user.pkeyex.HasValue)
                        Database.AddInParameter(cmd, "@PKeyEX", DbType.Int64, owin_user.pkeyex);

                    IList<owin_userEntity> itemList = new List<owin_userEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    
                    if(itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetSinglebyUsernameowin_user"));
            }	
        }
        
    }
}