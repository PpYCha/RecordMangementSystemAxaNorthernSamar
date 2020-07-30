using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace RecordManagementSystemInAxaNSamar.Model

{
    public class AxaContext : DbContext
    {
        public AxaContext()
            : base("AxaContext")
        {
            Database.SetInitializer<AxaContext>(new AxaDbInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AxaContext, Migrations.Configuration>(useSuppliedContext: true));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<ClientPlan> ClientPlans { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientBeneficiaries> ClientBeneficiaries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PaymentRecords> PaymentRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(k => k.UserId)
                .Property(p => p.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Plan>().HasKey(k => k.PlanId)
                .Property(p => p.PlanId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            modelBuilder.Entity<ClientPlan>().HasKey(k => k.ClientPlanId)
                .Property(p => p.ClientPlanId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Client>().HasKey(k => k.ClientId)
               .Property(p => p.ClientId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ClientBeneficiaries>().HasKey(k => k.ClientBeneficiaresId)
               .Property(p => p.ClientBeneficiaresId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Employee>().HasKey(k => k.EmployeeId)
               .Property(p => p.EmployeeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<PaymentRecords>().HasKey(k => k.PaymentId)
                  .Property(p => p.PaymentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ClientPlan>()
                    .HasRequired<Plan>(k => k.Plan)
                    .WithMany(p => p.ClientPlans)
                    .HasForeignKey<int>(k => k.PlanId);

            modelBuilder.Entity<ClientPlan>()
                .HasRequired<Client>(k => k.Client)
                .WithMany(p => p.ClientPlan)
                .HasForeignKey<int>(k => k.ClientId);

            modelBuilder.Entity<ClientBeneficiaries>()
                .HasRequired<Client>(k => k.Client)
                .WithMany(p => p.ClientBeneficiaries)
                .HasForeignKey<int>(k => k.ClientId);

            modelBuilder.Entity<Client>()
                .HasRequired<Employee>(k => k.Employee)
                .WithMany(p => p.Client)
                .HasForeignKey<int>(k => k.EmployeeId);
        }
    }
}
