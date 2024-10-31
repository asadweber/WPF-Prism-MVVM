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
	
	internal sealed partial class tran_notificationfileDataAccessObjects : BaseDataAccess, Itran_notificationfileDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_notificationfileDataAccessObjects";
        
		public tran_notificationfileDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_notificationfileEntity tran_notificationfile, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_notificationfile.filerequestid.HasValue)
				Database.AddInParameter(cmd, "@FileRequestID", DbType.Int64, tran_notificationfile.filerequestid);
            if (forDelete) return;
			
				Database.AddInParameter(cmd, "@FileGUID", DbType.Guid, tran_notificationfile.fileguid);
			
				Database.AddInParameter(cmd, "@ApplicationID", DbType.String, tran_notificationfile.applicationid);
			if (!(string.IsNullOrEmpty(tran_notificationfile.physicalfilename)))
				Database.AddInParameter(cmd, "@PhysicalFileName", DbType.String, tran_notificationfile.physicalfilename);
			if (!(string.IsNullOrEmpty(tran_notificationfile.userfilename)))
				Database.AddInParameter(cmd, "@UserFileName", DbType.String, tran_notificationfile.userfilename);
			if (!(string.IsNullOrEmpty(tran_notificationfile.filetype)))
				Database.AddInParameter(cmd, "@FileType", DbType.String, tran_notificationfile.filetype);
			if (!(string.IsNullOrEmpty(tran_notificationfile.fileextension)))
				Database.AddInParameter(cmd, "@FileExtension", DbType.String, tran_notificationfile.fileextension);
			if (tran_notificationfile.filesize.HasValue)
				Database.AddInParameter(cmd, "@FileSize", DbType.Int64, tran_notificationfile.filesize);
			if (!(string.IsNullOrEmpty(tran_notificationfile.messagesubject)))
				Database.AddInParameter(cmd, "@MessageSubject", DbType.String, tran_notificationfile.messagesubject);
			if (!(string.IsNullOrEmpty(tran_notificationfile.messagebody)))
				Database.AddInParameter(cmd, "@MessageBody", DbType.String, tran_notificationfile.messagebody);
			if (!(string.IsNullOrEmpty(tran_notificationfile.messagesubjectar)))
				Database.AddInParameter(cmd, "@MessageSubjectAR", DbType.String, tran_notificationfile.messagesubjectar);
			if (!(string.IsNullOrEmpty(tran_notificationfile.messagebodyar)))
				Database.AddInParameter(cmd, "@MessageBodyAR", DbType.String, tran_notificationfile.messagebodyar);
			if (!(string.IsNullOrEmpty(tran_notificationfile.messagebodyemail)))
				Database.AddInParameter(cmd, "@MessageBodyEmail", DbType.String, tran_notificationfile.messagebodyemail);
			if (!(string.IsNullOrEmpty(tran_notificationfile.messagebodyemailar)))
				Database.AddInParameter(cmd, "@MessageBodyEmailAR", DbType.String, tran_notificationfile.messagebodyemailar);
			if ((tran_notificationfile.sendsms != null))
				Database.AddInParameter(cmd, "@SendSMS", DbType.Boolean, tran_notificationfile.sendsms);
			if ((tran_notificationfile.senddigitalidnotification != null))
				Database.AddInParameter(cmd, "@SendDigitalIDNotification", DbType.Boolean, tran_notificationfile.senddigitalidnotification);
			if ((tran_notificationfile.sendemail != null))
				Database.AddInParameter(cmd, "@SendEmail", DbType.Boolean, tran_notificationfile.sendemail);
			
				Database.AddInParameter(cmd, "@FileID", DbType.String, tran_notificationfile.fileid);
			if ((tran_notificationfile.fileuploaddate.HasValue))
				Database.AddInParameter(cmd, "@FileUploadDate", DbType.DateTime, tran_notificationfile.fileuploaddate);
			if (tran_notificationfile.fileuploadresult != null)
				Database.AddInParameter(cmd, "@FileUploadResult", DbType.Boolean, tran_notificationfile.fileuploadresult);
			if (!(string.IsNullOrEmpty(tran_notificationfile.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, tran_notificationfile.comment);

        }
		
        
		#region Add Operation

        async Task<long> Itran_notificationfileDataAccessObjects.Add(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_notificationfile_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_notificationfile, cmd,Database);
                FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.Addtran_notificationfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_notificationfileDataAccessObjects.Update(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_notificationfile_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_notificationfile, cmd,Database);
                FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.Updatetran_notificationfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_notificationfileDataAccessObjects.Delete(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_notificationfile_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_notificationfile, cmd,Database, true);
                FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.Deletetran_notificationfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_notificationfileDataAccessObjects.SaveList(IList<tran_notificationfileEntity> listAdded, IList<tran_notificationfileEntity> listUpdated, IList<tran_notificationfileEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_notificationfile_Ins";
            const string SPUpdate = "tran_notificationfile_Upd";
            const string SPDelete = "tran_notificationfile_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationfileEntity tran_notificationfile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationfile, cmd, Database, true);
                            FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationfileEntity tran_notificationfile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationfile, cmd, Database);
                            FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationfileEntity tran_notificationfile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationfile, cmd, Database);
                            FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.Save_tran_notificationfile"));
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
       IList<tran_notificationfileEntity> listAdded, 
       IList<tran_notificationfileEntity> listUpdated, 
       IList<tran_notificationfileEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_notificationfile_Ins";
            const string SPUpdate = "tran_notificationfile_Upd";
            const string SPDelete = "tran_notificationfile_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationfileEntity tran_notificationfile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationfile, cmd, db, true);
                            FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationfileEntity tran_notificationfile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationfile, cmd, db);
                            FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationfileEntity tran_notificationfile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationfile, cmd, db);
                            FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.Save_tran_notificationfile"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_notificationfileEntity>> Itran_notificationfileDataAccessObjects.GetAll(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationfile_GA";
                IList<tran_notificationfileEntity> itemList = new List<tran_notificationfileEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_notificationfile.SortExpression);
                    FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationfile, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfileEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.GetAlltran_notificationfile"));
            }	
        }
		
        async Task<IList<tran_notificationfileEntity>> Itran_notificationfileDataAccessObjects.GetAllByPages(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationfile_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationfile.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationfile.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationfile.CurrentPage);                    
                    FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationfile, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_notificationfile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationfile.strCommonSerachParam+"%");

                    IList<tran_notificationfileEntity> itemList = new List<tran_notificationfileEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfileEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.GetAllByPagestran_notificationfile"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_notificationfileEntity> Itran_notificationfileDataAccessObjects.GetSingle(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationfile_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationfile, cmd, Database);
                    
                    IList<tran_notificationfileEntity> itemList = new List<tran_notificationfileEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfileEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.GetSingletran_notificationfile"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_notificationfileEntity>> Itran_notificationfileDataAccessObjects.GAPgListView(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationfile_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationfile.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationfile.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationfile.CurrentPage);                    
                    FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationfile, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_notificationfile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationfile.strCommonSerachParam+"%");

                    IList<tran_notificationfileEntity> itemList = new List<tran_notificationfileEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfileEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.GAPgListViewtran_notificationfile"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Itran_notificationfileDataAccessObjects.GetDataForDropDown(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_notificationfile_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationfile.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationfile.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationfile.CurrentPage);
                    FillSequrityParameters(tran_notificationfile.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationfile, cmd, Database);
                    if (!string.IsNullOrEmpty(tran_notificationfile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + tran_notificationfile.strCommonSerachParam + " % ");
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
                        tran_notificationfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfileDataAccess.GetDataForDropDown"));
            }
        }
        #endregion

    }
}