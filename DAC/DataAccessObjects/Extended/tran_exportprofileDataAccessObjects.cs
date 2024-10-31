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
	
	internal sealed partial class tran_exportprofileDataAccessObjects 
	{
        async Task<long> Itran_exportprofileDataAccessObjects.AddExt(tran_exportprofileEntity tran_exportprofiledata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_exportprofile_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_exportprofiledata, cmd,Database);
                FillSequrityParameters(tran_exportprofiledata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<tran_exportprofileEntity>> Itran_exportprofileDataAccessObjects.GetAllExt(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_exportprofile_GA_Ext";
                IList<tran_exportprofileEntity> itemList = new List<tran_exportprofileEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_exportprofile.SortExpression);
                    FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_exportprofile, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_exportprofileEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.GetAlltran_exportprofile"));
            }	
        }
        
	}
}