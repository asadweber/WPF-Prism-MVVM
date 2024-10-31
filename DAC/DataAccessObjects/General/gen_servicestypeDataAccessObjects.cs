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
	
	internal sealed partial class gen_servicestypeDataAccessObjects : BaseDataAccess, Igen_servicestypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_servicestypeDataAccessObjects";
        
		public gen_servicestypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_servicestypeEntity gen_servicestype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_servicestype.servicetypeid.HasValue)
				Database.AddInParameter(cmd, "@ServiceTypeID", DbType.Int64, gen_servicestype.servicetypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_servicestype.servicetypear)))
				Database.AddInParameter(cmd, "@ServiceTypeAR", DbType.String, gen_servicestype.servicetypear);
			if (!(string.IsNullOrEmpty(gen_servicestype.descriptionar)))
				Database.AddInParameter(cmd, "@DescriptionAR", DbType.String, gen_servicestype.descriptionar);
			if (!(string.IsNullOrEmpty(gen_servicestype.servicetype)))
				Database.AddInParameter(cmd, "@ServiceType", DbType.String, gen_servicestype.servicetype);
			if (!(string.IsNullOrEmpty(gen_servicestype.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, gen_servicestype.description);

        }
		
        
		#region Add Operation

        async Task<long> Igen_servicestypeDataAccessObjects.Add(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_servicestype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_servicestype, cmd,Database);
                FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.Addgen_servicestype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_servicestypeDataAccessObjects.Update(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_servicestype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_servicestype, cmd,Database);
                FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.Updategen_servicestype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_servicestypeDataAccessObjects.Delete(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_servicestype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_servicestype, cmd,Database, true);
                FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.Deletegen_servicestype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_servicestypeDataAccessObjects.SaveList(IList<gen_servicestypeEntity> listAdded, IList<gen_servicestypeEntity> listUpdated, IList<gen_servicestypeEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_servicestype_Ins";
            const string SPUpdate = "gen_servicestype_Upd";
            const string SPDelete = "gen_servicestype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicestypeEntity gen_servicestype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_servicestype, cmd, Database, true);
                            FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicestypeEntity gen_servicestype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_servicestype, cmd, Database);
                            FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicestypeEntity gen_servicestype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_servicestype, cmd, Database);
                            FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.Save_gen_servicestype"));
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
       IList<gen_servicestypeEntity> listAdded, 
       IList<gen_servicestypeEntity> listUpdated, 
       IList<gen_servicestypeEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_servicestype_Ins";
            const string SPUpdate = "gen_servicestype_Upd";
            const string SPDelete = "gen_servicestype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicestypeEntity gen_servicestype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_servicestype, cmd, db, true);
                            FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicestypeEntity gen_servicestype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_servicestype, cmd, db);
                            FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicestypeEntity gen_servicestype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_servicestype, cmd, db);
                            FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.Save_gen_servicestype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_servicestypeEntity>> Igen_servicestypeDataAccessObjects.GetAll(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_servicestype_GA";
                IList<gen_servicestypeEntity> itemList = new List<gen_servicestypeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_servicestype.SortExpression);
                    FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_servicestype, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestypeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.GetAllgen_servicestype"));
            }	
        }
		
        async Task<IList<gen_servicestypeEntity>> Igen_servicestypeDataAccessObjects.GetAllByPages(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_servicestype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_servicestype.SortExpression);
                    AddPageSizeParameter(cmd, gen_servicestype.PageSize);
                    AddCurrentPageParameter(cmd, gen_servicestype.CurrentPage);                    
                    FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_servicestype, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_servicestype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_servicestype.strCommonSerachParam+"%");

                    IList<gen_servicestypeEntity> itemList = new List<gen_servicestypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestypeEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_servicestype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.GetAllByPagesgen_servicestype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_servicestypeDataAccessObjects.SaveMasterDetgen_services(gen_servicestypeEntity masterEntity, 
        IList<gen_servicesEntity> listAdded, 
        IList<gen_servicesEntity> listUpdated,
        IList<gen_servicesEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_servicestype_Ins";
            const string MasterSPUpdate = "gen_servicestype_Upd";
            const string MasterSPDelete = "gen_servicestype_Del";
            
			
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
                                item.servicetypeid=PrimaryKeyMaster;
                            }
                        }
                        gen_servicesDataAccessObjects objgen_services=new gen_servicesDataAccessObjects(this.Context);
                        objgen_services.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.SaveDsgen_servicestype"));
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
        async Task<gen_servicestypeEntity> Igen_servicestypeDataAccessObjects.GetSingle(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_servicestype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_servicestype, cmd, Database);
                    
                    IList<gen_servicestypeEntity> itemList = new List<gen_servicestypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.GetSinglegen_servicestype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_servicestypeEntity>> Igen_servicestypeDataAccessObjects.GAPgListView(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_servicestype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_servicestype.SortExpression);
                    AddPageSizeParameter(cmd, gen_servicestype.PageSize);
                    AddCurrentPageParameter(cmd, gen_servicestype.CurrentPage);                    
                    FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_servicestype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_servicestype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_servicestype.strCommonSerachParam+"%");

                    IList<gen_servicestypeEntity> itemList = new List<gen_servicestypeEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestypeEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_servicestype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.GAPgListViewgen_servicestype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_servicestypeDataAccessObjects.GetDataForDropDown(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_servicestype_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_servicestype.SortExpression);
					AddPageSizeParameter(cmd, gen_servicestype.PageSize);
					AddCurrentPageParameter(cmd, gen_servicestype.CurrentPage);                    
					FillSequrityParameters(gen_servicestype.BaseSecurityParam, cmd, Database);
					FillParameters(gen_servicestype, cmd,Database);
					if (!string.IsNullOrEmpty(gen_servicestype.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_servicestype.strCommonSerachParam + " % ");
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
						gen_servicestype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_servicestypeDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}