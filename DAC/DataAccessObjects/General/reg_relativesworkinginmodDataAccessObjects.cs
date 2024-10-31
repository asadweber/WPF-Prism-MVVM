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
	
	internal sealed partial class reg_relativesworkinginmodDataAccessObjects : BaseDataAccess, Ireg_relativesworkinginmodDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_relativesworkinginmodDataAccessObjects";
        
		public reg_relativesworkinginmodDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_relativesworkinginmodEntity reg_relativesworkinginmod, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_relativesworkinginmod.regrelativesid.HasValue)
				Database.AddInParameter(cmd, "@RegRelativesID", DbType.Int64, reg_relativesworkinginmod.regrelativesid);
            if (forDelete) return;
			if (reg_relativesworkinginmod.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_relativesworkinginmod.basicinfoid);
			if (reg_relativesworkinginmod.imergencycontactid.HasValue)
				Database.AddInParameter(cmd, "@ImergencyContactID", DbType.Int64, reg_relativesworkinginmod.imergencycontactid);
			if (reg_relativesworkinginmod.relativemilorempno.HasValue)
				Database.AddInParameter(cmd, "@RelativeMilOrEmpNo", DbType.Int64, reg_relativesworkinginmod.relativemilorempno);
			if (reg_relativesworkinginmod.relativeentitykey.HasValue)
				Database.AddInParameter(cmd, "@RelativeEntityKey", DbType.Int64, reg_relativesworkinginmod.relativeentitykey);
			if (!(string.IsNullOrEmpty(reg_relativesworkinginmod.relativeworkdesignation)))
				Database.AddInParameter(cmd, "@RelativeWorkDesignation", DbType.String, reg_relativesworkinginmod.relativeworkdesignation);
			if (!(string.IsNullOrEmpty(reg_relativesworkinginmod.relativecivilid)))
				Database.AddInParameter(cmd, "@RelativeCivilID", DbType.String, reg_relativesworkinginmod.relativecivilid);
			if (!(string.IsNullOrEmpty(reg_relativesworkinginmod.relativemobile1)))
				Database.AddInParameter(cmd, "@RelativeMobile1", DbType.String, reg_relativesworkinginmod.relativemobile1);
			if (!(string.IsNullOrEmpty(reg_relativesworkinginmod.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_relativesworkinginmod.remarks);
			if (!(string.IsNullOrEmpty(reg_relativesworkinginmod.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_relativesworkinginmod.updateinfo);
			if (reg_relativesworkinginmod.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_relativesworkinginmod.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_relativesworkinginmodDataAccessObjects.Add(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_relativesworkinginmod_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_relativesworkinginmod, cmd,Database);
                FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.Addreg_relativesworkinginmod"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_relativesworkinginmodDataAccessObjects.Update(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_relativesworkinginmod_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_relativesworkinginmod, cmd,Database);
                FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.Updatereg_relativesworkinginmod"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_relativesworkinginmodDataAccessObjects.Delete(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_relativesworkinginmod_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_relativesworkinginmod, cmd,Database, true);
                FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.Deletereg_relativesworkinginmod"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_relativesworkinginmodDataAccessObjects.SaveList(IList<reg_relativesworkinginmodEntity> listAdded, IList<reg_relativesworkinginmodEntity> listUpdated, IList<reg_relativesworkinginmodEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_relativesworkinginmod_Ins";
            const string SPUpdate = "reg_relativesworkinginmod_Upd";
            const string SPDelete = "reg_relativesworkinginmod_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_relativesworkinginmodEntity reg_relativesworkinginmod in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_relativesworkinginmod, cmd, Database, true);
                            FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_relativesworkinginmodEntity reg_relativesworkinginmod in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_relativesworkinginmod, cmd, Database);
                            FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_relativesworkinginmodEntity reg_relativesworkinginmod in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_relativesworkinginmod, cmd, Database);
                            FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.Save_reg_relativesworkinginmod"));
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
       IList<reg_relativesworkinginmodEntity> listAdded, 
       IList<reg_relativesworkinginmodEntity> listUpdated, 
       IList<reg_relativesworkinginmodEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_relativesworkinginmod_Ins";
            const string SPUpdate = "reg_relativesworkinginmod_Upd";
            const string SPDelete = "reg_relativesworkinginmod_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_relativesworkinginmodEntity reg_relativesworkinginmod in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_relativesworkinginmod, cmd, db, true);
                            FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, db);
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
                    foreach (reg_relativesworkinginmodEntity reg_relativesworkinginmod in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_relativesworkinginmod, cmd, db);
                            FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, db);
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
                    foreach (reg_relativesworkinginmodEntity reg_relativesworkinginmod in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_relativesworkinginmod, cmd, db);
                            FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.Save_reg_relativesworkinginmod"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodDataAccessObjects.GetAll(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_relativesworkinginmod_GA";
                IList<reg_relativesworkinginmodEntity> itemList = new List<reg_relativesworkinginmodEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_relativesworkinginmod.SortExpression);
                    FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_relativesworkinginmod, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_relativesworkinginmodEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.GetAllreg_relativesworkinginmod"));
            }	
        }
		
        async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodDataAccessObjects.GetAllByPages(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_relativesworkinginmod_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_relativesworkinginmod.SortExpression);
                    AddPageSizeParameter(cmd, reg_relativesworkinginmod.PageSize);
                    AddCurrentPageParameter(cmd, reg_relativesworkinginmod.CurrentPage);                    
                    FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_relativesworkinginmod, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_relativesworkinginmod.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_relativesworkinginmod.strCommonSerachParam+"%");

                    IList<reg_relativesworkinginmodEntity> itemList = new List<reg_relativesworkinginmodEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_relativesworkinginmodEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_relativesworkinginmod.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.GetAllByPagesreg_relativesworkinginmod"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_relativesworkinginmodEntity> Ireg_relativesworkinginmodDataAccessObjects.GetSingle(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_relativesworkinginmod_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_relativesworkinginmod, cmd, Database);
                    
                    IList<reg_relativesworkinginmodEntity> itemList = new List<reg_relativesworkinginmodEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_relativesworkinginmodEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.GetSinglereg_relativesworkinginmod"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodDataAccessObjects.GAPgListView(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_relativesworkinginmod_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_relativesworkinginmod.SortExpression);
                    AddPageSizeParameter(cmd, reg_relativesworkinginmod.PageSize);
                    AddCurrentPageParameter(cmd, reg_relativesworkinginmod.CurrentPage);                    
                    FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_relativesworkinginmod, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_relativesworkinginmod.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_relativesworkinginmod.strCommonSerachParam+"%");

                    IList<reg_relativesworkinginmodEntity> itemList = new List<reg_relativesworkinginmodEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_relativesworkinginmodEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_relativesworkinginmod.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.GAPgListViewreg_relativesworkinginmod"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}