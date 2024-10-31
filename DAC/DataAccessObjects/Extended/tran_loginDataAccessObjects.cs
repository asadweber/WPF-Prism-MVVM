using BDO.Core.DataAccessObjects.Models;
using IDAC.Core.IDataAccessObjects.General;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class tran_loginDataAccessObjects
    {


        async Task<IList<tran_loginEntity>> Itran_loginDataAccessObjects.GetAllTokenByUser(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_login_GA";
                IList<tran_loginEntity> itemList = new List<tran_loginEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_login.SortExpression);
                    FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_login, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_loginEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.GetAlltran_login"));
            }
        }

    }
}