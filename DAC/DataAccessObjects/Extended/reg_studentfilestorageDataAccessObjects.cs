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
using System.Transactions;



namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class reg_studentfilestorageDataAccessObjects 
	{
        async Task<long> Ireg_studentfilestorageDataAccessObjects.AddExt(reg_studentfilestorageEntity reg_studentfilestoragedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_studentfilestorage_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_studentfilestoragedata, cmd,Database);
                FillSequrityParameters(reg_studentfilestoragedata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageDataAccessObjects.GetAllExt(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_studentfilestorage_GA_Ext";
                IList<reg_studentfilestorageEntity> itemList = new List<reg_studentfilestorageEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_studentfilestorage.SortExpression);
                    FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_studentfilestorage, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_studentfilestorageEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.GetAllreg_studentfilestorage"));
            }	
        }


       public async Task<List<reg_studentfilestorageEntity>> GetAllByBasicId_FileConfigType(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_studentfilestorage_BasicId_FileConfigType";
                List<reg_studentfilestorageEntity> itemList = new List<reg_studentfilestorageEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_studentfilestorage.SortExpression);
                    FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_studentfilestorage, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_studentfilestorageEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.GetAllreg_studentfilestorage"));
            }
        }

        public async Task<List<reg_studentfilestorageEntity>> GetAllByBasicId(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetStudentFileStorageAgainstBasicInfoID";
                List<reg_studentfilestorageEntity> itemList = new List<reg_studentfilestorageEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    //AddSortExpressionParameter(cmd, reg_studentfilestorage.SortExpression);
                    FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_studentfilestorage, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_studentfilestorageEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.GetAllreg_studentfilestorage"));
            }
        }

        async Task<long> Ireg_studentfilestorageDataAccessObjects.DeletebyBasicInfoIDFileConfigID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_RegStudentFileStorage_Del_byBasicInfoIDFileConfigID";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                if (reg_studentfilestorage.basicinfoid.HasValue)
                    Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_studentfilestorage.basicinfoid);
                if (reg_studentfilestorage.fileconfignameid.HasValue)
                    Database.AddInParameter(cmd, "@FileConfigNameID", DbType.Int64, reg_studentfilestorage.fileconfignameid);

                FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.DeletebyBasicInfoIDFileConfigID"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageDataAccessObjects.GetAllByBasicInfoID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetAll_RegStudentFileStorage_by_BasicInfoID";
                IList<reg_studentfilestorageEntity> itemList = new List<reg_studentfilestorageEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_studentfilestorage.SortExpression);
                    FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_studentfilestorage, cmd, Database);

                    if (reg_studentfilestorage.BatchID.HasValue)
                        Database.AddInParameter(cmd, "@BatchID", DbType.Int64, reg_studentfilestorage.BatchID);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_studentfilestorageEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.GetAllByBasicInfoID"));
            }
        }

        public async Task<long> SaveDocumentList(Database db, DbTransaction transaction, IList<reg_studentfilestorageEntity> listAdded, IList<reg_studentfilestorageEntity> listUpdated, IList<reg_studentfilestorageEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_studentfilestorage_Ins";
            const string SPUpdate = "reg_studentfilestorage_Upd";
            const string SPDelete = "reg_studentfilestorage_Del";

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listDeleted)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_studentfilestorage, cmd, db, true);
                            FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);

                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
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
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listUpdated)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_studentfilestorage, cmd, db);
                            FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
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
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listAdded)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_studentfilestorage, cmd, db);
                            FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);

                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.SaveDocumentList_reg_studentfilestorage"));
            }
            return returnCode;
        }

        //public async Task<long> UpdateAllFileConfigIDbyBasicInfoID(Database db,
        //DbTransaction transaction, reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        //{
        //    long returnCode = -99;
        //    const string SP = "reg_studentfilestorage_Upd_Ext";

        //    using (DbCommand cmd = db.GetStoredProcCommand(SP))
        //    {
        //        FillParameters(reg_studentfilestorage, cmd, db);
        //        FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, db);
        //        AddOutputParameter(cmd);

        //        if (reg_studentfilestorage.BatchID.HasValue)
        //            Database.AddInParameter(cmd, "@BatchID", DbType.Int64, reg_studentfilestorage.BatchID);

        //        try
        //        {
        //            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
        //            while (!result.IsCompleted)
        //            {
        //            }
        //            returnCode = Database.EndExecuteNonQuery(result);
        //            returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
        //        }
        //        catch (Exception ex)
        //        {
        //            throw GetDataAccessException(ex, SourceOfException("reg_studentfilestorageDataAccess.UpdateAllFileConfigIDbyBasicInfoID"));
        //        }
        //        cmd.Dispose();
        //    }
        //    return returnCode;
        //}

    }
}