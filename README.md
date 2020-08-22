Implementation .Net Core API + EntityFramework + JWT Authentication

Prerequisites:

Install .Net Core 3.1.2 SDK

  * Nuget Packages :
  
    Microsoft.EntityFrameworkCore.SqlServer(3.1.7)
    
    Microsoft.EntityFrameworkCore.Tools(3.1.7)
    
    Microsoft.AspNetCore.Authentication.JWTBearer(3.1.7)
    
    Microsoft.ASPNetCore.Cors(2.2.0)

 Build and run the application using IISExpress

 Application runs on a Base url: http://localhost:50858

 Here are the API's:
 
  * GetAllEmployees:
  
  * HTTPMethod: GET
  
  * Url: http://localhost:50858/api/employees
  
  * GetEmployeeByID:
  
  * HTTPMethod: GET
  * Url: http://localhost:50858/api/employees/6
  
  * CreateNewEmployee:
  * HTTPMethod: POST
  * Url: http://localhost:50858/api/employees
  * Body:
    {
     "firstName": "Lalith",
    "lastName": "Swarna",
    "designation": "Technical Lead"
    }
  
  * UpdateEmployee:
  * HTTPMethod: PUT
  * Url: http://localhost:50858/api/employees
  * Body:
        {
          "id": 1
          "firstName": "Lalith",
          "lastName": "Swarna",
          "designation": "Technical Lead"
         }

  * DeleteEmployee:
  * HTTPMethod: DELETE
  * Url: http://localhost:50858/api/employees/6
  * Mention the id of the employee to be deleted in the url
