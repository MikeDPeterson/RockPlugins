using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPOS.Data
{
    public partial class RockPOSContext : DbContext
    {
        public RockPOSContext()
            : base( "RockContext" )
        {
            // intentionally left blank
        }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // model configurations
        }
    }
}
