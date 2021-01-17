using BussinesLayer.Entities;
using BussinessCommon.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.Contexts
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions options)
      : base(options)
        {
        }
        public PageParameters BaseParameters { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        public void SetReadUnCommitted()
        {
            if (Database.IsSqlServer())
            {
                Database.OpenConnection();
                Database.SetCommandTimeout(TimeSpan.FromSeconds(30));
                Database.ExecuteSqlCommand(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; 
                                             SET ARITHABORT ON");

            }
        }

        public DbSet<T> Get<T>() where T : class
        {
            return Set<T>();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
