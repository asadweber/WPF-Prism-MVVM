using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.Security;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.Base;

namespace DAC.Core.DataAccessObjects.Security
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_formactionDataAccessObjects : BaseDataAccess, Iowin_formactionDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_formactionDataAccessObjects";
        
		public owin_formactionDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_formactionEntity owin_formaction, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_formaction.formactionid.HasValue)
				Database.AddInParameter(cmd, "@FormActionID", DbType.Int64, owin_formaction.formactionid);
            if (forDelete) return;
			if (owin_formaction.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, owin_formaction.parentid);
			if (!(string.IsNullOrEmpty(owin_formaction.actionname)))
				Database.AddInParameter(cmd, "@ActionName", DbType.String, owin_formaction.actionname);
			if (!(string.IsNullOrEmpty(owin_formaction.displaynamear)))
				Database.AddInParameter(cmd, "@DisplayNameAr", DbType.String, owin_formaction.displaynamear);
			if (!(string.IsNullOrEmpty(owin_formaction.displayname)))
				Database.AddInParameter(cmd, "@DisplayName", DbType.String, owin_formaction.displayname);
			if (!(string.IsNullOrEmpty(owin_formaction.actiontype)))
				Database.AddInParameter(cmd, "@ActionType", DbType.String, owin_formaction.actiontype);
			if ((owin_formaction.isview != null))
				Database.AddInParameter(cmd, "@IsView", DbType.Boolean, owin_formaction.isview);
			if ((owin_formaction.isapi != null))
				Database.AddInParameter(cmd, "@IsAPI", DbType.Boolean, owin_formaction.isapi);
			if ((owin_formaction.isshowonmenu != null))
				Database.AddInParameter(cmd, "@IsShowOnMenu", DbType.Boolean, owin_formaction.isshowonmenu);
			if (!(string.IsNullOrEmpty(owin_formaction.classicon)))
				Database.AddInParameter(cmd, "@ClassIcon", DbType.String, owin_formaction.classicon);
			if ((owin_formaction.isitem != null))
				Database.AddInParameter(cmd, "@IsItem", DbType.Boolean, owin_formaction.isitem);
			if (!(string.IsNullOrEmpty(owin_formaction.eventname)))
				Database.AddInParameter(cmd, "@EventName", DbType.String, owin_formaction.eventname);
			if (owin_formaction.sequence.HasValue)
				Database.AddInParameter(cmd, "@Sequence", DbType.Int32, owin_formaction.sequence);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_formactionDataAccessObjects.Add(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_formaction_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_formaction, cmd,Database);
                FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Addowin_formaction"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_formactionDataAccessObjects.Update(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_formaction_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_formaction, cmd,Database);
                FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Updateowin_formaction"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_formactionDataAccessObjects.Delete(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_formaction_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_formaction, cmd,Database, true);
                FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Deleteowin_formaction"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_formactionDataAccessObjects.SaveList(IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_formaction_Ins";
            const string SPUpdate = "owin_formaction_Upd";
            const string SPDelete = "owin_formaction_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_formactionEntity owin_formaction in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_formaction, cmd, Database, true);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_formactionEntity owin_formaction in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_formaction, cmd, Database);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_formactionEntity owin_formaction in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_formaction, cmd, Database);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Save_owin_formaction"));
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
       IList<owin_formactionEntity> listAdded, 
       IList<owin_formactionEntity> listUpdated, 
       IList<owin_formactionEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_formaction_Ins";
            const string SPUpdate = "owin_formaction_Upd";
            const string SPDelete = "owin_formaction_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_formactionEntity owin_formaction in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_formaction, cmd, db, true);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, db);
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
                    foreach (owin_formactionEntity owin_formaction in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_formaction, cmd, db);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, db);
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
                    foreach (owin_formactionEntity owin_formaction in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_formaction, cmd, db);
                            FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.Save_owin_formaction"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_formactionEntity>> Iowin_formactionDataAccessObjects.GetAll(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_formaction_GA";
                IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_formaction, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetAllowin_formaction"));
            }	
        }
		
        async Task<IList<owin_formactionEntity>> Iowin_formactionDataAccessObjects.GetAllByPages(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_formaction_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    AddPageSizeParameter(cmd, owin_formaction.PageSize);
                    AddCurrentPageParameter(cmd, owin_formaction.CurrentPage);                    
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_formaction, cmd,Database);

                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_formaction.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetAllByPagesowin_formaction"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Iowin_formactionDataAccessObjects.SaveMasterDetowin_formaction(owin_formactionEntity masterEntity, 
        IList<owin_formactionEntity> listAdded, 
        IList<owin_formactionEntity> listUpdated,
        IList<owin_formactionEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_formaction_Ins";
            const string MasterSPUpdate = "owin_formaction_Upd";
            const string MasterSPDelete = "owin_formaction_Del";
            
			
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
                                item.parentid=PrimaryKeyMaster;
                            }
                        }
                        owin_formactionDataAccessObjects objowin_formaction=new owin_formactionDataAccessObjects(this.Context);
                        objowin_formaction.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.SaveDsowin_formaction"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_formactionDataAccessObjects.SaveMasterDetowin_lastworkingpage(owin_formactionEntity masterEntity, 
        IList<owin_lastworkingpageEntity> listAdded, 
        IList<owin_lastworkingpageEntity> listUpdated,
        IList<owin_lastworkingpageEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_formaction_Ins";
            const string MasterSPUpdate = "owin_formaction_Upd";
            const string MasterSPDelete = "owin_formaction_Del";
            
			
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
                                item.formactionid=PrimaryKeyMaster;
                            }
                        }
                        owin_lastworkingpageDataAccessObjects objowin_lastworkingpage=new owin_lastworkingpageDataAccessObjects(this.Context);
                        objowin_lastworkingpage.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.SaveDsowin_formaction"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_formactionDataAccessObjects.SaveMasterDetowin_rolepermission(owin_formactionEntity masterEntity, 
        IList<owin_rolepermissionEntity> listAdded, 
        IList<owin_rolepermissionEntity> listUpdated,
        IList<owin_rolepermissionEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_formaction_Ins";
            const string MasterSPUpdate = "owin_formaction_Upd";
            const string MasterSPDelete = "owin_formaction_Del";
            
			
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
                                item.formactionid=PrimaryKeyMaster;
                            }
                        }
                        owin_rolepermissionDataAccessObjects objowin_rolepermission=new owin_rolepermissionDataAccessObjects(this.Context);
                        objowin_rolepermission.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.SaveDsowin_formaction"));
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
        async Task<owin_formactionEntity> Iowin_formactionDataAccessObjects.GetSingle(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_formaction_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_formaction, cmd, Database);
                    
                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GetSingleowin_formaction"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_formactionEntity>> Iowin_formactionDataAccessObjects.GAPgListView(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_formaction_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_formaction.SortExpression);
                    AddPageSizeParameter(cmd, owin_formaction.PageSize);
                    AddCurrentPageParameter(cmd, owin_formaction.CurrentPage);                    
                    FillSequrityParameters(owin_formaction.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_formaction, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_formaction.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_formaction.strCommonSerachParam+"%");

                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_formaction.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_formactionDataAccess.GAPgListViewowin_formaction"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}