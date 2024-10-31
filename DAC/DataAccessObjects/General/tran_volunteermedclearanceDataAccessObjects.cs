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
	
	internal sealed partial class tran_volunteermedclearanceDataAccessObjects : BaseDataAccess, Itran_volunteermedclearanceDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_volunteermedclearanceDataAccessObjects";
        
		public tran_volunteermedclearanceDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_volunteermedclearanceEntity tran_volunteermedclearance, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_volunteermedclearance.volunteermedclearanceid.HasValue)
				Database.AddInParameter(cmd, "@VolunteerMedClearanceID", DbType.Int64, tran_volunteermedclearance.volunteermedclearanceid);
            if (forDelete) return;
			if (tran_volunteermedclearance.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_volunteermedclearance.basicinfoid);
			if (tran_volunteermedclearance.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_volunteermedclearance.registrationid);
			if (tran_volunteermedclearance.medclearanceresult.HasValue)
				Database.AddInParameter(cmd, "@MedClearanceResult", DbType.Int32, tran_volunteermedclearance.medclearanceresult);
			if (!(string.IsNullOrEmpty(tran_volunteermedclearance.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_volunteermedclearance.remarks);
			if ((tran_volunteermedclearance.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_volunteermedclearance.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_volunteermedclearance.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_volunteermedclearance.updateinfo);
			if (tran_volunteermedclearance.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_volunteermedclearance.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_volunteermedclearanceDataAccessObjects.Add(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_volunteermedclearance_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_volunteermedclearance, cmd,Database);
                FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.Addtran_volunteermedclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_volunteermedclearanceDataAccessObjects.Update(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_volunteermedclearance_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_volunteermedclearance, cmd,Database);
                FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.Updatetran_volunteermedclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_volunteermedclearanceDataAccessObjects.Delete(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_volunteermedclearance_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_volunteermedclearance, cmd,Database, true);
                FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.Deletetran_volunteermedclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_volunteermedclearanceDataAccessObjects.SaveList(IList<tran_volunteermedclearanceEntity> listAdded, IList<tran_volunteermedclearanceEntity> listUpdated, IList<tran_volunteermedclearanceEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_volunteermedclearance_Ins";
            const string SPUpdate = "tran_volunteermedclearance_Upd";
            const string SPDelete = "tran_volunteermedclearance_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_volunteermedclearanceEntity tran_volunteermedclearance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_volunteermedclearance, cmd, Database, true);
                            FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_volunteermedclearanceEntity tran_volunteermedclearance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_volunteermedclearance, cmd, Database);
                            FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_volunteermedclearanceEntity tran_volunteermedclearance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_volunteermedclearance, cmd, Database);
                            FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.Save_tran_volunteermedclearance"));
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
       IList<tran_volunteermedclearanceEntity> listAdded, 
       IList<tran_volunteermedclearanceEntity> listUpdated, 
       IList<tran_volunteermedclearanceEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_volunteermedclearance_Ins";
            const string SPUpdate = "tran_volunteermedclearance_Upd";
            const string SPDelete = "tran_volunteermedclearance_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_volunteermedclearanceEntity tran_volunteermedclearance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_volunteermedclearance, cmd, db, true);
                            FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, db);
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
                    foreach (tran_volunteermedclearanceEntity tran_volunteermedclearance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_volunteermedclearance, cmd, db);
                            FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, db);
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
                    foreach (tran_volunteermedclearanceEntity tran_volunteermedclearance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_volunteermedclearance, cmd, db);
                            FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.Save_tran_volunteermedclearance"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_volunteermedclearanceEntity>> Itran_volunteermedclearanceDataAccessObjects.GetAll(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_volunteermedclearance_GA";
                IList<tran_volunteermedclearanceEntity> itemList = new List<tran_volunteermedclearanceEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_volunteermedclearance.SortExpression);
                    FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteermedclearance, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteermedclearanceEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.GetAlltran_volunteermedclearance"));
            }	
        }
		
        async Task<IList<tran_volunteermedclearanceEntity>> Itran_volunteermedclearanceDataAccessObjects.GetAllByPages(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_volunteermedclearance_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_volunteermedclearance.SortExpression);
                    AddPageSizeParameter(cmd, tran_volunteermedclearance.PageSize);
                    AddCurrentPageParameter(cmd, tran_volunteermedclearance.CurrentPage);                    
                    FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_volunteermedclearance, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_volunteermedclearance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_volunteermedclearance.strCommonSerachParam+"%");

                    IList<tran_volunteermedclearanceEntity> itemList = new List<tran_volunteermedclearanceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteermedclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_volunteermedclearance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.GetAllByPagestran_volunteermedclearance"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_volunteermedclearanceEntity> Itran_volunteermedclearanceDataAccessObjects.GetSingle(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_volunteermedclearance_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteermedclearance, cmd, Database);
                    
                    IList<tran_volunteermedclearanceEntity> itemList = new List<tran_volunteermedclearanceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteermedclearanceEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.GetSingletran_volunteermedclearance"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_volunteermedclearanceEntity>> Itran_volunteermedclearanceDataAccessObjects.GAPgListView(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_volunteermedclearance_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_volunteermedclearance.SortExpression);
                    AddPageSizeParameter(cmd, tran_volunteermedclearance.PageSize);
                    AddCurrentPageParameter(cmd, tran_volunteermedclearance.CurrentPage);                    
                    FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_volunteermedclearance, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_volunteermedclearance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_volunteermedclearance.strCommonSerachParam+"%");

                    IList<tran_volunteermedclearanceEntity> itemList = new List<tran_volunteermedclearanceEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteermedclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_volunteermedclearance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.GAPgListViewtran_volunteermedclearance"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}