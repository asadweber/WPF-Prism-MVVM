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
using BDO.Core.Base;
using System.Diagnostics;
using CLL.LLClasses.Models;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class reg_educationinfoDataAccessObjects
    {
        async Task<long> Ireg_educationinfoDataAccessObjects.AddExt(reg_educationinfoEntity reg_educationinfodata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_educationinfo_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_educationinfodata, cmd, Database);
                FillSequrityParameters(reg_educationinfodata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoDataAccessObjects.GetAllExt(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_educationinfo_GA_Ext";
                IList<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_educationinfo.SortExpression);
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_educationinfo, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_educationinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GetAllreg_educationinfo"));
            }
        }

        public async Task<List<reg_educationinfoEntity>> GetAllByBasicInfoID(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_educationinfo_By_BasicInfoID";
                List<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_educationinfo.basicinfoid);


                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_educationinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GetAllreg_educationinfo"));
            }
        }

        async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoDataAccessObjects.GetAllByBasicInfoID(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_educationinfo_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_educationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_educationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_educationinfo.CurrentPage);
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_educationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_educationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_educationinfo.strCommonSerachParam + "%");

                    IList<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_educationinfoEntity(reader);
                            if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevel"))) obj.CertificateLevel = reader.GetString(reader.GetOrdinal("CertificateLevel"));
                            if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) obj.CertificateName = reader.GetString(reader.GetOrdinal("CertificateName"));
                            if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectName"))) obj.CertificateSubjectName = reader.GetString(reader.GetOrdinal("CertificateSubjectName"));
                           
                            //reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            //obj.CertificateDocuments = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId_FileConfigType(new reg_studentfilestorageEntity()
                            //{
                            //    basicinfoid = reg_educationinfo.basicinfoid,
                            //    fileconfigid = (long)FileConfig.EducationalCertificate,
                            //    CurrentState = BaseEntity.EntityState.Unchanged,

                            //}, cancellationToken);

                            itemList.Add(obj);
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_educationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GAPgListViewreg_educationinfo"));
            }
        }

        async Task<reg_educationinfoEntity> Ireg_educationinfoDataAccessObjects.GetSingleById(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_educationinfo_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_educationinfo, cmd, Database);

                    IList<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_educationinfoEntity(reader);
                            //reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            //obj.CertificateDocuments = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId_FileConfigType(new reg_studentfilestorageEntity()
                            //{
                            //    basicinfoid = obj.basicinfoid,
                            //    fileconfigid = (long)FileConfig.EducationalCertificate,
                            //    CurrentState = BaseEntity.EntityState.Unchanged,

                            //}, cancellationToken);


                            itemList.Add(obj);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GetSinglereg_educationinfo"));
            }
        }

        public async Task<long> SaveEducationList(
                                                  Database db,
                                                  DbTransaction transaction,
                                                  IList<reg_educationinfoEntity> listAdded,
                                                  IList<reg_educationinfoEntity> listUpdated,
                                                  IList<reg_educationinfoEntity> listDeleted,
                                                  CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "KAF_reg_educationinfo_Ins_EXT";
            const string SPUpdate = "KAF_reg_educationinfo_Upd_EXT";
            const string SPDelete = "KAF_reg_educationinfo_Del_ext";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (reg_educationinfoEntity reg_educationinfo in listDeleted)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_educationinfo, cmd, db, true);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = db.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listUpdated.Count > 0)
                {
                    foreach (reg_educationinfoEntity reg_educationinfo in listUpdated)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_educationinfo, cmd, db);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = db.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listAdded.Count > 0)
                {
                    foreach (reg_educationinfoEntity reg_educationinfo in listAdded)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_educationinfo, cmd, db);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);

                            IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = db.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Save_reg_educationinfo"));
            }
           
            return returnCode;
        }


        async Task<long> Ireg_educationinfoDataAccessObjects.AddOrUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
             string SP = string.Empty;

            if (reg_educationinfo.educationid.HasValue)
                SP = "reg_educationinfo_Upd";
            else
                SP = "reg_educationinfo_Ins";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_educationinfo, cmd, Database);
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                        returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                        if (reg_educationinfo.CertificateDocuments != null)
                        {
                            foreach (var item in reg_educationinfo.CertificateDocuments)
                            {
                                item.BaseSecurityParam = reg_educationinfo.BaseSecurityParam;
                                item.basicinfoid = reg_educationinfo.basicinfoid;
                                if (item.CurrentState == BaseEntity.EntityState.Added)
                                {
                                    item.basicfileid = (long?)null;
                                }
                            }
                            reg_studentfilestorageDataAccessObjects reg_StudentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            IList<reg_studentfilestorageEntity> listBasicDocumentAdded = reg_educationinfo.CertificateDocuments.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                            IList<reg_studentfilestorageEntity> listBasicDocumentUpdated = reg_educationinfo.CertificateDocuments.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                            IList<reg_studentfilestorageEntity> listBasicDocumentDeleted = reg_educationinfo.CertificateDocuments.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                            await reg_StudentfilestorageDataAccessObjects.SaveList(Database, transaction, listBasicDocumentAdded, listBasicDocumentUpdated, listBasicDocumentDeleted, cancellationToken);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Addreg_educationinfo"));
                    }
                    cmd.Dispose();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Addreg_educationinfo"));
            }
            finally {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
          
            return returnCode;
        }

        async Task<long> Ireg_educationinfoDataAccessObjects.ApllicantReviewEducationInfoSaveorUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            string SP = string.Empty;

            if (reg_educationinfo.educationid.HasValue)
                SP = "reg_educationinfo_Upd";
            else
                SP = "reg_educationinfo_Ins";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_educationinfo, cmd, Database);
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                        returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                        if (reg_educationinfo.CertificateDocuments != null)
                        {
                            foreach (var item in reg_educationinfo.CertificateDocuments)
                            {
                                item.BaseSecurityParam = reg_educationinfo.BaseSecurityParam;
                                item.basicinfoid = reg_educationinfo.basicinfoid;
                                if (item.CurrentState == BaseEntity.EntityState.Added)
                                {
                                    item.basicfileid = (long?)null;
                                }
                            }
                            reg_studentfilestorageDataAccessObjects reg_StudentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            IList<reg_studentfilestorageEntity> listBasicDocumentAdded = reg_educationinfo.CertificateDocuments.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                            IList<reg_studentfilestorageEntity> listBasicDocumentUpdated = reg_educationinfo.CertificateDocuments.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                            IList<reg_studentfilestorageEntity> listBasicDocumentDeleted = reg_educationinfo.CertificateDocuments.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                            await reg_StudentfilestorageDataAccessObjects.SaveList(Database, transaction, listBasicDocumentAdded, listBasicDocumentUpdated, listBasicDocumentDeleted, cancellationToken);
                        }

                        #region TABLE:Reg_DataChecked
                        reg_datacheckedDataAccessObjects objreg_datacheckedDataAccessObjects = new reg_datacheckedDataAccessObjects(this.Context);
                        var applicantTableID = (long)ApplicantTableEnum.Reg_EducationInfo;
                        var objEntityRegDataChecked = await objreg_datacheckedDataAccessObjects.GetRegDataCheckedByApplicantTable(new reg_datacheckedEntity()
                        {
                            basicinfoid = reg_educationinfo.basicinfoid,
                            registrationid = reg_educationinfo.RegistrationID,
                            applicanttableid = applicantTableID
                        }, cancellationToken);
                        if (objEntityRegDataChecked != null) {
                            objEntityRegDataChecked.reviewedbyid = reg_educationinfo.BaseSecurityParam.userid;
                            objEntityRegDataChecked.vieweddate = DateTime.Now;
                            objEntityRegDataChecked.BaseSecurityParam = new SecurityCapsule();
                            objEntityRegDataChecked.BaseSecurityParam = reg_educationinfo.BaseSecurityParam;
                            await objreg_datacheckedDataAccessObjects.UpdateRegDataCheckedByApplicantTable(Database, transaction, objEntityRegDataChecked, cancellationToken);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.ApllicantReviewEducationInfoSaveorUpdatereg_educationinfo"));
                    }
                    cmd.Dispose();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.ApllicantReviewEducationInfoSaveorUpdatereg_educationinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }

            return returnCode;
        }

        async Task<long> Ireg_educationinfoDataAccessObjects.DeleteWithAttachment(BDO.Core.DataAccessObjects.Models.reg_educationinfoEntity reg_educationinfo, System.Threading.CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_reg_educationinfo_Del_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_educationinfo, cmd, Database, true);
                FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Deletereg_educationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }


    }
}