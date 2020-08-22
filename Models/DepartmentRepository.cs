using EmployeeManagementModels;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementAPI.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDBContext appDbContext;

        public DepartmentRepository(AppDBContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Department GetDepartment(int departmentId)
        {
            return appDbContext.Departments
                .FirstOrDefault(d => d.DepartmentID == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDbContext.Departments;
        }
    }
}