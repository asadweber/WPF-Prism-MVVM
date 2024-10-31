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
	
	internal sealed partial class gen_certificatesubjectsDataAccessObjects : BaseDataAccess, Igen_certificatesubjectsDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_certificatesubjectsDataAccessObjects";
        
		public gen_certificatesubjectsDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_certificatesubjectsEntity gen_certificatesubjects, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_certificatesubjects.certificatesubjectid.HasValue)
				Database.AddInParameter(cmd, "@CertificateSubjectID", DbType.Int64, gen_certificatesubjects.certificatesubjectid);
            if (forDelete) return;
			if (gen_certificatesubjects.certificateid.HasValue)
				Database.AddInParameter(cmd, "@CertificateID", DbType.Int64, gen_certificatesubjects.certificateid);
			if (!(string.IsNullOrEmpty(gen_certificatesubjects.certificatesubjectname)))
				Database.AddInParameter(cmd, "@CertificateSubjectName", DbType.String, gen_certificatesubjects.certificatesubjectname);
			if (gen_certificatesubjects.years.HasValue)
				Database.AddInParameter(cmd, "@Years", DbType.Int32, gen_certificatesubjects.years);
			if (!(string.IsNullOrEmpty(gen_certificatesubjects.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_certificatesubjects.comment);
			if (!(string.IsNullOrEmpty(gen_certificatesubjects.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_certificatesubjects.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_certificatesubjectsDataAccessObjects.Add(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_certificatesubjects_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_certificatesubjects, cmd,Database);
                FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.Addgen_certificatesubjects"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_certificatesubjectsDataAccessObjects.Update(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_certificatesubjects_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_certificatesubjects, cmd,Database);
                FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.Updategen_certificatesubjects"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_certificatesubjectsDataAccessObjects.Delete(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_certificatesubjects_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_certificatesubjects, cmd,Database, true);
                FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.Deletegen_certificatesubjects"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_certificatesubjectsDataAccessObjects.SaveList(IList<gen_certificatesubjectsEntity> listAdded, IList<gen_certificatesubjectsEntity> listUpdated, IList<gen_certificatesubjectsEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_certificatesubjects_Ins";
            const string SPUpdate = "gen_certificatesubjects_Upd";
            const string SPDelete = "gen_certificatesubjects_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_certificatesubjectsEntity gen_certificatesubjects in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_certificatesubjects, cmd, Database, true);
                            FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_certificatesubjectsEntity gen_certificatesubjects in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_certificatesubjects, cmd, Database);
                            FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_certificatesubjectsEntity gen_certificatesubjects in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_certificatesubjects, cmd, Database);
                            FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.Save_gen_certificatesubjects"));
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
       IList<gen_certificatesubjectsEntity> listAdded, 
       IList<gen_certificatesubjectsEntity> listUpdated, 
       IList<gen_certificatesubjectsEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_certificatesubjects_Ins";
            const string SPUpdate = "gen_certificatesubjects_Upd";
            const string SPDelete = "gen_certificatesubjects_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_certificatesubjectsEntity gen_certificatesubjects in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_certificatesubjects, cmd, db, true);
                            FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, db);
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
                    foreach (gen_certificatesubjectsEntity gen_certificatesubjects in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_certificatesubjects, cmd, db);
                            FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, db);
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
                    foreach (gen_certificatesubjectsEntity gen_certificatesubjects in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_certificatesubjects, cmd, db);
                            FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.Save_gen_certificatesubjects"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsDataAccessObjects.GetAll(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificatesubjects_GA";
                IList<gen_certificatesubjectsEntity> itemList = new List<gen_certificatesubjectsEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_certificatesubjects.SortExpression);
                    FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificatesubjects, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatesubjectsEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.GetAllgen_certificatesubjects"));
            }	
        }
		
        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsDataAccessObjects.GetAllByPages(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_certificatesubjects_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificatesubjects.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificatesubjects.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificatesubjects.CurrentPage);                    
                    FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_certificatesubjects, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_certificatesubjects.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_certificatesubjects.strCommonSerachParam+"%");

                    IList<gen_certificatesubjectsEntity> itemList = new List<gen_certificatesubjectsEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatesubjectsEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_certificatesubjects.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.GetAllByPagesgen_certificatesubjects"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_certificatesubjectsEntity> Igen_certificatesubjectsDataAccessObjects.GetSingle(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificatesubjects_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificatesubjects, cmd, Database);
                    
                    IList<gen_certificatesubjectsEntity> itemList = new List<gen_certificatesubjectsEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatesubjectsEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.GetSinglegen_certificatesubjects"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsDataAccessObjects.GAPgListView(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_certificatesubjects_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificatesubjects.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificatesubjects.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificatesubjects.CurrentPage);                    
                    FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_certificatesubjects, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_certificatesubjects.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_certificatesubjects.strCommonSerachParam+"%");

                    IList<gen_certificatesubjectsEntity> itemList = new List<gen_certificatesubjectsEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatesubjectsEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_certificatesubjects.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.GAPgListViewgen_certificatesubjects"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}