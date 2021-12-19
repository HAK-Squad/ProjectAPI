using Microsoft.EntityFrameworkCore;
using ProjectAPI.Data;
using ProjectAPI.Models;


namespace ProjectAPI
{
    public class APIprojectDBcontext : DbContext 
    {
        public APIprojectDBcontext(DbContextOptions<APIprojectDBcontext> options)
           : base(options)
        {

        }
        public DbSet<Code> Codes { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<DoorTag> DoorTags { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //Override EF Core convention so that I can have a table in SQL with only two foreignkeys
        // So the primary key is a composite key with DoorId and TagId
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DoorTag>()
                .HasKey(dt => new {dt.DoorId, dt.TagId});
            builder.Entity<DoorTag>()
                .HasOne(dt => dt.Door)
                .WithMany(dt => dt.Tags)
                .HasForeignKey(dt => dt.DoorId);
            builder.Entity<DoorTag>()
                .HasOne(dt => dt.Tag)
                .WithMany(dt => dt.Doors)
                .HasForeignKey(dt => dt.TagId);
            builder.Seed();
            
           
        }

       

            


    }
}
