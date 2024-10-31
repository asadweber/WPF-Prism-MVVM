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
	
	internal sealed partial class tran_syexamnotificationDataAccessObjects : BaseDataAccess, Itran_syexamnotificationDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_syexamnotificationDataAccessObjects";
        
		public tran_syexamnotificationDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_syexamnotificationEntity tran_syexamnotification, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_syexamnotification.syexamnotificationid.HasValue)
				Database.AddInParameter(cmd, "@SyExamNotificationID", DbType.Int64, tran_syexamnotification.syexamnotificationid);
            if (forDelete) return;
			if (tran_syexamnotification.batchid.HasValue)
				Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_syexamnotification.batchid);
			if (tran_syexamnotification.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_syexamnotification.basicinfoid);
			if (tran_syexamnotification.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_syexamnotification.registrationid);
			if (tran_syexamnotification.applicantphaseid.HasValue)
				Database.AddInParameter(cmd, "@ApplicantPhaseID", DbType.Int64, tran_syexamnotification.applicantphaseid);
			if (!(string.IsNullOrEmpty(tran_syexamnotification.messagesubject)))
				Database.AddInParameter(cmd, "@MessageSubject", DbType.String, tran_syexamnotification.messagesubject);
			if (!(string.IsNullOrEmpty(tran_syexamnotification.messagebody)))
				Database.AddInParameter(cmd, "@MessageBody", DbType.String, tran_syexamnotification.messagebody);
			if ((tran_syexamnotification.smsnotification != null))
				Database.AddInParameter(cmd, "@SmsNotification", DbType.Boolean, tran_syexamnotification.smsnotification);
			if ((tran_syexamnotification.pacinotification != null))
				Database.AddInParameter(cmd, "@PaciNotification", DbType.Boolean, tran_syexamnotification.pacinotification);
			if ((tran_syexamnotification.emailnotification != null))
				Database.AddInParameter(cmd, "@EmailNotification", DbType.Boolean, tran_syexamnotification.emailnotification);
			if ((tran_syexamnotification.senddate.HasValue))
				Database.AddInParameter(cmd, "@SendDate", DbType.DateTime, tran_syexamnotification.senddate);
			if (!(string.IsNullOrEmpty(tran_syexamnotification.notificationstatus)))
				Database.AddInParameter(cmd, "@NotificationStatus", DbType.String, tran_syexamnotification.notificationstatus);
			
				Database.AddInParameter(cmd, "@FileID", DbType.Guid, tran_syexamnotification.fileid);
			if ((tran_syexamnotification.fileuploadresult != null))
				Database.AddInParameter(cmd, "@FileUploadResult", DbType.Boolean, tran_syexamnotification.fileuploadresult);
			if (!(string.IsNullOrEmpty(tran_syexamnotification.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, tran_syexamnotification.comment);
			if (!(string.IsNullOrEmpty(tran_syexamnotification.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_syexamnotification.remarks);
			if (!(string.IsNullOrEmpty(tran_syexamnotification.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_syexamnotification.updateinfo);
			if (tran_syexamnotification.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_syexamnotification.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_syexamnotificationDataAccessObjects.Add(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_syexamnotification_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_syexamnotification, cmd,Database);
                FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.Addtran_syexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_syexamnotificationDataAccessObjects.Update(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_syexamnotification_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_syexamnotification, cmd,Database);
                FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.Updatetran_syexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_syexamnotificationDataAccessObjects.Delete(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_syexamnotification_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_syexamnotification, cmd,Database, true);
                FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.Deletetran_syexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_syexamnotificationDataAccessObjects.SaveList(IList<tran_syexamnotificationEntity> listAdded, IList<tran_syexamnotificationEntity> listUpdated, IList<tran_syexamnotificationEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_syexamnotification_Ins";
            const string SPUpdate = "tran_syexamnotification_Upd";
            const string SPDelete = "tran_syexamnotification_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_syexamnotificationEntity tran_syexamnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_syexamnotification, cmd, Database, true);
                            FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_syexamnotificationEntity tran_syexamnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_syexamnotification, cmd, Database);
                            FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_syexamnotificationEntity tran_syexamnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_syexamnotification, cmd, Database);
                            FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.Save_tran_syexamnotification"));
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
       IList<tran_syexamnotificationEntity> listAdded, 
       IList<tran_syexamnotificationEntity> listUpdated, 
       IList<tran_syexamnotificationEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_syexamnotification_Ins";
            const string SPUpdate = "tran_syexamnotification_Upd";
            const string SPDelete = "tran_syexamnotification_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_syexamnotificationEntity tran_syexamnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_syexamnotification, cmd, db, true);
                            FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, db);
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
                    foreach (tran_syexamnotificationEntity tran_syexamnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_syexamnotification, cmd, db);
                            FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, db);
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
                    foreach (tran_syexamnotificationEntity tran_syexamnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_syexamnotification, cmd, db);
                            FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.Save_tran_syexamnotification"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_syexamnotificationEntity>> Itran_syexamnotificationDataAccessObjects.GetAll(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_syexamnotification_GA";
                IList<tran_syexamnotificationEntity> itemList = new List<tran_syexamnotificationEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_syexamnotification.SortExpression);
                    FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_syexamnotification, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.GetAlltran_syexamnotification"));
            }	
        }
		
        async Task<IList<tran_syexamnotificationEntity>> Itran_syexamnotificationDataAccessObjects.GetAllByPages(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_syexamnotification_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_syexamnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_syexamnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_syexamnotification.CurrentPage);                    
                    FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_syexamnotification, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_syexamnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_syexamnotification.strCommonSerachParam+"%");

                    IList<tran_syexamnotificationEntity> itemList = new List<tran_syexamnotificationEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_syexamnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.GetAllByPagestran_syexamnotification"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_syexamnotificationEntity> Itran_syexamnotificationDataAccessObjects.GetSingle(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_syexamnotification_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_syexamnotification, cmd, Database);
                    
                    IList<tran_syexamnotificationEntity> itemList = new List<tran_syexamnotificationEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamnotificationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.GetSingletran_syexamnotification"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_syexamnotificationEntity>> Itran_syexamnotificationDataAccessObjects.GAPgListView(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_syexamnotification_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_syexamnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_syexamnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_syexamnotification.CurrentPage);                    
                    FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_syexamnotification, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_syexamnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_syexamnotification.strCommonSerachParam+"%");

                    IList<tran_syexamnotificationEntity> itemList = new List<tran_syexamnotificationEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_syexamnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.GAPgListViewtran_syexamnotification"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}