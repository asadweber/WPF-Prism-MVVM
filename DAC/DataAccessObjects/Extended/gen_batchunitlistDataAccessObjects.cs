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
	
	internal sealed partial class gen_batchunitlistDataAccessObjects 
	{
        async Task<long> Igen_batchunitlistDataAccessObjects.AddExt(gen_batchunitlistEntity gen_batchunitlistdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchunitlist_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchunitlistdata, cmd,Database);
                FillSequrityParameters(gen_batchunitlistdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistDataAccessObjects.GetAllExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchunitlist_GA_Ext";
                IList<gen_batchunitlistEntity> itemList = new List<gen_batchunitlistEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchunitlist.SortExpression);
                    FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchunitlist, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchunitlistEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.GetAllgen_batchunitlist"));
            }	
        }

        async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistDataAccessObjects.GAPgListViewExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchunitlist_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchunitlist.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchunitlist.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchunitlist.CurrentPage);
                    FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_batchunitlist, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_batchunitlist.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batchunitlist.strCommonSerachParam + "%");

                    IList<gen_batchunitlistEntity> itemList = new List<gen_batchunitlistEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchunitlistEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batchunitlist.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.GAPgListViewExtgen_batchunitlist"));
            }
        }

    }
}