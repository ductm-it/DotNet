using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uit_project_framework.Models
{
    public class ShopContext : DbContext
    {


        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    Title = "BAI VIET 1",
                    Image = "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg",

                    Content = "The key value is required so it must be supplied. When a migration is created, the SQL Server provider will enable the insertion of Identity values:"
                },
                new Post
                {
                    PostId = 2,
                    Title = "BAI VIET 2",
                    Image = "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg",

                    Content = "This site can’t be reached"
                },
                new Post
                {
                    PostId = 3,
                    Title = "BAI VIET 3",
                    Image = "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg",

                    Content = "This site can’t be reached"
                },
                new Post
                {
                    PostId = 4,
                    Title = "BAI VIET 4",
                    Image = "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg",

                    Content = "This site can’t be reached"
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "the loai 1",
                    Image = "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg",
                    Description = "mo ta 1"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "the loai 2",
                    Image = "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg",
                    Description = "mo ta 2"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "the loai 3",
                    Image = "https://cdn.pixabay.com/photo/2015/10/21/16/44/cold-999972__340.jpg",
                    Description = "mo ta 3"
                });


            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {
                      ProductId = 1,
                      ProductName = "san pham 1",
                      Image = "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg",
                      Unit = "cai",
                      Price = 2223,
                      CategoryID = 1,
                      CreatedAt = new DateTime(),
                      UpdatedAt = new DateTime()
                  },
                  new Product
                  {
                      ProductId = 2,
                      ProductName = "san pham 2",
                      Image = "https://cdn.pixabay.com/photo/2015/10/21/16/44/cold-999972__340.jpg",

                      Unit = "cai",
                      Price = 2223,
                      CategoryID = 1,
                      CreatedAt = new DateTime(),
                      UpdatedAt = new DateTime()
                  },
                  new Product
                  {
                      ProductId = 3,
                      ProductName = "san pham 3",
                      Image = "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg",
                      Unit = "mieng",
                      Price = 666,
                      CategoryID = 1,
                      CreatedAt = new DateTime(),
                      UpdatedAt = new DateTime()
                  },
                  new Product
                  {
                      ProductId = 4,
                      ProductName = "san pham 4",
                      Image = "https://cdn.pixabay.com/photo/2015/10/21/16/44/cold-999972__340.jpg",

                      Unit = "cuc",
                      Price = 111,
                      CategoryID = 1,
                      CreatedAt = new DateTime(),
                      UpdatedAt = new DateTime()
                  }
                  );




        }
    }
}
