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

namespace DAC.Core.DataAccessObjects.Security
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class owin_roleDataAccessObjects
    {

        public static void FillParametersGetByUsrID(owin_userEntity owin_user, DbCommand cmd, Database Database, bool forDelete = false)
        {
                Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_user.userid);
        }


        async Task<IList<owin_roleEntity>> Iowin_roleDataAccessObjects.GetByUsrID(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "owin_role_GSByUser";
                IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    FillParametersGetByUsrID(owin_user, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetByUsrID"));
            }
        }

    }
}