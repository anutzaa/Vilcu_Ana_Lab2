﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vilcu_Ana_Lab2.Models;

namespace Vilcu_Ana_Lab2.Data
{
    public class Vilcu_Ana_Lab2Context : DbContext
    {
        public Vilcu_Ana_Lab2Context (DbContextOptions<Vilcu_Ana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vilcu_Ana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Vilcu_Ana_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Vilcu_Ana_Lab2.Models.Author>? Author { get; set; }
    }
}
