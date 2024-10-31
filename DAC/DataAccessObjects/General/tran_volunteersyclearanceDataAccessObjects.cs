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
	
	internal sealed partial class tran_volunteersyclearanceDataAccessObjects : BaseDataAccess, Itran_volunteersyclearanceDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_volunteersyclearanceDataAccessObjects";
        
		public tran_volunteersyclearanceDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_volunteersyclearanceEntity tran_volunteersyclearance, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_volunteersyclearance.volunteersyclearanceid.HasValue)
				Database.AddInParameter(cmd, "@VolunteerSyClearanceID", DbType.Int64, tran_volunteersyclearance.volunteersyclearanceid);
            if (forDelete) return;
			if (tran_volunteersyclearance.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_volunteersyclearance.basicinfoid);
			if (tran_volunteersyclearance.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_volunteersyclearance.registrationid);
            if (tran_volunteersyclearance.syclearanceresult.HasValue)
                Database.AddInParameter(cmd, "@SyClearanceResult", DbType.Int32, tran_volunteersyclearance.syclearanceresult);
            if (!(string.IsNullOrEmpty(tran_volunteersyclearance.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_volunteersyclearance.remarks);
			if ((tran_volunteersyclearance.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_volunteersyclearance.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_volunteersyclearance.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_volunteersyclearance.updateinfo);
			if (tran_volunteersyclearance.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_volunteersyclearance.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_volunteersyclearanceDataAccessObjects.Add(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_volunteersyclearance_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_volunteersyclearance, cmd,Database);
                FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.Addtran_volunteersyclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_volunteersyclearanceDataAccessObjects.Update(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_volunteersyclearance_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_volunteersyclearance, cmd,Database);
                FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.Updatetran_volunteersyclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_volunteersyclearanceDataAccessObjects.Delete(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_volunteersyclearance_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_volunteersyclearance, cmd,Database, true);
                FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.Deletetran_volunteersyclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_volunteersyclearanceDataAccessObjects.SaveList(IList<tran_volunteersyclearanceEntity> listAdded, IList<tran_volunteersyclearanceEntity> listUpdated, IList<tran_volunteersyclearanceEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_volunteersyclearance_Ins";
            const string SPUpdate = "tran_volunteersyclearance_Upd";
            const string SPDelete = "tran_volunteersyclearance_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_volunteersyclearanceEntity tran_volunteersyclearance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_volunteersyclearance, cmd, Database, true);
                            FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_volunteersyclearanceEntity tran_volunteersyclearance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_volunteersyclearance, cmd, Database);
                            FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_volunteersyclearanceEntity tran_volunteersyclearance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_volunteersyclearance, cmd, Database);
                            FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.Save_tran_volunteersyclearance"));
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
       IList<tran_volunteersyclearanceEntity> listAdded, 
       IList<tran_volunteersyclearanceEntity> listUpdated, 
       IList<tran_volunteersyclearanceEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_volunteersyclearance_Ins";
            const string SPUpdate = "tran_volunteersyclearance_Upd";
            const string SPDelete = "tran_volunteersyclearance_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_volunteersyclearanceEntity tran_volunteersyclearance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_volunteersyclearance, cmd, db, true);
                            FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, db);
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
                    foreach (tran_volunteersyclearanceEntity tran_volunteersyclearance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_volunteersyclearance, cmd, db);
                            FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, db);
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
                    foreach (tran_volunteersyclearanceEntity tran_volunteersyclearance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_volunteersyclearance, cmd, db);
                            FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.Save_tran_volunteersyclearance"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_volunteersyclearanceEntity>> Itran_volunteersyclearanceDataAccessObjects.GetAll(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_volunteersyclearance_GA";
                IList<tran_volunteersyclearanceEntity> itemList = new List<tran_volunteersyclearanceEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_volunteersyclearance.SortExpression);
                    FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteersyclearance, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteersyclearanceEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.GetAlltran_volunteersyclearance"));
            }	
        }
		
        async Task<IList<tran_volunteersyclearanceEntity>> Itran_volunteersyclearanceDataAccessObjects.GetAllByPages(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_volunteersyclearance_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_volunteersyclearance.SortExpression);
                    AddPageSizeParameter(cmd, tran_volunteersyclearance.PageSize);
                    AddCurrentPageParameter(cmd, tran_volunteersyclearance.CurrentPage);                    
                    FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_volunteersyclearance, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_volunteersyclearance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_volunteersyclearance.strCommonSerachParam+"%");

                    IList<tran_volunteersyclearanceEntity> itemList = new List<tran_volunteersyclearanceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteersyclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_volunteersyclearance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.GetAllByPagestran_volunteersyclearance"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_volunteersyclearanceEntity> Itran_volunteersyclearanceDataAccessObjects.GetSingle(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_volunteersyclearance_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteersyclearance, cmd, Database);
                    
                    IList<tran_volunteersyclearanceEntity> itemList = new List<tran_volunteersyclearanceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteersyclearanceEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.GetSingletran_volunteersyclearance"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_volunteersyclearanceEntity>> Itran_volunteersyclearanceDataAccessObjects.GAPgListView(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_volunteersyclearance_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_volunteersyclearance.SortExpression);
                    AddPageSizeParameter(cmd, tran_volunteersyclearance.PageSize);
                    AddCurrentPageParameter(cmd, tran_volunteersyclearance.CurrentPage);                    
                    FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_volunteersyclearance, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_volunteersyclearance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_volunteersyclearance.strCommonSerachParam+"%");

                    IList<tran_volunteersyclearanceEntity> itemList = new List<tran_volunteersyclearanceEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteersyclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_volunteersyclearance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.GAPgListViewtran_volunteersyclearance"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}