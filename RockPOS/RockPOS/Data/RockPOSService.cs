using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPOS.Data
{
    public class RockPOSService<T> : Rock.Data.Service<T> where T : Rock.Data.Entity<T>, new()
    {
        public RockPOSService()
            : this( new RockPOSContext() )
        {
        }

        public RockPOSService( RockPOSContext rockPOSContext )
            : base( rockPOSContext )
        {
            RockPOSContext = rockPOSContext;
        }

        public RockPOSContext RockPOSContext { get; private set; }
    }
}
