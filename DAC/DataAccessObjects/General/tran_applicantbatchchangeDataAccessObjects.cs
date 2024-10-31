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
	
	internal sealed partial class tran_applicantbatchchangeDataAccessObjects : BaseDataAccess, Itran_applicantbatchchangeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_applicantbatchchangeDataAccessObjects";
        
		public tran_applicantbatchchangeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_applicantbatchchangeEntity tran_applicantbatchchange, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_applicantbatchchange.batchchangeid.HasValue)
				Database.AddInParameter(cmd, "@BatchChangeID", DbType.Int64, tran_applicantbatchchange.batchchangeid);
            if (forDelete) return;
			if (tran_applicantbatchchange.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_applicantbatchchange.basicinfoid);
			if (tran_applicantbatchchange.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_applicantbatchchange.registrationid);
			if (tran_applicantbatchchange.joindate.HasValue)
				Database.AddInParameter(cmd, "@JoinDate", DbType.DateTime, tran_applicantbatchchange.joindate);
			if (tran_applicantbatchchange.volunteerno.HasValue)
				Database.AddInParameter(cmd, "@VolunteerNo", DbType.Int64, tran_applicantbatchchange.volunteerno);
			if (!(string.IsNullOrEmpty(tran_applicantbatchchange.groupno)))
				Database.AddInParameter(cmd, "@GroupNo", DbType.String, tran_applicantbatchchange.groupno);
			if (tran_applicantbatchchange.batchid.HasValue)
				Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_applicantbatchchange.batchid);
			if (!(string.IsNullOrEmpty(tran_applicantbatchchange.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_applicantbatchchange.remarks);
			if ((tran_applicantbatchchange.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_applicantbatchchange.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_applicantbatchchange.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_applicantbatchchange.updateinfo);
			if (tran_applicantbatchchange.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_applicantbatchchange.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_applicantbatchchangeDataAccessObjects.Add(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applicantbatchchange_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantbatchchange, cmd,Database);
                FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.Addtran_applicantbatchchange"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_applicantbatchchangeDataAccessObjects.Update(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_applicantbatchchange_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_applicantbatchchange, cmd,Database);
                FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.Updatetran_applicantbatchchange"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_applicantbatchchangeDataAccessObjects.Delete(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_applicantbatchchange_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_applicantbatchchange, cmd,Database, true);
                FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.Deletetran_applicantbatchchange"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_applicantbatchchangeDataAccessObjects.SaveList(IList<tran_applicantbatchchangeEntity> listAdded, IList<tran_applicantbatchchangeEntity> listUpdated, IList<tran_applicantbatchchangeEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_applicantbatchchange_Ins";
            const string SPUpdate = "tran_applicantbatchchange_Upd";
            const string SPDelete = "tran_applicantbatchchange_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantbatchchangeEntity tran_applicantbatchchange in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantbatchchange, cmd, Database, true);
                            FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantbatchchangeEntity tran_applicantbatchchange in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantbatchchange, cmd, Database);
                            FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantbatchchangeEntity tran_applicantbatchchange in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantbatchchange, cmd, Database);
                            FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.Save_tran_applicantbatchchange"));
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
       IList<tran_applicantbatchchangeEntity> listAdded, 
       IList<tran_applicantbatchchangeEntity> listUpdated, 
       IList<tran_applicantbatchchangeEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_applicantbatchchange_Ins";
            const string SPUpdate = "tran_applicantbatchchange_Upd";
            const string SPDelete = "tran_applicantbatchchange_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantbatchchangeEntity tran_applicantbatchchange in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantbatchchange, cmd, db, true);
                            FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantbatchchangeEntity tran_applicantbatchchange in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantbatchchange, cmd, db);
                            FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantbatchchangeEntity tran_applicantbatchchange in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantbatchchange, cmd, db);
                            FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.Save_tran_applicantbatchchange"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_applicantbatchchangeEntity>> Itran_applicantbatchchangeDataAccessObjects.GetAll(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantbatchchange_GA";
                IList<tran_applicantbatchchangeEntity> itemList = new List<tran_applicantbatchchangeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_applicantbatchchange.SortExpression);
                    FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantbatchchange, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantbatchchangeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.GetAlltran_applicantbatchchange"));
            }	
        }
		
        async Task<IList<tran_applicantbatchchangeEntity>> Itran_applicantbatchchangeDataAccessObjects.GetAllByPages(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantbatchchange_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantbatchchange.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantbatchchange.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantbatchchange.CurrentPage);                    
                    FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantbatchchange, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_applicantbatchchange.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantbatchchange.strCommonSerachParam+"%");

                    IList<tran_applicantbatchchangeEntity> itemList = new List<tran_applicantbatchchangeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantbatchchangeEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantbatchchange.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.GetAllByPagestran_applicantbatchchange"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_applicantbatchchangeEntity> Itran_applicantbatchchangeDataAccessObjects.GetSingle(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantbatchchange_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantbatchchange, cmd, Database);
                    
                    IList<tran_applicantbatchchangeEntity> itemList = new List<tran_applicantbatchchangeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantbatchchangeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.GetSingletran_applicantbatchchange"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_applicantbatchchangeEntity>> Itran_applicantbatchchangeDataAccessObjects.GAPgListView(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantbatchchange_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantbatchchange.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantbatchchange.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantbatchchange.CurrentPage);                    
                    FillSequrityParameters(tran_applicantbatchchange.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantbatchchange, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_applicantbatchchange.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantbatchchange.strCommonSerachParam+"%");

                    IList<tran_applicantbatchchangeEntity> itemList = new List<tran_applicantbatchchangeEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantbatchchangeEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantbatchchange.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantbatchchangeDataAccess.GAPgListViewtran_applicantbatchchange"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}