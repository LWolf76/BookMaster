using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BM.Web.Models
{
    public class BookMasterDb : DbContext
    {
        public BookMasterDb()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer(new BookMasterInitalizer());
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemContent> ItemContents { get; set; }


        public class BookMasterInitalizer : DropCreateDatabaseAlways<BookMasterDb>
        {
            //Add Test Data
            protected override void Seed(BookMasterDb context)
            {
                var Book1 = new Item
                {
                    Title = "Book One Title",
                    Author = "B1 Author",
                    Edition = "B1 Edition",
                    ISBN = "B1 ISBN",
                    Location = "B1 Location",
                    Pages = 150
                };

                var Book2 = new Item
                {
                    Title = "Book Two Title",
                    Author = "B2 Author",
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 250
                };

                var Book3 = new Item
                {
                    Title = "Book Three Title",
                    Author = "B3 Author",
                    Edition = "B3 Edition",
                    ISBN = "B3 ISBN",
                    Location = "B3 Location",
                    Pages = 350
                };

                var Book4 = new Item
                {
                    Title = "Book Four Title",
                    Author = "B4 Author",
                    Edition = "B4 Edition",
                    ISBN = "B4 ISBN",
                    Location = "B4 Location",
                    Pages = 450
                };

                context.Set<Item>().Add(Book1);
                context.Set<Item>().Add(Book2);
                context.Set<Item>().Add(Book3);
                context.Set<Item>().Add(Book4);
            }
        }

    }


}