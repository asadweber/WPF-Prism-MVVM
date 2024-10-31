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
	
	internal sealed partial class gen_candidatetypeDataAccessObjects 
	{
        async Task<long> Igen_candidatetypeDataAccessObjects.AddExt(gen_candidatetypeEntity gen_candidatetypedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_candidatetype_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_candidatetypedata, cmd,Database);
                FillSequrityParameters(gen_candidatetypedata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeDataAccessObjects.GetAllExt(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_candidatetype_GA_Ext";
                IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_candidatetype, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_candidatetypeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetAllgen_candidatetype"));
            }	
        }


        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeDataAccessObjects.GetBatchWiseCandidateTypeDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_BatchWise_Gen_CandidateType";
                IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddTotalRecordParameter(cmd); 
                    AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_candidatetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_candidatetype.CurrentPage);
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_candidatetype, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_candidatetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_candidatetype.strCommonSerachParam + "%");

                    
                    Database.AddInParameter(cmd, "@BatchId", DbType.Int64, gen_candidatetype.BatchId);



                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var data = new gen_candidatetypeEntity(reader);
                            data.LoadBatchCandidateTypeMapInfo(reader);
                            itemList.Add(data);
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_candidatetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }

                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetAllgen_candidatetype"));
            }
        }


        //For Web Admin
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeDataAccessObjects.GetBatchWiseCandidateTypeListDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_candidatetype_Batch_GAPgDropDown";
                IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_candidatetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_candidatetype.CurrentPage);
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_candidatetype, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_candidatetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_candidatetype.strCommonSerachParam + "%");

                    Database.AddInParameter(cmd, "@BatchId", DbType.Int64, gen_candidatetype.BatchId);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_candidatetypeEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_candidatetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }

                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetAllBatchWisegen_candidatetype"));
            }
        }

        //For Web Admin
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeDataAccessObjects.GetMultiBatchWiseCandidateTypeListDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_candidatetype_MultiBatch_GAPgDropDown";
                IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_candidatetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_candidatetype.CurrentPage);
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_candidatetype, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_candidatetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_candidatetype.strCommonSerachParam + "%");

                    Database.AddInParameter(cmd, "@BatchIds", DbType.String, gen_candidatetype.BatchIdString);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_candidatetypeEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_candidatetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }

                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetAllMultiBatchWisegen_candidatetype"));
            }
        }


        async Task<gen_candidatetypeEntity> Igen_candidatetypeDataAccessObjects.GetSingleById(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_candidatetype_GS_By_ID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_candidatetype, cmd, Database);

                    IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var data = new gen_candidatetypeEntity(reader);
                            //data.LoadBatchCandidateTypeMapInfo(reader);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetSinglegen_candidatetype"));
            }
        }

    }
}