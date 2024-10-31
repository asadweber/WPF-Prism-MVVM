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
	
	internal sealed partial class gen_batchcandidatereqfileDataAccessObjects 
	{
        async Task<long> Igen_batchcandidatereqfileDataAccessObjects.AddExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfiledata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatereqfile_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatereqfiledata, cmd,Database);
                FillSequrityParameters(gen_batchcandidatereqfiledata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileDataAccessObjects.GetAllExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandidatereqfile_GA_Ext";
                IList<gen_batchcandidatereqfileEntity> itemList = new List<gen_batchcandidatereqfileEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchcandidatereqfile.SortExpression);
                    FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatereqfile, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatereqfileEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.GetAllgen_batchcandidatereqfile"));
            }	
        }

        async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileDataAccessObjects.GAPgListViewExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatereqfile_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatereqfile.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatereqfile.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatereqfile.CurrentPage);
                    FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_batchcandidatereqfile, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_batchcandidatereqfile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batchcandidatereqfile.strCommonSerachParam + "%");

                    IList<gen_batchcandidatereqfileEntity> itemList = new List<gen_batchcandidatereqfileEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatereqfileEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batchcandidatereqfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.GAPgListViewExtgen_batchcandidatereqfile"));
            }
        }

        async Task<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileDataAccessObjects.GetSingleExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatereqfile_GS_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatereqfile, cmd, Database);

                    IList<gen_batchcandidatereqfileEntity> itemList = new List<gen_batchcandidatereqfileEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatereqfileEntity(reader, -99));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.GetSingleExtgen_batchcandidatereqfile"));
            }
        }

    }
}