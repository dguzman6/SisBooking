using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisBooking.Migrations
{
    public partial class SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                    @"CREATE PROCEDURE sp_AloPorFecha @id int,@fini date, @ffin date
                    AS
                    BEGIN
                    SELECT COUNT(*)
                    FROM BookingDB.dbo.Alojamientos as u INNER JOIN BookingDB.dbo.FechasUtilizados as r ON r.IdAlojamiento = u.Id
                    WHERE(@fini < r.Fecha or r.Fecha > @ffin) and
                    r.IdAlojamiento = @id
                    END"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE [sp_AloPorFecha];");
        }
    }
}
