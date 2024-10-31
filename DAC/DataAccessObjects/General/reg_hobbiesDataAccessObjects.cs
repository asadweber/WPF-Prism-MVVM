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
	
	internal sealed partial class reg_hobbiesDataAccessObjects : BaseDataAccess, Ireg_hobbiesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_hobbiesDataAccessObjects";
        
		public reg_hobbiesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_hobbiesEntity reg_hobbies, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_hobbies.hobbiesid.HasValue)
				Database.AddInParameter(cmd, "@HobbiesID", DbType.Int64, reg_hobbies.hobbiesid);
            if (forDelete) return;
			if (reg_hobbies.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_hobbies.basicinfoid);
			if (!(string.IsNullOrEmpty(reg_hobbies.hobbies)))
				Database.AddInParameter(cmd, "@Hobbies", DbType.String, reg_hobbies.hobbies);
			if (!(string.IsNullOrEmpty(reg_hobbies.details)))
				Database.AddInParameter(cmd, "@Details", DbType.String, reg_hobbies.details);
			if (!(string.IsNullOrEmpty(reg_hobbies.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, reg_hobbies.comment);
			if (!(string.IsNullOrEmpty(reg_hobbies.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_hobbies.remarks);
			if (!(string.IsNullOrEmpty(reg_hobbies.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_hobbies.updateinfo);
			if (reg_hobbies.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_hobbies.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_hobbiesDataAccessObjects.Add(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_hobbies_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_hobbies, cmd,Database);
                FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.Addreg_hobbies"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_hobbiesDataAccessObjects.Update(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_hobbies_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_hobbies, cmd,Database);
                FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.Updatereg_hobbies"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_hobbiesDataAccessObjects.Delete(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_hobbies_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_hobbies, cmd,Database, true);
                FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.Deletereg_hobbies"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_hobbiesDataAccessObjects.SaveList(IList<reg_hobbiesEntity> listAdded, IList<reg_hobbiesEntity> listUpdated, IList<reg_hobbiesEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_hobbies_Ins";
            const string SPUpdate = "reg_hobbies_Upd";
            const string SPDelete = "reg_hobbies_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_hobbiesEntity reg_hobbies in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_hobbies, cmd, Database, true);
                            FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_hobbiesEntity reg_hobbies in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_hobbies, cmd, Database);
                            FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_hobbiesEntity reg_hobbies in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_hobbies, cmd, Database);
                            FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.Save_reg_hobbies"));
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
       IList<reg_hobbiesEntity> listAdded, 
       IList<reg_hobbiesEntity> listUpdated, 
       IList<reg_hobbiesEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_hobbies_Ins";
            const string SPUpdate = "reg_hobbies_Upd";
            const string SPDelete = "reg_hobbies_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_hobbiesEntity reg_hobbies in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_hobbies, cmd, db, true);
                            FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, db);
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
                    foreach (reg_hobbiesEntity reg_hobbies in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_hobbies, cmd, db);
                            FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, db);
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
                    foreach (reg_hobbiesEntity reg_hobbies in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_hobbies, cmd, db);
                            FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.Save_reg_hobbies"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesDataAccessObjects.GetAll(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_hobbies_GA";
                IList<reg_hobbiesEntity> itemList = new List<reg_hobbiesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_hobbies.SortExpression);
                    FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_hobbies, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_hobbiesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.GetAllreg_hobbies"));
            }	
        }
		
        async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesDataAccessObjects.GetAllByPages(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_hobbies_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_hobbies.SortExpression);
                    AddPageSizeParameter(cmd, reg_hobbies.PageSize);
                    AddCurrentPageParameter(cmd, reg_hobbies.CurrentPage);                    
                    FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_hobbies, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_hobbies.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_hobbies.strCommonSerachParam+"%");

                    IList<reg_hobbiesEntity> itemList = new List<reg_hobbiesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_hobbiesEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_hobbies.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.GetAllByPagesreg_hobbies"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_hobbiesEntity> Ireg_hobbiesDataAccessObjects.GetSingle(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_hobbies_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_hobbies, cmd, Database);
                    
                    IList<reg_hobbiesEntity> itemList = new List<reg_hobbiesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_hobbiesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.GetSinglereg_hobbies"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesDataAccessObjects.GAPgListView(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_hobbies_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_hobbies.SortExpression);
                    AddPageSizeParameter(cmd, reg_hobbies.PageSize);
                    AddCurrentPageParameter(cmd, reg_hobbies.CurrentPage);                    
                    FillSequrityParameters(reg_hobbies.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_hobbies, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_hobbies.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_hobbies.strCommonSerachParam+"%");

                    IList<reg_hobbiesEntity> itemList = new List<reg_hobbiesEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_hobbiesEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_hobbies.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_hobbiesDataAccess.GAPgListViewreg_hobbies"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}