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
	
	internal sealed partial class gen_econtactlistDataAccessObjects : BaseDataAccess, Igen_econtactlistDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_econtactlistDataAccessObjects";
        
		public gen_econtactlistDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_econtactlistEntity gen_econtactlist, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_econtactlist.emrgconrelid.HasValue)
				Database.AddInParameter(cmd, "@EmrgConRelID", DbType.Int64, gen_econtactlist.emrgconrelid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_econtactlist.emrgrelationshipname)))
				Database.AddInParameter(cmd, "@EmrgRelationshipName", DbType.String, gen_econtactlist.emrgrelationshipname);
			if (!(string.IsNullOrEmpty(gen_econtactlist.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_econtactlist.updateinfo);
			if (gen_econtactlist.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_econtactlist.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_econtactlistDataAccessObjects.Add(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_econtactlist_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_econtactlist, cmd,Database);
                FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.Addgen_econtactlist"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_econtactlistDataAccessObjects.Update(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_econtactlist_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_econtactlist, cmd,Database);
                FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.Updategen_econtactlist"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_econtactlistDataAccessObjects.Delete(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_econtactlist_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_econtactlist, cmd,Database, true);
                FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.Deletegen_econtactlist"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_econtactlistDataAccessObjects.SaveList(IList<gen_econtactlistEntity> listAdded, IList<gen_econtactlistEntity> listUpdated, IList<gen_econtactlistEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_econtactlist_Ins";
            const string SPUpdate = "gen_econtactlist_Upd";
            const string SPDelete = "gen_econtactlist_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_econtactlistEntity gen_econtactlist in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_econtactlist, cmd, Database, true);
                            FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_econtactlistEntity gen_econtactlist in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_econtactlist, cmd, Database);
                            FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_econtactlistEntity gen_econtactlist in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_econtactlist, cmd, Database);
                            FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.Save_gen_econtactlist"));
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
       IList<gen_econtactlistEntity> listAdded, 
       IList<gen_econtactlistEntity> listUpdated, 
       IList<gen_econtactlistEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_econtactlist_Ins";
            const string SPUpdate = "gen_econtactlist_Upd";
            const string SPDelete = "gen_econtactlist_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_econtactlistEntity gen_econtactlist in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_econtactlist, cmd, db, true);
                            FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, db);
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
                    foreach (gen_econtactlistEntity gen_econtactlist in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_econtactlist, cmd, db);
                            FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, db);
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
                    foreach (gen_econtactlistEntity gen_econtactlist in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_econtactlist, cmd, db);
                            FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.Save_gen_econtactlist"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_econtactlistEntity>> Igen_econtactlistDataAccessObjects.GetAll(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_econtactlist_GA";
                IList<gen_econtactlistEntity> itemList = new List<gen_econtactlistEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_econtactlist.SortExpression);
                    FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_econtactlist, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_econtactlistEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.GetAllgen_econtactlist"));
            }	
        }
		
        async Task<IList<gen_econtactlistEntity>> Igen_econtactlistDataAccessObjects.GetAllByPages(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_econtactlist_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_econtactlist.SortExpression);
                    AddPageSizeParameter(cmd, gen_econtactlist.PageSize);
                    AddCurrentPageParameter(cmd, gen_econtactlist.CurrentPage);                    
                    FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_econtactlist, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_econtactlist.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_econtactlist.strCommonSerachParam+"%");

                    IList<gen_econtactlistEntity> itemList = new List<gen_econtactlistEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_econtactlistEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_econtactlist.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.GetAllByPagesgen_econtactlist"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_econtactlistEntity> Igen_econtactlistDataAccessObjects.GetSingle(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_econtactlist_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_econtactlist, cmd, Database);
                    
                    IList<gen_econtactlistEntity> itemList = new List<gen_econtactlistEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_econtactlistEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    
                    if(itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return new gen_econtactlistEntity();
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.GetSinglegen_econtactlist"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_econtactlistEntity>> Igen_econtactlistDataAccessObjects.GAPgListView(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_econtactlist_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_econtactlist.SortExpression);
                    AddPageSizeParameter(cmd, gen_econtactlist.PageSize);
                    AddCurrentPageParameter(cmd, gen_econtactlist.CurrentPage);                    
                    FillSequrityParameters(gen_econtactlist.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_econtactlist, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_econtactlist.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_econtactlist.strCommonSerachParam+"%");

                    IList<gen_econtactlistEntity> itemList = new List<gen_econtactlistEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_econtactlistEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_econtactlist.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_econtactlistDataAccess.GAPgListViewgen_econtactlist"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}