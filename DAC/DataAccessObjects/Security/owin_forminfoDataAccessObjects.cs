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
using BDO.Core.DataAccessObjects.SecurityModels;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_forminfoDataAccessObjects : BaseDataAccess, Iowin_forminfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_forminfoDataAccessObjects";
        
		public owin_forminfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_forminfoEntity owin_forminfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_forminfo.appformid.HasValue)
				Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, owin_forminfo.appformid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(owin_forminfo.formname)))
				Database.AddInParameter(cmd, "@FormName", DbType.String, owin_forminfo.formname);
			if (owin_forminfo.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, owin_forminfo.parentid);
			if (owin_forminfo.levelid.HasValue)
				Database.AddInParameter(cmd, "@LevelID", DbType.Int32, owin_forminfo.levelid);
			if (!(string.IsNullOrEmpty(owin_forminfo.menulevel)))
				Database.AddInParameter(cmd, "@MenuLevel", DbType.String, owin_forminfo.menulevel);
			if (!(string.IsNullOrEmpty(owin_forminfo.formnamear)))
				Database.AddInParameter(cmd, "@FormNameAr", DbType.String, owin_forminfo.formnamear);
			if ((owin_forminfo.hasdirectchild != null))
				Database.AddInParameter(cmd, "@HasDirectChild", DbType.Boolean, owin_forminfo.hasdirectchild);
			
				Database.AddInParameter(cmd, "@Icon", DbType.Binary, owin_forminfo.icon);
			if (!(string.IsNullOrEmpty(owin_forminfo.classicon)))
				Database.AddInParameter(cmd, "@ClassIcon", DbType.String, owin_forminfo.classicon);
			if (owin_forminfo.sequence.HasValue)
				Database.AddInParameter(cmd, "@Sequence", DbType.Int32, owin_forminfo.sequence);
			if (!(string.IsNullOrEmpty(owin_forminfo.url)))
				Database.AddInParameter(cmd, "@URL", DbType.String, owin_forminfo.url);
			if ((owin_forminfo.isview != null))
				Database.AddInParameter(cmd, "@IsView", DbType.Boolean, owin_forminfo.isview);
			if ((owin_forminfo.isdynamic != null))
				Database.AddInParameter(cmd, "@IsDynamic", DbType.Boolean, owin_forminfo.isdynamic);
			if ((owin_forminfo.issuperadmin != null))
				Database.AddInParameter(cmd, "@IsSuperAdmin", DbType.Boolean, owin_forminfo.issuperadmin);
			if ((owin_forminfo.isvisibleinmenu != null))
				Database.AddInParameter(cmd, "@IsVisibleInMenu", DbType.Boolean, owin_forminfo.isvisibleinmenu);
			if (owin_forminfo.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, owin_forminfo.organizationkey);
			

        }
		
        
		#region Add Operation

        async Task<long> Iowin_forminfoDataAccessObjects.Add(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_forminfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_forminfo, cmd,Database);
                FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Addowin_forminfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_forminfoDataAccessObjects.Update(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_forminfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_forminfo, cmd,Database);
                FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Updateowin_forminfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_forminfoDataAccessObjects.Delete(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_forminfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_forminfo, cmd,Database, true);
                FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Deleteowin_forminfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_forminfoDataAccessObjects.SaveList(IList<owin_forminfoEntity> listAdded, IList<owin_forminfoEntity> listUpdated, IList<owin_forminfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_forminfo_Ins";
            const string SPUpdate = "owin_forminfo_Upd";
            const string SPDelete = "owin_forminfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_forminfoEntity owin_forminfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_forminfo, cmd, Database, true);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_forminfoEntity owin_forminfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_forminfo, cmd, Database);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_forminfoEntity owin_forminfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_forminfo, cmd, Database);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Save_owin_forminfo"));
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
       IList<owin_forminfoEntity> listAdded, 
       IList<owin_forminfoEntity> listUpdated, 
       IList<owin_forminfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_forminfo_Ins";
            const string SPUpdate = "owin_forminfo_Upd";
            const string SPDelete = "owin_forminfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_forminfoEntity owin_forminfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_forminfo, cmd, db, true);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, db);
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
                    foreach (owin_forminfoEntity owin_forminfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_forminfo, cmd, db);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, db);
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
                    foreach (owin_forminfoEntity owin_forminfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_forminfo, cmd, db);
                            FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.Save_owin_forminfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_forminfoEntity>> Iowin_forminfoDataAccessObjects.GetAll(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_forminfo_GA";
                IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_forminfo.SortExpression);
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_forminfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GetAllowin_forminfo"));
            }	
        }
		
        async Task<IList<owin_forminfoEntity>> Iowin_forminfoDataAccessObjects.GetAllByPages(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_forminfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_forminfo.SortExpression);
                    AddPageSizeParameter(cmd, owin_forminfo.PageSize);
                    AddCurrentPageParameter(cmd, owin_forminfo.CurrentPage);                    
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_forminfo, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (owin_forminfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_forminfo.strCommonSerachParam+"%");

                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_forminfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GetAllByPagesowin_forminfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
      
    
        
        async Task<long> Iowin_forminfoDataAccessObjects.SaveMasterDetowin_formaction(owin_forminfoEntity masterEntity, 
        IList<owin_formactionEntity> listAdded, 
        IList<owin_formactionEntity> listUpdated,
        IList<owin_formactionEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_forminfo_Ins";
            const string MasterSPUpdate = "owin_forminfo_Upd";
            const string MasterSPDelete = "owin_forminfo_Del";
            
			
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
				
                    //if (returnCode>0)
                    //{
                    //    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    //    {
                    //        foreach (var item in listAdded)
                    //        {
                    //            item.formactionid=PrimaryKeyMaster;
                    //        }
                    //    }
                    //    owin_formactionDataAccessObjects objowin_formaction=new owin_formactionDataAccessObjects(this.Context);
                    //    objowin_formaction.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    //}
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.SaveDsowin_forminfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_forminfoDataAccessObjects.SaveMasterDetowin_rolepermission(owin_forminfoEntity masterEntity, 
        IList<owin_rolepermissionEntity> listAdded, 
        IList<owin_rolepermissionEntity> listUpdated,
        IList<owin_rolepermissionEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "owin_forminfo_Ins";
            const string MasterSPUpdate = "owin_forminfo_Upd";
            const string MasterSPDelete = "owin_forminfo_Del";
            
			
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
				
                    //if (returnCode>0)
                    //{
                    //    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    //    {
                    //        foreach (var item in listAdded)
                    //        {
                    //            item.appformid=PrimaryKeyMaster;
                    //        }
                    //    }
                    //    owin_rolepermissionDataAccessObjects objowin_rolepermission=new owin_rolepermissionDataAccessObjects(this.Context);
                    //    objowin_rolepermission.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    //}
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.SaveDsowin_forminfo"));
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
        async Task<owin_forminfoEntity> Iowin_forminfoDataAccessObjects.GetSingle(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_forminfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_forminfo, cmd, Database);
                    
                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GetSingleowin_forminfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_forminfoEntity>> Iowin_forminfoDataAccessObjects.GAPgListView(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_forminfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_forminfo.SortExpression);
                    AddPageSizeParameter(cmd, owin_forminfo.PageSize);
                    AddCurrentPageParameter(cmd, owin_forminfo.CurrentPage);                    
                    FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_forminfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_forminfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_forminfo.strCommonSerachParam+"%");

                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_forminfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GAPgListViewowin_forminfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Iowin_forminfoDataAccessObjects.GetDataForDropDown(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "owin_forminfo_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, owin_forminfo.SortExpression);
					AddPageSizeParameter(cmd, owin_forminfo.PageSize);
					AddCurrentPageParameter(cmd, owin_forminfo.CurrentPage);                    
					FillSequrityParameters(owin_forminfo.BaseSecurityParam, cmd, Database);
					FillParameters(owin_forminfo, cmd,Database);
					if (!string.IsNullOrEmpty(owin_forminfo.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + owin_forminfo.strCommonSerachParam + " % ");
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
						owin_forminfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Iowin_forminfoDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}