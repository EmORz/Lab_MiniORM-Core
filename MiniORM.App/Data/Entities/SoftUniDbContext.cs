﻿namespace MiniORM.App.Data.Entities
{
    public class SoftUniDbContext : DbContext
    {
        public SoftUniDbContext(string connetionString) : base(connetionString)
        {
        }

        public DbSet<Employee> Employees { get; }

        public DbSet<Project> Projects { get;  }


        public DbSet<Department> Departments { get; }

        public DbSet<EmployeesProjects> EmployeesProjects { get; }
    }
}