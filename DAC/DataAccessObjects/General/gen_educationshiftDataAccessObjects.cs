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
	
	internal sealed partial class gen_educationshiftDataAccessObjects : BaseDataAccess, Igen_educationshiftDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_educationshiftDataAccessObjects";
        
		public gen_educationshiftDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_educationshiftEntity gen_educationshift, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_educationshift.educationshiftid.HasValue)
				Database.AddInParameter(cmd, "@EducationShiftID", DbType.Int64, gen_educationshift.educationshiftid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_educationshift.educationshiftname)))
				Database.AddInParameter(cmd, "@EducationShiftName", DbType.String, gen_educationshift.educationshiftname);
			if (!(string.IsNullOrEmpty(gen_educationshift.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_educationshift.comment);
			if (!(string.IsNullOrEmpty(gen_educationshift.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_educationshift.remarks);
			if (!(string.IsNullOrEmpty(gen_educationshift.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_educationshift.updateinfo);
			if (gen_educationshift.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_educationshift.tranformactionid);
			if (gen_educationshift.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_educationshift.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_educationshiftDataAccessObjects.Add(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_educationshift_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_educationshift, cmd,Database);
                FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.Addgen_educationshift"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_educationshiftDataAccessObjects.Update(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_educationshift_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_educationshift, cmd,Database);
                FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.Updategen_educationshift"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_educationshiftDataAccessObjects.Delete(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_educationshift_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_educationshift, cmd,Database, true);
                FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.Deletegen_educationshift"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_educationshiftDataAccessObjects.SaveList(IList<gen_educationshiftEntity> listAdded, IList<gen_educationshiftEntity> listUpdated, IList<gen_educationshiftEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_educationshift_Ins";
            const string SPUpdate = "gen_educationshift_Upd";
            const string SPDelete = "gen_educationshift_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_educationshiftEntity gen_educationshift in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_educationshift, cmd, Database, true);
                            FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_educationshiftEntity gen_educationshift in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_educationshift, cmd, Database);
                            FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_educationshiftEntity gen_educationshift in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_educationshift, cmd, Database);
                            FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.Save_gen_educationshift"));
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
       IList<gen_educationshiftEntity> listAdded, 
       IList<gen_educationshiftEntity> listUpdated, 
       IList<gen_educationshiftEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_educationshift_Ins";
            const string SPUpdate = "gen_educationshift_Upd";
            const string SPDelete = "gen_educationshift_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_educationshiftEntity gen_educationshift in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_educationshift, cmd, db, true);
                            FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, db);
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
                    foreach (gen_educationshiftEntity gen_educationshift in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_educationshift, cmd, db);
                            FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, db);
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
                    foreach (gen_educationshiftEntity gen_educationshift in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_educationshift, cmd, db);
                            FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.Save_gen_educationshift"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_educationshiftEntity>> Igen_educationshiftDataAccessObjects.GetAll(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationshift_GA";
                IList<gen_educationshiftEntity> itemList = new List<gen_educationshiftEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_educationshift.SortExpression);
                    FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationshift, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationshiftEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.GetAllgen_educationshift"));
            }	
        }
		
        async Task<IList<gen_educationshiftEntity>> Igen_educationshiftDataAccessObjects.GetAllByPages(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_educationshift_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_educationshift.SortExpression);
                    AddPageSizeParameter(cmd, gen_educationshift.PageSize);
                    AddCurrentPageParameter(cmd, gen_educationshift.CurrentPage);                    
                    FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_educationshift, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_educationshift.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_educationshift.strCommonSerachParam+"%");

                    IList<gen_educationshiftEntity> itemList = new List<gen_educationshiftEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationshiftEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_educationshift.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.GetAllByPagesgen_educationshift"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_educationshiftDataAccessObjects.SaveMasterDetreg_educationinfo(gen_educationshiftEntity masterEntity, 
        IList<reg_educationinfoEntity> listAdded, 
        IList<reg_educationinfoEntity> listUpdated,
        IList<reg_educationinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_educationshift_Ins";
            const string MasterSPUpdate = "gen_educationshift_Upd";
            const string MasterSPDelete = "gen_educationshift_Del";
            
			
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
                                item.educationshiftid=PrimaryKeyMaster;
                            }
                        }
                        reg_educationinfoDataAccessObjects objreg_educationinfo=new reg_educationinfoDataAccessObjects(this.Context);
                        objreg_educationinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.SaveDsgen_educationshift"));
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
        async Task<gen_educationshiftEntity> Igen_educationshiftDataAccessObjects.GetSingle(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationshift_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationshift, cmd, Database);
                    
                    IList<gen_educationshiftEntity> itemList = new List<gen_educationshiftEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationshiftEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.GetSinglegen_educationshift"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_educationshiftEntity>> Igen_educationshiftDataAccessObjects.GAPgListView(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_educationshift_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_educationshift.SortExpression);
                    AddPageSizeParameter(cmd, gen_educationshift.PageSize);
                    AddCurrentPageParameter(cmd, gen_educationshift.CurrentPage);                    
                    FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_educationshift, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_educationshift.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_educationshift.strCommonSerachParam+"%");

                    IList<gen_educationshiftEntity> itemList = new List<gen_educationshiftEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationshiftEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_educationshift.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.GAPgListViewgen_educationshift"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_educationshiftDataAccessObjects.GetDataForDropDown(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_educationshift_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_educationshift.SortExpression);
					AddPageSizeParameter(cmd, gen_educationshift.PageSize);
					AddCurrentPageParameter(cmd, gen_educationshift.CurrentPage);                    
					FillSequrityParameters(gen_educationshift.BaseSecurityParam, cmd, Database);
					FillParameters(gen_educationshift, cmd,Database);
					if (!string.IsNullOrEmpty(gen_educationshift.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_educationshift.strCommonSerachParam + " % ");
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
						gen_educationshift.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_educationshiftDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}