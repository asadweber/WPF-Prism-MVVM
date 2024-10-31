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
	
	internal sealed partial class reg_nonkuwaitystatusDataAccessObjects : BaseDataAccess, Ireg_nonkuwaitystatusDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_nonkuwaitystatusDataAccessObjects";
        
		public reg_nonkuwaitystatusDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_nonkuwaitystatus.regnonkuwaitystatusid.HasValue)
				Database.AddInParameter(cmd, "@RegNonKuwaityStatusID", DbType.Int64, reg_nonkuwaitystatus.regnonkuwaitystatusid);
            if (forDelete) return;
			if (reg_nonkuwaitystatus.nonkuwaitystatusid.HasValue)
				Database.AddInParameter(cmd, "@NonKuwaityStatusID", DbType.Int64, reg_nonkuwaitystatus.nonkuwaitystatusid);
			if (!(string.IsNullOrEmpty(reg_nonkuwaitystatus.civilid)))
				Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_nonkuwaitystatus.civilid);
			if (reg_nonkuwaitystatus.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_nonkuwaitystatus.basicinfoid);
			if (reg_nonkuwaitystatus.familyid.HasValue)
				Database.AddInParameter(cmd, "@FamilyID", DbType.Int64, reg_nonkuwaitystatus.familyid);
			if (!(string.IsNullOrEmpty(reg_nonkuwaitystatus.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, reg_nonkuwaitystatus.comment);
			if (!(string.IsNullOrEmpty(reg_nonkuwaitystatus.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_nonkuwaitystatus.remarks);
			if (!(string.IsNullOrEmpty(reg_nonkuwaitystatus.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_nonkuwaitystatus.updateinfo);
			if (reg_nonkuwaitystatus.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_nonkuwaitystatus.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_nonkuwaitystatusDataAccessObjects.Add(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_nonkuwaitystatus_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_nonkuwaitystatus, cmd,Database);
                FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.Addreg_nonkuwaitystatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_nonkuwaitystatusDataAccessObjects.Update(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_nonkuwaitystatus_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_nonkuwaitystatus, cmd,Database);
                FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.Updatereg_nonkuwaitystatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_nonkuwaitystatusDataAccessObjects.Delete(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_nonkuwaitystatus_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_nonkuwaitystatus, cmd,Database, true);
                FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.Deletereg_nonkuwaitystatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_nonkuwaitystatusDataAccessObjects.SaveList(IList<reg_nonkuwaitystatusEntity> listAdded, IList<reg_nonkuwaitystatusEntity> listUpdated, IList<reg_nonkuwaitystatusEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_nonkuwaitystatus_Ins";
            const string SPUpdate = "reg_nonkuwaitystatus_Upd";
            const string SPDelete = "reg_nonkuwaitystatus_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_nonkuwaitystatusEntity reg_nonkuwaitystatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_nonkuwaitystatus, cmd, Database, true);
                            FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_nonkuwaitystatusEntity reg_nonkuwaitystatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_nonkuwaitystatus, cmd, Database);
                            FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_nonkuwaitystatusEntity reg_nonkuwaitystatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_nonkuwaitystatus, cmd, Database);
                            FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.Save_reg_nonkuwaitystatus"));
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
       IList<reg_nonkuwaitystatusEntity> listAdded, 
       IList<reg_nonkuwaitystatusEntity> listUpdated, 
       IList<reg_nonkuwaitystatusEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_nonkuwaitystatus_Ins";
            const string SPUpdate = "reg_nonkuwaitystatus_Upd";
            const string SPDelete = "reg_nonkuwaitystatus_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_nonkuwaitystatusEntity reg_nonkuwaitystatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_nonkuwaitystatus, cmd, db, true);
                            FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, db);
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
                    foreach (reg_nonkuwaitystatusEntity reg_nonkuwaitystatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_nonkuwaitystatus, cmd, db);
                            FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, db);
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
                    foreach (reg_nonkuwaitystatusEntity reg_nonkuwaitystatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_nonkuwaitystatus, cmd, db);
                            FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.Save_reg_nonkuwaitystatus"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusDataAccessObjects.GetAll(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_nonkuwaitystatus_GA";
                IList<reg_nonkuwaitystatusEntity> itemList = new List<reg_nonkuwaitystatusEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_nonkuwaitystatus.SortExpression);
                    FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_nonkuwaitystatus, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.GetAllreg_nonkuwaitystatus"));
            }	
        }
		
        async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusDataAccessObjects.GetAllByPages(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_nonkuwaitystatus_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_nonkuwaitystatus.SortExpression);
                    AddPageSizeParameter(cmd, reg_nonkuwaitystatus.PageSize);
                    AddCurrentPageParameter(cmd, reg_nonkuwaitystatus.CurrentPage);                    
                    FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_nonkuwaitystatus, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_nonkuwaitystatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_nonkuwaitystatus.strCommonSerachParam+"%");

                    IList<reg_nonkuwaitystatusEntity> itemList = new List<reg_nonkuwaitystatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_nonkuwaitystatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.GetAllByPagesreg_nonkuwaitystatus"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_nonkuwaitystatusEntity> Ireg_nonkuwaitystatusDataAccessObjects.GetSingle(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_nonkuwaitystatus_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_nonkuwaitystatus, cmd, Database);
                    
                    IList<reg_nonkuwaitystatusEntity> itemList = new List<reg_nonkuwaitystatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_nonkuwaitystatusEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.GetSinglereg_nonkuwaitystatus"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusDataAccessObjects.GAPgListView(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_nonkuwaitystatus_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_nonkuwaitystatus.SortExpression);
                    AddPageSizeParameter(cmd, reg_nonkuwaitystatus.PageSize);
                    AddCurrentPageParameter(cmd, reg_nonkuwaitystatus.CurrentPage);                    
                    FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_nonkuwaitystatus, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_nonkuwaitystatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_nonkuwaitystatus.strCommonSerachParam+"%");

                    IList<reg_nonkuwaitystatusEntity> itemList = new List<reg_nonkuwaitystatusEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_nonkuwaitystatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.GAPgListViewreg_nonkuwaitystatus"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}