
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.Models;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.General
{
    public sealed partial class NotificationExcelObject
	{
		private string _Serial;

        public string Serial
        {
            get { return _Serial; }
			set { _Serial = value; }
		}

		private string _CivilID;

		public string CivilID
        {
			get { return _CivilID; }
			set { _CivilID = value; }
		}

		private string _MessageSubject;

		public string MessageSubject
        {
			get { return _MessageSubject; }
			set { _MessageSubject = value; }
		}

		private string _MessageBody;

		public string MessageBody
        {
			get { return _MessageBody; }
			set { _MessageBody = value; }
		}

		private string _MessageSubjectAR;

		public string MessageSubjectAR
        {
			get { return _MessageSubjectAR; }
			set { _MessageSubjectAR = value; }
		}

		private string _MessageBodyAR;

		public string MessageBodyAR
        {
			get { return _MessageBodyAR; }
			set { _MessageBodyAR = value; }
		}

		private string _MobileNumber;

		public string MobileNumber
        {
			get { return _MobileNumber; }
			set { _MobileNumber = value; }
		}

		private string _EmailContent;

		public string EmailContent
        {
			get { return _EmailContent; }
			set { _EmailContent = value; }
		}

		private string _EmailContentAR;

		public string EmailContentAR
        {
			get { return _EmailContentAR; }
			set { _EmailContentAR = value; }
		}

		private string _Email;

		public string Email
        {
			get { return _Email; }
			set { _Email = value; }
		}

	}
}
