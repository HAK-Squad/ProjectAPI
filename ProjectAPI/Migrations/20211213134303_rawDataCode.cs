using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class rawDataCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            

            INSERT INTO [dbo].[Codes] ([CodeString],[CodeDescription])
                VALUES
                    ('DÖUT', 'Dörr har öppnats utifrån'),
                    ('DÖIN', 'Dörr har öppnats inifrån'),
                    ('FDIN', 'Fel dörr - Försökt in'),
                    ('FDUT', 'Fel dörr - Försökt ut')
           
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM Code WHERE CodeString = 'DÖUT'");
            migrationBuilder.Sql($"DELETE FROM Code WHERE CodeString = 'DÖIN'");
            migrationBuilder.Sql($"DELETE FROM Code WHERE CodeString = 'FDIN'");
            migrationBuilder.Sql($"DELETE FROM Code WHERE CodeString = 'FDUT'");

        }
    }
}
