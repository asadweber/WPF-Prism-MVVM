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
	
	internal sealed partial class reg_basicinfoDataAccessObjects : BaseDataAccess, Ireg_basicinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_basicinfoDataAccessObjects";
        
		public reg_basicinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(reg_basicinfoEntity reg_basicinfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (reg_basicinfo.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_basicinfo.basicinfoid);
            if (forDelete) return;
            if (!(string.IsNullOrEmpty(reg_basicinfo.civilid)))
                Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_basicinfo.civilid);
            if (!(string.IsNullOrEmpty(reg_basicinfo.passportno)))
                Database.AddInParameter(cmd, "@PassportNo", DbType.String, reg_basicinfo.passportno);
            if (!(string.IsNullOrEmpty(reg_basicinfo.fullname)))
                Database.AddInParameter(cmd, "@FullName", DbType.String, reg_basicinfo.fullname);
            if (!(string.IsNullOrEmpty(reg_basicinfo.name1)))
                Database.AddInParameter(cmd, "@Name1", DbType.String, reg_basicinfo.name1);
            if (!(string.IsNullOrEmpty(reg_basicinfo.name2)))
                Database.AddInParameter(cmd, "@Name2", DbType.String, reg_basicinfo.name2);
            if (!(string.IsNullOrEmpty(reg_basicinfo.name3)))
                Database.AddInParameter(cmd, "@Name3", DbType.String, reg_basicinfo.name3);
            if (!(string.IsNullOrEmpty(reg_basicinfo.name4)))
                Database.AddInParameter(cmd, "@Name4", DbType.String, reg_basicinfo.name4);
            if (!(string.IsNullOrEmpty(reg_basicinfo.name5)))
                Database.AddInParameter(cmd, "@Name5", DbType.String, reg_basicinfo.name5);
            if ((reg_basicinfo.dob.HasValue))
                Database.AddInParameter(cmd, "@DOB", DbType.DateTime, reg_basicinfo.dob);
            if (reg_basicinfo.birthcountryid.HasValue)
                Database.AddInParameter(cmd, "@BirthCountryID", DbType.Int64, reg_basicinfo.birthcountryid);
            if (reg_basicinfo.gender.HasValue)
                Database.AddInParameter(cmd, "@Gender", DbType.Int64, reg_basicinfo.gender);
            if (!(string.IsNullOrEmpty(reg_basicinfo.mob1)))
                Database.AddInParameter(cmd, "@Mob1", DbType.String, reg_basicinfo.mob1);
            if (!(string.IsNullOrEmpty(reg_basicinfo.mob2)))
                Database.AddInParameter(cmd, "@Mob2", DbType.String, reg_basicinfo.mob2);
            if (!(string.IsNullOrEmpty(reg_basicinfo.mob3)))
                Database.AddInParameter(cmd, "@Mob3", DbType.String, reg_basicinfo.mob3);
            if (!(string.IsNullOrEmpty(reg_basicinfo.telephone1)))
                Database.AddInParameter(cmd, "@Telephone1", DbType.String, reg_basicinfo.telephone1);
            if (!(string.IsNullOrEmpty(reg_basicinfo.telephone2)))
                Database.AddInParameter(cmd, "@Telephone2", DbType.String, reg_basicinfo.telephone2);
            if (!(string.IsNullOrEmpty(reg_basicinfo.telephone3)))
                Database.AddInParameter(cmd, "@Telephone3", DbType.String, reg_basicinfo.telephone3);
            if (!(string.IsNullOrEmpty(reg_basicinfo.email)))
                Database.AddInParameter(cmd, "@Email", DbType.String, reg_basicinfo.email);
            if (reg_basicinfo.preaddcountryid.HasValue)
                Database.AddInParameter(cmd, "@PreAddCountryID", DbType.Int64, reg_basicinfo.preaddcountryid);
            if (reg_basicinfo.preaddgovernid.HasValue)
                Database.AddInParameter(cmd, "@PreAddGovernID", DbType.Int64, reg_basicinfo.preaddgovernid);
            if (!(string.IsNullOrEmpty(reg_basicinfo.preaddgovernarate)))
                Database.AddInParameter(cmd, "@PreAddGovernarate", DbType.String, reg_basicinfo.preaddgovernarate);
            if (reg_basicinfo.preaddcityid.HasValue)
                Database.AddInParameter(cmd, "@PreAddCityID", DbType.Int64, reg_basicinfo.preaddcityid);
            if (!(string.IsNullOrEmpty(reg_basicinfo.preaddcity)))
                Database.AddInParameter(cmd, "@PreAddCity", DbType.String, reg_basicinfo.preaddcity);
            if (!(string.IsNullOrEmpty(reg_basicinfo.preaddstreet)))
                Database.AddInParameter(cmd, "@PreAddStreet", DbType.String, reg_basicinfo.preaddstreet);
            if (!(string.IsNullOrEmpty(reg_basicinfo.preaddblock)))
                Database.AddInParameter(cmd, "@PreAddBlock", DbType.String, reg_basicinfo.preaddblock);
            if (!(string.IsNullOrEmpty(reg_basicinfo.preaddhousingno)))
                Database.AddInParameter(cmd, "@PreAddHousingNo", DbType.String, reg_basicinfo.preaddhousingno);
            if (!(string.IsNullOrEmpty(reg_basicinfo.preaddhousingflatno)))
                Database.AddInParameter(cmd, "@PreAddHousingFlatNo", DbType.String, reg_basicinfo.preaddhousingflatno);
            if (!(string.IsNullOrEmpty(reg_basicinfo.preaddress)))
                Database.AddInParameter(cmd, "@PreAddress", DbType.String, reg_basicinfo.preaddress);
            if (!(string.IsNullOrEmpty(reg_basicinfo.prepaci)))
                Database.AddInParameter(cmd, "@PrePaci", DbType.String, reg_basicinfo.prepaci);
            if (!(string.IsNullOrEmpty(reg_basicinfo.pres_latitude)))
                Database.AddInParameter(cmd, "@Pres_Latitude", DbType.String, reg_basicinfo.pres_latitude);
            if (!(string.IsNullOrEmpty(reg_basicinfo.pres_longitude)))
                Database.AddInParameter(cmd, "@Pres_Longitude", DbType.String, reg_basicinfo.pres_longitude);
            if (reg_basicinfo.peraddcountryid.HasValue)
                Database.AddInParameter(cmd, "@PerAddCountryID", DbType.Int64, reg_basicinfo.peraddcountryid);
            if (reg_basicinfo.peraddgovernid.HasValue)
                Database.AddInParameter(cmd, "@PerAddGovernID", DbType.Int64, reg_basicinfo.peraddgovernid);
            if (reg_basicinfo.peraddcityid.HasValue)
                Database.AddInParameter(cmd, "@PerAddCityID", DbType.Int64, reg_basicinfo.peraddcityid);
            if (!(string.IsNullOrEmpty(reg_basicinfo.peraddstreet)))
                Database.AddInParameter(cmd, "@PerAddStreet", DbType.String, reg_basicinfo.peraddstreet);
            if (!(string.IsNullOrEmpty(reg_basicinfo.peraddblock)))
                Database.AddInParameter(cmd, "@PerAddBlock", DbType.String, reg_basicinfo.peraddblock);
            if (!(string.IsNullOrEmpty(reg_basicinfo.peraddhousingno)))
                Database.AddInParameter(cmd, "@PerAddHousingNo", DbType.String, reg_basicinfo.peraddhousingno);
            if (!(string.IsNullOrEmpty(reg_basicinfo.peraddhousingflatno)))
                Database.AddInParameter(cmd, "@PerAddHousingFlatNo", DbType.String, reg_basicinfo.peraddhousingflatno);
            if (!(string.IsNullOrEmpty(reg_basicinfo.perpaci)))
                Database.AddInParameter(cmd, "@PerPaci", DbType.String, reg_basicinfo.perpaci);
            if (!(string.IsNullOrEmpty(reg_basicinfo.peraddress)))
                Database.AddInParameter(cmd, "@PerAddress", DbType.String, reg_basicinfo.peraddress);
            if (!(string.IsNullOrEmpty(reg_basicinfo.perm_latitude)))
                Database.AddInParameter(cmd, "@Perm_Latitude", DbType.String, reg_basicinfo.perm_latitude);
            if (!(string.IsNullOrEmpty(reg_basicinfo.perm_longitude)))
                Database.AddInParameter(cmd, "@Perm_Longitude", DbType.String, reg_basicinfo.perm_longitude);
            if (reg_basicinfo.maritalstatus.HasValue)
                Database.AddInParameter(cmd, "@MaritalStatus", DbType.Int64, reg_basicinfo.maritalstatus);
            if (!(string.IsNullOrEmpty(reg_basicinfo.nationalid)))
                Database.AddInParameter(cmd, "@NationalID", DbType.String, reg_basicinfo.nationalid);
            if ((reg_basicinfo.nationaldate.HasValue))
                Database.AddInParameter(cmd, "@NationalDate", DbType.DateTime, reg_basicinfo.nationaldate);
            if (reg_basicinfo.countrynationalityid.HasValue)
                Database.AddInParameter(cmd, "@CountryNationalityID", DbType.Int64, reg_basicinfo.countrynationalityid);
            if (reg_basicinfo.countryclassid.HasValue)
                Database.AddInParameter(cmd, "@CountryClassID", DbType.Int64, reg_basicinfo.countryclassid);
            if (reg_basicinfo.residenttypeid.HasValue)
                Database.AddInParameter(cmd, "@ResidentTypeID", DbType.Int64, reg_basicinfo.residenttypeid);
            if (reg_basicinfo.bloodgroupid.HasValue)
                Database.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, reg_basicinfo.bloodgroupid);
            if (reg_basicinfo.relogionid.HasValue)
                Database.AddInParameter(cmd, "@RelogionID", DbType.Int64, reg_basicinfo.relogionid);
            if (!(string.IsNullOrEmpty(reg_basicinfo.filepath)))
                Database.AddInParameter(cmd, "@FilePath", DbType.String, reg_basicinfo.filepath);
            if (!(string.IsNullOrEmpty(reg_basicinfo.filename)))
                Database.AddInParameter(cmd, "@FileName", DbType.String, reg_basicinfo.filename);
            if (!(string.IsNullOrEmpty(reg_basicinfo.filetype)))
                Database.AddInParameter(cmd, "@FileType", DbType.String, reg_basicinfo.filetype);
            if (!(string.IsNullOrEmpty(reg_basicinfo.extension)))
                Database.AddInParameter(cmd, "@Extension", DbType.String, reg_basicinfo.extension);
            if (!(string.IsNullOrEmpty(reg_basicinfo.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, reg_basicinfo.comment);

            Database.AddInParameter(cmd, "@UserID", DbType.Guid, reg_basicinfo.userid);
            if (!(string.IsNullOrEmpty(reg_basicinfo.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_basicinfo.remarks);
            if (!(string.IsNullOrEmpty(reg_basicinfo.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_basicinfo.updateinfo);
            if (reg_basicinfo.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_basicinfo.tranformactionid);

        }



        #region Add Operation

        async Task<long> Ireg_basicinfoDataAccessObjects.Add(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_basicinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_basicinfo, cmd,Database);
                FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.Addreg_basicinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_basicinfoDataAccessObjects.Update(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_basicinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_basicinfo, cmd,Database);
                FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.Updatereg_basicinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_basicinfoDataAccessObjects.Delete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_basicinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_basicinfo, cmd,Database, true);
                FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.Deletereg_basicinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveList(IList<reg_basicinfoEntity> listAdded, IList<reg_basicinfoEntity> listUpdated, IList<reg_basicinfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_basicinfo_Ins";
            const string SPUpdate = "reg_basicinfo_Upd";
            const string SPDelete = "reg_basicinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_basicinfoEntity reg_basicinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_basicinfo, cmd, Database, true);
                            FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_basicinfoEntity reg_basicinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_basicinfo, cmd, Database);
                            FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_basicinfoEntity reg_basicinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_basicinfo, cmd, Database);
                            FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.Save_reg_basicinfo"));
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
       IList<reg_basicinfoEntity> listAdded, 
       IList<reg_basicinfoEntity> listUpdated, 
       IList<reg_basicinfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_basicinfo_Ins";
            const string SPUpdate = "reg_basicinfo_Upd";
            const string SPDelete = "reg_basicinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_basicinfoEntity reg_basicinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_basicinfo, cmd, db, true);
                            FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_basicinfoEntity reg_basicinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_basicinfo, cmd, db);
                            FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_basicinfoEntity reg_basicinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_basicinfo, cmd, db);
                            FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.Save_reg_basicinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoDataAccessObjects.GetAll(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_basicinfo_GA";
                IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_basicinfo.SortExpression);
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_basicinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetAllreg_basicinfo"));
            }	
        }
		
        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoDataAccessObjects.GetAllByPages(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_basicinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_basicinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_basicinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_basicinfo.CurrentPage);                    
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_basicinfo, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_basicinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_basicinfo.strCommonSerachParam+"%");

                    IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_basicinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetAllByPagesreg_basicinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetcnf_smsactivationcode(reg_basicinfoEntity masterEntity, 
        IList<cnf_smsactivationcodeEntity> listAdded, 
        IList<cnf_smsactivationcodeEntity> listUpdated,
        IList<cnf_smsactivationcodeEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        cnf_smsactivationcodeDataAccessObjects objcnf_smsactivationcode=new cnf_smsactivationcodeDataAccessObjects(this.Context);
                        objcnf_smsactivationcode.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetcnf_studentmenuskipdetail(reg_basicinfoEntity masterEntity, 
        IList<cnf_studentmenuskipdetailEntity> listAdded, 
        IList<cnf_studentmenuskipdetailEntity> listUpdated,
        IList<cnf_studentmenuskipdetailEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        cnf_studentmenuskipdetailDataAccessObjects objcnf_studentmenuskipdetail=new cnf_studentmenuskipdetailDataAccessObjects(this.Context);
                        objcnf_studentmenuskipdetail.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_educationinfo(reg_basicinfoEntity masterEntity, 
        IList<reg_educationinfoEntity> listAdded, 
        IList<reg_educationinfoEntity> listUpdated,
        IList<reg_educationinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_educationinfoDataAccessObjects objreg_educationinfo=new reg_educationinfoDataAccessObjects(this.Context);
                        objreg_educationinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_familly(reg_basicinfoEntity masterEntity, 
        IList<reg_famillyEntity> listAdded, 
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_famillyDataAccessObjects objreg_familly=new reg_famillyDataAccessObjects(this.Context);
                        objreg_familly.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_hobbies(reg_basicinfoEntity masterEntity, 
        IList<reg_hobbiesEntity> listAdded, 
        IList<reg_hobbiesEntity> listUpdated,
        IList<reg_hobbiesEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_hobbiesDataAccessObjects objreg_hobbies=new reg_hobbiesDataAccessObjects(this.Context);
                        objreg_hobbies.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_language(reg_basicinfoEntity masterEntity, 
        IList<reg_languageEntity> listAdded, 
        IList<reg_languageEntity> listUpdated,
        IList<reg_languageEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_languageDataAccessObjects objreg_language=new reg_languageDataAccessObjects(this.Context);
                        objreg_language.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_nonkuwaitystatus(reg_basicinfoEntity masterEntity, 
        IList<reg_nonkuwaitystatusEntity> listAdded, 
        IList<reg_nonkuwaitystatusEntity> listUpdated,
        IList<reg_nonkuwaitystatusEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_nonkuwaitystatusDataAccessObjects objreg_nonkuwaitystatus=new reg_nonkuwaitystatusDataAccessObjects(this.Context);
                        objreg_nonkuwaitystatus.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_previousexperiance(reg_basicinfoEntity masterEntity, 
        IList<reg_previousexperianceEntity> listAdded, 
        IList<reg_previousexperianceEntity> listUpdated,
        IList<reg_previousexperianceEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_previousexperianceDataAccessObjects objreg_previousexperiance=new reg_previousexperianceDataAccessObjects(this.Context);
                        objreg_previousexperiance.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_punishment(reg_basicinfoEntity masterEntity, 
        IList<reg_punishmentEntity> listAdded, 
        IList<reg_punishmentEntity> listUpdated,
        IList<reg_punishmentEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_punishmentDataAccessObjects objreg_punishment=new reg_punishmentDataAccessObjects(this.Context);
                        objreg_punishment.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_registrationinfo(reg_basicinfoEntity masterEntity, 
        IList<reg_registrationinfoEntity> listAdded, 
        IList<reg_registrationinfoEntity> listUpdated,
        IList<reg_registrationinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_registrationinfoDataAccessObjects objreg_registrationinfo=new reg_registrationinfoDataAccessObjects(this.Context);
                        objreg_registrationinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_relativesworkinginmod(reg_basicinfoEntity masterEntity, 
        IList<reg_relativesworkinginmodEntity> listAdded, 
        IList<reg_relativesworkinginmodEntity> listUpdated,
        IList<reg_relativesworkinginmodEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_relativesworkinginmodDataAccessObjects objreg_relativesworkinginmod=new reg_relativesworkinginmodDataAccessObjects(this.Context);
                        objreg_relativesworkinginmod.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDetreg_studentfilestorage(reg_basicinfoEntity masterEntity, 
        IList<reg_studentfilestorageEntity> listAdded, 
        IList<reg_studentfilestorageEntity> listUpdated,
        IList<reg_studentfilestorageEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorage=new reg_studentfilestorageDataAccessObjects(this.Context);
                        objreg_studentfilestorage.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDettran_applicantphases(reg_basicinfoEntity masterEntity, 
        IList<tran_applicantphasesEntity> listAdded, 
        IList<tran_applicantphasesEntity> listUpdated,
        IList<tran_applicantphasesEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        tran_applicantphasesDataAccessObjects objtran_applicantphases=new tran_applicantphasesDataAccessObjects(this.Context);
                        objtran_applicantphases.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDettran_exportprofile(reg_basicinfoEntity masterEntity, 
        IList<tran_exportprofileEntity> listAdded, 
        IList<tran_exportprofileEntity> listUpdated,
        IList<tran_exportprofileEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        tran_exportprofileDataAccessObjects objtran_exportprofile=new tran_exportprofileDataAccessObjects(this.Context);
                        objtran_exportprofile.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDettran_notificationbatchdet(reg_basicinfoEntity masterEntity, 
        IList<tran_notificationbatchdetEntity> listAdded, 
        IList<tran_notificationbatchdetEntity> listUpdated,
        IList<tran_notificationbatchdetEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        tran_notificationbatchdetDataAccessObjects objtran_notificationbatchdet=new tran_notificationbatchdetDataAccessObjects(this.Context);
                        objtran_notificationbatchdet.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_basicinfoDataAccessObjects.SaveMasterDettran_rollbackinfo(reg_basicinfoEntity masterEntity, 
        IList<tran_rollbackinfoEntity> listAdded, 
        IList<tran_rollbackinfoEntity> listUpdated,
        IList<tran_rollbackinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_basicinfo_Ins";
            const string MasterSPUpdate = "reg_basicinfo_Upd";
            const string MasterSPDelete = "reg_basicinfo_Del";
            
			
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
                                item.basicinfoid=PrimaryKeyMaster;
                            }
                        }
                        tran_rollbackinfoDataAccessObjects objtran_rollbackinfo=new tran_rollbackinfoDataAccessObjects(this.Context);
                        objtran_rollbackinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.SaveDsreg_basicinfo"));
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
        async Task<reg_basicinfoEntity> Ireg_basicinfoDataAccessObjects.GetSingle(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_basicinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_basicinfo, cmd, Database);
                    
                    IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetSinglereg_basicinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoDataAccessObjects.GAPgListView(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_basicinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_basicinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_basicinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_basicinfo.CurrentPage);                    
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_basicinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_basicinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_basicinfo.strCommonSerachParam+"%");

                    IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_basicinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GAPgListViewreg_basicinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_basicinfoDataAccessObjects.GetDataForDropDown(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "reg_basicinfo_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, reg_basicinfo.SortExpression);
					AddPageSizeParameter(cmd, reg_basicinfo.PageSize);
					AddCurrentPageParameter(cmd, reg_basicinfo.CurrentPage);                    
					FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
					FillParameters(reg_basicinfo, cmd,Database);
					if (!string.IsNullOrEmpty(reg_basicinfo.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + reg_basicinfo.strCommonSerachParam + " % ");
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
						reg_basicinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}