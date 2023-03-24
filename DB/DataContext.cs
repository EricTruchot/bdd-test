using Microsoft.EntityFrameworkCore;


namespace bddTest.DB
{
    public class DataContext : DbContext
    {
        public DataContext() {}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //        .AddJsonFile("appsettings.json")
        //        .Build();
        //    optionsBuilder.UseNpgsql(configuration.GetConnectionString("DockerConnectionString"));
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseNpgsql("Server=;Database=CrashTest1;Trusted_Connection=True;user id=admin;password=u5TM4~;");

                optionsBuilder.UseNpgsql("Host=db:5432;Database=dtest;Username=dtest;Password=dtest");
            }
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Users> users { get; set; }
    }
}
