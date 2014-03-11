using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using BookMaster.Models;

namespace BookMaster.DAL
{
    public class BookMasterContext : DbContext
    {
        public BookMasterContext() : base("BookMasterContext")
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}