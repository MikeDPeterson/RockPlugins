using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace RockPOS.Migrations
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<RockPOS.Data.RockPOSContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            CodeGenerator = new Rock.Migrations.RockCSharpMigrationCodeGenerator<RockPOS.Data.RockPOSContext>( true );
        }

        /// <summary>
        /// Seeds the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        protected override void Seed(RockPOS.Data.RockPOSContext context)
        {
        }
    }
}
