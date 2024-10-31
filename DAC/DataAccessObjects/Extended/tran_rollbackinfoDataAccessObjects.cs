using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;



namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class tran_rollbackinfoDataAccessObjects 
	{
        async Task<long> Itran_rollbackinfoDataAccessObjects.AddExt(tran_rollbackinfoEntity tran_rollbackinfodata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_rollbackinfo_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_rollbackinfodata, cmd,Database);
                FillSequrityParameters(tran_rollbackinfodata.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_userpindataDataAccess.Addtran_userpindata"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        
        async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoDataAccessObjects.GetAllExt(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_rollbackinfo_GA_Ext";
                IList<tran_rollbackinfoEntity> itemList = new List<tran_rollbackinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_rollbackinfo.SortExpression);
                    FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_rollbackinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_rollbackinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.GetAlltran_rollbackinfo"));
            }	
        }

        public async Task<long> AddRollBackInfo(Database db, DbTransaction transaction, tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_rollbackinfo_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_rollbackinfo, cmd, db);
                FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = db.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.Addtran_rollbackinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

    }
}