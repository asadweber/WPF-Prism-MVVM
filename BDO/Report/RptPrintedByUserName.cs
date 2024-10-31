using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptPrintedByUserName", Namespace = "http://www.KAF.com/types")]
    public partial class RptPrintedByUserName


    {

        public string printedByUsername { get; set; }
    }






}
