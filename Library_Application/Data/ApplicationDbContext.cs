using Library_Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Application.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }  
        public DbSet<OrderHeader> OrderHeaders { get;set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Book_Application;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id=1,
                AuthorName="Endru Troelson",
                BookName="C# 10.0 Full Course",
                Price=3400,
            });  
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id=2,
                AuthorName="Endru Troelson",
                BookName="Java Full Course",
                Price=12,
            });    modelBuilder.Entity<Book>().HasData(new Book
            {
                Id=3,
                AuthorName="Endru Troelson",
                BookName="Python",
                Price=21,
            });    modelBuilder.Entity<Book>().HasData(new Book
            {
               
                Id=4,
                AuthorName="Endru Troelson",
                BookName="Python Full Course",
                Price=555,
            });    modelBuilder.Entity<Book>().HasData(new Book
            {
               
                Id=5,
                AuthorName="Davit Makaryan",
                BookName="Java Script Full Course",
                Price=321,
            });    modelBuilder.Entity<Book>().HasData(new Book
            {
               
                Id=6,
                AuthorName="Gexam Hakobyan",
                BookName="C++ Full Course",
                Price=890,
            });    modelBuilder.Entity<Book>().HasData(new Book
            {
               
                Id=7,
                AuthorName="Endru Troelson",
                BookName=" C",
                Price=450,
            });   modelBuilder.Entity<Book>().HasData(new Book
            {
               
                Id=8,
                AuthorName="Endru Troelson",
                BookName="Assembly Full Course",
                Price=123,
            });   modelBuilder.Entity<Book>().HasData(new Book
            {
               
                Id=9,
                AuthorName="Endru Troelson",
                BookName="Visual Basic Full Course",
                Price=345,
            });   modelBuilder.Entity<Book>().HasData(new Book
            {
               
                Id=10,
                AuthorName="Endru Troelson",
                BookName="F# Full Course",
                Price=567,
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=1,
                GenreName = "Programming",
            });  modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=2,
                GenreName = "Programming",
            });  modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=3,
                GenreName = "Programming",
            });  modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=4,
                GenreName = "Programming",
            });  modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=5,
                GenreName = "Programming",
            });  modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=6,
                GenreName = "Programming",
            });  modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=7,
                GenreName = "Programming",
            });  modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=8,
                GenreName = "Programming",
            }); modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=9,
                GenreName = "Programming",
            }); modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id=10,
                GenreName = "Programming",
            });


        }
    }
}
