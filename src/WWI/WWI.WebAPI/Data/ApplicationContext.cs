using System.Data.Entity;
using WWI.WebAPI.Data.Application;

namespace WWI.WebAPI.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuring one-to-many relationship between DeliveryMethod and People.
            modelBuilder.Entity<DeliveryMethod>()
                .HasRequired(p => p.People)
                .WithMany(d => d.DeliveryMethods)
                .HasForeignKey(p => p.LastEditedBy)
                .WillCascadeOnDelete();

            // Configuring one-to-many relationship between TransactionType and People.
            modelBuilder.Entity<TransactionType>()
                .HasRequired(p => p.People)
                .WithMany(t => t.TransactionTypes)
                .HasForeignKey(p => p.LastEditedBy)
                .WillCascadeOnDelete();

            // Configuring one-to-many relationship between PaymentMethod and People.
            modelBuilder.Entity<PaymentMethod>()
                .HasRequired(p => p.People)
                .WithMany(p => p.PaymentMethods)
                .HasForeignKey(p => p.LastEditedBy)
                .WillCascadeOnDelete();

            // Configuring one-to-many relationship between Country and People.
            modelBuilder.Entity<Country>()
                .HasRequired(p => p.People)
                .WithMany(p => p.Countries)
                .HasForeignKey(p => p.LastEditedBy)
                .WillCascadeOnDelete();

            // Configuring one-to-many relationship between StateProvince and People.
            modelBuilder.Entity<StateProvince>()
                .HasRequired(p => p.People)
                .WithMany(s => s.StateProvinces)
                .HasForeignKey(p => p.LastEditedBy)
                .WillCascadeOnDelete();

            // Configuring one-to-many relationship between City and People.
            modelBuilder.Entity<City>()
                .HasRequired(p => p.People)
                .WithMany(c => c.Cities)
                .HasForeignKey(p => p.LastEditedBy)
                .WillCascadeOnDelete();

            // Configuring one-to-many relationship between SystemParameters and People.
            modelBuilder.Entity<SystemParameter>()
                .HasRequired(p => p.People)
                .WithMany(s => s.SystemParameters)
                .HasForeignKey(p => p.LastEditedBy)
                .WillCascadeOnDelete();
        }
    }
}