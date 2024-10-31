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
	
	internal sealed partial class reg_previousexperianceDataAccessObjects 
	{
        async Task<long> Ireg_previousexperianceDataAccessObjects.AddExt(reg_previousexperianceEntity reg_previousexperiancedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_previousexperiance_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_previousexperiancedata, cmd,Database);
                FillSequrityParameters(reg_previousexperiancedata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceDataAccessObjects.GetAllExt(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_previousexperiance_GA_Ext";
                IList<reg_previousexperianceEntity> itemList = new List<reg_previousexperianceEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_previousexperiance.SortExpression);
                    FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_previousexperiance, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_previousexperianceEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.GetAllreg_previousexperiance"));
            }	
        }
        
	}
}