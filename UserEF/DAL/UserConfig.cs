using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class UserConfig : EntityTypeConfiguration<Models.User>
    {
        public UserConfig()
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
