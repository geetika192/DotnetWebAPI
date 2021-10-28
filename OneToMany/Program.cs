using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OneToMany
{

    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public virtual Publisher Publisher { get; set; }
    }

    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }



    public class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=fundamental;Pooling=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //WellStructuredness with relationship (Using fluent API)
            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
            });
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.ISBN);
                entity.Property(e => e.Title).IsRequired();
                entity.HasOne(d => d.Publisher)
                .WithMany(p => p.Books);
            });

        }
    }



    public class Controller
    {
        public static void Main()
        {
             LibraryContext obj1 = new LibraryContext();
            // Publisher obj = new Publisher();
            // obj.ID = 501;
            // obj.Name = "TechMedia";
            // obj1.Add(obj);
            // obj1.SaveChanges();

            // obj1.Book.Add(new Book
            // {

            //     ISBN = "978-0544003415",
            //     Title = "The Lord of the Rings",
            //     Author = "J.R.R. Tolkien",
            //     Language = "English",
            //     Pages = 1216,
            //     Publisher = obj
            // });

            // obj1.Book.Add(new Book
            // {

            //     ISBN = "978-0547247762",
            //     Title = "The Sealed Letter",
            //     Author = "Emma Donoghue",
            //     Language = "English",
            //     Pages = 416,
            //     Publisher = obj
            // });
            // obj1.SaveChanges();
        //     var books = obj1.Book
        //  .Include(ctr => ctr.Publisher);
        //     foreach (var book in books)
        //     {
        //        Console.WriteLine(book.ISBN+" " +book.Title+" "+book.Publisher.ID+" "+book.Publisher.Name);
                 
        //     }
        }
    }
}