using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.ViewModels
{
    public class MasterViewModel : BaseViewModel
    {
        private readonly IRegionManager _regionManager;

        public MasterViewModel(IRegionManager regionManager)
        {
            Title = "KNS";
            _regionManager = regionManager;

        }
    }
}
