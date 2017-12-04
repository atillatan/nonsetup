using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Db.Model;

namespace Db.Repository
{
    public class Database : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public DbSet<Download> Download { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=46.101.12.71;database=nonsetup;uid=dbUser;pwd=...;");
    }

}