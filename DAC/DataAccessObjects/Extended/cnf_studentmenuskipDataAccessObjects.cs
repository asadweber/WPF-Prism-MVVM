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
	
	internal sealed partial class cnf_studentmenuskipDataAccessObjects 
	{
        async Task<long> Icnf_studentmenuskipDataAccessObjects.AddExt(cnf_studentmenuskipEntity cnf_studentmenuskipdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_studentmenuskip_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_studentmenuskipdata, cmd,Database);
                FillSequrityParameters(cnf_studentmenuskipdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipDataAccessObjects.GetAllExt(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_studentmenuskip_GA_Ext";
                IList<cnf_studentmenuskipEntity> itemList = new List<cnf_studentmenuskipEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_studentmenuskip.SortExpression);
                    FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_studentmenuskip, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.GetAllcnf_studentmenuskip"));
            }	
        }
        
	}
}