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
using CLL.LLClasses.Models;
using Microsoft.IdentityModel.Tokens;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class tran_notificationbatchDataAccessObjects : BaseDataAccess, Itran_notificationbatchDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_notificationbatchDataAccessObjects";
        
		public tran_notificationbatchDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_notificationbatchEntity tran_notificationbatch, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_notificationbatch.notificationbatchid.HasValue)
				Database.AddInParameter(cmd, "@NotificationBatchID", DbType.Int64, tran_notificationbatch.notificationbatchid);
            if (forDelete) return;
            if (!(string.IsNullOrEmpty(tran_notificationbatch.batchidstring)))
				Database.AddInParameter(cmd, "@BatchID", DbType.String, tran_notificationbatch.batchidstring);
			if (tran_notificationbatch.typeid.HasValue)
				Database.AddInParameter(cmd, "@TypeID", DbType.Int64, tran_notificationbatch.typeid);
			if (!(string.IsNullOrEmpty(tran_notificationbatch.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, tran_notificationbatch.description);
			if (!(string.IsNullOrEmpty(tran_notificationbatch.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_notificationbatch.remarks);
			if (tran_notificationbatch.phaseid.HasValue)
				Database.AddInParameter(cmd, "@PhaseID", DbType.Int64, tran_notificationbatch.phaseid);
			if (tran_notificationbatch.statusid.HasValue)
				Database.AddInParameter(cmd, "@StatusID", DbType.Int64, tran_notificationbatch.statusid);
			if (tran_notificationbatch.numberofapplicant.HasValue)
				Database.AddInParameter(cmd, "@NumberofApplicant", DbType.Int32, tran_notificationbatch.numberofapplicant);
			if ((tran_notificationbatch.interviewdate.HasValue))
				Database.AddInParameter(cmd, "@InterviewDate", DbType.DateTime, tran_notificationbatch.interviewdate);
            if ((tran_notificationbatch.sendsms != null))
                Database.AddInParameter(cmd, "@SendSMS", DbType.Boolean, tran_notificationbatch.sendsms);
            if ((tran_notificationbatch.senddigitalidnotification != null))
                Database.AddInParameter(cmd, "@SendDigitalIDNotification", DbType.Boolean, tran_notificationbatch.senddigitalidnotification);
            if ((tran_notificationbatch.sendemail != null))
                Database.AddInParameter(cmd, "@SendEmail", DbType.Boolean, tran_notificationbatch.sendemail);
            if (!(string.IsNullOrEmpty(tran_notificationbatch.notificationstatus)))
				Database.AddInParameter(cmd, "@NotificationStatus", DbType.String, tran_notificationbatch.notificationstatus);
			if (!(string.IsNullOrEmpty(tran_notificationbatch.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, tran_notificationbatch.comment);
            if (tran_notificationbatch.fileid.HasValue)
                Database.AddInParameter(cmd, "@FileID", DbType.Guid, tran_notificationbatch.fileid);
            if ((tran_notificationbatch.fileuploaddate.HasValue))
                Database.AddInParameter(cmd, "@FileUploadDate", DbType.DateTime, tran_notificationbatch.fileuploaddate);
            if ((tran_notificationbatch.fileuploadresult != null))
                Database.AddInParameter(cmd, "@FileUploadResult", DbType.Boolean, tran_notificationbatch.fileuploadresult);
        }
		
        
		#region Add Operation

        async Task<long> Itran_notificationbatchDataAccessObjects.Add(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_notificationbatch_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_notificationbatch, cmd,Database);
                FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.Addtran_notificationbatch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_notificationbatchDataAccessObjects.Update(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_notificationbatch_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_notificationbatch, cmd,Database);
                FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.Updatetran_notificationbatch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_notificationbatchDataAccessObjects.Delete(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_notificationbatch_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_notificationbatch, cmd,Database, true);
                FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.Deletetran_notificationbatch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_notificationbatchDataAccessObjects.SaveList(IList<tran_notificationbatchEntity> listAdded, IList<tran_notificationbatchEntity> listUpdated, IList<tran_notificationbatchEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_notificationbatch_Ins";
            const string SPUpdate = "tran_notificationbatch_Upd";
            const string SPDelete = "tran_notificationbatch_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationbatchEntity tran_notificationbatch in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationbatch, cmd, Database, true);
                            FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationbatchEntity tran_notificationbatch in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationbatch, cmd, Database);
                            FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationbatchEntity tran_notificationbatch in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationbatch, cmd, Database);
                            FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.Save_tran_notificationbatch"));
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
       IList<tran_notificationbatchEntity> listAdded, 
       IList<tran_notificationbatchEntity> listUpdated, 
       IList<tran_notificationbatchEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_notificationbatch_Ins";
            const string SPUpdate = "tran_notificationbatch_Upd";
            const string SPDelete = "tran_notificationbatch_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationbatchEntity tran_notificationbatch in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationbatch, cmd, db, true);
                            FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationbatchEntity tran_notificationbatch in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationbatch, cmd, db);
                            FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationbatchEntity tran_notificationbatch in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationbatch, cmd, db);
                            FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.Save_tran_notificationbatch"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchDataAccessObjects.GetAll(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationbatch_GA";
                IList<tran_notificationbatchEntity> itemList = new List<tran_notificationbatchEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_notificationbatch.SortExpression);
                    FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatch, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.GetAlltran_notificationbatch"));
            }	
        }
		
        async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchDataAccessObjects.GetAllByPages(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationbatch_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationbatch.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationbatch.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationbatch.CurrentPage);                    
                    FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationbatch, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_notificationbatch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationbatch.strCommonSerachParam+"%");

                    IList<tran_notificationbatchEntity> itemList = new List<tran_notificationbatchEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationbatch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.GetAllByPagestran_notificationbatch"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Itran_notificationbatchDataAccessObjects.SaveMasterDettran_notificationbatchdet(tran_notificationbatchEntity masterEntity, 
        IList<tran_notificationbatchdetEntity> listAdded, 
        IList<tran_notificationbatchdetEntity> listUpdated,
        IList<tran_notificationbatchdetEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "tran_notificationbatch_Ins";
            const string MasterSPUpdate = "tran_notificationbatch_Upd";
            const string MasterSPDelete = "tran_notificationbatch_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                                PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = PrimaryKeyMaster;
                        
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.notificationbatchid=PrimaryKeyMaster;
                            }
                        }
                        tran_notificationbatchdetDataAccessObjects objtran_notificationbatchdet=new tran_notificationbatchdetDataAccessObjects(this.Context);
                        objtran_notificationbatchdet.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.SaveDstran_notificationbatch"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_notificationbatchEntity> Itran_notificationbatchDataAccessObjects.GetSingle(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationbatch_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatch, cmd, Database);
                    
                    IList<tran_notificationbatchEntity> itemList = new List<tran_notificationbatchEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.GetSingletran_notificationbatch"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchDataAccessObjects.GAPgListView(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationbatch_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationbatch.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationbatch.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationbatch.CurrentPage);                    
                    FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationbatch, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_notificationbatch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationbatch.strCommonSerachParam+"%");

                    IList<tran_notificationbatchEntity> itemList = new List<tran_notificationbatchEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationbatch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.GAPgListViewtran_notificationbatch"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Itran_notificationbatchDataAccessObjects.GetDataForDropDown(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "tran_notificationbatch_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, tran_notificationbatch.SortExpression);
					AddPageSizeParameter(cmd, tran_notificationbatch.PageSize);
					AddCurrentPageParameter(cmd, tran_notificationbatch.CurrentPage);                    
					FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
					FillParameters(tran_notificationbatch, cmd,Database);
					if (!string.IsNullOrEmpty(tran_notificationbatch.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + tran_notificationbatch.strCommonSerachParam + " % ");
					IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
					IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
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
					if(itemList.Count>0)
					{
						itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationbatch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}