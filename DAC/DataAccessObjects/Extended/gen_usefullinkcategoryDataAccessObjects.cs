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
	
	internal sealed partial class gen_usefullinkcategoryDataAccessObjects 
	{
        async Task<long> Igen_usefullinkcategoryDataAccessObjects.AddExt(gen_usefullinkcategoryEntity gen_usefullinkcategorydata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_usefullinkcategory_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_usefullinkcategorydata, cmd,Database);
                FillSequrityParameters(gen_usefullinkcategorydata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryDataAccessObjects.GetAllExt(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_usefullinkcategory_GA_Ext";
                IList<gen_usefullinkcategoryEntity> itemList = new List<gen_usefullinkcategoryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_usefullinkcategory.SortExpression);
                    FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_usefullinkcategory, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkcategoryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.GetAllgen_usefullinkcategory"));
            }	
        }
        
	}
}