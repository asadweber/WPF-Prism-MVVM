﻿using KAF.UI.Common.Model;
using KAF.UI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        public Department GetDepartment(int id)
        {
            Department department = new Department();
            return department;
        }

        public async Task<List<Department>> GetDepartments()
        {
            // Create a list of departments with sample data
            //Let assume data load take some time
            await Task.Delay(300);
            List<Department> list = new List<Department>
                    {
                        new Department { DepartmentCode = 1, DepartmentName = "HR" },
                        new Department { DepartmentCode = 2, DepartmentName = "IT" },
                        new Department { DepartmentCode = 3, DepartmentName = "Finance" }
                    };

            return list;
        }
    }
}
