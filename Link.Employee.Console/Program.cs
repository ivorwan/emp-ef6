using Link.Employee.Repos.EF6;
using Link.Employee.Service;
using Link.Employee.Service.Contracts.Interfaces;
using Link.Employees.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models = Link.Employee.DTO.Models;


namespace Link.Employee.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            IEmployeeService svc = new EmployeeService(
                new EmployeeDataStore(
                    new SQLEmployeeWriteRepo(new IwContext()),
                    new SQLEmployeeReadRepo()
                    ));

            Models.Employee model = new Models.Employee() { FirstName = "eita", LastName = "porra", Address1 = "address", Address2 = "address2" };

            svc.AddEmployee(model);
        }
    }
}
