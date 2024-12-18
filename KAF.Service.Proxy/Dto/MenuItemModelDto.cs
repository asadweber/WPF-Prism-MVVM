﻿using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.Service.Proxy.Dto
{
    public class MenuItemModelDto : BaseModel
    {
        private int _id;
        private string _header;
        private DelegateCommand _command;

        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value); // Use SetProperty to notify property changes
        }

        public string Header
        {
            get => _header;
            set => SetProperty(ref _header, value);
        }

        public DelegateCommand Command
        {
            get => _command;
            set => SetProperty(ref _command, value);
        }
        public List<MenuItemModelDto> SubItems { get; set; } = new List<MenuItemModelDto>();
    }
}
