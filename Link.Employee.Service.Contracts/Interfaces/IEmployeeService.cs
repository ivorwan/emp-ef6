using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models = Link.Employee.DTO.Models;

namespace Link.Employee.Service.Contracts.Interfaces
{
    /// <summary>
    ///		<![CDATA[
    ///    		Describe the purpose of this file.
    ///   	]]>
    ///     <csod-wiki>
    ///	        <csod-pageId></csod-pageId>
    ///     </csod-wiki>
    /// </summary>
    public interface IEmployeeService
    {
        Models.Employee GetEmployee(int employeeId);
        Models.Employee AddEmployee(Models.Employee employee);
    }
}
