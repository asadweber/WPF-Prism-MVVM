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
	
	internal sealed partial class gen_serviceinfoDataAccessObjects : BaseDataAccess, Igen_serviceinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_serviceinfoDataAccessObjects";
        
		public gen_serviceinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_serviceinfoEntity gen_serviceinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_serviceinfo.serviceid.HasValue)
				Database.AddInParameter(cmd, "@ServiceID", DbType.Int64, gen_serviceinfo.serviceid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_serviceinfo.servicear)))
				Database.AddInParameter(cmd, "@ServiceAR", DbType.String, gen_serviceinfo.servicear);
			if (!(string.IsNullOrEmpty(gen_serviceinfo.serviceen)))
				Database.AddInParameter(cmd, "@ServiceEN", DbType.String, gen_serviceinfo.serviceen);
			if (!(string.IsNullOrEmpty(gen_serviceinfo.descriptionar)))
				Database.AddInParameter(cmd, "@DescriptionAR", DbType.String, gen_serviceinfo.descriptionar);
			if (!(string.IsNullOrEmpty(gen_serviceinfo.descriptionen)))
				Database.AddInParameter(cmd, "@DescriptionEN", DbType.String, gen_serviceinfo.descriptionen);
			if ((gen_serviceinfo.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, gen_serviceinfo.isactive);

        }
		
        
		#region Add Operation

        async Task<long> Igen_serviceinfoDataAccessObjects.Add(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_serviceinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_serviceinfo, cmd,Database);
                FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.Addgen_serviceinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_serviceinfoDataAccessObjects.Update(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_serviceinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_serviceinfo, cmd,Database);
                FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.Updategen_serviceinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_serviceinfoDataAccessObjects.Delete(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_serviceinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_serviceinfo, cmd,Database, true);
                FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.Deletegen_serviceinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_serviceinfoDataAccessObjects.SaveList(IList<gen_serviceinfoEntity> listAdded, IList<gen_serviceinfoEntity> listUpdated, IList<gen_serviceinfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_serviceinfo_Ins";
            const string SPUpdate = "gen_serviceinfo_Upd";
            const string SPDelete = "gen_serviceinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_serviceinfoEntity gen_serviceinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_serviceinfo, cmd, Database, true);
                            FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_serviceinfoEntity gen_serviceinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_serviceinfo, cmd, Database);
                            FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_serviceinfoEntity gen_serviceinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_serviceinfo, cmd, Database);
                            FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.Save_gen_serviceinfo"));
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
       IList<gen_serviceinfoEntity> listAdded, 
       IList<gen_serviceinfoEntity> listUpdated, 
       IList<gen_serviceinfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_serviceinfo_Ins";
            const string SPUpdate = "gen_serviceinfo_Upd";
            const string SPDelete = "gen_serviceinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_serviceinfoEntity gen_serviceinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_serviceinfo, cmd, db, true);
                            FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, db);
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
                    foreach (gen_serviceinfoEntity gen_serviceinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_serviceinfo, cmd, db);
                            FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, db);
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
                    foreach (gen_serviceinfoEntity gen_serviceinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_serviceinfo, cmd, db);
                            FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.Save_gen_serviceinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_serviceinfoEntity>> Igen_serviceinfoDataAccessObjects.GetAll(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_serviceinfo_GA";
                IList<gen_serviceinfoEntity> itemList = new List<gen_serviceinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_serviceinfo.SortExpression);
                    FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_serviceinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_serviceinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.GetAllgen_serviceinfo"));
            }	
        }
		
        async Task<IList<gen_serviceinfoEntity>> Igen_serviceinfoDataAccessObjects.GetAllByPages(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_serviceinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_serviceinfo.SortExpression);
                    AddPageSizeParameter(cmd, gen_serviceinfo.PageSize);
                    AddCurrentPageParameter(cmd, gen_serviceinfo.CurrentPage);                    
                    FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_serviceinfo, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_serviceinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_serviceinfo.strCommonSerachParam+"%");

                    IList<gen_serviceinfoEntity> itemList = new List<gen_serviceinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_serviceinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_serviceinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.GetAllByPagesgen_serviceinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_serviceinfoEntity> Igen_serviceinfoDataAccessObjects.GetSingle(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_serviceinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_serviceinfo, cmd, Database);
                    
                    IList<gen_serviceinfoEntity> itemList = new List<gen_serviceinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_serviceinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.GetSinglegen_serviceinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_serviceinfoEntity>> Igen_serviceinfoDataAccessObjects.GAPgListView(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_serviceinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_serviceinfo.SortExpression);
                    AddPageSizeParameter(cmd, gen_serviceinfo.PageSize);
                    AddCurrentPageParameter(cmd, gen_serviceinfo.CurrentPage);                    
                    FillSequrityParameters(gen_serviceinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_serviceinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_serviceinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_serviceinfo.strCommonSerachParam+"%");

                    IList<gen_serviceinfoEntity> itemList = new List<gen_serviceinfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_serviceinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_serviceinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_serviceinfoDataAccess.GAPgListViewgen_serviceinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}