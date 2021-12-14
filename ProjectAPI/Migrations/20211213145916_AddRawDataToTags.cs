using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class AddRawDataToTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            

            INSERT INTO [dbo].[Tags] ([TagNumber],[PersonId])
                VALUES
                    ('0101A', '1'),

                    ('0102A', '2'),
                    ('0102B', '3'),

                    ('0103A', '4'),
                    ('0103B', '5'),

                    ('0201A', '6'),
                    ('0201B', '7'),
                    ('0201C', '8'),
                    ('0201D', '9'),

                    ('0202A', '10'),
                    ('0202B', '11'),
                    ('0202C', '12'),

                    ('0301A', '13'),
                    ('0301B', '14'),
                    ('0301C', '15'),
                    ('0301D', '16'),

                    ('0302A', '17'),
                    ('0302B', '18'),
                    ('0302C', '19'),
                    ('0302D', '20'),

                    ('VAKT01', '21');
           
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0101A'");

            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0102A'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0102B'");

            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0103A'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0103B'");

            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0201A'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0201B'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0201C'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0201D'");

            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0202A'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0202B'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0202C'");

            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0301A'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0301B'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0301C'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0301D'");

            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0302A'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0302B'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0302C'");
            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = '0302D'");

            migrationBuilder.Sql($"DELETE FROM Tags WHERE TagNumber = 'VAKT01'");
        }
    }
}
