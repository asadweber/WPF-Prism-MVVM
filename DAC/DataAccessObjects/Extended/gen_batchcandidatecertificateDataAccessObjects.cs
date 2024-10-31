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
	
	internal sealed partial class gen_batchcandidatecertificateDataAccessObjects 
	{
        async Task<long> Igen_batchcandidatecertificateDataAccessObjects.AddExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificatedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatecertificate_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatecertificatedata, cmd,Database);
                FillSequrityParameters(gen_batchcandidatecertificatedata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateDataAccessObjects.GetAllExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandidatecertificate_GA_Ext";
                IList<gen_batchcandidatecertificateEntity> itemList = new List<gen_batchcandidatecertificateEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchcandidatecertificate.SortExpression);
                    FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatecertificate, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatecertificateEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.GetAllgen_batchcandidatecertificate"));
            }	
        }

        async Task<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateDataAccessObjects.GetSingleExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatecertificate_GS_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatecertificate, cmd, Database);

                    IList<gen_batchcandidatecertificateEntity> itemList = new List<gen_batchcandidatecertificateEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatecertificateEntity(reader, "ext"));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.GetSingleExtgen_batchcandidatecertificate"));
            }
        }

        async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateDataAccessObjects.GAPgListViewExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatecertificate_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatecertificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatecertificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatecertificate.CurrentPage);
                    FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_batchcandidatecertificate, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_batchcandidatecertificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batchcandidatecertificate.strCommonSerachParam + "%");

                    IList<gen_batchcandidatecertificateEntity> itemList = new List<gen_batchcandidatecertificateEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatecertificateEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batchcandidatecertificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.GAPgListViewExtgen_batchcandidatecertificate"));
            }
        }

        public async Task<long> DeletebyBatchCandidateTypeMapID(Database db, DbTransaction transaction, gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatecertificate_Del";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                if (gen_batchcandidatecertificate.batchcandidatetypemapid.HasValue)
                    Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_batchcandidatecertificate.batchcandidatetypemapid);
                FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("DeletebyBatchCandidateTypeMapIDgen_batchcandidatecertificateDataAccessObject"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

    }
}