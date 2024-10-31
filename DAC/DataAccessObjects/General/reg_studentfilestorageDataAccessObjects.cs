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
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class reg_studentfilestorageDataAccessObjects : BaseDataAccess, Ireg_studentfilestorageDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_studentfilestorageDataAccessObjects";
        
		public reg_studentfilestorageDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion


        public static void FillParameters(reg_studentfilestorageEntity reg_studentfilestorage, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (reg_studentfilestorage.basicfileid.HasValue)
                Database.AddInParameter(cmd, "@BasicFileID", DbType.Int64, reg_studentfilestorage.basicfileid);
            if (forDelete) return;
            if (reg_studentfilestorage.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_studentfilestorage.basicinfoid);
            if (reg_studentfilestorage.fileconfignameid.HasValue)
                Database.AddInParameter(cmd, "@FileConfigNameID", DbType.Int64, reg_studentfilestorage.fileconfignameid);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.foldercontentid)))
                Database.AddInParameter(cmd, "@FolderContentId", DbType.String, reg_studentfilestorage.foldercontentid);
            if (reg_studentfilestorage.pkcolumnid.HasValue)
                Database.AddInParameter(cmd, "@PkColumnID", DbType.Int64, reg_studentfilestorage.pkcolumnid);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.pkcolumnname)))
                Database.AddInParameter(cmd, "@PkColumnName", DbType.String, reg_studentfilestorage.pkcolumnname);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.userfilename)))
                Database.AddInParameter(cmd, "@UserFileName", DbType.String, reg_studentfilestorage.userfilename);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.filepath)))
                Database.AddInParameter(cmd, "@FilePath", DbType.String, reg_studentfilestorage.filepath);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.filename)))
                Database.AddInParameter(cmd, "@FileName", DbType.String, reg_studentfilestorage.filename);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.filetype)))
                Database.AddInParameter(cmd, "@FileType", DbType.String, reg_studentfilestorage.filetype);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.filesize)))
                Database.AddInParameter(cmd, "@FileSize", DbType.String, reg_studentfilestorage.filesize);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.extension)))
                Database.AddInParameter(cmd, "@Extension", DbType.String, reg_studentfilestorage.extension);
            if (!(string.IsNullOrEmpty(reg_studentfilestorage.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, reg_studentfilestorage.comment);
        }


        #region Add Operation

        async Task<long> Ireg_studentfilestorageDataAccessObjects.Add(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_studentfilestorage_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_studentfilestorage, cmd,Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.Addreg_studentfilestorage"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_studentfilestorageDataAccessObjects.Update(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_studentfilestorage_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_studentfilestorage, cmd,Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.Updatereg_studentfilestorage"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_studentfilestorageDataAccessObjects.Delete(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_studentfilestorage_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_studentfilestorage, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.Deletereg_studentfilestorage"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_studentfilestorageDataAccessObjects.SaveList(IList<reg_studentfilestorageEntity> listAdded, IList<reg_studentfilestorageEntity> listUpdated, IList<reg_studentfilestorageEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_studentfilestorage_Ins";
            const string SPUpdate = "reg_studentfilestorage_Upd";
            const string SPDelete = "reg_studentfilestorage_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_studentfilestorage, cmd, Database, true);
                            FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
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
                if (listUpdated.Count > 0 )
                {
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_studentfilestorage, cmd, Database);
                            FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
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
                if (listAdded.Count > 0 )
                {
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_studentfilestorage, cmd, Database);
                            FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
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

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.Save_reg_studentfilestorage"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
       public async Task<long> SaveList(
       Database db , 
       DbTransaction transaction,
       IList<reg_studentfilestorageEntity> listAdded, 
       IList<reg_studentfilestorageEntity> listUpdated, 
       IList<reg_studentfilestorageEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_studentfilestorage_Ins";
            const string SPUpdate = "reg_studentfilestorage_Upd";
            const string SPDelete = "reg_studentfilestorage_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
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
                if (listUpdated.Count > 0 )
                {
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
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
                if (listAdded.Count > 0 )
                {
                    foreach (reg_studentfilestorageEntity reg_studentfilestorage in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.Save_reg_studentfilestorage"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageDataAccessObjects.GetAll(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_studentfilestorage_GA";
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
		
        async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageDataAccessObjects.GetAllByPages(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_studentfilestorage_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_studentfilestorage.SortExpression);
                    AddPageSizeParameter(cmd, reg_studentfilestorage.PageSize);
                    AddCurrentPageParameter(cmd, reg_studentfilestorage.CurrentPage);                    
                    FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_studentfilestorage, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_studentfilestorage.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_studentfilestorage.strCommonSerachParam+"%");

                    IList<reg_studentfilestorageEntity> itemList = new List<reg_studentfilestorageEntity>();
                    
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
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_studentfilestorage.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.GetAllByPagesreg_studentfilestorage"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_studentfilestorageEntity> Ireg_studentfilestorageDataAccessObjects.GetSingle(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_studentfilestorage_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_studentfilestorage, cmd, Database);
                    
                    IList<reg_studentfilestorageEntity> itemList = new List<reg_studentfilestorageEntity>();
                    
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
                    
                    if(itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.GetSinglereg_studentfilestorage"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageDataAccessObjects.GAPgListView(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_studentfilestorage_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_studentfilestorage.SortExpression);
                    AddPageSizeParameter(cmd, reg_studentfilestorage.PageSize);
                    AddCurrentPageParameter(cmd, reg_studentfilestorage.CurrentPage);                    
                    FillSequrityParameters(reg_studentfilestorage.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_studentfilestorage, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_studentfilestorage.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_studentfilestorage.strCommonSerachParam+"%");

                    IList<reg_studentfilestorageEntity> itemList = new List<reg_studentfilestorageEntity>();
					
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
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_studentfilestorage.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_studentfilestorageDataAccess.GAPgListViewreg_studentfilestorage"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}