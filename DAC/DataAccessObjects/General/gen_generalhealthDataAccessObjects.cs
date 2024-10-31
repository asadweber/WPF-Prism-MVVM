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
	
	internal sealed partial class gen_generalhealthDataAccessObjects : BaseDataAccess, Igen_generalhealthDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_generalhealthDataAccessObjects";
        
		public gen_generalhealthDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_generalhealthEntity gen_generalhealth, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_generalhealth.generalhealthid.HasValue)
				Database.AddInParameter(cmd, "@GeneralHealthID", DbType.Int64, gen_generalhealth.generalhealthid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_generalhealth.generalhealth)))
				Database.AddInParameter(cmd, "@GeneralHealth", DbType.String, gen_generalhealth.generalhealth);
			if (!(string.IsNullOrEmpty(gen_generalhealth.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_generalhealth.comment);
			if (!(string.IsNullOrEmpty(gen_generalhealth.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_generalhealth.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Igen_generalhealthDataAccessObjects.Add(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_generalhealth_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_generalhealth, cmd,Database);
                FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.Addgen_generalhealth"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_generalhealthDataAccessObjects.Update(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_generalhealth_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_generalhealth, cmd,Database);
                FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.Updategen_generalhealth"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_generalhealthDataAccessObjects.Delete(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_generalhealth_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_generalhealth, cmd,Database, true);
                FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.Deletegen_generalhealth"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_generalhealthDataAccessObjects.SaveList(IList<gen_generalhealthEntity> listAdded, IList<gen_generalhealthEntity> listUpdated, IList<gen_generalhealthEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_generalhealth_Ins";
            const string SPUpdate = "gen_generalhealth_Upd";
            const string SPDelete = "gen_generalhealth_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_generalhealthEntity gen_generalhealth in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_generalhealth, cmd, Database, true);
                            FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_generalhealthEntity gen_generalhealth in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_generalhealth, cmd, Database);
                            FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_generalhealthEntity gen_generalhealth in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_generalhealth, cmd, Database);
                            FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.Save_gen_generalhealth"));
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
       IList<gen_generalhealthEntity> listAdded, 
       IList<gen_generalhealthEntity> listUpdated, 
       IList<gen_generalhealthEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_generalhealth_Ins";
            const string SPUpdate = "gen_generalhealth_Upd";
            const string SPDelete = "gen_generalhealth_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_generalhealthEntity gen_generalhealth in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_generalhealth, cmd, db, true);
                            FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, db);
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
                    foreach (gen_generalhealthEntity gen_generalhealth in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_generalhealth, cmd, db);
                            FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, db);
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
                    foreach (gen_generalhealthEntity gen_generalhealth in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_generalhealth, cmd, db);
                            FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.Save_gen_generalhealth"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_generalhealthEntity>> Igen_generalhealthDataAccessObjects.GetAll(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_generalhealth_GA";
                IList<gen_generalhealthEntity> itemList = new List<gen_generalhealthEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_generalhealth.SortExpression);
                    FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_generalhealth, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generalhealthEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.GetAllgen_generalhealth"));
            }	
        }
		
        async Task<IList<gen_generalhealthEntity>> Igen_generalhealthDataAccessObjects.GetAllByPages(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_generalhealth_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_generalhealth.SortExpression);
                    AddPageSizeParameter(cmd, gen_generalhealth.PageSize);
                    AddCurrentPageParameter(cmd, gen_generalhealth.CurrentPage);                    
                    FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_generalhealth, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_generalhealth.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_generalhealth.strCommonSerachParam+"%");

                    IList<gen_generalhealthEntity> itemList = new List<gen_generalhealthEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generalhealthEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_generalhealth.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.GetAllByPagesgen_generalhealth"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_generalhealthEntity> Igen_generalhealthDataAccessObjects.GetSingle(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_generalhealth_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_generalhealth, cmd, Database);
                    
                    IList<gen_generalhealthEntity> itemList = new List<gen_generalhealthEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generalhealthEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.GetSinglegen_generalhealth"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_generalhealthEntity>> Igen_generalhealthDataAccessObjects.GAPgListView(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_generalhealth_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_generalhealth.SortExpression);
                    AddPageSizeParameter(cmd, gen_generalhealth.PageSize);
                    AddCurrentPageParameter(cmd, gen_generalhealth.CurrentPage);                    
                    FillSequrityParameters(gen_generalhealth.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_generalhealth, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_generalhealth.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_generalhealth.strCommonSerachParam+"%");

                    IList<gen_generalhealthEntity> itemList = new List<gen_generalhealthEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_generalhealthEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_generalhealth.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_generalhealthDataAccess.GAPgListViewgen_generalhealth"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}