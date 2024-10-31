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
	
	internal sealed partial class gen_servicestatusDataAccessObjects : BaseDataAccess, Igen_servicestatusDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_servicestatusDataAccessObjects";
        
		public gen_servicestatusDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_servicestatusEntity gen_servicestatus, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_servicestatus.servicestatusid.HasValue)
				Database.AddInParameter(cmd, "@ServiceStatusID", DbType.Int64, gen_servicestatus.servicestatusid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_servicestatus.servicestatusar)))
				Database.AddInParameter(cmd, "@ServiceStatusAR", DbType.String, gen_servicestatus.servicestatusar);
			if (!(string.IsNullOrEmpty(gen_servicestatus.servicestatusen)))
				Database.AddInParameter(cmd, "@ServiceStatusEN", DbType.String, gen_servicestatus.servicestatusen);
			if (!(string.IsNullOrEmpty(gen_servicestatus.descriptionar)))
				Database.AddInParameter(cmd, "@DescriptionAR", DbType.String, gen_servicestatus.descriptionar);
			if (!(string.IsNullOrEmpty(gen_servicestatus.descriptionen)))
				Database.AddInParameter(cmd, "@DescriptionEN", DbType.String, gen_servicestatus.descriptionen);
			if ((gen_servicestatus.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, gen_servicestatus.isactive);

        }
		
        
		#region Add Operation

        async Task<long> Igen_servicestatusDataAccessObjects.Add(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_servicestatus_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_servicestatus, cmd,Database);
                FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Addgen_servicestatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_servicestatusDataAccessObjects.Update(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_servicestatus_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_servicestatus, cmd,Database);
                FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Updategen_servicestatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_servicestatusDataAccessObjects.Delete(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_servicestatus_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_servicestatus, cmd,Database, true);
                FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Deletegen_servicestatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_servicestatusDataAccessObjects.SaveList(IList<gen_servicestatusEntity> listAdded, IList<gen_servicestatusEntity> listUpdated, IList<gen_servicestatusEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_servicestatus_Ins";
            const string SPUpdate = "gen_servicestatus_Upd";
            const string SPDelete = "gen_servicestatus_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicestatusEntity gen_servicestatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_servicestatus, cmd, Database, true);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_servicestatus, cmd, Database);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_servicestatus, cmd, Database);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Save_gen_servicestatus"));
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
       IList<gen_servicestatusEntity> listAdded, 
       IList<gen_servicestatusEntity> listUpdated, 
       IList<gen_servicestatusEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_servicestatus_Ins";
            const string SPUpdate = "gen_servicestatus_Upd";
            const string SPDelete = "gen_servicestatus_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_servicestatusEntity gen_servicestatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_servicestatus, cmd, db, true);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_servicestatus, cmd, db);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_servicestatusEntity gen_servicestatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_servicestatus, cmd, db);
                            FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.Save_gen_servicestatus"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_servicestatusEntity>> Igen_servicestatusDataAccessObjects.GetAll(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_servicestatus_GA";
                IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_servicestatus.SortExpression);
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_servicestatus, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GetAllgen_servicestatus"));
            }	
        }
		
        async Task<IList<gen_servicestatusEntity>> Igen_servicestatusDataAccessObjects.GetAllByPages(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_servicestatus_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_servicestatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_servicestatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_servicestatus.CurrentPage);                    
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_servicestatus, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_servicestatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_servicestatus.strCommonSerachParam+"%");

                    IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_servicestatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GetAllByPagesgen_servicestatus"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_servicestatusEntity> Igen_servicestatusDataAccessObjects.GetSingle(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_servicestatus_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_servicestatus, cmd, Database);
                    
                    IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GetSinglegen_servicestatus"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_servicestatusEntity>> Igen_servicestatusDataAccessObjects.GAPgListView(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_servicestatus_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_servicestatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_servicestatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_servicestatus.CurrentPage);                    
                    FillSequrityParameters(gen_servicestatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_servicestatus, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_servicestatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_servicestatus.strCommonSerachParam+"%");

                    IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_servicestatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_servicestatusDataAccess.GAPgListViewgen_servicestatus"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}