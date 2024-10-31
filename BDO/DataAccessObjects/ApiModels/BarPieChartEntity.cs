using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.DataAccessObjects.ApiModels
{

    [Serializable]
    public class BarPieChartEntity
    {
        public List<string> labels { get; set; }
        public List<Dataset> datasets { get; set; }
    }

    [Serializable]
    public class Dataset
    {
        public string label { get; set; }
        public List<int> data { get; set; }
        public List<string> backgroundColor { get; set; }
        public List<string> borderColor { get; set; }
        public int borderWidth { get; set; }
    }
}
