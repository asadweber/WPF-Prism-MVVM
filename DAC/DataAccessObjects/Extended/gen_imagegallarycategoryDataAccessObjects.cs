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
	
	internal sealed partial class gen_imagegallarycategoryDataAccessObjects 
	{
        async Task<long> Igen_imagegallarycategoryDataAccessObjects.AddExt(gen_imagegallarycategoryEntity gen_imagegallarycategorydata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_imagegallarycategory_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_imagegallarycategorydata, cmd,Database);
                FillSequrityParameters(gen_imagegallarycategorydata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryDataAccessObjects.GetAllExt(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_imagegallarycategory_GA_Ext";
                IList<gen_imagegallarycategoryEntity> itemList = new List<gen_imagegallarycategoryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_imagegallarycategory.SortExpression);
                    FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_imagegallarycategory, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallarycategoryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.GetAllgen_imagegallarycategory"));
            }	
        }
        
	}
}