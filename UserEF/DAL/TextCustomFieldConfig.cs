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
    public class TextCustomFieldConfig : EntityTypeConfiguration<Models.TextCustomField>
    {
        public TextCustomFieldConfig()
        {
            Property(usr => usr.Value)
                .HasColumnName("text_value")
                .IsRequired();

            Map(m =>
            {
                m.Properties(t => new { t.Value });
                m.ToTable("iw.custom_field_values");
            });

        }
        


    }
    
}
