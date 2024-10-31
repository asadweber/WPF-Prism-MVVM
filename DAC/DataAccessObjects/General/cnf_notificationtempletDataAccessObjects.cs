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
	
	internal sealed partial class cnf_notificationtempletDataAccessObjects : BaseDataAccess, Icnf_notificationtempletDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_notificationtempletDataAccessObjects";
        
		public cnf_notificationtempletDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_notificationtempletEntity cnf_notificationtemplet, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_notificationtemplet.notificationtemplateid.HasValue)
				Database.AddInParameter(cmd, "@NotificationTemplateID", DbType.Int64, cnf_notificationtemplet.notificationtemplateid);
            if (forDelete) return;
			if (cnf_notificationtemplet.templettypeid.HasValue)
				Database.AddInParameter(cmd, "@TempletTypeID", DbType.Int64, cnf_notificationtemplet.templettypeid);
			if (!(string.IsNullOrEmpty(cnf_notificationtemplet.templateshortname)))
				Database.AddInParameter(cmd, "@TemplateShortName", DbType.String, cnf_notificationtemplet.templateshortname);
			if (!(string.IsNullOrEmpty(cnf_notificationtemplet.templatemsg)))
				Database.AddInParameter(cmd, "@TemplateMSG", DbType.String, cnf_notificationtemplet.templatemsg);
			if (!(string.IsNullOrEmpty(cnf_notificationtemplet.tempaltesubject)))
				Database.AddInParameter(cmd, "@TempalteSubject", DbType.String, cnf_notificationtemplet.tempaltesubject);
			if (!(string.IsNullOrEmpty(cnf_notificationtemplet.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, cnf_notificationtemplet.comment);
			if (!(string.IsNullOrEmpty(cnf_notificationtemplet.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_notificationtemplet.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Icnf_notificationtempletDataAccessObjects.Add(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_notificationtemplet_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_notificationtemplet, cmd,Database);
                FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.Addcnf_notificationtemplet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_notificationtempletDataAccessObjects.Update(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_notificationtemplet_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_notificationtemplet, cmd,Database);
                FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.Updatecnf_notificationtemplet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_notificationtempletDataAccessObjects.Delete(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_notificationtemplet_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_notificationtemplet, cmd,Database, true);
                FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.Deletecnf_notificationtemplet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_notificationtempletDataAccessObjects.SaveList(IList<cnf_notificationtempletEntity> listAdded, IList<cnf_notificationtempletEntity> listUpdated, IList<cnf_notificationtempletEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_notificationtemplet_Ins";
            const string SPUpdate = "cnf_notificationtemplet_Upd";
            const string SPDelete = "cnf_notificationtemplet_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_notificationtempletEntity cnf_notificationtemplet in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_notificationtemplet, cmd, Database, true);
                            FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_notificationtempletEntity cnf_notificationtemplet in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_notificationtemplet, cmd, Database);
                            FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_notificationtempletEntity cnf_notificationtemplet in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_notificationtemplet, cmd, Database);
                            FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.Save_cnf_notificationtemplet"));
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
       IList<cnf_notificationtempletEntity> listAdded, 
       IList<cnf_notificationtempletEntity> listUpdated, 
       IList<cnf_notificationtempletEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_notificationtemplet_Ins";
            const string SPUpdate = "cnf_notificationtemplet_Upd";
            const string SPDelete = "cnf_notificationtemplet_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_notificationtempletEntity cnf_notificationtemplet in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_notificationtemplet, cmd, db, true);
                            FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_notificationtempletEntity cnf_notificationtemplet in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_notificationtemplet, cmd, db);
                            FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_notificationtempletEntity cnf_notificationtemplet in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_notificationtemplet, cmd, db);
                            FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.Save_cnf_notificationtemplet"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletDataAccessObjects.GetAll(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationtemplet_GA";
                IList<cnf_notificationtempletEntity> itemList = new List<cnf_notificationtempletEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_notificationtemplet.SortExpression);
                    FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationtemplet, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationtempletEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.GetAllcnf_notificationtemplet"));
            }	
        }
		
        async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletDataAccessObjects.GetAllByPages(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_notificationtemplet_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationtemplet.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationtemplet.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationtemplet.CurrentPage);                    
                    FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_notificationtemplet, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_notificationtemplet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_notificationtemplet.strCommonSerachParam+"%");

                    IList<cnf_notificationtempletEntity> itemList = new List<cnf_notificationtempletEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationtempletEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_notificationtemplet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.GetAllByPagescnf_notificationtemplet"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Icnf_notificationtempletDataAccessObjects.SaveMasterDetcnf_notificationconfigdetl(cnf_notificationtempletEntity masterEntity, 
        IList<cnf_notificationconfigdetlEntity> listAdded, 
        IList<cnf_notificationconfigdetlEntity> listUpdated,
        IList<cnf_notificationconfigdetlEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "cnf_notificationtemplet_Ins";
            const string MasterSPUpdate = "cnf_notificationtemplet_Upd";
            const string MasterSPDelete = "cnf_notificationtemplet_Del";
            
			
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
                                item.notificationtemplateid=PrimaryKeyMaster;
                            }
                        }
                        cnf_notificationconfigdetlDataAccessObjects objcnf_notificationconfigdetl=new cnf_notificationconfigdetlDataAccessObjects(this.Context);
                        objcnf_notificationconfigdetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.SaveDscnf_notificationtemplet"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
         
        
        async Task<long> Icnf_notificationtempletDataAccessObjects.SaveMasterDettran_notificationbatchdet(cnf_notificationtempletEntity masterEntity, 
        IList<tran_notificationbatchdetEntity> listAdded, 
        IList<tran_notificationbatchdetEntity> listUpdated,
        IList<tran_notificationbatchdetEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "cnf_notificationtemplet_Ins";
            const string MasterSPUpdate = "cnf_notificationtemplet_Upd";
            const string MasterSPDelete = "cnf_notificationtemplet_Del";
            
			
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
                                item.notificationtemplateid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.SaveDscnf_notificationtemplet"));
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
        async Task<cnf_notificationtempletEntity> Icnf_notificationtempletDataAccessObjects.GetSingle(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationtemplet_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationtemplet, cmd, Database);
                    
                    IList<cnf_notificationtempletEntity> itemList = new List<cnf_notificationtempletEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationtempletEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.GetSinglecnf_notificationtemplet"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletDataAccessObjects.GAPgListView(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_notificationtemplet_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationtemplet.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationtemplet.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationtemplet.CurrentPage);                    
                    FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_notificationtemplet, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_notificationtemplet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_notificationtemplet.strCommonSerachParam+"%");

                    IList<cnf_notificationtempletEntity> itemList = new List<cnf_notificationtempletEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationtempletEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_notificationtemplet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.GAPgListViewcnf_notificationtemplet"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_notificationtempletDataAccessObjects.GetDataForDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "cnf_notificationtemplet_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, cnf_notificationtemplet.SortExpression);
					AddPageSizeParameter(cmd, cnf_notificationtemplet.PageSize);
					AddCurrentPageParameter(cmd, cnf_notificationtemplet.CurrentPage);                    
					FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
					FillParameters(cnf_notificationtemplet, cmd,Database);
					if (!string.IsNullOrEmpty(cnf_notificationtemplet.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_notificationtemplet.strCommonSerachParam + " % ");
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
						cnf_notificationtemplet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}