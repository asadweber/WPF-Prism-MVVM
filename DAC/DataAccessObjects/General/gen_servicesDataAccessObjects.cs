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
	
	internal sealed partial class gen_servicesDataAccessObjects : BaseDataAccess, Igen_servicesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_servicesDataAccessObjects";
        
		public gen_servicesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_servicesEntity gen_services, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_services.serviceid.HasValue)
				Database.AddInParameter(cmd, "@ServiceID", DbType.Int64, gen_services.serviceid);
            if (forDelete) return;
			if (gen_services.servicetypeid.HasValue)
				Database.AddInParameter(cmd, "@ServiceTypeID", DbType.Int64, gen_services.servicetypeid);
			if (!(string.IsNullOrEmpty(gen_services.servicename)))
				Database.AddInParameter(cmd, "@ServiceName", DbType.String, gen_services.servicename);
			if (!(string.IsNullOrEmpty(gen_services.servicenamear)))
				Database.AddInParameter(cmd, "@ServiceNameAR", DbType.String, gen_services.servicenamear);
			if (!(string.IsNullOrEmpty(gen_services.servicedescription)))
				Database.AddInParameter(cmd, "@ServiceDescription", DbType.String, gen_services.servicedescription);
			if (!(string.IsNullOrEmpty(gen_services.servicedescriptionar)))
				Database.AddInParameter(cmd, "@ServiceDescriptionAR", DbType.String, gen_services.servicedescriptionar);
			if (!(string.IsNullOrEmpty(gen_services.servicelogopath)))
				Database.AddInParameter(cmd, "@ServiceLogoPath", DbType.String, gen_services.servicelogopath);
			if (!(string.IsNullOrEmpty(gen_services.serviceurl)))
				Database.AddInParameter(cmd, "@ServiceURL", DbType.String, gen_services.serviceurl);

        }
		
        
		#region Add Operation

        async Task<long> Igen_servicesDataAccessObjects.Add(gen_servicesEntity gen_services, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_services_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_services, cmd,Database);
                FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.Addgen_services"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_servicesDataAccessObjects.Update(gen_servicesEntity gen_services, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_services_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_services, cmd,Database);
                FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.Updategen_services"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_servicesDataAccessObjects.Delete(gen_servicesEntity gen_services, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_services_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_services, cmd,Database, true);
                FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.Deletegen_services"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_servicesDataAccessObjects.SaveList(IList<gen_servicesEntity> listAdded, IList<gen_servicesEntity> listUpdated, IList<gen_servicesEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_services_Ins";
            const string SPUpdate = "gen_services_Upd";
            const string SPDelete = "gen_services_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicesEntity gen_services in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_services, cmd, Database, true);
                            FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicesEntity gen_services in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_services, cmd, Database);
                            FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicesEntity gen_services in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_services, cmd, Database);
                            FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.Save_gen_services"));
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
       IList<gen_servicesEntity> listAdded, 
       IList<gen_servicesEntity> listUpdated, 
       IList<gen_servicesEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_services_Ins";
            const string SPUpdate = "gen_services_Upd";
            const string SPDelete = "gen_services_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicesEntity gen_services in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_services, cmd, db, true);
                            FillSequrityParameters(gen_services.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicesEntity gen_services in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_services, cmd, db);
                            FillSequrityParameters(gen_services.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicesEntity gen_services in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_services, cmd, db);
                            FillSequrityParameters(gen_services.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.Save_gen_services"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_servicesEntity>> Igen_servicesDataAccessObjects.GetAll(gen_servicesEntity gen_services, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_services_GA";
                IList<gen_servicesEntity> itemList = new List<gen_servicesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_services.SortExpression);
                    FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_services, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.GetAllgen_services"));
            }	
        }
		
        async Task<IList<gen_servicesEntity>> Igen_servicesDataAccessObjects.GetAllByPages(gen_servicesEntity gen_services, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_services_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_services.SortExpression);
                    AddPageSizeParameter(cmd, gen_services.PageSize);
                    AddCurrentPageParameter(cmd, gen_services.CurrentPage);                    
                    FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_services, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_services.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_services.strCommonSerachParam+"%");

                    IList<gen_servicesEntity> itemList = new List<gen_servicesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicesEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_services.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.GetAllByPagesgen_services"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_servicesEntity> Igen_servicesDataAccessObjects.GetSingle(gen_servicesEntity gen_services, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_services_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_services, cmd, Database);
                    
                    IList<gen_servicesEntity> itemList = new List<gen_servicesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.GetSinglegen_services"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_servicesEntity>> Igen_servicesDataAccessObjects.GAPgListView(gen_servicesEntity gen_services, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_services_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_services.SortExpression);
                    AddPageSizeParameter(cmd, gen_services.PageSize);
                    AddCurrentPageParameter(cmd, gen_services.CurrentPage);                    
                    FillSequrityParameters(gen_services.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_services, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_services.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_services.strCommonSerachParam+"%");

                    IList<gen_servicesEntity> itemList = new List<gen_servicesEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicesEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_services.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicesDataAccess.GAPgListViewgen_services"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}