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
	
	internal sealed partial class cnf_smsactivationcodeDataAccessObjects : BaseDataAccess, Icnf_smsactivationcodeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_smsactivationcodeDataAccessObjects";
        
		public cnf_smsactivationcodeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_smsactivationcodeEntity cnf_smsactivationcode, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_smsactivationcode.smscodeid.HasValue)
				Database.AddInParameter(cmd, "@SMSCodeID", DbType.Int64, cnf_smsactivationcode.smscodeid);
            if (forDelete) return;
			if (cnf_smsactivationcode.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, cnf_smsactivationcode.basicinfoid);
            if (cnf_smsactivationcode.userid.HasValue)
                Database.AddInParameter(cmd, "@UserID", DbType.Guid, cnf_smsactivationcode.userid);
            if ((cnf_smsactivationcode.generatedate.HasValue))
				Database.AddInParameter(cmd, "@GenerateDate", DbType.DateTime, cnf_smsactivationcode.generatedate);
			if (cnf_smsactivationcode.smscodetype.HasValue)
				Database.AddInParameter(cmd, "@SmsCodeType", DbType.Int64, cnf_smsactivationcode.smscodetype);
			if (cnf_smsactivationcode.smscode.HasValue)
				Database.AddInParameter(cmd, "@SmsCode", DbType.Int64, cnf_smsactivationcode.smscode);
			if ((cnf_smsactivationcode.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, cnf_smsactivationcode.isactive);
			if ((cnf_smsactivationcode.sucessdate.HasValue))
				Database.AddInParameter(cmd, "@SucessDate", DbType.DateTime, cnf_smsactivationcode.sucessdate);
			if ((cnf_smsactivationcode.smsstatus != null))
				Database.AddInParameter(cmd, "@smsStatus", DbType.Boolean, cnf_smsactivationcode.smsstatus);
			if ((cnf_smsactivationcode.smssenddate.HasValue))
				Database.AddInParameter(cmd, "@SmsSendDate", DbType.DateTime, cnf_smsactivationcode.smssenddate);
			if (!(string.IsNullOrEmpty(cnf_smsactivationcode.smsresponse)))
				Database.AddInParameter(cmd, "@SmsResponse", DbType.String, cnf_smsactivationcode.smsresponse);
			if (!(string.IsNullOrEmpty(cnf_smsactivationcode.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, cnf_smsactivationcode.comment);
			if (!(string.IsNullOrEmpty(cnf_smsactivationcode.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_smsactivationcode.remarks);
			if (!(string.IsNullOrEmpty(cnf_smsactivationcode.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, cnf_smsactivationcode.updateinfo);
			if (cnf_smsactivationcode.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, cnf_smsactivationcode.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Icnf_smsactivationcodeDataAccessObjects.Add(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_smsactivationcode_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_smsactivationcode, cmd,Database);
                FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.Addcnf_smsactivationcode"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_smsactivationcodeDataAccessObjects.Update(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_smsactivationcode_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_smsactivationcode, cmd,Database);
                FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.Updatecnf_smsactivationcode"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_smsactivationcodeDataAccessObjects.Delete(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_smsactivationcode_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_smsactivationcode, cmd,Database, true);
                FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.Deletecnf_smsactivationcode"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_smsactivationcodeDataAccessObjects.SaveList(IList<cnf_smsactivationcodeEntity> listAdded, IList<cnf_smsactivationcodeEntity> listUpdated, IList<cnf_smsactivationcodeEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_smsactivationcode_Ins";
            const string SPUpdate = "cnf_smsactivationcode_Upd";
            const string SPDelete = "cnf_smsactivationcode_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_smsactivationcodeEntity cnf_smsactivationcode in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_smsactivationcode, cmd, Database, true);
                            FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_smsactivationcodeEntity cnf_smsactivationcode in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_smsactivationcode, cmd, Database);
                            FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_smsactivationcodeEntity cnf_smsactivationcode in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_smsactivationcode, cmd, Database);
                            FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.Save_cnf_smsactivationcode"));
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
       IList<cnf_smsactivationcodeEntity> listAdded, 
       IList<cnf_smsactivationcodeEntity> listUpdated, 
       IList<cnf_smsactivationcodeEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_smsactivationcode_Ins";
            const string SPUpdate = "cnf_smsactivationcode_Upd";
            const string SPDelete = "cnf_smsactivationcode_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_smsactivationcodeEntity cnf_smsactivationcode in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_smsactivationcode, cmd, db, true);
                            FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_smsactivationcodeEntity cnf_smsactivationcode in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_smsactivationcode, cmd, db);
                            FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_smsactivationcodeEntity cnf_smsactivationcode in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_smsactivationcode, cmd, db);
                            FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.Save_cnf_smsactivationcode"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeDataAccessObjects.GetAll(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smsactivationcode_GA";
                IList<cnf_smsactivationcodeEntity> itemList = new List<cnf_smsactivationcodeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_smsactivationcode.SortExpression);
                    FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smsactivationcode, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationcodeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.GetAllcnf_smsactivationcode"));
            }	
        }
		
        async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeDataAccessObjects.GetAllByPages(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_smsactivationcode_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_smsactivationcode.SortExpression);
                    AddPageSizeParameter(cmd, cnf_smsactivationcode.PageSize);
                    AddCurrentPageParameter(cmd, cnf_smsactivationcode.CurrentPage);                    
                    FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_smsactivationcode, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_smsactivationcode.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_smsactivationcode.strCommonSerachParam+"%");

                    IList<cnf_smsactivationcodeEntity> itemList = new List<cnf_smsactivationcodeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationcodeEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_smsactivationcode.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.GetAllByPagescnf_smsactivationcode"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Icnf_smsactivationcodeDataAccessObjects.SaveMasterDetcnf_smsactivationtransection(cnf_smsactivationcodeEntity masterEntity, 
        IList<cnf_smsactivationtransectionEntity> listAdded, 
        IList<cnf_smsactivationtransectionEntity> listUpdated,
        IList<cnf_smsactivationtransectionEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "cnf_smsactivationcode_Ins";
            const string MasterSPUpdate = "cnf_smsactivationcode_Upd";
            const string MasterSPDelete = "cnf_smsactivationcode_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                                PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = PrimaryKeyMaster;
                        
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.smscodeid=PrimaryKeyMaster;
                            }
                        }
                        cnf_smsactivationtransectionDataAccessObjects objcnf_smsactivationtransection=new cnf_smsactivationtransectionDataAccessObjects(this.Context);
                        objcnf_smsactivationtransection.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.SaveDscnf_smsactivationcode"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeDataAccessObjects.GetSingle(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smsactivationcode_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smsactivationcode, cmd, Database);
                    
                    IList<cnf_smsactivationcodeEntity> itemList = new List<cnf_smsactivationcodeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationcodeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.GetSinglecnf_smsactivationcode"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeDataAccessObjects.GAPgListView(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_smsactivationcode_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_smsactivationcode.SortExpression);
                    AddPageSizeParameter(cmd, cnf_smsactivationcode.PageSize);
                    AddCurrentPageParameter(cmd, cnf_smsactivationcode.CurrentPage);                    
                    FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_smsactivationcode, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_smsactivationcode.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_smsactivationcode.strCommonSerachParam+"%");

                    IList<cnf_smsactivationcodeEntity> itemList = new List<cnf_smsactivationcodeEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationcodeEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_smsactivationcode.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.GAPgListViewcnf_smsactivationcode"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_smsactivationcodeDataAccessObjects.GetDataForDropDown(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "cnf_smsactivationcode_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, cnf_smsactivationcode.SortExpression);
					AddPageSizeParameter(cmd, cnf_smsactivationcode.PageSize);
					AddCurrentPageParameter(cmd, cnf_smsactivationcode.CurrentPage);                    
					FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
					FillParameters(cnf_smsactivationcode, cmd,Database);
					if (!string.IsNullOrEmpty(cnf_smsactivationcode.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_smsactivationcode.strCommonSerachParam + " % ");
					IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
					IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
					while (!result.IsCompleted)
					{
						
					}
					using (IDataReader reader = Database.EndExecuteReader(result))
					{
						while (reader.Read())
						{
							itemList.Add(new gen_dropdownEntity(reader));
						}
						reader.Close();
					}
					if(itemList.Count>0)
					{
						itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_smsactivationcode.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}