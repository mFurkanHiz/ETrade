﻿using ETrade.Ent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> op) : base(op)
        {

        }
        // 
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
