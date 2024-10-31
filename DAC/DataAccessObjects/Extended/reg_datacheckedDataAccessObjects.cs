using BDO.Core.DataAccessObjects.Models;
using IDAC.Core.IDataAccessObjects.General;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class reg_datacheckedDataAccessObjects
    {
        public async Task<long> AddDataCheck(Database db,DbTransaction transaction, reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_reg_datachecked_Ins_Ext_AfterFinalSubmit";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(reg_datachecked, cmd, db);
                FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);

                if ((reg_datachecked.isMarried != null))
                    Database.AddInParameter(cmd, "@IsMarried", DbType.Boolean, reg_datachecked.isMarried);

                try
                {
                    IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = db.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.Addreg_datachecked"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<IList<reg_datacheckedEntity>> GetAllRegDataCheckedListByRegistrationID(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetAllRegDataCheckedListByRegistrationID_GA";
                IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_datachecked.SortExpression);
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_datachecked, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GetAllRegDataCheckedListByRegistrationIDreg_datachecked"));
            }
        }

        public async Task<reg_datacheckedEntity> GetRegDataCheckedByApplicantTable(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegDataCheckedByBasicInfoIDRegIDTabID_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_datachecked, cmd, Database);

                    IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.KAF_GetRegDataCheckedByBasicInfoIDRegIDTabID_GSreg_datachecked"));
            }
        }

        public async Task<reg_datacheckedEntity> GetNotCheckedRegDataCheckedByApplicantTableID(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetNotCheckedRegDataCheckedByBasicInfoIDRegIDTabID_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_datachecked, cmd, Database);

                    IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.KAF_GetRegDataCheckedByBasicInfoIDRegIDTabID_GSreg_datachecked"));
            }
        }

        public async Task<long> UpdateRegDataCheckedByApplicantTable(Database db, DbTransaction transaction, reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_datachecked_Upd_Ext";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(reg_datachecked, cmd, db);
                FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);

                if ((reg_datachecked.isMarried != null))
                    Database.AddInParameter(cmd, "@IsMarried", DbType.Boolean, reg_datachecked.isMarried);

                try
                {
                    IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = db.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.Updatereg_datachecked"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<reg_datacheckedEntity> Ireg_datacheckedDataAccessObjects.GetRegDataCheckedByBasicinfoRegistrationID(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegDataCheckedByBasicinfoRegistrationID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_datachecked, cmd, Database);

                    IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GetRegDataCheckedByBasicinfoRegistrationID"));
            }
        }

        public async Task<IList<reg_datacheckedEntity>> GetAllRegDataChecked(Database db, DbTransaction transaction, reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_datachecked_GA";
                IList<reg_datacheckedEntity> itemList = new List<reg_datacheckedEntity>();
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    //get only active Reg_DateChecked
                    reg_datachecked.isactive = true;

                    AddSortExpressionParameter(cmd, reg_datachecked.SortExpression);
                    FillSequrityParameters(reg_datachecked.BaseSecurityParam, cmd, db);
                    FillParameters(reg_datachecked, cmd, db);

                    IAsyncResult result = db.BeginExecuteReader(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = db.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_datacheckedEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_datacheckedDataAccess.GetAllRegDataChecked"));
            }
        }


    }
}