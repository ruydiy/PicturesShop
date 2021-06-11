namespace PicturesShop.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using PicturesShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ApplicationDbContext : IdentityDbContext <User>
    {
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Painter> Painters { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-F8AKO5E9\MYSQLSERVER2017;Database=PictureShop;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Picture>()
            .HasOne<Publisher>(b => b.Publisher)
            .WithMany(p => p.Pictures)
            .HasForeignKey(b => b.PublisherId);
            base.OnModelCreating(modelBuilder);
        }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{
        //}
    }
}
