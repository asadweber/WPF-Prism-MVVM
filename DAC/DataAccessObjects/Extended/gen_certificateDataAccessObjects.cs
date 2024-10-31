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

    internal sealed partial class gen_certificateDataAccessObjects
    {
        async Task<long> Igen_certificateDataAccessObjects.AddExt(gen_certificateEntity gen_certificatedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_certificate_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_certificatedata, cmd, Database);
                FillSequrityParameters(gen_certificatedata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<gen_certificateEntity>> Igen_certificateDataAccessObjects.GetAllExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_certificate_GA_Ext";
                IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
                    FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificate, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificateEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GetAllgen_certificate"));
            }
        }

        async Task<IList<gen_certificateEntity>> Igen_certificateDataAccessObjects.GAPgListViewExt(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_certificate_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificate.CurrentPage);
                    FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_certificate, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_certificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificate.strCommonSerachParam + "%");

                    IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificateEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_certificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GAPgListViewExtgen_certificate"));
            }
        }

        async Task<IList<gen_certificateEntity>> Igen_certificateDataAccessObjects.GetCertificatebyCertificateLevel(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_certificate_By_CertificateLevelID_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificate.CurrentPage);
                    FillParameters(gen_certificate, cmd, Database);

                    if (gen_certificate.BatchCandidateTypeMapID.HasValue)
                        Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_certificate.BatchCandidateTypeMapID);


                    if (!string.IsNullOrEmpty(gen_certificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificate.strCommonSerachParam + "%");

                    IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new gen_certificateEntity(reader);
                            itemList.Add(obj);
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_certificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GAPgListViewExtgen_certificate"));
            }
        }

        //For Web Admin
        async Task<IList<gen_certificateEntity>> Igen_certificateDataAccessObjects.GetBatchCandidateTypeWiseCertificateDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_certificate_BatchCandidateType_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificate.CurrentPage);
                    FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificate, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_certificate.BatchIDString))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, gen_certificate.BatchIDString);
                    if (gen_certificate.CandidateTypeID.HasValue)
                        Database.AddInParameter(cmd, "@CandidateTypeID", DbType.Int64, gen_certificate.CandidateTypeID);

                    if (!string.IsNullOrEmpty(gen_certificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificate.strCommonSerachParam + "%");
                    IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificateEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_certificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GetBatchCandidateTypeWiseCertificateForDropDown"));
            }
        }

    }
}