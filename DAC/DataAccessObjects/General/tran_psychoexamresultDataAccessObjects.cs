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
	
	internal sealed partial class tran_psychoexamresultDataAccessObjects : BaseDataAccess, Itran_psychoexamresultDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_psychoexamresultDataAccessObjects";
        
		public tran_psychoexamresultDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_psychoexamresultEntity tran_psychoexamresult, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_psychoexamresult.psychoexamresultid.HasValue)
				Database.AddInParameter(cmd, "@PsychoExamResultID", DbType.Int64, tran_psychoexamresult.psychoexamresultid);
            if (forDelete) return;
			if (tran_psychoexamresult.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_psychoexamresult.basicinfoid);
			if (tran_psychoexamresult.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_psychoexamresult.registrationid);
			if (tran_psychoexamresult.psychoexamresult.HasValue)
				Database.AddInParameter(cmd, "@PsychoExamResult", DbType.Int32, tran_psychoexamresult.psychoexamresult);
			if (!(string.IsNullOrEmpty(tran_psychoexamresult.psychoexamcomment)))
				Database.AddInParameter(cmd, "@PsychoExamComment", DbType.String, tran_psychoexamresult.psychoexamcomment);
			if ((tran_psychoexamresult.psychoexamresultdate.HasValue))
				Database.AddInParameter(cmd, "@PsychoExamResultDate", DbType.DateTime, tran_psychoexamresult.psychoexamresultdate);
			if (!(string.IsNullOrEmpty(tran_psychoexamresult.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_psychoexamresult.remarks);
			if ((tran_psychoexamresult.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_psychoexamresult.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_psychoexamresult.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_psychoexamresult.updateinfo);
			if (tran_psychoexamresult.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_psychoexamresult.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_psychoexamresultDataAccessObjects.Add(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_psychoexamresult_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_psychoexamresult, cmd,Database);
                FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.Addtran_psychoexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_psychoexamresultDataAccessObjects.Update(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_psychoexamresult_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_psychoexamresult, cmd,Database);
                FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.Updatetran_psychoexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_psychoexamresultDataAccessObjects.Delete(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_psychoexamresult_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_psychoexamresult, cmd,Database, true);
                FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.Deletetran_psychoexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_psychoexamresultDataAccessObjects.SaveList(IList<tran_psychoexamresultEntity> listAdded, IList<tran_psychoexamresultEntity> listUpdated, IList<tran_psychoexamresultEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_psychoexamresult_Ins";
            const string SPUpdate = "tran_psychoexamresult_Upd";
            const string SPDelete = "tran_psychoexamresult_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_psychoexamresultEntity tran_psychoexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_psychoexamresult, cmd, Database, true);
                            FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_psychoexamresultEntity tran_psychoexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_psychoexamresult, cmd, Database);
                            FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_psychoexamresultEntity tran_psychoexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_psychoexamresult, cmd, Database);
                            FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.Save_tran_psychoexamresult"));
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
       IList<tran_psychoexamresultEntity> listAdded, 
       IList<tran_psychoexamresultEntity> listUpdated, 
       IList<tran_psychoexamresultEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_psychoexamresult_Ins";
            const string SPUpdate = "tran_psychoexamresult_Upd";
            const string SPDelete = "tran_psychoexamresult_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_psychoexamresultEntity tran_psychoexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_psychoexamresult, cmd, db, true);
                            FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_psychoexamresultEntity tran_psychoexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_psychoexamresult, cmd, db);
                            FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_psychoexamresultEntity tran_psychoexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_psychoexamresult, cmd, db);
                            FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.Save_tran_psychoexamresult"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_psychoexamresultEntity>> Itran_psychoexamresultDataAccessObjects.GetAll(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_psychoexamresult_GA";
                IList<tran_psychoexamresultEntity> itemList = new List<tran_psychoexamresultEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_psychoexamresult.SortExpression);
                    FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_psychoexamresult, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_psychoexamresultEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.GetAlltran_psychoexamresult"));
            }	
        }
		
        async Task<IList<tran_psychoexamresultEntity>> Itran_psychoexamresultDataAccessObjects.GetAllByPages(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_psychoexamresult_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_psychoexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_psychoexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_psychoexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_psychoexamresult, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_psychoexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_psychoexamresult.strCommonSerachParam+"%");

                    IList<tran_psychoexamresultEntity> itemList = new List<tran_psychoexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_psychoexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_psychoexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.GetAllByPagestran_psychoexamresult"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_psychoexamresultEntity> Itran_psychoexamresultDataAccessObjects.GetSingle(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_psychoexamresult_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_psychoexamresult, cmd, Database);
                    
                    IList<tran_psychoexamresultEntity> itemList = new List<tran_psychoexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_psychoexamresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.GetSingletran_psychoexamresult"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_psychoexamresultEntity>> Itran_psychoexamresultDataAccessObjects.GAPgListView(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_psychoexamresult_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_psychoexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_psychoexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_psychoexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_psychoexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_psychoexamresult, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_psychoexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_psychoexamresult.strCommonSerachParam+"%");

                    IList<tran_psychoexamresultEntity> itemList = new List<tran_psychoexamresultEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_psychoexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_psychoexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_psychoexamresultDataAccess.GAPgListViewtran_psychoexamresult"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}