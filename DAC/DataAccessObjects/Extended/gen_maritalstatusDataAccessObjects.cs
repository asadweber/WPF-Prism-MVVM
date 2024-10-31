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
	
	internal sealed partial class gen_maritalstatusDataAccessObjects 
	{
        async Task<long> Igen_maritalstatusDataAccessObjects.AddExt(gen_maritalstatusEntity gen_maritalstatusdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_maritalstatus_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_maritalstatusdata, cmd,Database);
                FillSequrityParameters(gen_maritalstatusdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusDataAccessObjects.GetAllExt(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_maritalstatus_GA_Ext";
                IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_maritalstatus, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetAllgen_maritalstatus"));
            }	
        }

        async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusDataAccessObjects.GetMaritalStatusDataForDropDown(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_maritalstatus_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_maritalstatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_maritalstatus.CurrentPage);
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_maritalstatus, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_maritalstatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_maritalstatus.strCommonSerachParam + "%");
                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_maritalstatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetDataForDropDown"));
            }
        }

    }
}