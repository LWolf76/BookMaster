using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using Microsoft.Ajax.Utilities;
using BookMaster.Models;

namespace BookMaster.DAL
{
    public class BookMasterInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookMasterContext> // DropCreateDatabaseAlways 
    {
        protected override void Seed(BookMasterContext context)
        {

            var subjects = new List<Subject>
            {
                new Subject
                {
                    Description = "Coins"
                },
                new Subject()
                {
                    Description = "Cards"
                },
                new Subject()
                {
                    Description = "Wand"
                },
                new Subject()
                {
                    Description = "Balls"
                },
                new Subject()
                {
                    Description = "Silks"
                },
                new Subject()
                {
                    Description = "Match"
                },
                new Subject()
                {
                    Description = "Rubber Band"
                },
                new Subject()
                {
                    Description = "Paper Clip"
                }
            };
            subjects.ForEach(s => context.Subjects.Add(s));

            var items = new List<Item>
            {
                new Item
                {
                    ItemType = 0,
                    Title = "Book One Title",
                    Author = "B1 Author",
                    Edition = "B1 Edition",
                    ISBN = "B1 ISBN",
                    Location = "B1 Location",
                    Pages = 150,
                    Subjects = new Collection<Subject>
                    {
                        new Subject { Description = "Book" },
                        new Subject { Description = "DVD"},
                        new Subject { Description = "Description3"}
                    }
                },
                new Item
                {
                    ItemType = ItemType.Book,
                    Title = "The Expert at the Card Table",
                    Author = "S. W. Erdnase",
                    Publisher = "Unknown",
                    Published = 1902,
                    Edition = "Hardcover",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 205
                },
                new Item
                {
                    ItemType = ItemType.Book,
                    Title = "The Art of Astonishment - Book 1",
                    Author = "Paul Harris & Eric Mead",
                    Publisher = "A-1 MultiMedia",
                    Published = 1996,
                    Edition = "Hardcover",
                    ISBN = "B3 ISBN",
                    Location = "B3 Location",
                    Pages = 310
                },
                new Item
                {
                    ItemType = 0,
                    Title = "The Magic of Michael Ammar",
                    Author = "Michael Ammar",
                    Publisher = "L&L Publishing",
                    Published = 1991,
                    Edition = "Hardcover",
                    ISBN = "B4 ISBN",
                    Location = "B4 Location",
                    Pages = 306
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Best of Friends",
                    Author = "Harry Lorayne",
                    Publisher = "Harry Lorayne, Inc.",
                    Published = 1982,
                    Edition = "Hardcover",
                    ISBN = "B4 ISBN",
                    Location = "B4 Location",
                    Pages = 559
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Rim Shots",
                    Author = "Harry Lorayne",
                    Publisher = "Harry Lorayne, Inc.",
                    Published = 1973,
                    Edition = "Hardcover",
                    ISBN = "B4 ISBN",
                    Location = "B4 Location",
                    Pages = 148
                },
                new Item
                {
                    ItemType = 0,
                    Title = "The Cardician",
                    Author = "Ed Marlo",
                    Publisher = "Magic, Inc.",
                    Published = 1953,
                    Edition = "Spiralbound",
                    ISBN = "B4 ISBN",
                    Location = "B4 Location",
                    Pages = 199
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Tarbell Course in Magic - Volume 1",
                    Author = "Harlan Tarbell",
                    Publisher = "Robbins",
                    Published = 1941,
                    Edition = "B1 Edition",
                    ISBN = "B1 ISBN",
                    Location = "B1 Location",
                    Pages = 413
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Tarbell Course in Magic - Volume 2",
                    Author = "Harlan Tarbell",
                    Publisher = "Robbins",
                    Published = 1942,
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 416
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Tarbell Course in Magic - Volume 3",
                    Author = "Harlan Tarbell",
                    Publisher = "Robbins",
                    Published = 1943,
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 416
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Tarbell Course in Magic - Volume 4",
                    Author = "Harlan Tarbell",
                    Publisher = "Robbins",
                    Published = 1945,
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 416
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Tarbell Course in Magic - Volume 5",
                    Author = "Harlan Tarbell",
                    Publisher = "Robbins",
                    Published = 1948,
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 417
                },
                new Item
                {
                    ItemType = 0,
                    Title = "Tarbell Course in Magic - Volume 6",
                    Author = "Harlan Tarbell",
                    Publisher = "Robbins",
                    Published = 1954,
                    Edition = "B2 Edition",
                    ISBN = "B2 ISBN",
                    Location = "B2 Location",
                    Pages = 409
                }
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();

        }

    }
}