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
    //{
    //    public class Startup
    //    {
    //        // constructor
    //        public Startup(IConfiguration configuration)
    //        {
    //            Configuration = configuration;

    //        }

    //        public IConfiguration Configuration { get; }


    //        // This method gets called by the runtime. Use this method to add services to the container.

    //        public void ConfigureServices(IServiceCollection services)
    //        {

    //            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

    //            //BookStoreDataContext.ConnectionString = Configuration.GetConnectionString("Default");
    //        }

    //        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //        {
    //            if (env.IsDevelopment())
    //            {
    //                app.UseDeveloperExceptionPage();
    //            }
    //            else
    //            {
    //                /*

    //                     // The default HSTS value is 30 days. You may want to 
    //                    change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //                 */
    //                app.UseHsts();
    //            }

    //            app.UseHttpsRedirection();
    //            app.UseRouting();

    //        }

    //        //"A namespace does not directly contain members such as fields or methods"
    //        // error ini menunjukkan bahwa methode dibuat diluar kelas yg ada -> masukkan methode ke kelas yg ada
    //      }
    //    }




    public class BookStoreDataContext : DbContext
    {
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {

            optionsBuilder.UseMySQL(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
            modelBuilder.Entity<Author>().ToTable("authors");
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e =>
               e.AuthorID).HasColumnName("author_id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Email).HasColumnName("email");
            });
            modelBuilder.Entity<Author>().HasKey(e => new { e.AuthorID });
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