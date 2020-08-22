using EmployeeManagementModels;
using System;
using System.Collections.Generic;

namespace EmployeeManagementAPI.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
    }
}
