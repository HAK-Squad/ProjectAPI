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
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'LGH0101'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'BLK0101'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'LGH0102'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'BLK0102'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'LGH0103'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'BLK0103'");

            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'LGH0201'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'BLK0201'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'LGH0202'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'BLK0202'");

            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'LGH0301'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'BLK0301'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'LGH0302'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'BLK0302'");

            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'SOPRUM'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'UT'");
            migrationBuilder.Sql($"DELETE FROM Doors WHERE DoorName = 'TVÄTT'");
        }
    }
}
