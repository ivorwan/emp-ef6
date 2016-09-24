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
    public abstract class ACustomFieldValue
    {
        public int UserId { get; set; }

        public int CustomFieldId { get; set; }

    }
}
