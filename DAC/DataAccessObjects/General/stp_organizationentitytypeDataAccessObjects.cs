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
	
	internal sealed partial class stp_organizationentitytypeDataAccessObjects : BaseDataAccess, Istp_organizationentitytypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "stp_organizationentitytypeDataAccessObjects";
        
		public stp_organizationentitytypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(stp_organizationentitytypeEntity stp_organizationentitytype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (stp_organizationentitytype.entirytypekey.HasValue)
				Database.AddInParameter(cmd, "@EntiryTypeKey", DbType.Int64, stp_organizationentitytype.entirytypekey);
            if (forDelete) return;
			if (stp_organizationentitytype.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, stp_organizationentitytype.organizationkey);
			if (!(string.IsNullOrEmpty(stp_organizationentitytype.entirytypecode)))
				Database.AddInParameter(cmd, "@EntiryTypeCode", DbType.String, stp_organizationentitytype.entirytypecode);
			if (!(string.IsNullOrEmpty(stp_organizationentitytype.entirytype)))
				Database.AddInParameter(cmd, "@EntiryType", DbType.String, stp_organizationentitytype.entirytype);
			if (!(string.IsNullOrEmpty(stp_organizationentitytype.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, stp_organizationentitytype.description);
			if (stp_organizationentitytype.entitylevel.HasValue)
				Database.AddInParameter(cmd, "@EntityLevel", DbType.Int32, stp_organizationentitytype.entitylevel);
			if ((stp_organizationentitytype.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, stp_organizationentitytype.isactive);
			if (!(string.IsNullOrEmpty(stp_organizationentitytype.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, stp_organizationentitytype.updateinfo);
			if (stp_organizationentitytype.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, stp_organizationentitytype.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Istp_organizationentitytypeDataAccessObjects.Add(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "stp_organizationentitytype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_organizationentitytype, cmd,Database);
                FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.Addstp_organizationentitytype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Istp_organizationentitytypeDataAccessObjects.Update(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "stp_organizationentitytype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(stp_organizationentitytype, cmd,Database);
                FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.Updatestp_organizationentitytype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Istp_organizationentitytypeDataAccessObjects.Delete(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "stp_organizationentitytype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(stp_organizationentitytype, cmd,Database, true);
                FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.Deletestp_organizationentitytype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Istp_organizationentitytypeDataAccessObjects.SaveList(IList<stp_organizationentitytypeEntity> listAdded, IList<stp_organizationentitytypeEntity> listUpdated, IList<stp_organizationentitytypeEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "stp_organizationentitytype_Ins";
            const string SPUpdate = "stp_organizationentitytype_Upd";
            const string SPDelete = "stp_organizationentitytype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationentitytypeEntity stp_organizationentitytype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organizationentitytype, cmd, Database, true);
                            FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationentitytypeEntity stp_organizationentitytype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organizationentitytype, cmd, Database);
                            FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationentitytypeEntity stp_organizationentitytype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organizationentitytype, cmd, Database);
                            FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.Save_stp_organizationentitytype"));
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
       IList<stp_organizationentitytypeEntity> listAdded, 
       IList<stp_organizationentitytypeEntity> listUpdated, 
       IList<stp_organizationentitytypeEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "stp_organizationentitytype_Ins";
            const string SPUpdate = "stp_organizationentitytype_Upd";
            const string SPDelete = "stp_organizationentitytype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationentitytypeEntity stp_organizationentitytype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organizationentitytype, cmd, db, true);
                            FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationentitytypeEntity stp_organizationentitytype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organizationentitytype, cmd, db);
                            FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationentitytypeEntity stp_organizationentitytype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organizationentitytype, cmd, db);
                            FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.Save_stp_organizationentitytype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<stp_organizationentitytypeEntity>> Istp_organizationentitytypeDataAccessObjects.GetAll(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organizationentitytype_GA";
                IList<stp_organizationentitytypeEntity> itemList = new List<stp_organizationentitytypeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_organizationentitytype.SortExpression);
                    FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentitytype, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentitytypeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.GetAllstp_organizationentitytype"));
            }	
        }
		
        async Task<IList<stp_organizationentitytypeEntity>> Istp_organizationentitytypeDataAccessObjects.GetAllByPages(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "stp_organizationentitytype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organizationentitytype.SortExpression);
                    AddPageSizeParameter(cmd, stp_organizationentitytype.PageSize);
                    AddCurrentPageParameter(cmd, stp_organizationentitytype.CurrentPage);                    
                    FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organizationentitytype, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (stp_organizationentitytype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+stp_organizationentitytype.strCommonSerachParam+"%");

                    IList<stp_organizationentitytypeEntity> itemList = new List<stp_organizationentitytypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentitytypeEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organizationentitytype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.GetAllByPagesstp_organizationentitytype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Istp_organizationentitytypeDataAccessObjects.SaveMasterDetstp_organizationentity(stp_organizationentitytypeEntity masterEntity, 
        IList<stp_organizationentityEntity> listAdded, 
        IList<stp_organizationentityEntity> listUpdated,
        IList<stp_organizationentityEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organizationentitytype_Ins";
            const string MasterSPUpdate = "stp_organizationentitytype_Upd";
            const string MasterSPDelete = "stp_organizationentitytype_Del";
            
			
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
                                item.entirytypekey=PrimaryKeyMaster;
                            }
                        }
                        stp_organizationentityDataAccessObjects objstp_organizationentity=new stp_organizationentityDataAccessObjects(this.Context);
                        objstp_organizationentity.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.SaveDsstp_organizationentitytype"));
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
        async Task<stp_organizationentitytypeEntity> Istp_organizationentitytypeDataAccessObjects.GetSingle(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organizationentitytype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentitytype, cmd, Database);
                    
                    IList<stp_organizationentitytypeEntity> itemList = new List<stp_organizationentitytypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentitytypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.GetSinglestp_organizationentitytype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<stp_organizationentitytypeEntity>> Istp_organizationentitytypeDataAccessObjects.GAPgListView(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "stp_organizationentitytype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organizationentitytype.SortExpression);
                    AddPageSizeParameter(cmd, stp_organizationentitytype.PageSize);
                    AddCurrentPageParameter(cmd, stp_organizationentitytype.CurrentPage);                    
                    FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organizationentitytype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (stp_organizationentitytype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+stp_organizationentitytype.strCommonSerachParam+"%");

                    IList<stp_organizationentitytypeEntity> itemList = new List<stp_organizationentitytypeEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentitytypeEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organizationentitytype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.GAPgListViewstp_organizationentitytype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Istp_organizationentitytypeDataAccessObjects.GetDataForDropDown(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "stp_organizationentitytype_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, stp_organizationentitytype.SortExpression);
					AddPageSizeParameter(cmd, stp_organizationentitytype.PageSize);
					AddCurrentPageParameter(cmd, stp_organizationentitytype.CurrentPage);                    
					FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
					FillParameters(stp_organizationentitytype, cmd,Database);
					if (!string.IsNullOrEmpty(stp_organizationentitytype.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + stp_organizationentitytype.strCommonSerachParam + " % ");
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
						stp_organizationentitytype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Istp_organizationentitytypeDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}