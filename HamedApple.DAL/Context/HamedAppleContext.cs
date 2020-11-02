using HamedApple.DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.DAL.Context
{
    public class HamedAppleContext : IdentityDbContext<ApplicationUser>
    {
        public HamedAppleContext() : base("name=ConString")
        {

        }

        public DbSet<News> News { get; set; }
        public DbSet<Refrence> Refrence { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDetails> ProductDetail { get; set; }
        public DbSet<ProductDetailAnswers> ProductDetailAnswer { get; set; }
        public DbSet<Order> Order { get; set; }

        public static HamedAppleContext Create()
        {
            return new HamedAppleContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.Type)
                .WithMany(r => r.Products)
                .HasForeignKey(p => p.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductDetails>()
                .HasRequired(pd => pd.Refrence)
                .WithMany(r => r.ProductDetails)
                .HasForeignKey(pd => pd.RefrenceId)
                .WillCascadeOnDelete(false);
        }
    }
}
