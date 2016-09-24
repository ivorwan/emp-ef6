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
    public class ACustomFieldValueConfig : EntityTypeConfiguration<Models.ACustomFieldValue>
    {
        public ACustomFieldValueConfig()
        {
            Property(usr => usr.UserId)
                .HasColumnName("user_id")
                .IsRequired();
            Property(usr => usr.CustomFieldId)
                .HasColumnName("custom_field_id")
                .IsRequired();
            HasKey(t => new { t.UserId, t.CustomFieldId });

            Map(m =>
            {
                m.Properties(t => new { t.UserId, t.CustomFieldId });
                m.ToTable("iw.custom_field_values");
            });


            Map<Models.LookupCustomField>(m =>
            {
                m.Property(t => t.LookupValue).HasColumnName("lookup_value");
                m.Properties(t => new { t.LookupValue });
                m.ToTable("iw.custom_field_values");
                m.Requires("field_type").HasValue((int)Models.CustomFieldType.Lookup);
            });

            Map<Models.TextCustomField>(m =>
            {
                m.Property(t => t.Value).HasColumnName("text_value");
                m.Properties(t => new { t.Value });
                m.ToTable("iw.custom_field_values");
                m.Requires("field_type").HasValue((int)Models.CustomFieldType.Text);
            });



        }

    }


}
