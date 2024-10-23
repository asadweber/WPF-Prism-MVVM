﻿using KAF.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Module.ViewModels
{
    public class DepartmentViewModel : BaseViewModel
    {
        private readonly IRegionManager _regionManager;

        public DepartmentViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
    }
}
