using Link.Employee.DataStore.Contracts.Interfaces;

using Link.Employees.Repos.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Link.Employee.DTO.Models;



namespace Link.Employees.DataStore
{
    /// <summary>
    ///		<![CDATA[
    ///    		Mainly a wrapper for the repos. 
    ///    		There might be multiple repos (one for read, one for write.. there might be a unit of work pattern as well)
    ///   	]]>
    ///     <csod-wiki>
    ///	        <csod-pageId></csod-pageId>
    ///     </csod-wiki>
    /// </summary>
    public class EmployeeDataStore : IEmployeeDataStore
    {
        IWriteRepo _writeRepo;
        IReadRepo _readRepo;
        public EmployeeDataStore(IWriteRepo writeRepo, IReadRepo readRepo)
        {
            // forks IEmployeeDataStore into a read repo and write repo
            _writeRepo = writeRepo;
            _readRepo = readRepo;
        }



        
        public Models.Employee AddEmployee(Models.Employee employee)
        {
            return _writeRepo.AddEmployee(employee);
        }

        public Models.Employee GetEmployee(int employeeId)
        {
            return _readRepo.GetEmployee(employeeId);
        }






        // ====================================================================
        // begin tran, commit and rollback only applies to write Data Store
        // not a big fan of leaving this here, but couldn't figure out to 
        // get the unit work pattern integrated properly without crossing boundaries/concerns
        // ====================================================================
        public void BeginTransaction()
        {
            _writeRepo.BeginTransaction();
        }

        public void Commit()
        {
            _writeRepo.Commit();
        }

        public void Rollback()
        {
            _writeRepo.Rollback();
        }
    }
}
