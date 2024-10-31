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
	
	internal sealed partial class cnf_smstempaltesDataAccessObjects 
	{
        async Task<long> Icnf_smstempaltesDataAccessObjects.AddExt(cnf_smstempaltesEntity cnf_smstempaltesdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_smstempaltes_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_smstempaltesdata, cmd,Database);
                FillSequrityParameters(cnf_smstempaltesdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_smstempaltesEntity>> Icnf_smstempaltesDataAccessObjects.GetAllExt(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smstempaltes_GA_Ext";
                IList<cnf_smstempaltesEntity> itemList = new List<cnf_smstempaltesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_smstempaltes.SortExpression);
                    FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smstempaltes, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smstempaltesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.GetAllcnf_smstempaltes"));
            }	
        }
        
	}
}