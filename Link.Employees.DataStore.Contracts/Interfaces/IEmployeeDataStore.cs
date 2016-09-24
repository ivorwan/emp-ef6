using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models = Link.Employee.DTO.Models;

namespace Link.Employee.DataStore.Contracts.Interfaces
{
    /// <summary>
    ///		<![CDATA[
    ///    		Describe the purpose of this file.
    ///   	]]>
    ///     <csod-wiki>
    ///	        <csod-pageId></csod-pageId>
    ///     </csod-wiki>
    /// </summary>
    public interface IEmployeeDataStore
    {
        Models.Employee GetEmployee(int employeeId);
        Models.Employee AddEmployee(Models.Employee employee);


        // ====================================================================
        // begin tran, commit and rollback only applies to write Data Store
        // not a big fan of leaving this here, but couldn't figure out to 
        // get the unit work pattern integrated properly without crossing boundaries/concerns
        // ====================================================================
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
