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
    public class IwContext : DbContext
    {
        public IwContext() : base("IwContext")
        {

        }
        
        public DbSet<Models.Employee> Users { get; set; }
        public DbSet<Models.CustomField> CustomFields { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfig());
            modelBuilder.Configurations.Add(new ACustomFieldValueConfig());

            //modelBuilder.Entity<Models.User>()
            //    .Property(t => t.UserId).HasColumnName("user_id");
            //modelBuilder.Entity<Models.User>()
            //    .Property(t => t.FirstName).HasColumnName("first_name");
            //modelBuilder.Entity<Models.User>()
            //    .Property(t => t.LastName).HasColumnName("last_name");

            //modelBuilder.Entity<Models.User>()
            //    .Property(t => t.Address1).HasColumnName("address1");
            //modelBuilder.Entity<Models.User>()
            //    .Property(t => t.Address2).HasColumnName("address2");

            //modelBuilder.Entity<Models.User>()
            //    .Map(m =>
            //    {
            //        m.Properties(t => new { t.FirstName, t.LastName });
            //        m.ToTable("iw.users");
            //    }
            //    )
            //    .Map(m =>
            //    {
            //        m.Properties(t => new { t.Address1, t.Address2 });
            //        m.ToTable("iw.user_detail");
            //    });




            //modelBuilder.Entity<Link.Employee.Repos.Contracts.Models.ACustomFieldValue>()
            //    .Map<Link.Employee.Repos.Contracts.Models.LookupCustomField>(m => m.Requires("field_type").HasValue((int)CustomFieldType.Lookup))
            //    .Map<Link.Employee.Repos.Contracts.Models.TextCustomField>(m => m.Requires("field_type").HasValue((int)CustomFieldType.Text));

            base.OnModelCreating(modelBuilder);


        }
    }
}
