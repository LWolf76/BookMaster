using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using BookMaster.Models;

namespace BookMaster.DAL
{
    public class BookMasterInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookMasterContext>
    {
        protected override void Seed(BookMasterContext context)
        {
            var items = new List<Item>
            {
                new Item
                {
                    Title = "Book One Title",
                    Author = "B1 Author",
                    Edition = "B1 Edition",
                    ISBN = "B1 ISBN",
                    Location = "B1 Location",
                    Pages = 150
                },
                new Item
                {
                    Title = "Book Two Title",
                    Author = "B2 Author",
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 250
                },
                new Item
                {
                    Title = "Book Three Title",
                    Author = "B3 Author",
                    Edition = "B3 Edition",
                    ISBN = "B3 ISBN",
                    Location = "B3 Location",
                    Pages = 350
                },
                new Item
                {
                    Title = "Book Four Title",
                    Author = "B4 Author",
                    Edition = "B4 Edition",
                    ISBN = "B4 ISBN",
                    Location = "B4 Location",
                    Pages = 450
                },
                new Item
                {
                    Title = "Best of Friends",
                    Author = "Harry Lorayne",
                    Edition = "B4 Edition",
                    ISBN = "B4 ISBN",
                    Location = "B4 Location",
                    Pages = 559
                },
                new Item
                {
                    Title = "Tarbell Course in Magic - Volume 1",
                    Author = "Harlan Tarbell",
                    Edition = "B1 Edition",
                    ISBN = "B1 ISBN",
                    Location = "B1 Location",
                    Pages = 413
                },
                new Item
                {
                    Title = "Tarbell Course in Magic - Volume 2",
                    Author = "Harlan Tarbell",
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 413
                },
                new Item
                {
                    Title = "Tarbell Course in Magic - Volume 3",
                    Author = "Harlan Tarbell",
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 413
                },
                new Item
                {
                    Title = "Tarbell Course in Magic - Volume 4",
                    Author = "Harlan Tarbell",
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 413
                },
                new Item
                {
                    Title = "Tarbell Course in Magic - Volume 5",
                    Author = "Harlan Tarbell",
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 413
                },
                new Item
                {
                    Title = "Tarbell Course in Magic - Volume 6",
                    Author = "Harlan Tarbell",
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 413
                }
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();

        }

    }
}