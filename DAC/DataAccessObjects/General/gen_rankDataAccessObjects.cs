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
	
	internal sealed partial class gen_rankDataAccessObjects : BaseDataAccess, Igen_rankDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_rankDataAccessObjects";
        
		public gen_rankDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_rankEntity gen_rank, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_rank.rankid.HasValue)
				Database.AddInParameter(cmd, "@RankID", DbType.Int64, gen_rank.rankid);
            if (forDelete) return;
			if (gen_rank.forceid.HasValue)
				Database.AddInParameter(cmd, "@ForceID", DbType.Int64, gen_rank.forceid);
			if (!(string.IsNullOrEmpty(gen_rank.rankname)))
				Database.AddInParameter(cmd, "@RankName", DbType.String, gen_rank.rankname);
			if (gen_rank.rankfor.HasValue)
				Database.AddInParameter(cmd, "@RankFor", DbType.Int32, gen_rank.rankfor);
			if (!(string.IsNullOrEmpty(gen_rank.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_rank.comment);
			if (!(string.IsNullOrEmpty(gen_rank.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_rank.remarks);
			if (!(string.IsNullOrEmpty(gen_rank.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_rank.updateinfo);
			if (gen_rank.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_rank.tranformactionid);
			if (gen_rank.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_rank.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_rankDataAccessObjects.Add(gen_rankEntity gen_rank, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_rank_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_rank, cmd,Database);
                FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Addgen_rank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_rankDataAccessObjects.Update(gen_rankEntity gen_rank, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_rank_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_rank, cmd,Database);
                FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Updategen_rank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_rankDataAccessObjects.Delete(gen_rankEntity gen_rank, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_rank_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_rank, cmd,Database, true);
                FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Deletegen_rank"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_rankDataAccessObjects.SaveList(IList<gen_rankEntity> listAdded, IList<gen_rankEntity> listUpdated, IList<gen_rankEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_rank_Ins";
            const string SPUpdate = "gen_rank_Upd";
            const string SPDelete = "gen_rank_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_rankEntity gen_rank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_rank, cmd, Database, true);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_rankEntity gen_rank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_rank, cmd, Database);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_rankEntity gen_rank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_rank, cmd, Database);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Save_gen_rank"));
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
       IList<gen_rankEntity> listAdded, 
       IList<gen_rankEntity> listUpdated, 
       IList<gen_rankEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_rank_Ins";
            const string SPUpdate = "gen_rank_Upd";
            const string SPDelete = "gen_rank_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_rankEntity gen_rank in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_rank, cmd, db, true);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_rankEntity gen_rank in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_rank, cmd, db);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, db);
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
                    foreach (gen_rankEntity gen_rank in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_rank, cmd, db);
                            FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.Save_gen_rank"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_rankEntity>> Igen_rankDataAccessObjects.GetAll(gen_rankEntity gen_rank, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_rank_GA";
                IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_rank.SortExpression);
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_rank, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GetAllgen_rank"));
            }	
        }
		
        async Task<IList<gen_rankEntity>> Igen_rankDataAccessObjects.GetAllByPages(gen_rankEntity gen_rank, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_rank_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_rank.SortExpression);
                    AddPageSizeParameter(cmd, gen_rank.PageSize);
                    AddCurrentPageParameter(cmd, gen_rank.CurrentPage);                    
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_rank, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_rank.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_rank.strCommonSerachParam+"%");

                    IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_rank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GetAllByPagesgen_rank"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_rankEntity> Igen_rankDataAccessObjects.GetSingle(gen_rankEntity gen_rank, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_rank_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_rank, cmd, Database);
                    
                    IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GetSinglegen_rank"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_rankEntity>> Igen_rankDataAccessObjects.GAPgListView(gen_rankEntity gen_rank, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_rank_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_rank.SortExpression);
                    AddPageSizeParameter(cmd, gen_rank.PageSize);
                    AddCurrentPageParameter(cmd, gen_rank.CurrentPage);                    
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_rank, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_rank.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_rank.strCommonSerachParam+"%");

                    IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_rank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_rankDataAccess.GAPgListViewgen_rank"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}