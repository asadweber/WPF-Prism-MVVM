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
using System.Linq;
using BDO.Core.Base;
using CLL.LLClasses.Models;
using System.Net.Cache;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class reg_famillyDataAccessObjects
    {
        async Task<reg_famillyEntity> Ireg_famillyDataAccessObjects.GetSingleByIdWithDocument(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_familly_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_famillyEntity(reader);
                            //reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            //obj.Documents = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId_FileConfigType(new reg_studentfilestorageEntity()
                            //{
                            //    basicinfoid = reg_familly.basicinfoid,
                            //    fileconfigid = reg_familly.fileConfigId,
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetSinglereg_familly"));
            }
        }
        async Task<long> Ireg_famillyDataAccessObjects.AddExt(reg_famillyEntity reg_famillydata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_familly_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_famillydata, cmd, Database);
                FillSequrityParameters(reg_famillydata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<reg_famillyEntity>> Ireg_famillyDataAccessObjects.GetAllExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_familly_GA_Ext";
                IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_familly.SortExpression);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_famillyEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetAllreg_familly"));
            }
        }


        public async Task<long> SaveFamilyList(
                       Database db,
                       DbTransaction transaction,
                       IList<reg_famillyEntity> listAdded,
                       IList<reg_famillyEntity> listUpdated,
                       IList<reg_famillyEntity> listDeleted,
                       CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "KAF_reg_familly_Ins_ext";
            const string SPUpdate = "KAF_reg_familly_Upd_Ext";
            const string SPDelete = "KAF_reg_familly_Del_Ext";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (reg_famillyEntity reg_familly in listDeleted)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_familly, cmd, db, true);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
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
                    foreach (reg_famillyEntity reg_familly in listUpdated)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_familly, cmd, db);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
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
                    foreach (reg_famillyEntity reg_familly in listAdded)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_familly, cmd, db);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.Save_reg_familly"));
            }

            return returnCode;
        }


        public async Task<reg_famillyEntity> GetFamiliyMemberByRelationType(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_familly_ByRelationType_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_famillyEntity(reader);
                            //if (reg_familly.fileConfigId.HasValue)
                            //{
                            //    reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            //    obj.Documents = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId_FileConfigType(new reg_studentfilestorageEntity()
                            //    {
                            //        basicinfoid = reg_familly.basicinfoid,
                            //        fileconfigid = reg_familly.fileConfigId,
                            //        CurrentState = BaseEntity.EntityState.Unchanged,

                            //    }, cancellationToken);
                            //}
                            itemList.Add(obj);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList.FirstOrDefault();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetSinglereg_familly"));
            }
        }

        public async Task<reg_famillyEntity> GetFamiliyMemberByRelationType(Database db, DbTransaction transaction, reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_familly_ByRelationType_GS";
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
                    FillParameters(reg_familly, cmd, db);

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = db.BeginExecuteReader(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = db.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_famillyEntity(reader);
                            itemList.Add(obj);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList.FirstOrDefault();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetFamiliyMemberByRelationType"));
            }
        }

        public async Task<List<reg_famillyEntity>> GetFamilyMemberListByRelationType(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_familly_ByRelationType_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);

                    List<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_famillyEntity(reader);

                            //if (reg_familly.fileConfigId.HasValue)
                            //{
                            //    reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            //    obj.Documents = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId_FileConfigType(new reg_studentfilestorageEntity()
                            //    {
                            //        basicinfoid = reg_familly.basicinfoid,
                            //        fileconfigid = reg_familly.fileConfigId,
                            //        CurrentState = BaseEntity.EntityState.Unchanged,

                            //    }, cancellationToken);
                            //}

                            itemList.Add(obj);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList;
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetSinglereg_familly"));
            }
        }

        public async Task<List<reg_famillyEntity>> GetFamilyMememberSpouseList(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_familly_all_Spouse_ByParentId";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);

                    List<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_famillyEntity(reader);
                            //reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            //obj.Documents = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId_FileConfigType(new reg_studentfilestorageEntity()
                            //{
                            //    basicinfoid = reg_familly.basicinfoid,
                            //    registrationid = reg_familly.RegistrationID,
                            //    fileconfigid = reg_familly.fileConfigId,
                            //    datatablename = "Reg_Familly",
                            //    pkcolumnname = "familyid",
                            //    pkcolumnid = obj.familyid,
                            //    CurrentState = BaseEntity.EntityState.Unchanged,

                            //}, cancellationToken);
                            itemList.Add(obj);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList;
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetSinglereg_familly"));
            }
        }



        async Task<long> Ireg_famillyDataAccessObjects.SaveUpdateExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            string SP = string.Empty;
            if (reg_familly.familyid.HasValue)
                SP = "KAF_reg_familly_Upd_EXT";
            else
                SP = "KAF_reg_familly_Ins_ext";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_familly, cmd, Database);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    Database.AddInParameter(cmd, "@HasSpouse", DbType.Boolean, reg_familly.HasSpouse);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                    if (reg_familly.relationshipid == (long)RelationshipEnum.Father)
                    {
                        if (reg_familly.RegNonKuwaityStatusList == null)
                            reg_familly.RegNonKuwaityStatusList = new List<reg_nonkuwaitystatusEntity>();

                        reg_nonkuwaitystatusDataAccessObjects objreg_nonkuwaitystatus = new reg_nonkuwaitystatusDataAccessObjects(this.Context);

                        IList<reg_nonkuwaitystatusEntity> listNonKuwaityStatusDeleted = null;
                        listNonKuwaityStatusDeleted = await objreg_nonkuwaitystatus.GetAll(Database, transaction, new reg_nonkuwaitystatusEntity()
                        { basicinfoid = reg_familly.basicinfoid, familyid = reg_familly.familyid }, cancellationToken);
                        foreach (var item in listNonKuwaityStatusDeleted)
                        {
                            item.CurrentState = BaseEntity.EntityState.Deleted;
                        }

                        foreach (var item in reg_familly.RegNonKuwaityStatusList)
                        {
                            item.BaseSecurityParam = new SecurityCapsule();
                            item.BaseSecurityParam = reg_familly.BaseSecurityParam;
                            item.regnonkuwaitystatusid = (long?)null;
                            item.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Added;
                            item.familyid = returnCode;
                        }

                        IList<reg_nonkuwaitystatusEntity> listNonKuwaityStatusAdded = reg_familly.RegNonKuwaityStatusList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                        IList<reg_nonkuwaitystatusEntity> listNonKuwaityStatusUpdated = reg_familly.RegNonKuwaityStatusList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                        if (listNonKuwaityStatusDeleted == null)
                            listNonKuwaityStatusDeleted = new List<reg_nonkuwaitystatusEntity>();
                        await objreg_nonkuwaitystatus.SaveList(Database, transaction, listNonKuwaityStatusAdded, listNonKuwaityStatusUpdated, listNonKuwaityStatusDeleted, cancellationToken);
                    }

                    //if (reg_familly.Documents != null)
                    //{
                    //    foreach (var item in reg_familly.Documents)
                    //    {
                    //        item.BaseSecurityParam = reg_familly.BaseSecurityParam;
                    //        item.basicinfoid = reg_familly.basicinfoid;
                    //        if (item.CurrentState == BaseEntity.EntityState.Added)
                    //        {
                    //            item.basicfileid = (long?)null;
                    //        }
                    //    }
                    //    reg_studentfilestorageDataAccessObjects reg_StudentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                    //    IList<reg_studentfilestorageEntity> listBasicDocumentAdded = reg_familly.Documents.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    //    IList<reg_studentfilestorageEntity> listBasicDocumentUpdated = reg_familly.Documents.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    //    IList<reg_studentfilestorageEntity> listBasicDocumentDeleted = reg_familly.Documents.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    //    await reg_StudentfilestorageDataAccessObjects.SaveList(Database, transaction, listBasicDocumentAdded, listBasicDocumentUpdated, listBasicDocumentDeleted, cancellationToken);
                    //}

                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        public async Task<long> SaveUpdateExt(Database db, DbTransaction transaction, reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            string SP = string.Empty;
            if (reg_familly.familyid.HasValue)
                SP = "KAF_reg_familly_Upd_EXT";
            else
                SP = "KAF_reg_familly_Ins_ext";

            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_familly, cmd, db);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
                    AddOutputParameter(cmd);

                    IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = db.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveUpdateExt"));
            }
            return returnCode;
        }

        async Task<long> Ireg_famillyDataAccessObjects.ApplicantReviewSaveUpdate(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            string SP = string.Empty;
            if (reg_familly.familyid.HasValue)
                SP = "KAF_reg_familly_Upd_EXT";
            else
                SP = "KAF_reg_familly_Ins_ext";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_familly, cmd, Database);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    Database.AddInParameter(cmd, "@HasSpouse", DbType.Boolean, reg_familly.HasSpouse);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                    if (reg_familly.RegNonKuwaityStatusList == null)
                        reg_familly.RegNonKuwaityStatusList = new List<reg_nonkuwaitystatusEntity>();

                    reg_nonkuwaitystatusDataAccessObjects objreg_nonkuwaitystatus = new reg_nonkuwaitystatusDataAccessObjects(this.Context);

                    IList<reg_nonkuwaitystatusEntity> listNonKuwaityStatusDeleted = null;
                    listNonKuwaityStatusDeleted = await objreg_nonkuwaitystatus.GetAll(Database, transaction, new reg_nonkuwaitystatusEntity()
                    { basicinfoid = reg_familly.basicinfoid, familyid = reg_familly.familyid }, cancellationToken);
                    foreach (var item in listNonKuwaityStatusDeleted)
                    {
                        item.CurrentState = BaseEntity.EntityState.Deleted;
                    }

                    foreach (var item in reg_familly.RegNonKuwaityStatusList)
                    {
                        item.BaseSecurityParam = new SecurityCapsule();
                        item.BaseSecurityParam = reg_familly.BaseSecurityParam;
                        item.regnonkuwaitystatusid = (long?)null;
                        item.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Added;
                        item.familyid = returnCode;
                    }

                    IList<reg_nonkuwaitystatusEntity> listNonKuwaityStatusAdded = reg_familly.RegNonKuwaityStatusList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_nonkuwaitystatusEntity> listNonKuwaityStatusUpdated = reg_familly.RegNonKuwaityStatusList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    if (listNonKuwaityStatusDeleted == null)
                        listNonKuwaityStatusDeleted = new List<reg_nonkuwaitystatusEntity>();
                    await objreg_nonkuwaitystatus.SaveList(Database, transaction, listNonKuwaityStatusAdded, listNonKuwaityStatusUpdated, listNonKuwaityStatusDeleted, cancellationToken);

                    #region TABLE:Reg_DataChecked
                    reg_datacheckedDataAccessObjects objreg_datacheckedDataAccessObjects = new reg_datacheckedDataAccessObjects(this.Context);
                    var applicantTableID = reg_familly.applicantTableID;
                    var objEntityRegDataChecked = await objreg_datacheckedDataAccessObjects.GetRegDataCheckedByApplicantTable(new reg_datacheckedEntity()
                    {
                        basicinfoid = reg_familly.basicinfoid,
                        registrationid = reg_familly.RegistrationID,
                        applicanttableid = applicantTableID
                    }, cancellationToken);
                    if (objEntityRegDataChecked != null)
                    {
                        objEntityRegDataChecked.reviewedbyid = reg_familly.BaseSecurityParam.userid;
                        objEntityRegDataChecked.vieweddate = DateTime.Now;
                        objEntityRegDataChecked.BaseSecurityParam = new SecurityCapsule();
                        objEntityRegDataChecked.BaseSecurityParam = reg_familly.BaseSecurityParam;
                        await objreg_datacheckedDataAccessObjects.UpdateRegDataCheckedByApplicantTable(Database, transaction, objEntityRegDataChecked, cancellationToken);
                    }
                    #endregion

                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_familyinfoDataAccess.ApplicantReviewSaveUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<IList<reg_famillyEntity>> Ireg_famillyDataAccessObjects.GetAllSpouseByPage(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_familly_all_Spouse_GAPg_EXT";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_familly.SortExpression);
                    AddPageSizeParameter(cmd, reg_familly.PageSize);
                    AddCurrentPageParameter(cmd, reg_familly.CurrentPage);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_familly, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_familly.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_familly.strCommonSerachParam + "%");

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_famillyEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_familly.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetAllByPagesreg_familly"));
            }
        }

        //async Task<IList<reg_famillyEntity>> Ireg_famillyDataAccessObjects.CheckHasSpouce(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        const string SP = "KAF_reg_familly_CheckHasSpouse";
        //        using (DbCommand cmd = Database.GetStoredProcCommand(SP))
        //        {

        //            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);

        //            FillParameters(reg_familly, cmd, Database);


        //            IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

        //            IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
        //            while (!result.IsCompleted)
        //            {
        //            }
        //            using (IDataReader reader = Database.EndExecuteReader(result))
        //            {
        //                while (reader.Read())
        //                {
        //                    itemList.Add(new reg_famillyEntity(reader));
        //                }
        //                reader.Close();
        //            }

        //            cmd.Dispose();
        //            return itemList;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetAllByPagesreg_familly"));
        //    }
        //}

        async Task<long> Ireg_famillyDataAccessObjects.DeleteByFamilityId(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_reg_familly_Del_EXT";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_familly, cmd, Database, true);
                FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.Deletereg_familly"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }


        async Task<IList<reg_famillyEntity>> Ireg_famillyDataAccessObjects.GetFamilyMembersByRelationshipType(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_familly_ByRelationshipType";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_familly.SortExpression);
                    AddPageSizeParameter(cmd, reg_familly.PageSize);
                    AddCurrentPageParameter(cmd, reg_familly.CurrentPage);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_familly, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_familly.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_familly.strCommonSerachParam + "%");

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_famillyEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_familly.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetAllByPagesreg_familly"));
            }
        }


    }
}