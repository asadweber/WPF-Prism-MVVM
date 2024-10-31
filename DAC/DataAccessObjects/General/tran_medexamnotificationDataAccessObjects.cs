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
	
	internal sealed partial class tran_medexamnotificationDataAccessObjects : BaseDataAccess, Itran_medexamnotificationDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_medexamnotificationDataAccessObjects";
        
		public tran_medexamnotificationDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_medexamnotificationEntity tran_medexamnotification, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_medexamnotification.medexamnotificationid.HasValue)
				Database.AddInParameter(cmd, "@MedExamNotificationID", DbType.Int64, tran_medexamnotification.medexamnotificationid);
            if (forDelete) return;
			if (tran_medexamnotification.batchid.HasValue)
				Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_medexamnotification.batchid);
			if (tran_medexamnotification.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_medexamnotification.basicinfoid);
			if (tran_medexamnotification.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_medexamnotification.registrationid);
			if (tran_medexamnotification.applicantphaseid.HasValue)
				Database.AddInParameter(cmd, "@ApplicantPhaseID", DbType.Int64, tran_medexamnotification.applicantphaseid);
			if (tran_medexamnotification.notificationtype.HasValue)
				Database.AddInParameter(cmd, "@NotificationType", DbType.Int32, tran_medexamnotification.notificationtype);
			if (!(string.IsNullOrEmpty(tran_medexamnotification.messagesubject)))
				Database.AddInParameter(cmd, "@MessageSubject", DbType.String, tran_medexamnotification.messagesubject);
			if (!(string.IsNullOrEmpty(tran_medexamnotification.messagebody)))
				Database.AddInParameter(cmd, "@MessageBody", DbType.String, tran_medexamnotification.messagebody);
			if ((tran_medexamnotification.smsnotification != null))
				Database.AddInParameter(cmd, "@SmsNotification", DbType.Boolean, tran_medexamnotification.smsnotification);
			if ((tran_medexamnotification.pacinotification != null))
				Database.AddInParameter(cmd, "@PaciNotification", DbType.Boolean, tran_medexamnotification.pacinotification);
			if ((tran_medexamnotification.emailnotification != null))
				Database.AddInParameter(cmd, "@EmailNotification", DbType.Boolean, tran_medexamnotification.emailnotification);
			if ((tran_medexamnotification.senddate.HasValue))
				Database.AddInParameter(cmd, "@SendDate", DbType.DateTime, tran_medexamnotification.senddate);
			if (!(string.IsNullOrEmpty(tran_medexamnotification.notificationstatus)))
				Database.AddInParameter(cmd, "@NotificationStatus", DbType.String, tran_medexamnotification.notificationstatus);
			
				Database.AddInParameter(cmd, "@FileID", DbType.Guid, tran_medexamnotification.fileid);
			if ((tran_medexamnotification.fileuploadresult != null))
				Database.AddInParameter(cmd, "@FileUploadResult", DbType.Boolean, tran_medexamnotification.fileuploadresult);
			if (!(string.IsNullOrEmpty(tran_medexamnotification.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, tran_medexamnotification.comment);
			if (!(string.IsNullOrEmpty(tran_medexamnotification.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_medexamnotification.remarks);
			if (!(string.IsNullOrEmpty(tran_medexamnotification.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_medexamnotification.updateinfo);
			if (tran_medexamnotification.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_medexamnotification.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_medexamnotificationDataAccessObjects.Add(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_medexamnotification_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_medexamnotification, cmd,Database);
                FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.Addtran_medexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_medexamnotificationDataAccessObjects.Update(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_medexamnotification_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_medexamnotification, cmd,Database);
                FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.Updatetran_medexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_medexamnotificationDataAccessObjects.Delete(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_medexamnotification_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_medexamnotification, cmd,Database, true);
                FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.Deletetran_medexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_medexamnotificationDataAccessObjects.SaveList(IList<tran_medexamnotificationEntity> listAdded, IList<tran_medexamnotificationEntity> listUpdated, IList<tran_medexamnotificationEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_medexamnotification_Ins";
            const string SPUpdate = "tran_medexamnotification_Upd";
            const string SPDelete = "tran_medexamnotification_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_medexamnotificationEntity tran_medexamnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_medexamnotification, cmd, Database, true);
                            FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_medexamnotificationEntity tran_medexamnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_medexamnotification, cmd, Database);
                            FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_medexamnotificationEntity tran_medexamnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_medexamnotification, cmd, Database);
                            FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.Save_tran_medexamnotification"));
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
       IList<tran_medexamnotificationEntity> listAdded, 
       IList<tran_medexamnotificationEntity> listUpdated, 
       IList<tran_medexamnotificationEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_medexamnotification_Ins";
            const string SPUpdate = "tran_medexamnotification_Upd";
            const string SPDelete = "tran_medexamnotification_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_medexamnotificationEntity tran_medexamnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_medexamnotification, cmd, db, true);
                            FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, db);
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
                    foreach (tran_medexamnotificationEntity tran_medexamnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_medexamnotification, cmd, db);
                            FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, db);
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
                    foreach (tran_medexamnotificationEntity tran_medexamnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_medexamnotification, cmd, db);
                            FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.Save_tran_medexamnotification"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_medexamnotificationEntity>> Itran_medexamnotificationDataAccessObjects.GetAll(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_medexamnotification_GA";
                IList<tran_medexamnotificationEntity> itemList = new List<tran_medexamnotificationEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_medexamnotification.SortExpression);
                    FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_medexamnotification, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.GetAlltran_medexamnotification"));
            }	
        }
		
        async Task<IList<tran_medexamnotificationEntity>> Itran_medexamnotificationDataAccessObjects.GetAllByPages(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_medexamnotification_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_medexamnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_medexamnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_medexamnotification.CurrentPage);                    
                    FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_medexamnotification, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_medexamnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_medexamnotification.strCommonSerachParam+"%");

                    IList<tran_medexamnotificationEntity> itemList = new List<tran_medexamnotificationEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_medexamnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.GetAllByPagestran_medexamnotification"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_medexamnotificationEntity> Itran_medexamnotificationDataAccessObjects.GetSingle(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_medexamnotification_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_medexamnotification, cmd, Database);
                    
                    IList<tran_medexamnotificationEntity> itemList = new List<tran_medexamnotificationEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamnotificationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.GetSingletran_medexamnotification"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_medexamnotificationEntity>> Itran_medexamnotificationDataAccessObjects.GAPgListView(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_medexamnotification_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_medexamnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_medexamnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_medexamnotification.CurrentPage);                    
                    FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_medexamnotification, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_medexamnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_medexamnotification.strCommonSerachParam+"%");

                    IList<tran_medexamnotificationEntity> itemList = new List<tran_medexamnotificationEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_medexamnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.GAPgListViewtran_medexamnotification"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}