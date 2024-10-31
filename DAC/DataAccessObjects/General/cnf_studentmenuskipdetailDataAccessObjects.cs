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
	
	internal sealed partial class cnf_studentmenuskipdetailDataAccessObjects : BaseDataAccess, Icnf_studentmenuskipdetailDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_studentmenuskipdetailDataAccessObjects";
        
		public cnf_studentmenuskipdetailDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_studentmenuskipdetail.studentskippedserialdetid.HasValue)
				Database.AddInParameter(cmd, "@StudentSkippedSerialDetID", DbType.Int64, cnf_studentmenuskipdetail.studentskippedserialdetid);
            if (forDelete) return;
			if (cnf_studentmenuskipdetail.studentskippedserialid.HasValue)
				Database.AddInParameter(cmd, "@StudentSkippedSerialID", DbType.Int64, cnf_studentmenuskipdetail.studentskippedserialid);
			if (cnf_studentmenuskipdetail.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, cnf_studentmenuskipdetail.basicinfoid);
			if (cnf_studentmenuskipdetail.appformid.HasValue)
				Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, cnf_studentmenuskipdetail.appformid);
			if (cnf_studentmenuskipdetail.formactionid.HasValue)
				Database.AddInParameter(cmd, "@FormActionID", DbType.Int64, cnf_studentmenuskipdetail.formactionid);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskipdetail.formname)))
				Database.AddInParameter(cmd, "@FormName", DbType.String, cnf_studentmenuskipdetail.formname);
			if ((cnf_studentmenuskipdetail.noinfoavailable != null))
				Database.AddInParameter(cmd, "@NoInfoAvailable", DbType.Boolean, cnf_studentmenuskipdetail.noinfoavailable);
			if ((cnf_studentmenuskipdetail.haschecked != null))
				Database.AddInParameter(cmd, "@HasChecked", DbType.Boolean, cnf_studentmenuskipdetail.haschecked);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskipdetail.optional)))
				Database.AddInParameter(cmd, "@Optional", DbType.String, cnf_studentmenuskipdetail.optional);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskipdetail.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, cnf_studentmenuskipdetail.comment);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskipdetail.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_studentmenuskipdetail.remarks);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskipdetail.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, cnf_studentmenuskipdetail.updateinfo);
			if (cnf_studentmenuskipdetail.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, cnf_studentmenuskipdetail.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Icnf_studentmenuskipdetailDataAccessObjects.Add(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_studentmenuskipdetail_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_studentmenuskipdetail, cmd,Database);
                FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.Addcnf_studentmenuskipdetail"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_studentmenuskipdetailDataAccessObjects.Update(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_studentmenuskipdetail_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_studentmenuskipdetail, cmd,Database);
                FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.Updatecnf_studentmenuskipdetail"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_studentmenuskipdetailDataAccessObjects.Delete(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_studentmenuskipdetail_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_studentmenuskipdetail, cmd,Database, true);
                FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.Deletecnf_studentmenuskipdetail"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_studentmenuskipdetailDataAccessObjects.SaveList(IList<cnf_studentmenuskipdetailEntity> listAdded, IList<cnf_studentmenuskipdetailEntity> listUpdated, IList<cnf_studentmenuskipdetailEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_studentmenuskipdetail_Ins";
            const string SPUpdate = "cnf_studentmenuskipdetail_Upd";
            const string SPDelete = "cnf_studentmenuskipdetail_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_studentmenuskipdetail, cmd, Database, true);
                            FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_studentmenuskipdetail, cmd, Database);
                            FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_studentmenuskipdetail, cmd, Database);
                            FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.Save_cnf_studentmenuskipdetail"));
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
       IList<cnf_studentmenuskipdetailEntity> listAdded, 
       IList<cnf_studentmenuskipdetailEntity> listUpdated, 
       IList<cnf_studentmenuskipdetailEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_studentmenuskipdetail_Ins";
            const string SPUpdate = "cnf_studentmenuskipdetail_Upd";
            const string SPDelete = "cnf_studentmenuskipdetail_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_studentmenuskipdetail, cmd, db, true);
                            FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_studentmenuskipdetail, cmd, db);
                            FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_studentmenuskipdetail, cmd, db);
                            FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.Save_cnf_studentmenuskipdetail"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailDataAccessObjects.GetAll(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_studentmenuskipdetail_GA";
                IList<cnf_studentmenuskipdetailEntity> itemList = new List<cnf_studentmenuskipdetailEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_studentmenuskipdetail.SortExpression);
                    FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_studentmenuskipdetail, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipdetailEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.GetAllcnf_studentmenuskipdetail"));
            }	
        }
		
        async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailDataAccessObjects.GetAllByPages(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_studentmenuskipdetail_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_studentmenuskipdetail.SortExpression);
                    AddPageSizeParameter(cmd, cnf_studentmenuskipdetail.PageSize);
                    AddCurrentPageParameter(cmd, cnf_studentmenuskipdetail.CurrentPage);                    
                    FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_studentmenuskipdetail, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_studentmenuskipdetail.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_studentmenuskipdetail.strCommonSerachParam+"%");

                    IList<cnf_studentmenuskipdetailEntity> itemList = new List<cnf_studentmenuskipdetailEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipdetailEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_studentmenuskipdetail.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.GetAllByPagescnf_studentmenuskipdetail"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<cnf_studentmenuskipdetailEntity> Icnf_studentmenuskipdetailDataAccessObjects.GetSingle(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_studentmenuskipdetail_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_studentmenuskipdetail, cmd, Database);
                    
                    IList<cnf_studentmenuskipdetailEntity> itemList = new List<cnf_studentmenuskipdetailEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipdetailEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.GetSinglecnf_studentmenuskipdetail"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailDataAccessObjects.GAPgListView(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_studentmenuskipdetail_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_studentmenuskipdetail.SortExpression);
                    AddPageSizeParameter(cmd, cnf_studentmenuskipdetail.PageSize);
                    AddCurrentPageParameter(cmd, cnf_studentmenuskipdetail.CurrentPage);                    
                    FillSequrityParameters(cnf_studentmenuskipdetail.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_studentmenuskipdetail, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_studentmenuskipdetail.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_studentmenuskipdetail.strCommonSerachParam+"%");

                    IList<cnf_studentmenuskipdetailEntity> itemList = new List<cnf_studentmenuskipdetailEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipdetailEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_studentmenuskipdetail.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipdetailDataAccess.GAPgListViewcnf_studentmenuskipdetail"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}