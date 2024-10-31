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
	
	internal sealed partial class stp_organizationentityDataAccessObjects 
	{
        async Task<long> Istp_organizationentityDataAccessObjects.AddExt(stp_organizationentityEntity stp_organizationentitydata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "stp_organizationentity_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_organizationentitydata, cmd,Database);
                FillSequrityParameters(stp_organizationentitydata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<stp_organizationentityEntity>> Istp_organizationentityDataAccessObjects.GetAllExt(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organizationentity_GA_Ext";
                IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentity, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetAllstp_organizationentity"));
            }	
        }
        
	}
}