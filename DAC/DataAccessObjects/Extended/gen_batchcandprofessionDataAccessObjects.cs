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
	
	internal sealed partial class gen_batchcandprofessionDataAccessObjects 
	{
        async Task<long> Igen_batchcandprofessionDataAccessObjects.AddExt(gen_batchcandprofessionEntity gen_batchcandprofessiondata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandprofession_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandprofessiondata, cmd,Database);
                FillSequrityParameters(gen_batchcandprofessiondata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionDataAccessObjects.GetAllExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandprofession_GA_Ext";
                IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchcandprofession.SortExpression);
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandprofession, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GetAllgen_batchcandprofession"));
            }	
        }

        async Task<gen_batchcandprofessionEntity> Igen_batchcandprofessionDataAccessObjects.GetSingleExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandprofession_GS_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandprofession, cmd, Database);

                    IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader, "ext"));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GetSingleExtgen_batchcandprofession"));
            }
        }

        async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionDataAccessObjects.GAPgListViewExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandprofession_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandprofession.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandprofession.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandprofession.CurrentPage);
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_batchcandprofession, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_batchcandprofession.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batchcandprofession.strCommonSerachParam + "%");

                    IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batchcandprofession.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GAPgListViewExtgen_batchcandprofession"));
            }
        }

        public async Task<long> DeletebyBatchCandidateTypeMapID(Database db, DbTransaction transaction, gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandprofession_Del";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                if (gen_batchcandprofession.batchcandidatetypemapid.HasValue)
                    Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_batchcandprofession.batchcandidatetypemapid);
                FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("DeletebyBatchCandidateTypeMapIDgen_batchcandprofessionDataAccessObject"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<gen_batchcandprofessionEntity> Igen_batchcandprofessionDataAccessObjects.GetSingleByBatchCandidateTypeMapProfessionID(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GenBatchCandProf_GS_ByBatchCandTypeMapProfID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandprofession, cmd, Database);

                    IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GetSingleByBatchCandidateTypeMapProfessionID"));
            }
        }

    }
}