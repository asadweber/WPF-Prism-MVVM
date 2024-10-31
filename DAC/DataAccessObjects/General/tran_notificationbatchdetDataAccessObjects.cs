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
	
	internal sealed partial class tran_notificationbatchdetDataAccessObjects : BaseDataAccess, Itran_notificationbatchdetDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_notificationbatchdetDataAccessObjects";
        
		public tran_notificationbatchdetDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_notificationbatchdetEntity tran_notificationbatchdet, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_notificationbatchdet.notificationbatchdetid.HasValue)
				Database.AddInParameter(cmd, "@NotificationBatchDetID", DbType.Int64, tran_notificationbatchdet.notificationbatchdetid);
            if (forDelete) return;
			if (tran_notificationbatchdet.notificationbatchid.HasValue)
				Database.AddInParameter(cmd, "@NotificationBatchID", DbType.Int64, tran_notificationbatchdet.notificationbatchid);
			if (tran_notificationbatchdet.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_notificationbatchdet.basicinfoid);
			if (tran_notificationbatchdet.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_notificationbatchdet.registrationid);
			if (tran_notificationbatchdet.applicantphaseid.HasValue)
				Database.AddInParameter(cmd, "@ApplicantPhaseID", DbType.Int64, tran_notificationbatchdet.applicantphaseid);
			if (tran_notificationbatchdet.notificationtypeid.HasValue)
				Database.AddInParameter(cmd, "@NotificationTypeID", DbType.Int64, tran_notificationbatchdet.notificationtypeid);
			if (tran_notificationbatchdet.notificationtemplateid.HasValue)
				Database.AddInParameter(cmd, "@NotificationTemplateID", DbType.Int64, tran_notificationbatchdet.notificationtemplateid);
			if (!(string.IsNullOrEmpty(tran_notificationbatchdet.sentmsg)))
				Database.AddInParameter(cmd, "@SentMsg", DbType.String, tran_notificationbatchdet.sentmsg);
			if ((tran_notificationbatchdet.senddate.HasValue))
				Database.AddInParameter(cmd, "@SendDate", DbType.DateTime, tran_notificationbatchdet.senddate);
			if (!(string.IsNullOrEmpty(tran_notificationbatchdet.sendresponse)))
				Database.AddInParameter(cmd, "@SendResponse", DbType.String, tran_notificationbatchdet.sendresponse);
			if (tran_notificationbatchdet.sendstatus.HasValue)
				Database.AddInParameter(cmd, "@SendStatus", DbType.Int64, tran_notificationbatchdet.sendstatus);
			if (!(string.IsNullOrEmpty(tran_notificationbatchdet.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, tran_notificationbatchdet.comment);
			if (!(string.IsNullOrEmpty(tran_notificationbatchdet.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_notificationbatchdet.remarks);
			if (!(string.IsNullOrEmpty(tran_notificationbatchdet.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_notificationbatchdet.updateinfo);
			if (tran_notificationbatchdet.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_notificationbatchdet.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_notificationbatchdetDataAccessObjects.Add(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_notificationbatchdet_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_notificationbatchdet, cmd,Database);
                FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.Addtran_notificationbatchdet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_notificationbatchdetDataAccessObjects.Update(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_notificationbatchdet_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_notificationbatchdet, cmd,Database);
                FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.Updatetran_notificationbatchdet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_notificationbatchdetDataAccessObjects.Delete(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_notificationbatchdet_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_notificationbatchdet, cmd,Database, true);
                FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.Deletetran_notificationbatchdet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_notificationbatchdetDataAccessObjects.SaveList(IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_notificationbatchdet_Ins";
            const string SPUpdate = "tran_notificationbatchdet_Upd";
            const string SPDelete = "tran_notificationbatchdet_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationbatchdetEntity tran_notificationbatchdet in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationbatchdet, cmd, Database, true);
                            FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationbatchdetEntity tran_notificationbatchdet in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationbatchdet, cmd, Database);
                            FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationbatchdetEntity tran_notificationbatchdet in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationbatchdet, cmd, Database);
                            FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.Save_tran_notificationbatchdet"));
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
       IList<tran_notificationbatchdetEntity> listAdded, 
       IList<tran_notificationbatchdetEntity> listUpdated, 
       IList<tran_notificationbatchdetEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_notificationbatchdet_Ins";
            const string SPUpdate = "tran_notificationbatchdet_Upd";
            const string SPDelete = "tran_notificationbatchdet_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationbatchdetEntity tran_notificationbatchdet in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationbatchdet, cmd, db, true);
                            FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationbatchdetEntity tran_notificationbatchdet in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationbatchdet, cmd, db);
                            FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationbatchdetEntity tran_notificationbatchdet in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationbatchdet, cmd, db);
                            FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.Save_tran_notificationbatchdet"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetDataAccessObjects.GetAll(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationbatchdet_GA";
                IList<tran_notificationbatchdetEntity> itemList = new List<tran_notificationbatchdetEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_notificationbatchdet.SortExpression);
                    FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatchdet, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchdetEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GetAlltran_notificationbatchdet"));
            }	
        }
		
        async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetDataAccessObjects.GetAllByPages(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationbatchdet_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationbatchdet.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationbatchdet.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationbatchdet.CurrentPage);                    
                    FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationbatchdet, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_notificationbatchdet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationbatchdet.strCommonSerachParam+"%");

                    IList<tran_notificationbatchdetEntity> itemList = new List<tran_notificationbatchdetEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchdetEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationbatchdet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GetAllByPagestran_notificationbatchdet"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Itran_notificationbatchdetDataAccessObjects.SaveMasterDettran_notificationbatchdet(tran_notificationbatchdetEntity masterEntity, 
        IList<tran_notificationbatchdetEntity> listAdded, 
        IList<tran_notificationbatchdetEntity> listUpdated,
        IList<tran_notificationbatchdetEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "tran_notificationbatchdet_Ins";
            const string MasterSPUpdate = "tran_notificationbatchdet_Upd";
            const string MasterSPDelete = "tran_notificationbatchdet_Del";
            
			
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
                              //  item.parentnotificationbatchdetid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.SaveDstran_notificationbatchdet"));
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
        async Task<tran_notificationbatchdetEntity> Itran_notificationbatchdetDataAccessObjects.GetSingle(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationbatchdet_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatchdet, cmd, Database);
                    
                    IList<tran_notificationbatchdetEntity> itemList = new List<tran_notificationbatchdetEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchdetEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GetSingletran_notificationbatchdet"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetDataAccessObjects.GAPgListView(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationbatchdet_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationbatchdet.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationbatchdet.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationbatchdet.CurrentPage);                    
                    FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationbatchdet, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_notificationbatchdet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationbatchdet.strCommonSerachParam+"%");

                    IList<tran_notificationbatchdetEntity> itemList = new List<tran_notificationbatchdetEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchdetEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationbatchdet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GAPgListViewtran_notificationbatchdet"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Itran_notificationbatchdetDataAccessObjects.GetDataForDropDown(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "tran_notificationbatchdet_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, tran_notificationbatchdet.SortExpression);
					AddPageSizeParameter(cmd, tran_notificationbatchdet.PageSize);
					AddCurrentPageParameter(cmd, tran_notificationbatchdet.CurrentPage);                    
					FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
					FillParameters(tran_notificationbatchdet, cmd,Database);
					if (!string.IsNullOrEmpty(tran_notificationbatchdet.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + tran_notificationbatchdet.strCommonSerachParam + " % ");
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
						tran_notificationbatchdet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}