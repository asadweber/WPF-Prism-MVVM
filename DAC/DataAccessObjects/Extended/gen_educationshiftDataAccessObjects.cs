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
	
	internal sealed partial class gen_educationshiftDataAccessObjects 
	{
        async Task<long> Igen_educationshiftDataAccessObjects.AddExt(gen_educationshiftEntity gen_educationshiftdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_educationshift_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_educationshiftdata, cmd,Database);
                FillSequrityParameters(gen_educationshiftdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_educationshiftEntity>> Igen_educationshiftDataAccessObjects.GetAllExt(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationshift_GA_Ext";
                IList<gen_educationshiftEntity> itemList = new List<gen_educationshiftEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_educationshift.SortExpression);
                    FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationshift, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationshiftEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.GetAllgen_educationshift"));
            }	
        }
        
	}
}