using EF_Code_First___Study_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___Study_1.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }

    }
}
