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
	
	internal sealed partial class gen_civilworkplacesDataAccessObjects 
	{
        async Task<long> Igen_civilworkplacesDataAccessObjects.AddExt(gen_civilworkplacesEntity gen_civilworkplacesdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_civilworkplaces_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_civilworkplacesdata, cmd,Database);
                FillSequrityParameters(gen_civilworkplacesdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesDataAccessObjects.GetAllExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_civilworkplaces_GA_Ext";
                IList<gen_civilworkplacesEntity> itemList = new List<gen_civilworkplacesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_civilworkplaces.SortExpression);
                    FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_civilworkplaces, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_civilworkplacesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.GetAllgen_civilworkplaces"));
            }	
        }

        async Task<gen_civilworkplacesEntity> Igen_civilworkplacesDataAccessObjects.GetSingleExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_civilworkplaces_GS_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_civilworkplaces, cmd, Database);

                    IList<gen_civilworkplacesEntity> itemList = new List<gen_civilworkplacesEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_civilworkplacesEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.GetSingleExtgen_civilworkplaces"));
            }
        }

    }
}