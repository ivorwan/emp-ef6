using Link.Employee.Service.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Link.Employee.DTO.Models;
using Link.Employee.DataStore.Contracts.Interfaces;

namespace Link.Employee.Service
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeDataStore _dataStore;

        public EmployeeService(IEmployeeDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public Models.Employee AddEmployee(Models.Employee employee)
        {
            return _dataStore.AddEmployee(employee);
        }

        public Models.Employee GetEmployee(int employeeId)
        {
            return _dataStore.GetEmployee(employeeId);
        }
    }
}
