using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class rawDataDoors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            

            INSERT INTO [dbo].[Doors] ([DoorName])
                VALUES
                    ('LGH0101'),
                    ('BLK0101'),
                    ('LGH0102'),
                    ('BLK0102'),
                    ('LGH0103'),
                    ('BLK0103'),

                    ('LGH0201'),
                    ('BLK0201'),
                    ('LGH0202'),
                    ('BLK0202'),

                    ('LGH0301'),
                    ('BLK0301'),
                    ('LGH0302'),
                    ('BLK0302'),

                    ('SOPRUM'),
                    ('UT'),
                    ('TVÄTT')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'LGH0101'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'BLK0101'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'LGH0102'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'BLK0102'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'LGH0103'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'BLK0103'");

            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'LGH0201'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'BLK0201'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'LGH0202'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'BLK0202'");

            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'LGH0301'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'BLK0301'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'LGH0302'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'BLK0302'");

            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'SOPRUM'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'UT'");
            migrationBuilder.Sql($"DELETE FROM Tag WHERE TagNumber = 'TVÄTT'");
        }
    }
}
