using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AISTest.Models
{
    public class AutoparkContext : DbContext
    {
        private const string connectionString = "server=remotemysql.com;port=3306;database=YvYXTO8W69;user=YvYXTO8W69;password=krKYIOBBC1";

        public AutoparkContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Department> Departments{ get; set; }
        public DbSet<Position> Positions{ get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<FuelRate> FuelRates { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TrackSheet> TrackSheets { get; set; }
        public DbSet<TrackSheetTask> TrackSheetTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackSheet>()
                .HasOne(ts => ts.Driver)
                .WithMany(e => e.DriverTrackSheets)
                .HasForeignKey(ts => ts.DriverID);

            modelBuilder.Entity<TrackSheet>()
                .HasOne(ts => ts.Checker)
                .WithMany(e => e.CheckerTrackSheets)
                .HasForeignKey(ts => ts.CheckerID);

            modelBuilder.Entity<TrackSheet>()
                .HasOne(ts => ts.Authorized)
                .WithMany(e => e.AuthorizedTrackSheets)
                .HasForeignKey(ts => ts.AuthorizedID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(e => e.PositionID);
        }
    }
}
