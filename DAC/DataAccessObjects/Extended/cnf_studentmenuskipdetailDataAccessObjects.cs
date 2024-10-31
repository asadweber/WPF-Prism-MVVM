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
	
	internal sealed partial class cnf_studentmenuskipdetailDataAccessObjects 
	{
        async Task<long> Icnf_studentmenuskipdetailDataAccessObjects.AddExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetaildata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_studentmenuskipdetail_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_studentmenuskipdetaildata, cmd,Database);
                FillSequrityParameters(cnf_studentmenuskipdetaildata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailDataAccessObjects.GetAllExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_studentmenuskipdetail_GA_Ext";
                IList<cnf_studentmenuskipdetailEntity> itemList = new List<cnf_studentmenuskipdetailEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_studentmenuskipdetail.SortExpression);
                    FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_studentmenuskipdetail, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipdetailEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.GetAllcnf_studentmenuskipdetail"));
            }	
        }
        
	}
}