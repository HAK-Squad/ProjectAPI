using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class AddRawDataToPeopleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            

            INSERT INTO [dbo].[People] ([FirstName],[LastName],[ApertmentNumber])
                VALUES
                    ('Liam', 'Jönsson', '0101'),

                    ('Elias', 'Petterson', '0102'),
                    ('Wilma', 'Johansson', '0102'),

                    ('Alicia', 'Sanchez', '0103'),
                    ('Aaron', 'Sanchez', '0103'),

                    ('Olivia', 'Erlander', '0201'),
                    ('William', 'Erlander', '0201'),
                    ('Alexander', 'Erlander', '0201'),
                    ('Astrid', 'Erlander', '0201'),

                    ('Lucas','Adolfsson', '0202'),
                    ('Ebba','Adolfsson', '0202'),
                    ('Lilly','Adolfsson', '0202'),

                    ('Ella','Ahlström', '0301'),
                    ('Alma','Alfredsson', '0301'),
                    ('Elsa','Ahlström', '0301'),
                    ('Maja','Ahlström', '0301'),

                    ('Noah','Almgren', '0302'),
                    ('Adam','Andersen', '0302'),
                    ('Kattis','Backman', '0302'),
                    ('Oscar','Chen', '0302'),

                    ('Vaktmästare','Vaktsson', 'VAKT');
                    
                   

                             
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Elias'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Wilma'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Alicia'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Aaron'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Olivia'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'William'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Alexander'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Astrid'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Lucas'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Ebba'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Lilly'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Ella'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Alma'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Elsa'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Maja'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Noah'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Adam'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Kattis'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Oscar'");
            migrationBuilder.Sql($"DELETE FROM People WHERE FirstName = 'Vaktmästare'");
        }
    }
}
