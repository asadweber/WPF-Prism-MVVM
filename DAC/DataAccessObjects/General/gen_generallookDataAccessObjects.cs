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
	
	internal sealed partial class gen_generallookDataAccessObjects : BaseDataAccess, Igen_generallookDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_generallookDataAccessObjects";
        
		public gen_generallookDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_generallookEntity gen_generallook, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_generallook.generallookid.HasValue)
				Database.AddInParameter(cmd, "@GeneralLookID", DbType.Int64, gen_generallook.generallookid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_generallook.generallook)))
				Database.AddInParameter(cmd, "@GeneralLook", DbType.String, gen_generallook.generallook);
			if (!(string.IsNullOrEmpty(gen_generallook.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_generallook.comment);
			if (!(string.IsNullOrEmpty(gen_generallook.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_generallook.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Igen_generallookDataAccessObjects.Add(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_generallook_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_generallook, cmd,Database);
                FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.Addgen_generallook"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_generallookDataAccessObjects.Update(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_generallook_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_generallook, cmd,Database);
                FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.Updategen_generallook"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_generallookDataAccessObjects.Delete(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_generallook_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_generallook, cmd,Database, true);
                FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.Deletegen_generallook"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_generallookDataAccessObjects.SaveList(IList<gen_generallookEntity> listAdded, IList<gen_generallookEntity> listUpdated, IList<gen_generallookEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_generallook_Ins";
            const string SPUpdate = "gen_generallook_Upd";
            const string SPDelete = "gen_generallook_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_generallookEntity gen_generallook in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_generallook, cmd, Database, true);
                            FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_generallookEntity gen_generallook in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_generallook, cmd, Database);
                            FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_generallookEntity gen_generallook in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_generallook, cmd, Database);
                            FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.Save_gen_generallook"));
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
       IList<gen_generallookEntity> listAdded, 
       IList<gen_generallookEntity> listUpdated, 
       IList<gen_generallookEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_generallook_Ins";
            const string SPUpdate = "gen_generallook_Upd";
            const string SPDelete = "gen_generallook_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_generallookEntity gen_generallook in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_generallook, cmd, db, true);
                            FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, db);
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
                    foreach (gen_generallookEntity gen_generallook in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_generallook, cmd, db);
                            FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, db);
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
                    foreach (gen_generallookEntity gen_generallook in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_generallook, cmd, db);
                            FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.Save_gen_generallook"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_generallookEntity>> Igen_generallookDataAccessObjects.GetAll(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_generallook_GA";
                IList<gen_generallookEntity> itemList = new List<gen_generallookEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_generallook.SortExpression);
                    FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_generallook, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generallookEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.GetAllgen_generallook"));
            }	
        }
		
        async Task<IList<gen_generallookEntity>> Igen_generallookDataAccessObjects.GetAllByPages(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_generallook_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_generallook.SortExpression);
                    AddPageSizeParameter(cmd, gen_generallook.PageSize);
                    AddCurrentPageParameter(cmd, gen_generallook.CurrentPage);                    
                    FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_generallook, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_generallook.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_generallook.strCommonSerachParam+"%");

                    IList<gen_generallookEntity> itemList = new List<gen_generallookEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generallookEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_generallook.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.GetAllByPagesgen_generallook"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_generallookEntity> Igen_generallookDataAccessObjects.GetSingle(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_generallook_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_generallook, cmd, Database);
                    
                    IList<gen_generallookEntity> itemList = new List<gen_generallookEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generallookEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.GetSinglegen_generallook"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_generallookEntity>> Igen_generallookDataAccessObjects.GAPgListView(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_generallook_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_generallook.SortExpression);
                    AddPageSizeParameter(cmd, gen_generallook.PageSize);
                    AddCurrentPageParameter(cmd, gen_generallook.CurrentPage);                    
                    FillSequrityParameters(gen_generallook.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_generallook, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_generallook.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_generallook.strCommonSerachParam+"%");

                    IList<gen_generallookEntity> itemList = new List<gen_generallookEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generallookEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_generallook.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_generallookDataAccess.GAPgListViewgen_generallook"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}