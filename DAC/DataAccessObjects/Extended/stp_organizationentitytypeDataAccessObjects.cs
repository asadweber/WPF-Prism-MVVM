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
	
	internal sealed partial class stp_organizationentitytypeDataAccessObjects 
	{
        async Task<long> Istp_organizationentitytypeDataAccessObjects.AddExt(stp_organizationentitytypeEntity stp_organizationentitytypedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "stp_organizationentitytype_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_organizationentitytypedata, cmd,Database);
                FillSequrityParameters(stp_organizationentitytypedata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<stp_organizationentitytypeEntity>> Istp_organizationentitytypeDataAccessObjects.GetAllExt(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organizationentitytype_GA_Ext";
                IList<stp_organizationentitytypeEntity> itemList = new List<stp_organizationentitytypeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_organizationentitytype.SortExpression);
                    FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentitytype, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentitytypeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.GetAllstp_organizationentitytype"));
            }	
        }
        
	}
}