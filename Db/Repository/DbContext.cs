using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Db.Model;

namespace Db.Repository
{
    public class Database:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Download> Downloads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=123123;database=nonsetup;uid=dbUser;pwd=123;");
    }

}