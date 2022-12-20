using EF_Code_First___Study_1.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___Study_1.Migrations
{
    internal sealed class Configuration:
        DbMigrationsConfiguration<EF_Code_First___Study_1.Models.Context.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(MyContext context)
        {
            base.Seed(context);
        }

    }
}
