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
	
	internal sealed partial class tran_unitclearanceresultDataAccessObjects : BaseDataAccess, Itran_unitclearanceresultDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_unitclearanceresultDataAccessObjects";
        
		public tran_unitclearanceresultDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_unitclearanceresultEntity tran_unitclearanceresult, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_unitclearanceresult.unitclearanceresultid.HasValue)
				Database.AddInParameter(cmd, "@UnitClearanceResultID", DbType.Int64, tran_unitclearanceresult.unitclearanceresultid);
            if (forDelete) return;
			if (tran_unitclearanceresult.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_unitclearanceresult.basicinfoid);
			if (tran_unitclearanceresult.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_unitclearanceresult.registrationid);
			if (tran_unitclearanceresult.unitclearanceresult.HasValue)
				Database.AddInParameter(cmd, "@UnitClearanceResult", DbType.Int32, tran_unitclearanceresult.unitclearanceresult);
			if (!(string.IsNullOrEmpty(tran_unitclearanceresult.unitclearancecomment)))
				Database.AddInParameter(cmd, "@UnitClearanceComment", DbType.String, tran_unitclearanceresult.unitclearancecomment);
			if ((tran_unitclearanceresult.unitclearanceresultdate.HasValue))
				Database.AddInParameter(cmd, "@UnitClearanceResultDate", DbType.DateTime, tran_unitclearanceresult.unitclearanceresultdate);
			
				Database.AddInParameter(cmd, "@UnitClearanceMarks", DbType.Decimal, tran_unitclearanceresult.unitclearancemarks);
			if (!(string.IsNullOrEmpty(tran_unitclearanceresult.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_unitclearanceresult.remarks);
			if ((tran_unitclearanceresult.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_unitclearanceresult.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_unitclearanceresult.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_unitclearanceresult.updateinfo);
			if (tran_unitclearanceresult.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_unitclearanceresult.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_unitclearanceresultDataAccessObjects.Add(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_unitclearanceresult_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_unitclearanceresult, cmd,Database);
                FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.Addtran_unitclearanceresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_unitclearanceresultDataAccessObjects.Update(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_unitclearanceresult_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_unitclearanceresult, cmd,Database);
                FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.Updatetran_unitclearanceresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_unitclearanceresultDataAccessObjects.Delete(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_unitclearanceresult_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_unitclearanceresult, cmd,Database, true);
                FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.Deletetran_unitclearanceresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_unitclearanceresultDataAccessObjects.SaveList(IList<tran_unitclearanceresultEntity> listAdded, IList<tran_unitclearanceresultEntity> listUpdated, IList<tran_unitclearanceresultEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_unitclearanceresult_Ins";
            const string SPUpdate = "tran_unitclearanceresult_Upd";
            const string SPDelete = "tran_unitclearanceresult_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_unitclearanceresultEntity tran_unitclearanceresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_unitclearanceresult, cmd, Database, true);
                            FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_unitclearanceresultEntity tran_unitclearanceresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_unitclearanceresult, cmd, Database);
                            FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_unitclearanceresultEntity tran_unitclearanceresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_unitclearanceresult, cmd, Database);
                            FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.Save_tran_unitclearanceresult"));
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
       IList<tran_unitclearanceresultEntity> listAdded, 
       IList<tran_unitclearanceresultEntity> listUpdated, 
       IList<tran_unitclearanceresultEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_unitclearanceresult_Ins";
            const string SPUpdate = "tran_unitclearanceresult_Upd";
            const string SPDelete = "tran_unitclearanceresult_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_unitclearanceresultEntity tran_unitclearanceresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_unitclearanceresult, cmd, db, true);
                            FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_unitclearanceresultEntity tran_unitclearanceresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_unitclearanceresult, cmd, db);
                            FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_unitclearanceresultEntity tran_unitclearanceresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_unitclearanceresult, cmd, db);
                            FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.Save_tran_unitclearanceresult"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_unitclearanceresultEntity>> Itran_unitclearanceresultDataAccessObjects.GetAll(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_unitclearanceresult_GA";
                IList<tran_unitclearanceresultEntity> itemList = new List<tran_unitclearanceresultEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_unitclearanceresult.SortExpression);
                    FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_unitclearanceresult, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_unitclearanceresultEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.GetAlltran_unitclearanceresult"));
            }	
        }
		
        async Task<IList<tran_unitclearanceresultEntity>> Itran_unitclearanceresultDataAccessObjects.GetAllByPages(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_unitclearanceresult_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_unitclearanceresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_unitclearanceresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_unitclearanceresult.CurrentPage);                    
                    FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_unitclearanceresult, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_unitclearanceresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_unitclearanceresult.strCommonSerachParam+"%");

                    IList<tran_unitclearanceresultEntity> itemList = new List<tran_unitclearanceresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_unitclearanceresultEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_unitclearanceresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.GetAllByPagestran_unitclearanceresult"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_unitclearanceresultEntity> Itran_unitclearanceresultDataAccessObjects.GetSingle(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_unitclearanceresult_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_unitclearanceresult, cmd, Database);
                    
                    IList<tran_unitclearanceresultEntity> itemList = new List<tran_unitclearanceresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_unitclearanceresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.GetSingletran_unitclearanceresult"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_unitclearanceresultEntity>> Itran_unitclearanceresultDataAccessObjects.GAPgListView(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_unitclearanceresult_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_unitclearanceresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_unitclearanceresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_unitclearanceresult.CurrentPage);                    
                    FillSequrityParameters(tran_unitclearanceresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_unitclearanceresult, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_unitclearanceresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_unitclearanceresult.strCommonSerachParam+"%");

                    IList<tran_unitclearanceresultEntity> itemList = new List<tran_unitclearanceresultEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_unitclearanceresultEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_unitclearanceresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_unitclearanceresultDataAccess.GAPgListViewtran_unitclearanceresult"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}