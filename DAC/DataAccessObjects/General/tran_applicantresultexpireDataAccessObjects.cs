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
	
	internal sealed partial class tran_applicantresultexpireDataAccessObjects : BaseDataAccess, Itran_applicantresultexpireDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_applicantresultexpireDataAccessObjects";
        
		public tran_applicantresultexpireDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_applicantresultexpireEntity tran_applicantresultexpire, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_applicantresultexpire.resultexpireid.HasValue)
				Database.AddInParameter(cmd, "@ResultExpireID", DbType.Int64, tran_applicantresultexpire.resultexpireid);
            if (forDelete) return;
			if (tran_applicantresultexpire.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_applicantresultexpire.basicinfoid);
			if (tran_applicantresultexpire.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_applicantresultexpire.registrationid);
			if (tran_applicantresultexpire.resulttypeid.HasValue)
				Database.AddInParameter(cmd, "@ResultTypeID", DbType.Int64, tran_applicantresultexpire.resulttypeid);
			if ((tran_applicantresultexpire.expiredate.HasValue))
				Database.AddInParameter(cmd, "@ExpireDate", DbType.DateTime, tran_applicantresultexpire.expiredate);
			if (!(string.IsNullOrEmpty(tran_applicantresultexpire.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_applicantresultexpire.remarks);
			if (tran_applicantresultexpire.statusid.HasValue)
				Database.AddInParameter(cmd, "@StatusID", DbType.Int64, tran_applicantresultexpire.statusid);
			if (!(string.IsNullOrEmpty(tran_applicantresultexpire.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_applicantresultexpire.updateinfo);
			if (tran_applicantresultexpire.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_applicantresultexpire.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_applicantresultexpireDataAccessObjects.Add(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applicantresultexpire_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantresultexpire, cmd,Database);
                FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.Addtran_applicantresultexpire"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_applicantresultexpireDataAccessObjects.Update(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_applicantresultexpire_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_applicantresultexpire, cmd,Database);
                FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.Updatetran_applicantresultexpire"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_applicantresultexpireDataAccessObjects.Delete(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_applicantresultexpire_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_applicantresultexpire, cmd,Database, true);
                FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.Deletetran_applicantresultexpire"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_applicantresultexpireDataAccessObjects.SaveList(IList<tran_applicantresultexpireEntity> listAdded, IList<tran_applicantresultexpireEntity> listUpdated, IList<tran_applicantresultexpireEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_applicantresultexpire_Ins";
            const string SPUpdate = "tran_applicantresultexpire_Upd";
            const string SPDelete = "tran_applicantresultexpire_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantresultexpireEntity tran_applicantresultexpire in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantresultexpire, cmd, Database, true);
                            FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantresultexpireEntity tran_applicantresultexpire in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantresultexpire, cmd, Database);
                            FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantresultexpireEntity tran_applicantresultexpire in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantresultexpire, cmd, Database);
                            FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.Save_tran_applicantresultexpire"));
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
       IList<tran_applicantresultexpireEntity> listAdded, 
       IList<tran_applicantresultexpireEntity> listUpdated, 
       IList<tran_applicantresultexpireEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_applicantresultexpire_Ins";
            const string SPUpdate = "tran_applicantresultexpire_Upd";
            const string SPDelete = "tran_applicantresultexpire_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantresultexpireEntity tran_applicantresultexpire in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantresultexpire, cmd, db, true);
                            FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantresultexpireEntity tran_applicantresultexpire in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantresultexpire, cmd, db);
                            FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantresultexpireEntity tran_applicantresultexpire in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantresultexpire, cmd, db);
                            FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.Save_tran_applicantresultexpire"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_applicantresultexpireEntity>> Itran_applicantresultexpireDataAccessObjects.GetAll(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantresultexpire_GA";
                IList<tran_applicantresultexpireEntity> itemList = new List<tran_applicantresultexpireEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_applicantresultexpire.SortExpression);
                    FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantresultexpire, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantresultexpireEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.GetAlltran_applicantresultexpire"));
            }	
        }
		
        async Task<IList<tran_applicantresultexpireEntity>> Itran_applicantresultexpireDataAccessObjects.GetAllByPages(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantresultexpire_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantresultexpire.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantresultexpire.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantresultexpire.CurrentPage);                    
                    FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantresultexpire, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_applicantresultexpire.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantresultexpire.strCommonSerachParam+"%");

                    IList<tran_applicantresultexpireEntity> itemList = new List<tran_applicantresultexpireEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantresultexpireEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantresultexpire.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.GetAllByPagestran_applicantresultexpire"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_applicantresultexpireEntity> Itran_applicantresultexpireDataAccessObjects.GetSingle(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantresultexpire_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantresultexpire, cmd, Database);
                    
                    IList<tran_applicantresultexpireEntity> itemList = new List<tran_applicantresultexpireEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantresultexpireEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.GetSingletran_applicantresultexpire"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_applicantresultexpireEntity>> Itran_applicantresultexpireDataAccessObjects.GAPgListView(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantresultexpire_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantresultexpire.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantresultexpire.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantresultexpire.CurrentPage);                    
                    FillSequrityParameters(tran_applicantresultexpire.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantresultexpire, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_applicantresultexpire.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantresultexpire.strCommonSerachParam+"%");

                    IList<tran_applicantresultexpireEntity> itemList = new List<tran_applicantresultexpireEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantresultexpireEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantresultexpire.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantresultexpireDataAccess.GAPgListViewtran_applicantresultexpire"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}