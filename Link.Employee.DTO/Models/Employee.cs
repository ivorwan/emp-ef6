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
    public class Employee
    {
        //[Column("user_id")]
        public int UserId { get; set; }

        //[Column("last_name")]
        public string LastName { get; set; }

        //[Column("first_name")]
        public string FirstName { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }

        //public virtual ICollection<ACustomFieldValue> CustomFieldValues { get; set; }
    }
}
