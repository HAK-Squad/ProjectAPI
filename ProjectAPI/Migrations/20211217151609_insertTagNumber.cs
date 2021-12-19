using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class insertTagNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            

            Update dbo.People
             SET TagNumber = ('0101A')
              WHERE FirstName = ('Liam')

            Update dbo.People
             SET TagNumber = ('0102A')
              WHERE FirstName = ('Elias')
            
            Update dbo.People
             SET TagNumber = ('0102B')
              WHERE FirstName = ('Wilma')
            
            Update dbo.People
             SET TagNumber = ('0103A')
              WHERE FirstName = ('Alicia')

            Update dbo.People
             SET TagNumber = ('0103B')
              WHERE FirstName = ('Aaron')
            
            Update dbo.People
             SET TagNumber = ('0201A')
              WHERE FirstName = ('Olivia')
            
            Update dbo.People
             SET TagNumber = ('0201B')
              WHERE FirstName = ('William')

            Update dbo.People
             SET TagNumber = ('0201C')
              WHERE FirstName = ('Alexander')
            
            Update dbo.People
             SET TagNumber = ('0201D')
              WHERE FirstName = ('Astrid')
            
            Update dbo.People
             SET TagNumber = ('0202A')
              WHERE FirstName = ('Lucas')

            Update dbo.People
             SET TagNumber = ('0202B')
              WHERE FirstName = ('Ebba')
            
            Update dbo.People
             SET TagNumber = ('0202C')
              WHERE FirstName = ('Lilly')
            
            Update dbo.People
             SET TagNumber = ('0301A')
              WHERE FirstName = ('Ella')

            Update dbo.People
             SET TagNumber = ('0301B')
              WHERE FirstName = ('Alma')
            
            Update dbo.People
             SET TagNumber = ('0301C')
              WHERE FirstName = ('Elsa')
            
            Update dbo.People
             SET TagNumber = ('0301D')
              WHERE FirstName = ('Maja')

            Update dbo.People
             SET TagNumber = ('0302A')
              WHERE FirstName = ('Noah')
            
            Update dbo.People
             SET TagNumber = ('0302B')
              WHERE FirstName = ('Adam')
            
            Update dbo.People
             SET TagNumber = ('0302C')
              WHERE FirstName = ('Kattis')

            Update dbo.People
             SET TagNumber = ('0302D')
              WHERE FirstName = ('Oscar')
            
            Update dbo.People
             SET TagNumber = ('VAKT01')
              WHERE FirstName = ('Vaktmästare')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
