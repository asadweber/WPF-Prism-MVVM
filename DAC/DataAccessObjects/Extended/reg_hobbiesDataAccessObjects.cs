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
	
	internal sealed partial class reg_hobbiesDataAccessObjects 
	{
        async Task<long> Ireg_hobbiesDataAccessObjects.AddExt(reg_hobbiesEntity reg_hobbiesdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_hobbies_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_hobbiesdata, cmd,Database);
                FillSequrityParameters(reg_hobbiesdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesDataAccessObjects.GetAllExt(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_hobbies_GA_Ext";
                IList<reg_hobbiesEntity> itemList = new List<reg_hobbiesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_hobbies.SortExpression);
                    FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_hobbies, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_hobbiesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.GetAllreg_hobbies"));
            }	
        }
        
	}
}