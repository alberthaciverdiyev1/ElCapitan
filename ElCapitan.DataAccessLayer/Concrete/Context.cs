﻿using ElCapitan.EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=ASUS\\MSSQLSERVER01;database=ElCapitan;integrated security=true; encrypt=false");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
