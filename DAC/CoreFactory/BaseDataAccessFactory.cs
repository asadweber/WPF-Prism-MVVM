using AppConfig.ConfigDAAC;
using IDAC.Core.IDataAccessObjects.General;
using IDAC.Core.IDataAccessObjects.Security;
using IDAC.IDataAccessObjects.Security;
using IDAC.IDataAccessObjects.Security.ExtendedPartial;
using System.Diagnostics;

namespace DAC.Core.CoreFactory
{
    public abstract partial class BaseDataAccessFactory
    {

        #region Instance Variables
        private Context _context;
        #endregion

        #region Property
        protected virtual Context CurrentContext
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

        #endregion

        #region Constructer
        [DebuggerStepThrough()]
        public BaseDataAccessFactory(Context context)
        {
            _context = context;
        }

        public BaseDataAccessFactory() : base()
        {

        }

        #endregion

        #region Static Methods

        [DebuggerStepThrough()]
        public static BaseDataAccessFactory Create(Context context)
        {
            //BaseDataAccessFactory dataAccessFactory = new DataAccessFactory(context);
            return (BaseDataAccessFactory)new DataAccessFactory(context);
        }
        #endregion

        #region Factory Methods 


        #endregion


        #region Extended
        #region IKAFUserSecurityDataAccess
        public abstract IKAFUserSecurityDataAccess CreateKAFUserSecurityDataAccess();
        #endregion IKAFUserSecurityDataAccess
        #endregion

        #region Factory Methods 






        #region owin_formaction
        public abstract Iowin_formactionDataAccessObjects Createowin_formactionDataAccess();
        #endregion owin_formaction


        #region owin_lastworkingpage
        public abstract Iowin_lastworkingpageDataAccessObjects Createowin_lastworkingpageDataAccess();
        #endregion owin_lastworkingpage


        #region owin_role
        public abstract Iowin_roleDataAccessObjects Createowin_roleDataAccess();
        #endregion owin_role


        #region owin_rolepermission
        public abstract Iowin_rolepermissionDataAccessObjects Createowin_rolepermissionDataAccess();
        #endregion owin_rolepermission


        #region owin_user
        public abstract Iowin_userDataAccessObjects Createowin_userDataAccess();
        #endregion owin_user


        #region owin_userclaims
        public abstract Iowin_userclaimsDataAccessObjects Createowin_userclaimsDataAccess();
        #endregion owin_userclaims


        #region owin_userlogintrail
        public abstract Iowin_userlogintrailDataAccessObjects Createowin_userlogintrailDataAccess();
        #endregion owin_userlogintrail


        #region owin_userpasswordresetinfo
        public abstract Iowin_userpasswordresetinfoDataAccessObjects Createowin_userpasswordresetinfoDataAccess();
        #endregion owin_userpasswordresetinfo


        #region owin_userprefferencessettings
        public abstract Iowin_userprefferencessettingsDataAccessObjects Createowin_userprefferencessettingsDataAccess();
        #endregion owin_userprefferencessettings


        #region owin_userrole
        public abstract Iowin_userroleDataAccessObjects Createowin_userroleDataAccess();
        #endregion owin_userrole


        #region owin_userroles
        public abstract Iowin_userrolesDataAccessObjects Createowin_userrolesDataAccess();
        #endregion owin_userroles


        #region owin_userstatuschangehistory
        public abstract Iowin_userstatuschangehistoryDataAccessObjects Createowin_userstatuschangehistoryDataAccess();
        #endregion owin_userstatuschangehistory


        #region tran_login
        public abstract Itran_loginDataAccessObjects Createtran_loginDataAccess();
        #endregion tran_login



      
        #endregion


	}
}



