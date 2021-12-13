using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class TestInsertIntoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            

            INSERT INTO [dbo].[People] ([FirstName],[LastName],[ApertmentNumber]  )
                VALUES
                    ('Liam', 'Jönsson', '0101');
                    
           
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Liam'");

        }
    }
}
