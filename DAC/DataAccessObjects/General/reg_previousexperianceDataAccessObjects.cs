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
	
	internal sealed partial class reg_previousexperianceDataAccessObjects : BaseDataAccess, Ireg_previousexperianceDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_previousexperianceDataAccessObjects";
        
		public reg_previousexperianceDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_previousexperianceEntity reg_previousexperiance, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_previousexperiance.prevexpid.HasValue)
				Database.AddInParameter(cmd, "@PrevExpID", DbType.Int64, reg_previousexperiance.prevexpid);
            if (forDelete) return;
			if (reg_previousexperiance.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_previousexperiance.basicinfoid);
			if (reg_previousexperiance.companytypeid.HasValue)
				Database.AddInParameter(cmd, "@CompanyTypeID", DbType.Int64, reg_previousexperiance.companytypeid);
			if (reg_previousexperiance.companyid.HasValue)
				Database.AddInParameter(cmd, "@CompanyID", DbType.Int64, reg_previousexperiance.companyid);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.companyname)))
				Database.AddInParameter(cmd, "@CompanyName", DbType.String, reg_previousexperiance.companyname);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.designation)))
				Database.AddInParameter(cmd, "@Designation", DbType.String, reg_previousexperiance.designation);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, reg_previousexperiance.description);
			if ((reg_previousexperiance.fromdate.HasValue))
				Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, reg_previousexperiance.fromdate);
			if ((reg_previousexperiance.todate.HasValue))
				Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, reg_previousexperiance.todate);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.filepath)))
				Database.AddInParameter(cmd, "@FilePath", DbType.String, reg_previousexperiance.filepath);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.filename)))
				Database.AddInParameter(cmd, "@FileName", DbType.String, reg_previousexperiance.filename);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.filetype)))
				Database.AddInParameter(cmd, "@FileType", DbType.String, reg_previousexperiance.filetype);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.extension)))
				Database.AddInParameter(cmd, "@Extension", DbType.String, reg_previousexperiance.extension);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, reg_previousexperiance.comment);
			if (!(string.IsNullOrEmpty(reg_previousexperiance.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_previousexperiance.updateinfo);
			if (reg_previousexperiance.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_previousexperiance.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_previousexperianceDataAccessObjects.Add(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_previousexperiance_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_previousexperiance, cmd,Database);
                FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.Addreg_previousexperiance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_previousexperianceDataAccessObjects.Update(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_previousexperiance_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_previousexperiance, cmd,Database);
                FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.Updatereg_previousexperiance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_previousexperianceDataAccessObjects.Delete(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_previousexperiance_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_previousexperiance, cmd,Database, true);
                FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.Deletereg_previousexperiance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_previousexperianceDataAccessObjects.SaveList(IList<reg_previousexperianceEntity> listAdded, IList<reg_previousexperianceEntity> listUpdated, IList<reg_previousexperianceEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_previousexperiance_Ins";
            const string SPUpdate = "reg_previousexperiance_Upd";
            const string SPDelete = "reg_previousexperiance_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_previousexperianceEntity reg_previousexperiance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_previousexperiance, cmd, Database, true);
                            FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_previousexperianceEntity reg_previousexperiance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_previousexperiance, cmd, Database);
                            FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_previousexperianceEntity reg_previousexperiance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_previousexperiance, cmd, Database);
                            FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.Save_reg_previousexperiance"));
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
       IList<reg_previousexperianceEntity> listAdded, 
       IList<reg_previousexperianceEntity> listUpdated, 
       IList<reg_previousexperianceEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_previousexperiance_Ins";
            const string SPUpdate = "reg_previousexperiance_Upd";
            const string SPDelete = "reg_previousexperiance_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_previousexperianceEntity reg_previousexperiance in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_previousexperiance, cmd, db, true);
                            FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, db);
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
                    foreach (reg_previousexperianceEntity reg_previousexperiance in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_previousexperiance, cmd, db);
                            FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, db);
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
                    foreach (reg_previousexperianceEntity reg_previousexperiance in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_previousexperiance, cmd, db);
                            FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.Save_reg_previousexperiance"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceDataAccessObjects.GetAll(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_previousexperiance_GA";
                IList<reg_previousexperianceEntity> itemList = new List<reg_previousexperianceEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_previousexperiance.SortExpression);
                    FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_previousexperiance, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_previousexperianceEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.GetAllreg_previousexperiance"));
            }	
        }
		
        async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceDataAccessObjects.GetAllByPages(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_previousexperiance_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_previousexperiance.SortExpression);
                    AddPageSizeParameter(cmd, reg_previousexperiance.PageSize);
                    AddCurrentPageParameter(cmd, reg_previousexperiance.CurrentPage);                    
                    FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_previousexperiance, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_previousexperiance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_previousexperiance.strCommonSerachParam+"%");

                    IList<reg_previousexperianceEntity> itemList = new List<reg_previousexperianceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_previousexperianceEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_previousexperiance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.GetAllByPagesreg_previousexperiance"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_previousexperianceEntity> Ireg_previousexperianceDataAccessObjects.GetSingle(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_previousexperiance_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_previousexperiance, cmd, Database);
                    
                    IList<reg_previousexperianceEntity> itemList = new List<reg_previousexperianceEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_previousexperianceEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.GetSinglereg_previousexperiance"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceDataAccessObjects.GAPgListView(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_previousexperiance_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_previousexperiance.SortExpression);
                    AddPageSizeParameter(cmd, reg_previousexperiance.PageSize);
                    AddCurrentPageParameter(cmd, reg_previousexperiance.CurrentPage);                    
                    FillSequrityParameters(reg_previousexperiance.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_previousexperiance, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_previousexperiance.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_previousexperiance.strCommonSerachParam+"%");

                    IList<reg_previousexperianceEntity> itemList = new List<reg_previousexperianceEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_previousexperianceEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_previousexperiance.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_previousexperianceDataAccess.GAPgListViewreg_previousexperiance"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}