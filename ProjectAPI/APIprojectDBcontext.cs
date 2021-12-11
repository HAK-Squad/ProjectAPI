using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;


namespace ProjectAPI
{
    public class APIprojectDBcontext : DbContext 
    {
        public DbSet<Code> Codes { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<DoorTag> DoorTags { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProjectAPI;Trusted_Connection=True;");
        }
    }
}
