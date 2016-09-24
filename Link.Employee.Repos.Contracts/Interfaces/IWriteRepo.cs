using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models = Link.Employee.DTO.Models;

namespace Link.Employees.Repos.Contracts.Interfaces
{
    /// <summary>
    ///		<![CDATA[
    ///    		Describe the purpose of this file.
    ///   	]]>
    ///     <csod-wiki>
    ///	        <csod-pageId></csod-pageId>
    ///     </csod-wiki>
    /// </summary>
    public interface IWriteRepo
    {
        Models.Employee AddEmployee(Models.Employee employee);

        
        // ====================================================================
        // not a big fan of leaving this here, but couldn't figure out to 
        // get the unit work pattern integrated properly without crossing boundaries/concerns
        // ====================================================================
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
