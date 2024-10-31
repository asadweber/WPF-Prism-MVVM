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
	
	internal sealed partial class cnf_smsactivationtransectionDataAccessObjects : BaseDataAccess, Icnf_smsactivationtransectionDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_smsactivationtransectionDataAccessObjects";
        
		public cnf_smsactivationtransectionDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_smsactivationtransection.smstransectioncodeid.HasValue)
				Database.AddInParameter(cmd, "@SMSTransectionCodeID", DbType.Int64, cnf_smsactivationtransection.smstransectioncodeid);
            if (forDelete) return;
			if (cnf_smsactivationtransection.smscodeid.HasValue)
				Database.AddInParameter(cmd, "@SMSCodeID", DbType.Int64, cnf_smsactivationtransection.smscodeid);
			if (cnf_smsactivationtransection.providedcode.HasValue)
				Database.AddInParameter(cmd, "@ProvidedCode", DbType.Int64, cnf_smsactivationtransection.providedcode);
			if ((cnf_smsactivationtransection.issuccess != null))
				Database.AddInParameter(cmd, "@IsSuccess", DbType.Boolean, cnf_smsactivationtransection.issuccess);
			if (!(string.IsNullOrEmpty(cnf_smsactivationtransection.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, cnf_smsactivationtransection.comment);
			if (!(string.IsNullOrEmpty(cnf_smsactivationtransection.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_smsactivationtransection.remarks);
			if (!(string.IsNullOrEmpty(cnf_smsactivationtransection.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, cnf_smsactivationtransection.updateinfo);
			if (cnf_smsactivationtransection.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, cnf_smsactivationtransection.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Icnf_smsactivationtransectionDataAccessObjects.Add(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_smsactivationtransection_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_smsactivationtransection, cmd,Database);
                FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.Addcnf_smsactivationtransection"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_smsactivationtransectionDataAccessObjects.Update(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_smsactivationtransection_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_smsactivationtransection, cmd,Database);
                FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.Updatecnf_smsactivationtransection"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_smsactivationtransectionDataAccessObjects.Delete(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_smsactivationtransection_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_smsactivationtransection, cmd,Database, true);
                FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.Deletecnf_smsactivationtransection"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_smsactivationtransectionDataAccessObjects.SaveList(IList<cnf_smsactivationtransectionEntity> listAdded, IList<cnf_smsactivationtransectionEntity> listUpdated, IList<cnf_smsactivationtransectionEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_smsactivationtransection_Ins";
            const string SPUpdate = "cnf_smsactivationtransection_Upd";
            const string SPDelete = "cnf_smsactivationtransection_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_smsactivationtransectionEntity cnf_smsactivationtransection in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_smsactivationtransection, cmd, Database, true);
                            FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_smsactivationtransectionEntity cnf_smsactivationtransection in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_smsactivationtransection, cmd, Database);
                            FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_smsactivationtransectionEntity cnf_smsactivationtransection in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_smsactivationtransection, cmd, Database);
                            FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.Save_cnf_smsactivationtransection"));
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
       IList<cnf_smsactivationtransectionEntity> listAdded, 
       IList<cnf_smsactivationtransectionEntity> listUpdated, 
       IList<cnf_smsactivationtransectionEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_smsactivationtransection_Ins";
            const string SPUpdate = "cnf_smsactivationtransection_Upd";
            const string SPDelete = "cnf_smsactivationtransection_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_smsactivationtransectionEntity cnf_smsactivationtransection in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_smsactivationtransection, cmd, db, true);
                            FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_smsactivationtransectionEntity cnf_smsactivationtransection in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_smsactivationtransection, cmd, db);
                            FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_smsactivationtransectionEntity cnf_smsactivationtransection in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_smsactivationtransection, cmd, db);
                            FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.Save_cnf_smsactivationtransection"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_smsactivationtransectionEntity>> Icnf_smsactivationtransectionDataAccessObjects.GetAll(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smsactivationtransection_GA";
                IList<cnf_smsactivationtransectionEntity> itemList = new List<cnf_smsactivationtransectionEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_smsactivationtransection.SortExpression);
                    FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smsactivationtransection, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationtransectionEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.GetAllcnf_smsactivationtransection"));
            }	
        }
		
        async Task<IList<cnf_smsactivationtransectionEntity>> Icnf_smsactivationtransectionDataAccessObjects.GetAllByPages(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_smsactivationtransection_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_smsactivationtransection.SortExpression);
                    AddPageSizeParameter(cmd, cnf_smsactivationtransection.PageSize);
                    AddCurrentPageParameter(cmd, cnf_smsactivationtransection.CurrentPage);                    
                    FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_smsactivationtransection, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_smsactivationtransection.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_smsactivationtransection.strCommonSerachParam+"%");

                    IList<cnf_smsactivationtransectionEntity> itemList = new List<cnf_smsactivationtransectionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationtransectionEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_smsactivationtransection.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.GetAllByPagescnf_smsactivationtransection"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<cnf_smsactivationtransectionEntity> Icnf_smsactivationtransectionDataAccessObjects.GetSingle(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smsactivationtransection_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smsactivationtransection, cmd, Database);
                    
                    IList<cnf_smsactivationtransectionEntity> itemList = new List<cnf_smsactivationtransectionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationtransectionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.GetSinglecnf_smsactivationtransection"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_smsactivationtransectionEntity>> Icnf_smsactivationtransectionDataAccessObjects.GAPgListView(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_smsactivationtransection_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_smsactivationtransection.SortExpression);
                    AddPageSizeParameter(cmd, cnf_smsactivationtransection.PageSize);
                    AddCurrentPageParameter(cmd, cnf_smsactivationtransection.CurrentPage);                    
                    FillSequrityParameters(cnf_smsactivationtransection.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_smsactivationtransection, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_smsactivationtransection.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_smsactivationtransection.strCommonSerachParam+"%");

                    IList<cnf_smsactivationtransectionEntity> itemList = new List<cnf_smsactivationtransectionEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationtransectionEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_smsactivationtransection.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationtransectionDataAccess.GAPgListViewcnf_smsactivationtransection"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}