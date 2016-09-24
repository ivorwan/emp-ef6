using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.Employee.DTO.Models
{
    /// <summary>
    ///		<![CDATA[
    ///    		Describe the purpose of this file.
    ///   	]]>
    ///     <csod-wiki>
    ///	        <csod-pageId></csod-pageId>
    ///     </csod-wiki>
    /// </summary>
    //[Table("custom_field", Schema = "iw")]
    public class CustomField
    {
        //[Key]
        //[Column("custom_field_id")]
        public int CustomFieldId { get; set; }

        //[Column("name")]
        public string Name { get; set; }

        //[Column("field_type")]
        public CustomFieldType Type { get; set; }

    }


    public enum CustomFieldType { Text = 10, Lookup = 20 }
}
