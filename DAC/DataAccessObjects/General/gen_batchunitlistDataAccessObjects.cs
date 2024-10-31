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
	
	internal sealed partial class gen_batchunitlistDataAccessObjects : BaseDataAccess, Igen_batchunitlistDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_batchunitlistDataAccessObjects";
        
		public gen_batchunitlistDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_batchunitlistEntity gen_batchunitlist, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_batchunitlist.batchunitlistid.HasValue)
				Database.AddInParameter(cmd, "@BatchUnitListID", DbType.Int64, gen_batchunitlist.batchunitlistid);
            if (forDelete) return;
			if (gen_batchunitlist.batchid.HasValue)
				Database.AddInParameter(cmd, "@BatchID", DbType.Int64, gen_batchunitlist.batchid);
			if (gen_batchunitlist.batchno.HasValue)
				Database.AddInParameter(cmd, "@BatchNo", DbType.Int64, gen_batchunitlist.batchno);
			if (gen_batchunitlist.entitykey.HasValue)
				Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, gen_batchunitlist.entitykey);
			if ((gen_batchunitlist.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, gen_batchunitlist.isactive);
			if (!(string.IsNullOrEmpty(gen_batchunitlist.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_batchunitlist.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_batchunitlistDataAccessObjects.Add(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchunitlist_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchunitlist, cmd,Database);
                FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.Addgen_batchunitlist"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_batchunitlistDataAccessObjects.Update(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_batchunitlist_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_batchunitlist, cmd,Database);
                FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.Updategen_batchunitlist"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_batchunitlistDataAccessObjects.Delete(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_batchunitlist_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_batchunitlist, cmd,Database, true);
                FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.Deletegen_batchunitlist"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_batchunitlistDataAccessObjects.SaveList(IList<gen_batchunitlistEntity> listAdded, IList<gen_batchunitlistEntity> listUpdated, IList<gen_batchunitlistEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_batchunitlist_Ins";
            const string SPUpdate = "gen_batchunitlist_Upd";
            const string SPDelete = "gen_batchunitlist_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchunitlistEntity gen_batchunitlist in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchunitlist, cmd, Database, true);
                            FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchunitlistEntity gen_batchunitlist in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchunitlist, cmd, Database);
                            FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchunitlistEntity gen_batchunitlist in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchunitlist, cmd, Database);
                            FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.Save_gen_batchunitlist"));
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
       IList<gen_batchunitlistEntity> listAdded, 
       IList<gen_batchunitlistEntity> listUpdated, 
       IList<gen_batchunitlistEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_batchunitlist_Ins";
            const string SPUpdate = "gen_batchunitlist_Upd";
            const string SPDelete = "gen_batchunitlist_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchunitlistEntity gen_batchunitlist in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchunitlist, cmd, db, true);
                            FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchunitlistEntity gen_batchunitlist in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchunitlist, cmd, db);
                            FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchunitlistEntity gen_batchunitlist in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchunitlist, cmd, db);
                            FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.Save_gen_batchunitlist"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistDataAccessObjects.GetAll(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchunitlist_GA";
                IList<gen_batchunitlistEntity> itemList = new List<gen_batchunitlistEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchunitlist.SortExpression);
                    FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchunitlist, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchunitlistEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.GetAllgen_batchunitlist"));
            }	
        }
		
        async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistDataAccessObjects.GetAllByPages(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchunitlist_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchunitlist.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchunitlist.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchunitlist.CurrentPage);                    
                    FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchunitlist, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_batchunitlist.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchunitlist.strCommonSerachParam+"%");

                    IList<gen_batchunitlistEntity> itemList = new List<gen_batchunitlistEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchunitlistEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchunitlist.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.GetAllByPagesgen_batchunitlist"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_batchunitlistEntity> Igen_batchunitlistDataAccessObjects.GetSingle(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchunitlist_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchunitlist, cmd, Database);
                    
                    IList<gen_batchunitlistEntity> itemList = new List<gen_batchunitlistEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchunitlistEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.GetSinglegen_batchunitlist"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistDataAccessObjects.GAPgListView(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchunitlist_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchunitlist.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchunitlist.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchunitlist.CurrentPage);                    
                    FillSequrityParameters(gen_batchunitlist.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchunitlist, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_batchunitlist.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchunitlist.strCommonSerachParam+"%");

                    IList<gen_batchunitlistEntity> itemList = new List<gen_batchunitlistEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchunitlistEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchunitlist.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchunitlistDataAccess.GAPgListViewgen_batchunitlist"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}