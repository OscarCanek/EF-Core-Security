﻿using DevExpress.EntityFramework.SecurityDataStore;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSecurityODataService.Models {
    public class EFCoreDemoDbContext : SecurityDbContext {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DemoTask> Tasks { get; set; }
        public DbSet<ContactTask> ContactTasks { get; set; }
        //public DbSet<Position> Positions { get; set; }
        protected override void OnSecuredConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //base.OnSecuredConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase();
        }
    }
}
