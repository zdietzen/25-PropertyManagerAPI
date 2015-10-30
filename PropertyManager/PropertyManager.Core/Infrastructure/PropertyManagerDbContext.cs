using PropertyManager.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManager.Core.Infrastructure
{
   public class PropertyManagerDbContext : DbContext
    {
        public PropertyManagerDbContext() : base("PropertyManager")
        {
        }

        public IDbSet<Property> Properties { get; set; }
        public IDbSet<Tenant> Tenants { get; set; }
        public IDbSet<Lease> Leases { get; set; }

    }

}
