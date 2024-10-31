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
	
	internal sealed partial class gen_residenttypeDataAccessObjects : BaseDataAccess, Igen_residenttypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_residenttypeDataAccessObjects";
        
		public gen_residenttypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_residenttypeEntity gen_residenttype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_residenttype.residenttypeid.HasValue)
				Database.AddInParameter(cmd, "@ResidentTypeID", DbType.Int64, gen_residenttype.residenttypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_residenttype.residenttype)))
				Database.AddInParameter(cmd, "@ResidentType", DbType.String, gen_residenttype.residenttype);
			if (!(string.IsNullOrEmpty(gen_residenttype.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_residenttype.comment);
			if (!(string.IsNullOrEmpty(gen_residenttype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_residenttype.remarks);
			if (!(string.IsNullOrEmpty(gen_residenttype.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_residenttype.updateinfo);
			if (gen_residenttype.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_residenttype.tranformactionid);
			if (gen_residenttype.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_residenttype.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_residenttypeDataAccessObjects.Add(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_residenttype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_residenttype, cmd,Database);
                FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.Addgen_residenttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_residenttypeDataAccessObjects.Update(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_residenttype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_residenttype, cmd,Database);
                FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.Updategen_residenttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_residenttypeDataAccessObjects.Delete(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_residenttype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_residenttype, cmd,Database, true);
                FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.Deletegen_residenttype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_residenttypeDataAccessObjects.SaveList(IList<gen_residenttypeEntity> listAdded, IList<gen_residenttypeEntity> listUpdated, IList<gen_residenttypeEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_residenttype_Ins";
            const string SPUpdate = "gen_residenttype_Upd";
            const string SPDelete = "gen_residenttype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_residenttypeEntity gen_residenttype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_residenttype, cmd, Database, true);
                            FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_residenttypeEntity gen_residenttype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_residenttype, cmd, Database);
                            FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_residenttypeEntity gen_residenttype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_residenttype, cmd, Database);
                            FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.Save_gen_residenttype"));
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
       IList<gen_residenttypeEntity> listAdded, 
       IList<gen_residenttypeEntity> listUpdated, 
       IList<gen_residenttypeEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_residenttype_Ins";
            const string SPUpdate = "gen_residenttype_Upd";
            const string SPDelete = "gen_residenttype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_residenttypeEntity gen_residenttype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_residenttype, cmd, db, true);
                            FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_residenttypeEntity gen_residenttype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_residenttype, cmd, db);
                            FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_residenttypeEntity gen_residenttype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_residenttype, cmd, db);
                            FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.Save_gen_residenttype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_residenttypeEntity>> Igen_residenttypeDataAccessObjects.GetAll(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_residenttype_GA";
                IList<gen_residenttypeEntity> itemList = new List<gen_residenttypeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_residenttype.SortExpression);
                    FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_residenttype, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_residenttypeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.GetAllgen_residenttype"));
            }	
        }
		
        async Task<IList<gen_residenttypeEntity>> Igen_residenttypeDataAccessObjects.GetAllByPages(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_residenttype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_residenttype.SortExpression);
                    AddPageSizeParameter(cmd, gen_residenttype.PageSize);
                    AddCurrentPageParameter(cmd, gen_residenttype.CurrentPage);                    
                    FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_residenttype, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_residenttype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_residenttype.strCommonSerachParam+"%");

                    IList<gen_residenttypeEntity> itemList = new List<gen_residenttypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_residenttypeEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_residenttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.GetAllByPagesgen_residenttype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_residenttypeDataAccessObjects.SaveMasterDetreg_basicinfo(gen_residenttypeEntity masterEntity, 
        IList<reg_basicinfoEntity> listAdded, 
        IList<reg_basicinfoEntity> listUpdated,
        IList<reg_basicinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_residenttype_Ins";
            const string MasterSPUpdate = "gen_residenttype_Upd";
            const string MasterSPDelete = "gen_residenttype_Del";
            
			
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
                                item.residenttypeid=PrimaryKeyMaster;
                            }
                        }
                        reg_basicinfoDataAccessObjects objreg_basicinfo=new reg_basicinfoDataAccessObjects(this.Context);
                        objreg_basicinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.SaveDsgen_residenttype"));
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
        async Task<gen_residenttypeEntity> Igen_residenttypeDataAccessObjects.GetSingle(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_residenttype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_residenttype, cmd, Database);
                    
                    IList<gen_residenttypeEntity> itemList = new List<gen_residenttypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_residenttypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.GetSinglegen_residenttype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_residenttypeEntity>> Igen_residenttypeDataAccessObjects.GAPgListView(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_residenttype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_residenttype.SortExpression);
                    AddPageSizeParameter(cmd, gen_residenttype.PageSize);
                    AddCurrentPageParameter(cmd, gen_residenttype.CurrentPage);                    
                    FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_residenttype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_residenttype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_residenttype.strCommonSerachParam+"%");

                    IList<gen_residenttypeEntity> itemList = new List<gen_residenttypeEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_residenttypeEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_residenttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.GAPgListViewgen_residenttype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_residenttypeDataAccessObjects.GetDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_residenttype_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_residenttype.SortExpression);
					AddPageSizeParameter(cmd, gen_residenttype.PageSize);
					AddCurrentPageParameter(cmd, gen_residenttype.CurrentPage);                    
					FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
					FillParameters(gen_residenttype, cmd,Database);
					if (!string.IsNullOrEmpty(gen_residenttype.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_residenttype.strCommonSerachParam + " % ");
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
						gen_residenttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}