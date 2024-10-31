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
	
	internal sealed partial class reg_datacheckedDataAccessObjects : BaseDataAccess, Ireg_datacheckedDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_datacheckedDataAccessObjects";
        
		public reg_datacheckedDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_datacheckedEntity reg_datachecked, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_datachecked.basicinfoviewid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoViewID", DbType.Int64, reg_datachecked.basicinfoviewid);
            if (forDelete) return;
			if (reg_datachecked.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_datachecked.basicinfoid);
			if (reg_datachecked.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, reg_datachecked.registrationid);
			if (reg_datachecked.applicanttableid.HasValue)
				Database.AddInParameter(cmd, "@ApplicantTableID", DbType.Int64, reg_datachecked.applicanttableid);
            if ((reg_datachecked.reviewedbyid.HasValue))
                Database.AddInParameter(cmd, "@ReviewedByID", DbType.Guid, reg_datachecked.reviewedbyid);
			if ((reg_datachecked.vieweddate.HasValue))
				Database.AddInParameter(cmd, "@ViewedDate", DbType.DateTime, reg_datachecked.vieweddate);
			if ((reg_datachecked.ischecked != null))
				Database.AddInParameter(cmd, "@IsChecked", DbType.Boolean, reg_datachecked.ischecked);
            if ((reg_datachecked.isactive != null))
                Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, reg_datachecked.isactive);
            if (!(string.IsNullOrEmpty(reg_datachecked.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, reg_datachecked.comment);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_datacheckedDataAccessObjects.Add(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_datachecked_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_datachecked, cmd,Database);
                FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.Addreg_datachecked"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_datacheckedDataAccessObjects.Update(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_datachecked_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_datachecked, cmd,Database);
                FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.Updatereg_datachecked"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_datacheckedDataAccessObjects.Delete(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_datachecked_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_datachecked, cmd,Database, true);
                FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.Deletereg_datachecked"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_datacheckedDataAccessObjects.SaveList(IList<reg_datacheckedEntity> listAdded, IList<reg_datacheckedEntity> listUpdated, IList<reg_datacheckedEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_datachecked_Ins";
            const string SPUpdate = "reg_datachecked_Upd";
            const string SPDelete = "reg_datachecked_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_datacheckedEntity reg_datachecked in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_datachecked, cmd, Database, true);
                            FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_datacheckedEntity reg_datachecked in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_datachecked, cmd, Database);
                            FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_datacheckedEntity reg_datachecked in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_datachecked, cmd, Database);
                            FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.Save_reg_datachecked"));
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
       IList<reg_datacheckedEntity> listAdded, 
       IList<reg_datacheckedEntity> listUpdated, 
       IList<reg_datacheckedEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_datachecked_Ins";
            const string SPUpdate = "reg_datachecked_Upd";
            const string SPDelete = "reg_datachecked_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_datacheckedEntity reg_datachecked in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_datachecked, cmd, db, true);
                            FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, db);
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
                    foreach (reg_datacheckedEntity reg_datachecked in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_datachecked, cmd, db);
                            FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, db);
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
                    foreach (reg_datacheckedEntity reg_datachecked in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_datachecked, cmd, db);
                            FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.Save_reg_datachecked"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_datacheckedEntity>> Ireg_datacheckedDataAccessObjects.GetAll(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_datachecked_GA";
                IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_datachecked.SortExpression);
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_datachecked, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GetAllreg_datachecked"));
            }	
        }
		
        async Task<IList<reg_datacheckedEntity>> Ireg_datacheckedDataAccessObjects.GetAllByPages(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_datachecked_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_datachecked.SortExpression);
                    AddPageSizeParameter(cmd, reg_datachecked.PageSize);
                    AddCurrentPageParameter(cmd, reg_datachecked.CurrentPage);                    
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_datachecked, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_datachecked.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_datachecked.strCommonSerachParam+"%");

                    IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_datachecked.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GetAllByPagesreg_datachecked"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Ireg_datacheckedDataAccessObjects.SaveMasterDetreg_datachecked(reg_datacheckedEntity masterEntity, 
        IList<reg_datacheckedEntity> listAdded, 
        IList<reg_datacheckedEntity> listUpdated,
        IList<reg_datacheckedEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_datachecked_Ins";
            const string MasterSPUpdate = "reg_datachecked_Upd";
            const string MasterSPDelete = "reg_datachecked_Del";
            
			
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
                                item.basicinfoviewid=PrimaryKeyMaster;
                            }
                        }
                        reg_datacheckedDataAccessObjects objreg_datachecked=new reg_datacheckedDataAccessObjects(this.Context);
                        objreg_datachecked.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.SaveDsreg_datachecked"));
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
        async Task<reg_datacheckedEntity> Ireg_datacheckedDataAccessObjects.GetSingle(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_datachecked_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_datachecked, cmd, Database);
                    
                    IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GetSinglereg_datachecked"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_datacheckedEntity>> Ireg_datacheckedDataAccessObjects.GAPgListView(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_datachecked_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_datachecked.SortExpression);
                    AddPageSizeParameter(cmd, reg_datachecked.PageSize);
                    AddCurrentPageParameter(cmd, reg_datachecked.CurrentPage);                    
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_datachecked, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_datachecked.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_datachecked.strCommonSerachParam+"%");

                    IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_datachecked.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GAPgListViewreg_datachecked"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_datacheckedDataAccessObjects.GetDataForDropDown(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "reg_datachecked_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, reg_datachecked.SortExpression);
					AddPageSizeParameter(cmd, reg_datachecked.PageSize);
					AddCurrentPageParameter(cmd, reg_datachecked.CurrentPage);                    
					FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
					FillParameters(reg_datachecked, cmd,Database);
					if (!string.IsNullOrEmpty(reg_datachecked.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + reg_datachecked.strCommonSerachParam + " % ");
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
						reg_datachecked.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}