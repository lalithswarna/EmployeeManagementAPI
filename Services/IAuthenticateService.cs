using EmployeeManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Services
{
   public interface IAuthenticateService
    {
        User Authenticate(string username, string password);
    }
}
