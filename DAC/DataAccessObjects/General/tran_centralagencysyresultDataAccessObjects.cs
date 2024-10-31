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
	
	internal sealed partial class tran_centralagencysyresultDataAccessObjects : BaseDataAccess, Itran_centralagencysyresultDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_centralagencysyresultDataAccessObjects";
        
		public tran_centralagencysyresultDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_centralagencysyresultEntity tran_centralagencysyresult, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_centralagencysyresult.centralagencysyid.HasValue)
				Database.AddInParameter(cmd, "@CentralAgencySyID", DbType.Int64, tran_centralagencysyresult.centralagencysyid);
            if (forDelete) return;
			if (tran_centralagencysyresult.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_centralagencysyresult.basicinfoid);
			if (tran_centralagencysyresult.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_centralagencysyresult.registrationid);
			if ((tran_centralagencysyresult.centralagencysyresult != null))
				Database.AddInParameter(cmd, "@CentralAgencySyResult", DbType.Boolean, tran_centralagencysyresult.centralagencysyresult);
			if (!(string.IsNullOrEmpty(tran_centralagencysyresult.centralagencysycomment)))
				Database.AddInParameter(cmd, "@CentralAgencySyComment", DbType.String, tran_centralagencysyresult.centralagencysycomment);
			if ((tran_centralagencysyresult.centralagencysyresultdate.HasValue))
				Database.AddInParameter(cmd, "@CentralAgencySyResultDate", DbType.DateTime, tran_centralagencysyresult.centralagencysyresultdate);
			if (!(string.IsNullOrEmpty(tran_centralagencysyresult.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_centralagencysyresult.remarks);
			if ((tran_centralagencysyresult.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_centralagencysyresult.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_centralagencysyresult.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_centralagencysyresult.updateinfo);
			if (tran_centralagencysyresult.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_centralagencysyresult.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_centralagencysyresultDataAccessObjects.Add(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_centralagencysyresult_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_centralagencysyresult, cmd,Database);
                FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.Addtran_centralagencysyresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_centralagencysyresultDataAccessObjects.Update(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_centralagencysyresult_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_centralagencysyresult, cmd,Database);
                FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.Updatetran_centralagencysyresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_centralagencysyresultDataAccessObjects.Delete(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_centralagencysyresult_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_centralagencysyresult, cmd,Database, true);
                FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.Deletetran_centralagencysyresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_centralagencysyresultDataAccessObjects.SaveList(IList<tran_centralagencysyresultEntity> listAdded, IList<tran_centralagencysyresultEntity> listUpdated, IList<tran_centralagencysyresultEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_centralagencysyresult_Ins";
            const string SPUpdate = "tran_centralagencysyresult_Upd";
            const string SPDelete = "tran_centralagencysyresult_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_centralagencysyresultEntity tran_centralagencysyresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_centralagencysyresult, cmd, Database, true);
                            FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_centralagencysyresultEntity tran_centralagencysyresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_centralagencysyresult, cmd, Database);
                            FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_centralagencysyresultEntity tran_centralagencysyresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_centralagencysyresult, cmd, Database);
                            FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.Save_tran_centralagencysyresult"));
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
       IList<tran_centralagencysyresultEntity> listAdded, 
       IList<tran_centralagencysyresultEntity> listUpdated, 
       IList<tran_centralagencysyresultEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_centralagencysyresult_Ins";
            const string SPUpdate = "tran_centralagencysyresult_Upd";
            const string SPDelete = "tran_centralagencysyresult_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_centralagencysyresultEntity tran_centralagencysyresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_centralagencysyresult, cmd, db, true);
                            FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_centralagencysyresultEntity tran_centralagencysyresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_centralagencysyresult, cmd, db);
                            FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_centralagencysyresultEntity tran_centralagencysyresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_centralagencysyresult, cmd, db);
                            FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.Save_tran_centralagencysyresult"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_centralagencysyresultEntity>> Itran_centralagencysyresultDataAccessObjects.GetAll(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_centralagencysyresult_GA";
                IList<tran_centralagencysyresultEntity> itemList = new List<tran_centralagencysyresultEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_centralagencysyresult.SortExpression);
                    FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_centralagencysyresult, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_centralagencysyresultEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.GetAlltran_centralagencysyresult"));
            }	
        }
		
        async Task<IList<tran_centralagencysyresultEntity>> Itran_centralagencysyresultDataAccessObjects.GetAllByPages(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_centralagencysyresult_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_centralagencysyresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_centralagencysyresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_centralagencysyresult.CurrentPage);                    
                    FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_centralagencysyresult, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_centralagencysyresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_centralagencysyresult.strCommonSerachParam+"%");

                    IList<tran_centralagencysyresultEntity> itemList = new List<tran_centralagencysyresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_centralagencysyresultEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_centralagencysyresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.GetAllByPagestran_centralagencysyresult"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_centralagencysyresultEntity> Itran_centralagencysyresultDataAccessObjects.GetSingle(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_centralagencysyresult_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_centralagencysyresult, cmd, Database);
                    
                    IList<tran_centralagencysyresultEntity> itemList = new List<tran_centralagencysyresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_centralagencysyresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.GetSingletran_centralagencysyresult"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_centralagencysyresultEntity>> Itran_centralagencysyresultDataAccessObjects.GAPgListView(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_centralagencysyresult_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_centralagencysyresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_centralagencysyresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_centralagencysyresult.CurrentPage);                    
                    FillSequrityParameters(tran_centralagencysyresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_centralagencysyresult, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_centralagencysyresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_centralagencysyresult.strCommonSerachParam+"%");

                    IList<tran_centralagencysyresultEntity> itemList = new List<tran_centralagencysyresultEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_centralagencysyresultEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_centralagencysyresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_centralagencysyresultDataAccess.GAPgListViewtran_centralagencysyresult"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}