using Link.Employees.Repos.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Link.Employee.DTO.Models;

namespace Link.Employee.Repos.EF6
{
    /// <summary>
    ///		<![CDATA[
    ///    		Describe the purpose of this file.
    ///   	]]>
    ///     <csod-wiki>
    ///	        <csod-pageId></csod-pageId>
    ///     </csod-wiki>
    /// </summary>
    public class SQLEmployeeReadRepo : IReadRepo
    {
        public Models.Employee GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
