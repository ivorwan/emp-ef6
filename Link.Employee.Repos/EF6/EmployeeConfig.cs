using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
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
    public class EmployeeConfig : EntityTypeConfiguration<Models.Employee>
    {
        public EmployeeConfig()
        {
            Property(usr => usr.UserId)
                .HasColumnName("user_id")
                .IsRequired();
            Property(usr => usr.LastName)
                .HasColumnName("last_name");
            Property(usr => usr.FirstName)
                .HasColumnName("first_name");

            Property(usr => usr.Address1)
                .HasColumnName("address1");

            Property(usr => usr.Address2)
                .HasColumnName("address2");

            HasKey(t => new { t.UserId });

            //ToTable("[iw].[users]");
            Map(m =>
            {
                m.Properties(t => new { t.FirstName, t.LastName });
                m.ToTable("iw.users");
            }
                );
            Map(m =>
            {
                m.Properties(t => new { t.Address1, t.Address2 });
                m.ToTable("iw.user_detail");
            });

        }

    }
}
