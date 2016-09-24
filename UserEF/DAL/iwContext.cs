using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEF.Models;

namespace UserEF.DAL
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

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.CustomField> CustomFields { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new ACustomFieldValueConfig());
            //modelBuilder.Configurations.Add(new TextCustomFieldConfig());
            //modelBuilder.Configurations.Add(new LookupCustomFieldConfig());



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





            //modelBuilder.Entity<Models.ACustomFieldValue>()
            //    .Map<Models.LookupCustomField>(m => m.Requires("field_type").HasValue((int)CustomFieldType.Lookup))
            //    .Map<Models.TextCustomField>(m => m.Requires("field_type").HasValue((int)CustomFieldType.Text));

            base.OnModelCreating(modelBuilder);


        }
    }
}
