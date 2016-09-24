using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEF.Models
{
    /// <summary>
    ///		<![CDATA[
    ///    		Describe the purpose of this file.
    ///   	]]>
    ///     <csod-wiki>
    ///	        <csod-pageId></csod-pageId>
    ///     </csod-wiki>
    /// </summary>
//    [Table("custom_field_values", Schema = "iw")]
    public abstract class ACustomFieldValue
    {
        //[Key]
        //[Column("user_id", Order = 1)]
        public int UserId { get; set; }

        //[Key]
        //[Column("custom_field_id", Order = 2)]
        public int CustomFieldId { get; set; }

    }
}

    


