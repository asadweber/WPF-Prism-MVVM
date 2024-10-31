using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    public class AjaxResponse
    {
        
        public Object data { get; }
        public long recordsTotal { get; }
        public long recordsFiltered { get; }

        public string responsecode { get; }
        public string responsetext { get; }
        public string responsestatus { get; }
        public string responsetitle { get; }
        public string responseredirecturl { get; }
        public string CivilId { get; }
        public string AditionalParam { get; }



        public AjaxResponse(string _responsecode, string _responsetext, string _responsestatus, string _responsetitle, string _responseredirecturl)
        {
            responsecode = _responsecode;
            responsetext = _responsetext;
            responsestatus = string.IsNullOrEmpty(_responsestatus) == true ? CLL.LLClasses._Status._statusSuccess  : _responsestatus;
            responsetitle = _responsetitle;
            responseredirecturl = _responseredirecturl;
        }

        public AjaxResponse(string _responsecode, string _responsetext, string _responsestatus, string _responsetitle, string _responseredirecturl,string _civilId)
        {
            responsecode = _responsecode;
            responsetext = _responsetext;
            responsestatus = string.IsNullOrEmpty(_responsestatus) == true ? CLL.LLClasses._Status._statusSuccess : _responsestatus;
            responsetitle = _responsetitle;
            responseredirecturl = _responseredirecturl;
            this.CivilId = _civilId;
        }

        public AjaxResponse(string _responsecode, string _responsetext, string _responsestatus, string _responsetitle, string _responseredirecturl, string _civilId, string _AditionalParam)
        {
            responsecode = _responsecode;
            responsetext = _responsetext;
            responsestatus = string.IsNullOrEmpty(_responsestatus) == true ? CLL.LLClasses._Status._statusSuccess : _responsestatus;
            responsetitle = _responsetitle;
            responseredirecturl = _responseredirecturl;
            this.CivilId = _civilId;
            this.AditionalParam = _AditionalParam;
        }

        public AjaxResponse(long _recordsTotal, Object _data)
        {
            recordsTotal = _recordsTotal;
            recordsFiltered = _recordsTotal;
            data = _data;
        }
        public AjaxResponse(Object _data)
        {
            data = _data;
        }
    }
}
