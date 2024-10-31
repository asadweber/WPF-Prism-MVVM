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
	
	internal sealed partial class tran_medexamresultDataAccessObjects : BaseDataAccess, Itran_medexamresultDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_medexamresultDataAccessObjects";
        
		public tran_medexamresultDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_medexamresultEntity tran_medexamresult, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_medexamresult.medexamresultid.HasValue)
				Database.AddInParameter(cmd, "@MedExamResultID", DbType.Int64, tran_medexamresult.medexamresultid);
            if (forDelete) return;
			if (tran_medexamresult.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_medexamresult.basicinfoid);
			if (tran_medexamresult.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_medexamresult.registrationid);
			if (tran_medexamresult.medexamresult.HasValue)
				Database.AddInParameter(cmd, "@MedExamResult", DbType.Int32, tran_medexamresult.medexamresult);
			if (!(string.IsNullOrEmpty(tran_medexamresult.medexamcomment)))
				Database.AddInParameter(cmd, "@MedExamComment", DbType.String, tran_medexamresult.medexamcomment);
			if ((tran_medexamresult.medexamresultdate.HasValue))
				Database.AddInParameter(cmd, "@MedExamResultDate", DbType.DateTime, tran_medexamresult.medexamresultdate);
			if (!(string.IsNullOrEmpty(tran_medexamresult.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_medexamresult.remarks);
			if ((tran_medexamresult.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_medexamresult.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_medexamresult.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_medexamresult.updateinfo);
			if (tran_medexamresult.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_medexamresult.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_medexamresultDataAccessObjects.Add(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_medexamresult_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_medexamresult, cmd,Database);
                FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.Addtran_medexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_medexamresultDataAccessObjects.Update(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_medexamresult_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_medexamresult, cmd,Database);
                FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.Updatetran_medexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_medexamresultDataAccessObjects.Delete(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_medexamresult_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_medexamresult, cmd,Database, true);
                FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.Deletetran_medexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_medexamresultDataAccessObjects.SaveList(IList<tran_medexamresultEntity> listAdded, IList<tran_medexamresultEntity> listUpdated, IList<tran_medexamresultEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_medexamresult_Ins";
            const string SPUpdate = "tran_medexamresult_Upd";
            const string SPDelete = "tran_medexamresult_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_medexamresultEntity tran_medexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_medexamresult, cmd, Database, true);
                            FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_medexamresultEntity tran_medexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_medexamresult, cmd, Database);
                            FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_medexamresultEntity tran_medexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_medexamresult, cmd, Database);
                            FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.Save_tran_medexamresult"));
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
       IList<tran_medexamresultEntity> listAdded, 
       IList<tran_medexamresultEntity> listUpdated, 
       IList<tran_medexamresultEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_medexamresult_Ins";
            const string SPUpdate = "tran_medexamresult_Upd";
            const string SPDelete = "tran_medexamresult_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_medexamresultEntity tran_medexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_medexamresult, cmd, db, true);
                            FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_medexamresultEntity tran_medexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_medexamresult, cmd, db);
                            FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_medexamresultEntity tran_medexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_medexamresult, cmd, db);
                            FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.Save_tran_medexamresult"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_medexamresultEntity>> Itran_medexamresultDataAccessObjects.GetAll(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_medexamresult_GA";
                IList<tran_medexamresultEntity> itemList = new List<tran_medexamresultEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_medexamresult.SortExpression);
                    FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_medexamresult, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamresultEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.GetAlltran_medexamresult"));
            }	
        }
		
        async Task<IList<tran_medexamresultEntity>> Itran_medexamresultDataAccessObjects.GetAllByPages(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_medexamresult_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_medexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_medexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_medexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_medexamresult, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_medexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_medexamresult.strCommonSerachParam+"%");

                    IList<tran_medexamresultEntity> itemList = new List<tran_medexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_medexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.GetAllByPagestran_medexamresult"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_medexamresultEntity> Itran_medexamresultDataAccessObjects.GetSingle(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_medexamresult_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_medexamresult, cmd, Database);
                    
                    IList<tran_medexamresultEntity> itemList = new List<tran_medexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.GetSingletran_medexamresult"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_medexamresultEntity>> Itran_medexamresultDataAccessObjects.GAPgListView(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_medexamresult_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_medexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_medexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_medexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_medexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_medexamresult, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_medexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_medexamresult.strCommonSerachParam+"%");

                    IList<tran_medexamresultEntity> itemList = new List<tran_medexamresultEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_medexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamresultDataAccess.GAPgListViewtran_medexamresult"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}