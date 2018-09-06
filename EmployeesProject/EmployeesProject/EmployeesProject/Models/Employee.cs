using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesProject.Models
{
        public class Employee
        {
            public int EmployeeId { get; set; }

            public string EmployeeName { get; set; }

            public string EmployeeDepartment { get; set; }

            public string Position { get; set; }

            public string Branch { get; set; }

            public string Mobile { get; set; }

            public decimal Salary { get; set; }
        }
    }
