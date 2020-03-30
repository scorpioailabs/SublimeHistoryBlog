﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardcoreHistory.Blazor.ViewModels
{
    public class RoleListViewModel
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int NumberOfUsers { get; set; }
    }
}
