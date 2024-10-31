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
	
	internal sealed partial class tran_applicantretestapprovalDataAccessObjects : BaseDataAccess, Itran_applicantretestapprovalDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_applicantretestapprovalDataAccessObjects";
        
		public tran_applicantretestapprovalDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_applicantretestapprovalEntity tran_applicantretestapproval, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_applicantretestapproval.retestapprovalid.HasValue)
				Database.AddInParameter(cmd, "@ReTestApprovalID", DbType.Int64, tran_applicantretestapproval.retestapprovalid);
            if (forDelete) return;
			if (tran_applicantretestapproval.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_applicantretestapproval.basicinfoid);
			if (tran_applicantretestapproval.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_applicantretestapproval.registrationid);
			if (tran_applicantretestapproval.resulttypeid.HasValue)
				Database.AddInParameter(cmd, "@ResultTypeID", DbType.Int64, tran_applicantretestapproval.resulttypeid);
			if (!(string.IsNullOrEmpty(tran_applicantretestapproval.clearanceby)))
				Database.AddInParameter(cmd, "@ClearanceBy", DbType.String, tran_applicantretestapproval.clearanceby);
			if ((tran_applicantretestapproval.clearancedate.HasValue))
				Database.AddInParameter(cmd, "@ClearanceDate", DbType.DateTime, tran_applicantretestapproval.clearancedate);
			if (!(string.IsNullOrEmpty(tran_applicantretestapproval.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_applicantretestapproval.remarks);
			if (tran_applicantretestapproval.statusid.HasValue)
				Database.AddInParameter(cmd, "@StatusID", DbType.Int64, tran_applicantretestapproval.statusid);
			if (!(string.IsNullOrEmpty(tran_applicantretestapproval.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_applicantretestapproval.updateinfo);
			if (tran_applicantretestapproval.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_applicantretestapproval.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_applicantretestapprovalDataAccessObjects.Add(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applicantretestapproval_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantretestapproval, cmd,Database);
                FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.Addtran_applicantretestapproval"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_applicantretestapprovalDataAccessObjects.Update(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_applicantretestapproval_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_applicantretestapproval, cmd,Database);
                FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.Updatetran_applicantretestapproval"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_applicantretestapprovalDataAccessObjects.Delete(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_applicantretestapproval_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_applicantretestapproval, cmd,Database, true);
                FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.Deletetran_applicantretestapproval"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_applicantretestapprovalDataAccessObjects.SaveList(IList<tran_applicantretestapprovalEntity> listAdded, IList<tran_applicantretestapprovalEntity> listUpdated, IList<tran_applicantretestapprovalEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_applicantretestapproval_Ins";
            const string SPUpdate = "tran_applicantretestapproval_Upd";
            const string SPDelete = "tran_applicantretestapproval_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantretestapprovalEntity tran_applicantretestapproval in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantretestapproval, cmd, Database, true);
                            FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantretestapprovalEntity tran_applicantretestapproval in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantretestapproval, cmd, Database);
                            FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantretestapprovalEntity tran_applicantretestapproval in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantretestapproval, cmd, Database);
                            FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.Save_tran_applicantretestapproval"));
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
       IList<tran_applicantretestapprovalEntity> listAdded, 
       IList<tran_applicantretestapprovalEntity> listUpdated, 
       IList<tran_applicantretestapprovalEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_applicantretestapproval_Ins";
            const string SPUpdate = "tran_applicantretestapproval_Upd";
            const string SPDelete = "tran_applicantretestapproval_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantretestapprovalEntity tran_applicantretestapproval in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantretestapproval, cmd, db, true);
                            FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantretestapprovalEntity tran_applicantretestapproval in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantretestapproval, cmd, db);
                            FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantretestapprovalEntity tran_applicantretestapproval in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantretestapproval, cmd, db);
                            FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.Save_tran_applicantretestapproval"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_applicantretestapprovalEntity>> Itran_applicantretestapprovalDataAccessObjects.GetAll(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantretestapproval_GA";
                IList<tran_applicantretestapprovalEntity> itemList = new List<tran_applicantretestapprovalEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_applicantretestapproval.SortExpression);
                    FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantretestapproval, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantretestapprovalEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.GetAlltran_applicantretestapproval"));
            }	
        }
		
        async Task<IList<tran_applicantretestapprovalEntity>> Itran_applicantretestapprovalDataAccessObjects.GetAllByPages(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantretestapproval_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantretestapproval.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantretestapproval.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantretestapproval.CurrentPage);                    
                    FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantretestapproval, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_applicantretestapproval.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantretestapproval.strCommonSerachParam+"%");

                    IList<tran_applicantretestapprovalEntity> itemList = new List<tran_applicantretestapprovalEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantretestapprovalEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantretestapproval.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.GetAllByPagestran_applicantretestapproval"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_applicantretestapprovalEntity> Itran_applicantretestapprovalDataAccessObjects.GetSingle(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantretestapproval_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantretestapproval, cmd, Database);
                    
                    IList<tran_applicantretestapprovalEntity> itemList = new List<tran_applicantretestapprovalEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantretestapprovalEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.GetSingletran_applicantretestapproval"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_applicantretestapprovalEntity>> Itran_applicantretestapprovalDataAccessObjects.GAPgListView(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantretestapproval_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantretestapproval.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantretestapproval.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantretestapproval.CurrentPage);                    
                    FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantretestapproval, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_applicantretestapproval.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantretestapproval.strCommonSerachParam+"%");

                    IList<tran_applicantretestapprovalEntity> itemList = new List<tran_applicantretestapprovalEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantretestapprovalEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantretestapproval.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.GAPgListViewtran_applicantretestapproval"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}