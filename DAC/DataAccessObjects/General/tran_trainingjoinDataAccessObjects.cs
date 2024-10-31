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
	
	internal sealed partial class tran_trainingjoinDataAccessObjects : BaseDataAccess, Itran_trainingjoinDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_trainingjoinDataAccessObjects";
        
		public tran_trainingjoinDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_trainingjoinEntity tran_trainingjoin, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_trainingjoin.trgjoinid.HasValue)
				Database.AddInParameter(cmd, "@TrgJoinID", DbType.Int64, tran_trainingjoin.trgjoinid);
            if (forDelete) return;
			if (tran_trainingjoin.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_trainingjoin.basicinfoid);
			if (tran_trainingjoin.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_trainingjoin.registrationid);
			if (tran_trainingjoin.trgcentreid.HasValue)
				Database.AddInParameter(cmd, "@TrgCentreID", DbType.Int64, tran_trainingjoin.trgcentreid);
			if ((tran_trainingjoin.joindate.HasValue))
				Database.AddInParameter(cmd, "@JoinDate", DbType.DateTime, tran_trainingjoin.joindate);
			if (tran_trainingjoin.volunteerno.HasValue)
				Database.AddInParameter(cmd, "@VolunteerNo", DbType.Int64, tran_trainingjoin.volunteerno);
			if (!(string.IsNullOrEmpty(tran_trainingjoin.groupno)))
				Database.AddInParameter(cmd, "@GroupNo", DbType.String, tran_trainingjoin.groupno);
			if (tran_trainingjoin.joiningbatchid.HasValue)
				Database.AddInParameter(cmd, "@JoiningBatchID", DbType.Int64, tran_trainingjoin.joiningbatchid);
            if (!(string.IsNullOrEmpty(tran_trainingjoin.orderno)))
                Database.AddInParameter(cmd, "@OrderNo", DbType.String, tran_trainingjoin.orderno);
            if (tran_trainingjoin.orderdate.HasValue)
                Database.AddInParameter(cmd, "@OrderDate", DbType.DateTime, tran_trainingjoin.orderdate);
            if (!(string.IsNullOrEmpty(tran_trainingjoin.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_trainingjoin.remarks);
			if ((tran_trainingjoin.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_trainingjoin.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_trainingjoin.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_trainingjoin.updateinfo);
			if (tran_trainingjoin.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_trainingjoin.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_trainingjoinDataAccessObjects.Add(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_trainingjoin_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_trainingjoin, cmd,Database);
                FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.Addtran_trainingjoin"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_trainingjoinDataAccessObjects.Update(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_trainingjoin_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_trainingjoin, cmd,Database);
                FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.Updatetran_trainingjoin"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_trainingjoinDataAccessObjects.Delete(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_trainingjoin_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_trainingjoin, cmd,Database, true);
                FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.Deletetran_trainingjoin"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_trainingjoinDataAccessObjects.SaveList(IList<tran_trainingjoinEntity> listAdded, IList<tran_trainingjoinEntity> listUpdated, IList<tran_trainingjoinEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_trainingjoin_Ins";
            const string SPUpdate = "tran_trainingjoin_Upd";
            const string SPDelete = "tran_trainingjoin_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_trainingjoinEntity tran_trainingjoin in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_trainingjoin, cmd, Database, true);
                            FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_trainingjoinEntity tran_trainingjoin in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_trainingjoin, cmd, Database);
                            FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_trainingjoinEntity tran_trainingjoin in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_trainingjoin, cmd, Database);
                            FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.Save_tran_trainingjoin"));
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
       IList<tran_trainingjoinEntity> listAdded, 
       IList<tran_trainingjoinEntity> listUpdated, 
       IList<tran_trainingjoinEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_trainingjoin_Ins";
            const string SPUpdate = "tran_trainingjoin_Upd";
            const string SPDelete = "tran_trainingjoin_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_trainingjoinEntity tran_trainingjoin in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_trainingjoin, cmd, db, true);
                            FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, db);
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
                    foreach (tran_trainingjoinEntity tran_trainingjoin in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_trainingjoin, cmd, db);
                            FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, db);
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
                    foreach (tran_trainingjoinEntity tran_trainingjoin in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_trainingjoin, cmd, db);
                            FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.Save_tran_trainingjoin"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_trainingjoinEntity>> Itran_trainingjoinDataAccessObjects.GetAll(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_trainingjoin_GA";
                IList<tran_trainingjoinEntity> itemList = new List<tran_trainingjoinEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_trainingjoin.SortExpression);
                    FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_trainingjoin, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.GetAlltran_trainingjoin"));
            }	
        }
		
        async Task<IList<tran_trainingjoinEntity>> Itran_trainingjoinDataAccessObjects.GetAllByPages(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_trainingjoin_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_trainingjoin.SortExpression);
                    AddPageSizeParameter(cmd, tran_trainingjoin.PageSize);
                    AddCurrentPageParameter(cmd, tran_trainingjoin.CurrentPage);                    
                    FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_trainingjoin, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_trainingjoin.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_trainingjoin.strCommonSerachParam+"%");

                    IList<tran_trainingjoinEntity> itemList = new List<tran_trainingjoinEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_trainingjoin.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.GetAllByPagestran_trainingjoin"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_trainingjoinEntity> Itran_trainingjoinDataAccessObjects.GetSingle(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_trainingjoin_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_trainingjoin, cmd, Database);
                    
                    IList<tran_trainingjoinEntity> itemList = new List<tran_trainingjoinEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.GetSingletran_trainingjoin"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_trainingjoinEntity>> Itran_trainingjoinDataAccessObjects.GAPgListView(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_trainingjoin_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_trainingjoin.SortExpression);
                    AddPageSizeParameter(cmd, tran_trainingjoin.PageSize);
                    AddCurrentPageParameter(cmd, tran_trainingjoin.CurrentPage);                    
                    FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_trainingjoin, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_trainingjoin.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_trainingjoin.strCommonSerachParam+"%");

                    IList<tran_trainingjoinEntity> itemList = new List<tran_trainingjoinEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_trainingjoin.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.GAPgListViewtran_trainingjoin"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}