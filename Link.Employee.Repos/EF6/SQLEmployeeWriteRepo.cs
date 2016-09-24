using Link.Employees.Repos.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class SQLEmployeeWriteRepo : IWriteRepo
    {
        IwContext _dbContext;
        DbContextTransaction _dbContextTransaction;

        public SQLEmployeeWriteRepo(IwContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Models.Employee AddEmployee(Models.Employee employee)
        {

            _dbContext.Users.Add(employee);
            _dbContext.SaveChanges();
            return employee;

            //Models.User u = context.Users.Where(x => x.UserId == 6).FirstOrDefault();
            //u.CustomFieldValues.Add(new TextCustomField() { CustomFieldId = 100, Value = "test 2" });
            //u.CustomFieldValues.Add(new LookupCustomField() { CustomFieldId = 101, LookupValue = 200 });
            //context.SaveChanges();
        }

        public void BeginTransaction()
        {
            _dbContextTransaction = _dbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbContextTransaction.Commit();
        }

        public void Rollback()
        {
            _dbContextTransaction.Rollback();
        }
    }
}
