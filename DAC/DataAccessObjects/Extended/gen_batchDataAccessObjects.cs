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
using BDO.Core.DataAccessObjects.ExtendedEntities;



namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class gen_batchDataAccessObjects 
	{
        async Task<long> Igen_batchDataAccessObjects.AddExt(gen_batchEntity gen_batchdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batch_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchdata, cmd,Database);
                FillSequrityParameters(gen_batchdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_batchEntity>> Igen_batchDataAccessObjects.GetAllExt(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batch_GA_Ext";
                IList<gen_batchEntity> itemList = new List<gen_batchEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batch.SortExpression);
                    FillSequrityParameters(gen_batch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batch, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchDataAccess.GetAllgen_batch"));
            }	
        }


        async Task<IList<gen_batchEntity>> Igen_batchDataAccessObjects.GetActiveBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_Gen_batch_GetActiveBatch";
                IList<gen_batchEntity> itemList = new List<gen_batchEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batch.SortExpression);
                    AddPageSizeParameter(cmd, gen_batch.PageSize);
                    AddCurrentPageParameter(cmd, gen_batch.CurrentPage);
                    FillSequrityParameters(gen_batch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batch, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_batch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batch.strCommonSerachParam + "%");


                    if (gen_batch.ProfileBasicId.HasValue)
                        Database.AddInParameter(cmd, "@BasicProfileId", DbType.Int64, gen_batch.ProfileBasicId);


                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            gen_batchEntity data = new gen_batchEntity(reader);
                            data.BatchDetailsFromReader(reader);
                            itemList.Add(data);
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchDataAccess.GetAllgen_batch"));
            }
        }

        async Task<IList<gen_batchEntity>> Igen_batchDataAccessObjects.GetActiveBatchDropDownForReview(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_Gen_batch_GetActiveBatchForReview";
                IList<gen_batchEntity> itemList = new List<gen_batchEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batch.SortExpression);
                    AddPageSizeParameter(cmd, gen_batch.PageSize);
                    AddCurrentPageParameter(cmd, gen_batch.CurrentPage);
                    FillSequrityParameters(gen_batch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batch, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_batch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batch.strCommonSerachParam + "%");


                    if (gen_batch.ProfileBasicId.HasValue)
                        Database.AddInParameter(cmd, "@BasicProfileId", DbType.Int64, gen_batch.ProfileBasicId);


                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            gen_batchEntity data = new gen_batchEntity(reader);
                            data.BatchDetailsFromReader(reader);
                            itemList.Add(data);
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchDataAccess.GetActiveBatchDropDownForReview"));
            }
        }

        async Task<IList<gen_batchEntity>> Igen_batchDataAccessObjects.GetAllBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_Gen_batch_GetAllBatch";
                IList<gen_batchEntity> itemList = new List<gen_batchEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batch.SortExpression);
                    AddPageSizeParameter(cmd, gen_batch.PageSize);
                    AddCurrentPageParameter(cmd, gen_batch.CurrentPage);
                    FillSequrityParameters(gen_batch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batch, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_batch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batch.strCommonSerachParam + "%");


                    if (gen_batch.ProfileBasicId.HasValue)
                        Database.AddInParameter(cmd, "@BasicProfileId", DbType.Int64, gen_batch.ProfileBasicId);


                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            gen_batchEntity data = new gen_batchEntity(reader);
                            data.BatchDetailsFromReader(reader);
                            itemList.Add(data);
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchDataAccess.GetAllgen_batch"));
            }
        }

        async Task<gen_batchEntity> Igen_batchDataAccessObjects.GetBatchById(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_batch_GS_BY_ID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_batch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batch, cmd, Database);

                    IList<gen_batchEntity> itemList = new List<gen_batchEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            gen_batchEntity data = new gen_batchEntity(reader);
                            data.BatchDetailsFromReader(reader);
                            itemList.Add(data);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchDataAccess.GetBatchById"));
            }
        }

        public async Task<gen_batchEntity> GetSingleBatchInfo(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batch_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_batch.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batch, cmd, Database);

                    IList<gen_batchEntity> itemList = new List<gen_batchEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchDataAccess.GetSinglegen_batch"));
            }
        }

        async Task<IList<gen_dropdownEntity>> Igen_batchDataAccessObjects.GetMilitaryTypeWiseBatchForDropDown(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetMilitaryTypeWiseBatch_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batch.SortExpression);
                    AddPageSizeParameter(cmd, gen_batch.PageSize);
                    AddCurrentPageParameter(cmd, gen_batch.CurrentPage);
                    FillSequrityParameters(gen_batch.BaseSecurityParam, cmd, Database);
                    //FillParameters(gen_batch, cmd, Database);
                    
                    if (!string.IsNullOrEmpty(gen_batch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batch.strCommonSerachParam + "%");
                    if (gen_batch.batchid.HasValue)
                        Database.AddInParameter(cmd, "@BatchID", DbType.Int64, gen_batch.batchid);
                    if (gen_batch.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@CandidateTypeID", DbType.String, gen_batch.candidatetypeid);

                    IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_dropdownEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchDataAccess.GetMilitaryTypeWiseBatchForDropDown"));
            }
        }

    }
}