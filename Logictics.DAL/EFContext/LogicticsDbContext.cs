using Logictics.DAL.Seed;
using Logictics.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Logictics.DAL.EFContext
{
    public class LogicticsDbContext : DbContext
    {

        public LogicticsDbContext()
        {
        }

        public LogicticsDbContext(DbContextOptions<LogicticsDbContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(x => x.Id);

                entity.Property(e => e.PassWord)
                      .HasMaxLength(150)
                      .IsUnicode(false);

                entity.Property(e => e.Role)
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.Property(e => e.Status)
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.Property(e => e.UserName)
                      .HasMaxLength(150)
                      .IsUnicode(false);

            
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");
                entity.HasKey(x => x.Id);
                entity.Property(e => e.Status).HasMaxLength(50).IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");
                entity.HasKey(x => x.id);
                entity.Property(e => e.status).HasMaxLength(50).IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.ToTable("CategoryProduct");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);

        }

       
        public virtual DbSet<User> User{ get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<CategoryProduct> CategoryProduct { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
