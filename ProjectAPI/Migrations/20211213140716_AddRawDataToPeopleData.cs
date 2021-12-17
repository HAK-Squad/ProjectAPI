using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class AddRawDataToPeopleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            

            INSERT INTO [dbo].[People] ([FirstName],[LastName],[ApertmentNumber], [TagNumber])
                VALUES
                    ('Liam', 'Jönsson', '0101', '0101A'),
                    ('Elias', 'Petterson', '0102', '0102A'),
                    ('Wilma', 'Johansson', '0102', '0102B'),
                    ('Alicia', 'Sanchez', '0103','0103A'),
                    ('Aaron', 'Sanchez', '0103', '0103B'),
                    ('Olivia', 'Erlander', '0201', '0201A'),
                    ('William', 'Erlander', '0201', '0201B'),
                    ('Alexander', 'Erlander', '0201', '0201C'),
                    ('Astrid', 'Erlander', '0201' ,'0201D'),
                    ('Lucas','Adolfsson', '0202', '0202A'),
                    ('Ebba','Adolfsson', '0202', '0202B'),
                    ('Lilly','Adolfsson', '0202', '0202C'),
                    ('Ella','Ahlström', '0301', '0301A'),
                    ('Alma','Alfredsson', '0301', '0301B'),
                    ('Elsa','Ahlström', '0301', '0301C'),
                    ('Maja','Ahlström', '0301', '0301D'),
                    ('Noah','Almgren', '0302', '0302A'),
                    ('Adam','Andersen', '0302', '0302B'),
                    ('Kattis','Backman', '0302', '0302C'),
                    ('Oscar','Chen', '0302', '0302D'),
                    ('Vaktmästare','Vaktsson', 'VAKT', 'VAKT01');
                    
                   

                             
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
