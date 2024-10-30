using System;
using System.Collections.Generic;
using System.Text;

namespace BFO.Base
{
    public abstract class BaseFacade
    {

        private bool _isDisposed;


        #region Constructer & Destructer

        protected BaseFacade()
        {

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

        ~BaseFacade()
        {
            Dispose(false);
        }

        #endregion

        //[DebuggerStepThrough()]

        protected virtual Exception GetFacadeException(Exception ex, string SourceOfException)
        {
            //if (System.Configuration.ConfigurationSettings.AppSettings["ShowError"].ToString().Equals("1"))
            //{
            if (!ex.Source.Equals("Data Access Layer"))
            {
                string msg = ex.Message.ToString() + "Source: " + SourceOfException;
                Exception CustomEx = new Exception(msg);
                CustomEx.Source = "Facade Layer";
                throw CustomEx;
            }
            throw ex;
            //}
            // else
            //throw ex;
        }
    }
}
