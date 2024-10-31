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
	
	internal sealed partial class reg_emergencycontactinfoDataAccessObjects : BaseDataAccess, Ireg_emergencycontactinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_emergencycontactinfoDataAccessObjects";
        
		public reg_emergencycontactinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_emergencycontactinfoEntity reg_emergencycontactinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_emergencycontactinfo.emergencycontactid.HasValue)
				Database.AddInParameter(cmd, "@EmergencyContactID", DbType.Int64, reg_emergencycontactinfo.emergencycontactid);
            if (forDelete) return;
			if (reg_emergencycontactinfo.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_emergencycontactinfo.basicinfoid);
			if (reg_emergencycontactinfo.familyid.HasValue)
				Database.AddInParameter(cmd, "@FamilyID", DbType.Int64, reg_emergencycontactinfo.familyid);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.name1)))
				Database.AddInParameter(cmd, "@Name1", DbType.String, reg_emergencycontactinfo.name1);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.name2)))
				Database.AddInParameter(cmd, "@Name2", DbType.String, reg_emergencycontactinfo.name2);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.name3)))
				Database.AddInParameter(cmd, "@Name3", DbType.String, reg_emergencycontactinfo.name3);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.name4)))
				Database.AddInParameter(cmd, "@Name4", DbType.String, reg_emergencycontactinfo.name4);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.name5)))
				Database.AddInParameter(cmd, "@Name5", DbType.String, reg_emergencycontactinfo.name5);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.fullname)))
				Database.AddInParameter(cmd, "@FullName", DbType.String, reg_emergencycontactinfo.fullname);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.mobile1)))
				Database.AddInParameter(cmd, "@Mobile1", DbType.String, reg_emergencycontactinfo.mobile1);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.mobile2)))
				Database.AddInParameter(cmd, "@Mobile2", DbType.String, reg_emergencycontactinfo.mobile2);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.telephone1)))
				Database.AddInParameter(cmd, "@Telephone1", DbType.String, reg_emergencycontactinfo.telephone1);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.telephone2)))
				Database.AddInParameter(cmd, "@Telephone2", DbType.String, reg_emergencycontactinfo.telephone2);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.email)))
				Database.AddInParameter(cmd, "@Email", DbType.String, reg_emergencycontactinfo.email);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, reg_emergencycontactinfo.comment);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_emergencycontactinfo.remarks);
			if (!(string.IsNullOrEmpty(reg_emergencycontactinfo.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_emergencycontactinfo.updateinfo);
			if (reg_emergencycontactinfo.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_emergencycontactinfo.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.Add(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_emergencycontactinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_emergencycontactinfo, cmd,Database);
                FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.Addreg_emergencycontactinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.Update(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_emergencycontactinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_emergencycontactinfo, cmd,Database);
                FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.Updatereg_emergencycontactinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.Delete(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_emergencycontactinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_emergencycontactinfo, cmd,Database, true);
                FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.Deletereg_emergencycontactinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.SaveList(IList<reg_emergencycontactinfoEntity> listAdded, IList<reg_emergencycontactinfoEntity> listUpdated, IList<reg_emergencycontactinfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_emergencycontactinfo_Ins";
            const string SPUpdate = "reg_emergencycontactinfo_Upd";
            const string SPDelete = "reg_emergencycontactinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_emergencycontactinfoEntity reg_emergencycontactinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_emergencycontactinfo, cmd, Database, true);
                            FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_emergencycontactinfoEntity reg_emergencycontactinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_emergencycontactinfo, cmd, Database);
                            FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_emergencycontactinfoEntity reg_emergencycontactinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_emergencycontactinfo, cmd, Database);
                            FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.Save_reg_emergencycontactinfo"));
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
       IList<reg_emergencycontactinfoEntity> listAdded, 
       IList<reg_emergencycontactinfoEntity> listUpdated, 
       IList<reg_emergencycontactinfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_emergencycontactinfo_Ins";
            const string SPUpdate = "reg_emergencycontactinfo_Upd";
            const string SPDelete = "reg_emergencycontactinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_emergencycontactinfoEntity reg_emergencycontactinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_emergencycontactinfo, cmd, db, true);
                            FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_emergencycontactinfoEntity reg_emergencycontactinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_emergencycontactinfo, cmd, db);
                            FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_emergencycontactinfoEntity reg_emergencycontactinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_emergencycontactinfo, cmd, db);
                            FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.Save_reg_emergencycontactinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoDataAccessObjects.GetAll(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_emergencycontactinfo_GA";
                IList<reg_emergencycontactinfoEntity> itemList = new List<reg_emergencycontactinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_emergencycontactinfo.SortExpression);
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_emergencycontactinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_emergencycontactinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GetAllreg_emergencycontactinfo"));
            }	
        }
		
        async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoDataAccessObjects.GetAllByPages(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_emergencycontactinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_emergencycontactinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_emergencycontactinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_emergencycontactinfo.CurrentPage);                    
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_emergencycontactinfo, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_emergencycontactinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_emergencycontactinfo.strCommonSerachParam+"%");

                    IList<reg_emergencycontactinfoEntity> itemList = new List<reg_emergencycontactinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_emergencycontactinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_emergencycontactinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GetAllByPagesreg_emergencycontactinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.SaveMasterDetreg_relativesworkinginmod(reg_emergencycontactinfoEntity masterEntity, 
        IList<reg_relativesworkinginmodEntity> listAdded, 
        IList<reg_relativesworkinginmodEntity> listUpdated,
        IList<reg_relativesworkinginmodEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_emergencycontactinfo_Ins";
            const string MasterSPUpdate = "reg_emergencycontactinfo_Upd";
            const string MasterSPDelete = "reg_emergencycontactinfo_Del";
            
			
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
                                item.imergencycontactid=PrimaryKeyMaster;
                            }
                        }
                        reg_relativesworkinginmodDataAccessObjects objreg_relativesworkinginmod=new reg_relativesworkinginmodDataAccessObjects(this.Context);
                        objreg_relativesworkinginmod.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.SaveDsreg_emergencycontactinfo"));
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
        async Task<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoDataAccessObjects.GetSingle(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_emergencycontactinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_emergencycontactinfo, cmd, Database);
                    
                    IList<reg_emergencycontactinfoEntity> itemList = new List<reg_emergencycontactinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_emergencycontactinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GetSinglereg_emergencycontactinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoDataAccessObjects.GAPgListView(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_emergencycontactinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_emergencycontactinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_emergencycontactinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_emergencycontactinfo.CurrentPage);                    
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_emergencycontactinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_emergencycontactinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_emergencycontactinfo.strCommonSerachParam+"%");

                    IList<reg_emergencycontactinfoEntity> itemList = new List<reg_emergencycontactinfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_emergencycontactinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_emergencycontactinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GAPgListViewreg_emergencycontactinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_emergencycontactinfoDataAccessObjects.GetDataForDropDown(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "reg_emergencycontactinfo_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, reg_emergencycontactinfo.SortExpression);
					AddPageSizeParameter(cmd, reg_emergencycontactinfo.PageSize);
					AddCurrentPageParameter(cmd, reg_emergencycontactinfo.CurrentPage);                    
					FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
					FillParameters(reg_emergencycontactinfo, cmd,Database);
					if (!string.IsNullOrEmpty(reg_emergencycontactinfo.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + reg_emergencycontactinfo.strCommonSerachParam + " % ");
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
						reg_emergencycontactinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}