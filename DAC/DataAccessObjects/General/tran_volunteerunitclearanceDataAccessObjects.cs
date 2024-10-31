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
	
	internal sealed partial class tran_volunteerunitclearanceDataAccessObjects : BaseDataAccess, Itran_volunteerunitclearanceDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_volunteerunitclearanceDataAccessObjects";
        
		public tran_volunteerunitclearanceDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_volunteerunitclearance.volunteerunitclearanceid.HasValue)
				Database.AddInParameter(cmd, "@VolunteerUnitClearanceID", DbType.Int64, tran_volunteerunitclearance.volunteerunitclearanceid);
            if (forDelete) return;
			if (tran_volunteerunitclearance.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_volunteerunitclearance.basicinfoid);
			if (tran_volunteerunitclearance.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_volunteerunitclearance.registrationid);
			if (tran_volunteerunitclearance.unitclearanceresult.HasValue)
				Database.AddInParameter(cmd, "@UnitClearanceResult", DbType.Int32, tran_volunteerunitclearance.unitclearanceresult);
			if (!(string.IsNullOrEmpty(tran_volunteerunitclearance.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_volunteerunitclearance.remarks);
			if ((tran_volunteerunitclearance.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_volunteerunitclearance.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_volunteerunitclearance.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_volunteerunitclearance.updateinfo);
			if (tran_volunteerunitclearance.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_volunteerunitclearance.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_volunteerunitclearanceDataAccessObjects.Add(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_volunteerunitclearance_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_volunteerunitclearance, cmd,Database);
                FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.Addtran_volunteerunitclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_volunteerunitclearanceDataAccessObjects.Update(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_volunteerunitclearance_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_volunteerunitclearance, cmd,Database);
                FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.Updatetran_volunteerunitclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_volunteerunitclearanceDataAccessObjects.Delete(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_volunteerunitclearance_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_volunteerunitclearance, cmd,Database, true);
                FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.Deletetran_volunteerunitclearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_volunteerunitclearanceDataAccessObjects.SaveList(IList<tran_volunteerunitclearanceEntity> listAdded, IList<tran_volunteerunitclearanceEntity> listUpdated, IList<tran_volunteerunitclearanceEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_volunteerunitclearance_Ins";
            const string SPUpdate = "tran_volunteerunitclearance_Upd";
            const string SPDelete = "tran_volunteerunitclearance_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_volunteerunitclearanceEntity tran_volunteerunitclearance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_volunteerunitclearance, cmd, Database, true);
                            FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_volunteerunitclearanceEntity tran_volunteerunitclearance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_volunteerunitclearance, cmd, Database);
                            FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_volunteerunitclearanceEntity tran_volunteerunitclearance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_volunteerunitclearance, cmd, Database);
                            FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.Save_tran_volunteerunitclearance"));
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
       IList<tran_volunteerunitclearanceEntity> listAdded, 
       IList<tran_volunteerunitclearanceEntity> listUpdated, 
       IList<tran_volunteerunitclearanceEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_volunteerunitclearance_Ins";
            const string SPUpdate = "tran_volunteerunitclearance_Upd";
            const string SPDelete = "tran_volunteerunitclearance_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_volunteerunitclearanceEntity tran_volunteerunitclearance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_volunteerunitclearance, cmd, db, true);
                            FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, db);
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
                    foreach (tran_volunteerunitclearanceEntity tran_volunteerunitclearance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_volunteerunitclearance, cmd, db);
                            FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, db);
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
                    foreach (tran_volunteerunitclearanceEntity tran_volunteerunitclearance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_volunteerunitclearance, cmd, db);
                            FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.Save_tran_volunteerunitclearance"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_volunteerunitclearanceEntity>> Itran_volunteerunitclearanceDataAccessObjects.GetAll(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_volunteerunitclearance_GA";
                IList<tran_volunteerunitclearanceEntity> itemList = new List<tran_volunteerunitclearanceEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_volunteerunitclearance.SortExpression);
                    FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteerunitclearance, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteerunitclearanceEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.GetAlltran_volunteerunitclearance"));
            }	
        }
		
        async Task<IList<tran_volunteerunitclearanceEntity>> Itran_volunteerunitclearanceDataAccessObjects.GetAllByPages(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_volunteerunitclearance_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_volunteerunitclearance.SortExpression);
                    AddPageSizeParameter(cmd, tran_volunteerunitclearance.PageSize);
                    AddCurrentPageParameter(cmd, tran_volunteerunitclearance.CurrentPage);                    
                    FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_volunteerunitclearance, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_volunteerunitclearance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_volunteerunitclearance.strCommonSerachParam+"%");

                    IList<tran_volunteerunitclearanceEntity> itemList = new List<tran_volunteerunitclearanceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteerunitclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_volunteerunitclearance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.GetAllByPagestran_volunteerunitclearance"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_volunteerunitclearanceEntity> Itran_volunteerunitclearanceDataAccessObjects.GetSingle(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_volunteerunitclearance_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteerunitclearance, cmd, Database);
                    
                    IList<tran_volunteerunitclearanceEntity> itemList = new List<tran_volunteerunitclearanceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteerunitclearanceEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.GetSingletran_volunteerunitclearance"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_volunteerunitclearanceEntity>> Itran_volunteerunitclearanceDataAccessObjects.GAPgListView(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_volunteerunitclearance_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_volunteerunitclearance.SortExpression);
                    AddPageSizeParameter(cmd, tran_volunteerunitclearance.PageSize);
                    AddCurrentPageParameter(cmd, tran_volunteerunitclearance.CurrentPage);                    
                    FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_volunteerunitclearance, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_volunteerunitclearance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_volunteerunitclearance.strCommonSerachParam+"%");

                    IList<tran_volunteerunitclearanceEntity> itemList = new List<tran_volunteerunitclearanceEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteerunitclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_volunteerunitclearance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.GAPgListViewtran_volunteerunitclearance"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}