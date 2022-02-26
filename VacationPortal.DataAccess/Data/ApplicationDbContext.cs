﻿using Microsoft.EntityFrameworkCore;
using VacationPortal.DataAccess.Data.EntityConfigurations;
using VacationPortal.Models;

namespace VacationPortal.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
