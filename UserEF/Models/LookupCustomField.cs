using System;
using System.Collections.Generic;
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
    //[Table("custom_field_values", Schema = "iw")]
    public class LookupCustomField : ACustomFieldValue
    {

        //[Column("lookup_value")]
        public int? LookupValue { get; set; }
    }
}
