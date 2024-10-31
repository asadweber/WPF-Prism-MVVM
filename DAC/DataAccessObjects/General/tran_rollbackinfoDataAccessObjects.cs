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
	
	internal sealed partial class tran_rollbackinfoDataAccessObjects : BaseDataAccess, Itran_rollbackinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_rollbackinfoDataAccessObjects";
        
		public tran_rollbackinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_rollbackinfoEntity tran_rollbackinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_rollbackinfo.rollbackid.HasValue)
				Database.AddInParameter(cmd, "@RollbackID", DbType.Int64, tran_rollbackinfo.rollbackid);
            if (forDelete) return;
			if (tran_rollbackinfo.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_rollbackinfo.basicinfoid);
			if (tran_rollbackinfo.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_rollbackinfo.registrationid);
			if (tran_rollbackinfo.type.HasValue)
				Database.AddInParameter(cmd, "@Type", DbType.Int64, tran_rollbackinfo.type);
			if ((tran_rollbackinfo.trandate.HasValue))
				Database.AddInParameter(cmd, "@TranDate", DbType.DateTime, tran_rollbackinfo.trandate);
			if (!(string.IsNullOrEmpty(tran_rollbackinfo.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, tran_rollbackinfo.comment);
			if (!(string.IsNullOrEmpty(tran_rollbackinfo.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_rollbackinfo.remarks);
			if (!(string.IsNullOrEmpty(tran_rollbackinfo.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_rollbackinfo.updateinfo);
			if (tran_rollbackinfo.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_rollbackinfo.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_rollbackinfoDataAccessObjects.Add(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_rollbackinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_rollbackinfo, cmd,Database);
                FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.Addtran_rollbackinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_rollbackinfoDataAccessObjects.Update(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_rollbackinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_rollbackinfo, cmd,Database);
                FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.Updatetran_rollbackinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_rollbackinfoDataAccessObjects.Delete(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_rollbackinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_rollbackinfo, cmd,Database, true);
                FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.Deletetran_rollbackinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_rollbackinfoDataAccessObjects.SaveList(IList<tran_rollbackinfoEntity> listAdded, IList<tran_rollbackinfoEntity> listUpdated, IList<tran_rollbackinfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_rollbackinfo_Ins";
            const string SPUpdate = "tran_rollbackinfo_Upd";
            const string SPDelete = "tran_rollbackinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_rollbackinfoEntity tran_rollbackinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_rollbackinfo, cmd, Database, true);
                            FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_rollbackinfoEntity tran_rollbackinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_rollbackinfo, cmd, Database);
                            FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_rollbackinfoEntity tran_rollbackinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_rollbackinfo, cmd, Database);
                            FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.Save_tran_rollbackinfo"));
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
       IList<tran_rollbackinfoEntity> listAdded, 
       IList<tran_rollbackinfoEntity> listUpdated, 
       IList<tran_rollbackinfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_rollbackinfo_Ins";
            const string SPUpdate = "tran_rollbackinfo_Upd";
            const string SPDelete = "tran_rollbackinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_rollbackinfoEntity tran_rollbackinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_rollbackinfo, cmd, db, true);
                            FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, db);
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
                    foreach (tran_rollbackinfoEntity tran_rollbackinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_rollbackinfo, cmd, db);
                            FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, db);
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
                    foreach (tran_rollbackinfoEntity tran_rollbackinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_rollbackinfo, cmd, db);
                            FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.Save_tran_rollbackinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoDataAccessObjects.GetAll(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_rollbackinfo_GA";
                IList<tran_rollbackinfoEntity> itemList = new List<tran_rollbackinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_rollbackinfo.SortExpression);
                    FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_rollbackinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_rollbackinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.GetAlltran_rollbackinfo"));
            }	
        }
		
        async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoDataAccessObjects.GetAllByPages(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_rollbackinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_rollbackinfo.SortExpression);
                    AddPageSizeParameter(cmd, tran_rollbackinfo.PageSize);
                    AddCurrentPageParameter(cmd, tran_rollbackinfo.CurrentPage);                    
                    FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_rollbackinfo, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_rollbackinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_rollbackinfo.strCommonSerachParam+"%");

                    IList<tran_rollbackinfoEntity> itemList = new List<tran_rollbackinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_rollbackinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_rollbackinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.GetAllByPagestran_rollbackinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_rollbackinfoEntity> Itran_rollbackinfoDataAccessObjects.GetSingle(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_rollbackinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_rollbackinfo, cmd, Database);
                    
                    IList<tran_rollbackinfoEntity> itemList = new List<tran_rollbackinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_rollbackinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.GetSingletran_rollbackinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoDataAccessObjects.GAPgListView(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_rollbackinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_rollbackinfo.SortExpression);
                    AddPageSizeParameter(cmd, tran_rollbackinfo.PageSize);
                    AddCurrentPageParameter(cmd, tran_rollbackinfo.CurrentPage);                    
                    FillSequrityParameters(tran_rollbackinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_rollbackinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_rollbackinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_rollbackinfo.strCommonSerachParam+"%");

                    IList<tran_rollbackinfoEntity> itemList = new List<tran_rollbackinfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_rollbackinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_rollbackinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_rollbackinfoDataAccess.GAPgListViewtran_rollbackinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}