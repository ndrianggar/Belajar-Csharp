using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Configuration;

using CoreBookStoreWebAPI.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace CoreBookStoreWebAPI.Models
{
   public class BookStoreDataContext : DbContext
    {
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {

            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           

            //Categories
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e =>
               e.CategoryID).HasColumnName("category_id");
                entity.Property(e => e.Name).HasColumnName("name");
            });
            modelBuilder.Entity<Category>().HasKey(e => new
            {
                e.CategoryID
            });

            //Authors
            modelBuilder.Entity<Author>().ToTable("authors");
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e =>
               e.AuthorID).HasColumnName("author_id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Email).HasColumnName("email");
            });
            modelBuilder.Entity<Author>().HasKey(e => new { e.AuthorID });

            //Book
            modelBuilder.Entity<Book>().ToTable("books");
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.ISBN).HasColumnName("isbn");
                entity.Property(e =>
               e.CategoryID).HasColumnName("category_id");
                entity.Property(e => e.Title).HasColumnName("title");
                entity.Property(e => e.Photo).HasColumnName("photo");
                entity.Property(e =>
               e.PublishDate).HasColumnName("publish_date");
                entity.Property(e => e.Price).HasColumnName("price");
                entity.Property(e => e.Quantity).HasColumnName("qty");
            });
            modelBuilder.Entity<Book>().HasKey(e => new { e.ISBN });
            
            //Book_Authors
            modelBuilder.Entity<BookAuthor>().ToTable("books_authors");
            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.Property(e => e.ISBN).HasColumnName("isbn");
                entity.Property(e =>
               e.AuthorID).HasColumnName("author_id");
            });
            modelBuilder.Entity<BookAuthor>().HasKey(e => new
            {
                e.ISBN,
                e.
           AuthorID
            });
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookAuthor> BooksAuthors { get; set; }
    }
}
