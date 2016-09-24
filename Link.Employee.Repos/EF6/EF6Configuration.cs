using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class EF6Configuration : DbConfiguration
    {
        // because we don't want to add the EntityFramework section in the app.config to the main app's config, we actually configure EF6 in code
        public EF6Configuration()
        {
            SetProviderServices(
                SqlProviderServices.ProviderInvariantName,
                SqlProviderServices.Instance);

            SetDefaultConnectionFactory(new SqlConnectionFactory());
        }
    }
}
