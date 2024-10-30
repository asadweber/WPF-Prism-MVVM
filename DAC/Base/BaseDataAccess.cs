using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace DAC.Core.Base
{
    
    internal interface IEntityBuilder<T> where T : BaseEntity
    {
        IList<T> BuildEntities(IDataReader dataReader);

        T BuildEntity(IDataReader dataReader);
    }

    internal abstract class BaseDataAccess : MarshalByRefObject, IDisposable
    {


        #region Instance Variables
        private string _objConstring = new AppConfiguration()._connectionString;
        private string _objSaltstring = new AppConfiguration()._saltString;
        private bool _isDisposed;
        private Context _context;

        private Database _db;

        #endregion

        #region Properties

        protected virtual Context Context
        {
            [DebuggerStepThrough()]
            get
            {
                if (_context == null)
                {
                    _context = new Context();
                }

                return _context;
            }
        }

        protected virtual Database Database
        {

           //[DebuggerStepThrough()]
            get
            {

                if (_db == null)
                {
                    string type = typeof(Database).ToString();

                    if (Context.Contains(type))
                    {
                        _db = (Database)Context[type];

                    }
                    else
                    {
                        DatabaseProviderFactory factory = new DatabaseProviderFactory();
                        AppConfig.EncryptionHandler.EncryptionHelper objEnc = new AppConfig.EncryptionHandler.EncryptionHelper();
                        _objConstring = objEnc.Decrypt(_objConstring, true, _objSaltstring);

                        _db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(_objConstring);
                        Context[type] = _db as IDisposable;
                    }
                }

                return _db;
            }
        }

        #endregion

        #region Constructer & Destructer

        protected BaseDataAccess(Context context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                }
            }

            _isDisposed = true;
        }

        ~BaseDataAccess()
        {
            Dispose(false);
        }

        #endregion

        #region Protected Methods
        public enum OparationType
        {
            Save = 0,
            Update = 1
        }

        [DebuggerStepThrough()]
        protected void AddOutputParameter(DbCommand command)
        {
            Database.AddOutParameter(command, "@RETURN_KEY", DbType.Int64, 8);
        }
        [DebuggerStepThrough()]
        protected void AddCurrentPageParameter(DbCommand command, int CurrentPage)
        {
            Database.AddInParameter(command, "@CurrentPage", DbType.Int32, CurrentPage);
        }
        [DebuggerStepThrough()]
        protected void AddPageSizeParameter(DbCommand command, int PageSize)
        {
            Database.AddInParameter(command, "@PageSize", DbType.Int32, PageSize);
        }
        [DebuggerStepThrough()]
        protected void AddSortExpressionParameter(DbCommand command, string SortExpression)
        {
            Database.AddInParameter(command, "@SortExpression", DbType.String, SortExpression);
        }
        [DebuggerStepThrough()]
        protected void AddTotalRecordParameter(DbCommand command)
        {
            Database.AddOutParameter(command, "@TotalRecord", DbType.Int64, 8);
        }

        protected void FillSequrityParameters(SecurityCapsule securityCapsule, DbCommand cmd, Database database)
        {
            if (securityCapsule != null)
            {
                database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, securityCapsule.createdbyusername);
                database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, securityCapsule.updatedbyusername);
                database.AddInParameter(cmd, "@CreatedDate", DbType.DateTime, securityCapsule.createddate.GetValueOrDefault(DateTime.Now));
                database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, securityCapsule.updateddate.GetValueOrDefault(DateTime.Now));
                database.AddInParameter(cmd, "@IPAddress", DbType.String, securityCapsule.ipaddress);
                database.AddInParameter(cmd, "@TransID", DbType.String, securityCapsule.transid);
                database.AddInParameter(cmd, "@Ts", DbType.String, securityCapsule.ts);
            }
        }

        [DebuggerStepThrough()]
        protected void AddOutputParameter(DbCommand command, Database db)
        {
            db.AddOutParameter(command, "@RETURN_KEY", DbType.Int64, 8);
        }

        [DebuggerStepThrough()]
        protected void AddCurrentPageParameter(DbCommand command, int CurrentPage, Database db)
        {
            db.AddInParameter(command, "@CurrentPage", DbType.Int32, CurrentPage);
        }
        [DebuggerStepThrough()]
        protected void AddPageSizeParameter(DbCommand command, int PageSize, Database db)
        {
            db.AddInParameter(command, "@PageSize", DbType.Int32, PageSize);
        }
        [DebuggerStepThrough()]
        protected void AddSortExpressionParameter(DbCommand command, string SortExpression, Database db)
        {
            db.AddInParameter(command, "@SortExpression", DbType.String, SortExpression);
        }

        //EntryDate
        #endregion


        #region Data Access Layer Exception

        protected virtual DataException GetDataAccessException(Exception ex, string SourceOfException)
        {
            DataException CustomEx = new DataException();
            string ErrorMessage = string.Empty;
            if (ex is System.Data.SqlClient.SqlException)
            {
                SqlException excep = ex as SqlException;

                switch (excep.Number)
                {
                    // Duplicate Value
                    case 2601:
                        {
                            ErrorMessage = "Duplicate value can not be saved.";
                            break;
                        }

                    // Reference
                    case 547:
                        {
                            ErrorMessage = "This reference is already in use. Data can not be deleted.";
                            break;
                        }
                    case 515:
                        {
                            ErrorMessage = "Can not insert null value.";
                            break;
                        }
                    case 8114:
                        {
                            ErrorMessage = "Exceeded value range";
                            break;
                        }
                    default:
                        {
                            ErrorMessage = ex.Message;// "An error occurred. Please contract with system admin.";
                            break;
                        }
                }

                CustomEx = new DataException(ErrorMessage);
                CustomEx.Source = "Data Access Layer";
            }
            else
            {
                ErrorMessage = ex.Message; //"An error occurred. Please contract with system admin.";
                CustomEx = new DataException(ErrorMessage);
                CustomEx.Source = "Data Access Layer";
            }
            throw CustomEx;
        }

        #endregion
    }
}
