using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisBooking.Migrations
{
    public partial class SetData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Sedes",
            columns: new[] { "Id", "Nombre", "Descripcion", "Tipo", "Ubicacion" },
            values: new object[,] { { 1, "Suramericana", "Descripcion Suramericana", "Apartamento", "Medellin" },
                { 2, "El Rodadero", "Descripcion El Rodadero", "Apartamento", "Santa Marta" },
                { 3, "Villeta", "Descripcion Villeta", "Recreativa", "Villeta" },
                { 4, "El Placer", "Descripcion El Placer", "Recreativa", "Fusagasugá" },
                { 5, "Gonzalo Morante", "Descripcion Gonzalo Morante", "Recreativa", "Chinchiná" },
                { 6, "Tablones", "Descripcion Tablones", "Recreativa", "Palmira" },
                { 7, "Manguruma", "Descripcion Maguruma", "Recreativa", "Santa fe de Antioquia" },
                { 8, "Federman", "Descripcion Federman", "Recreativa", "Bogotá" },});

            migrationBuilder.InsertData(
            table: "Alojamientos",
            columns: new[] { "Id", "Capacidad", "Baño", "CamaDoble", "Camarote", "Nevera", "TV",
                            "Terraza", "Descripcion", "TarifaOrd", "TarifaEsp", "IdSede" },
            values: new object[,] { { 1, 2, true, false, false, false, false, false, "2 camas sencillas y baño privado",
                                        63000, 75000, 1},
                                    { 2, 2, false, false, false, false, false, false, "2 camas sencillas",
                                        63000, 75000, 1},
                                    { 3, 2, false, false, false, false, false, false, "2 camas sencillas",
                                        63000, 75000, 1},
                                    { 4, 2, false, false, false, false, false, false, "2 camas sencillas",
                                        63000, 75000, 1},
                                    { 5, 1, true, false, false, false, false, false, "1 cama sencilla",
                                        63000, 75000, 1},
                                    { 6, 8, true, false, false, false, false, false,
                                        "Tiene sala comedor, cocina, 2 baños, tres habitaciones y un sitio para parqueo. Capacidad máxima: 8 personas.",
                                        103000, 143000, 2},
                                    { 7, 6, true, false, false, false, false, false,
                                        "Tiene Sala comedor, cocina, 1 baño, dos habitaciones y un sitio para parqueo. Capacidad máxima: 6 personas. ",
                                        89000, 124000, 2},
                                    { 8, 6, true, false, false, false, false, false,
                                        "Tiene Sala comedor, cocina, 1 baño, dos habitaciones y un sitio para parqueo. Capacidad máxima: 6 personas. ",
                                        89000, 124000, 2},
                                    { 9, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 3},
                                    { 10, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 3},
                                    { 11, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 3},
                                    { 12, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 3},
                                    { 13, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 3},
                                    { 14, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 3},
                                    { 15, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 3},
                                    { 16, 4, true, true, true, true, true, true,
                                        "habitacion con cama doble y un camarote, baño, nevera, televisor y terraza " +
                                        "cubierta.",
                                        70000, 27000, 4},
                                    { 17, 4, true, true, false, false, true, false,
                                        "tiene dos habitaciones, baño y Televisor, una con cama doble " +
                                        "y una sencilla, la otra con una cama sencilla.",
                                        90000, 37000, 4},
                                    { 18, 6, true, true, false, false, true, false,
                                        "tiene dos habitaciones, baño y Televisor, una con cama doble," +
                                        "la otra con 4 camas sencillas.",
                                        90000, 37000, 2},
                                    { 19, 4, true, true, false, false, true, false,
                                        "tiene una habitación con cama doble y 2 camas sencillas, " +
                                        "baño y Televisor",
                                        70000, 27000, 4},
                                    { 20, 4, true, true, false, false, true, false,
                                        "tiene dos habitaciones, baño y Televisor, una con cama doble " +
                                        "y una sencilla, la otra con una cama sencilla.",
                                        70000, 27000, 4},
                                    { 21, 4, true, true, false, true, true, true,
                                        " sala de estar con sofá cama y Televisor, baño, habitación " +
                                        "con cama doble y una cama sencilla, cocineta equipada y nevera, " +
                                        "terraza comedor.",
                                        70000, 27000, 4},
                                    { 22, 4, true, true, false, true, true, true,
                                        " sala de estar con sofá cama y Televisor, baño, habitación " +
                                        "con cama doble y una cama sencilla, cocineta equipada y nevera, " +
                                        "terraza comedor.",
                                        70000, 27000, 4}
            ,
                                    { 23, 4, true, true, false, true, true, true,
                                        " sala de estar con sofá cama y Televisor, baño, habitación " +
                                        "con cama doble y una cama sencilla, cocineta equipada y nevera, " +
                                        "terraza comedor.",
                                        70000, 27000, 4}
            ,
                                    { 24, 4, true, true, false, true, true, true,
                                        " sala de estar con sofá cama y Televisor, baño, habitación " +
                                        "con cama doble y una cama sencilla, cocineta equipada y nevera, " +
                                        "terraza comedor.",
                                        70000, 27000, 4},
                                    { 25, 7, true, true, false, true, true, false,
                                        "Tiene cocineta, baño, Televisor y 2 habitaciones. La 1 con dos " +
                                        "camas sencillas, mas dos adicionales. La 2 con una cama doble y una " +
                                        "sencilla.",
                                        90000, 37000, 5},
                                    { 26, 9, true, true, false, true, true, false,
                                        "Tiene cocineta, baño, Televisor y 2 habitaciones. La 1 con una " +
                                        "cama doble, mas una auxiliar doble. La 2 con dos camas sencillas, " +
                                        "mas dos auxiliares.",
                                        90000, 37000, 5},
                                    { 27, 3, true, true, false, true, true, false,
                                        "Tiene cocineta, baño, Televisor y una habitación con cama doble " +
                                        "y una cama sencilla.",
                                        70000, 27000, 5},
                                    { 28, 6, true, true, false, true, true, false,
                                        "Cocineta, baño, sala con sofá, Televisor una habitación con cama " +
                                        "doble y una cama sencilla.",
                                        70000, 27000, 5},
                                    { 29, 6, true, true, false, true, true, false,
                                        "Cocineta, baño, sala con sofá, Televisor una habitación con cama " +
                                        "doble y una cama sencilla.",
                                        70000, 27000, 5},
                                    { 30, 4, true, true, true, true, true, false,
                                        "Una habitación, con cama doble y un camarote. Televisor, baño, " +
                                        "cocineta con nevera, comedor.",
                                        70000, 27000, 6},
                                    { 31, 4, true, true, true, true, true, false,
                                        "Una habitación, con cama doble y un camarote. Televisor, baño, " +
                                        "cocineta con nevera, comedor.",
                                        70000, 27000, 6},
                                    { 32, 8, true, true, true, true, true, false,
                                        "Dos habitaciones. La habitación 1 con cama doble y un camarote. " +
                                        "La habitación 2 con dos camarotes. Sala de estar con Televisor, " +
                                        "baño y cocineta",
                                        90000, 37000, 6},
                                    { 33, 8, true, true, true, true, true, false,
                                        "Dos habitaciones. La habitación 1 con cama doble y un camarote. " +
                                        "La habitación 2 con dos camarotes. Sala de estar con Televisor, " +
                                        "baño y cocineta",
                                        90000, 37000, 6},
                                    { 34, 4, true, true, true, true, false, true,
                                        "Una cama doble y un camarote. Baño y terraza. Televisor",
                                        70000, 27000, 7},
                                    { 35, 5, true, true, true, true, false, true,
                                        "Una cama doble un camarote y un sofa-cama. Baño y terraza. Televisor",
                                        70000, 27000, 7},
                                    { 36, 5, true, true, true, true, false, true,
                                        "Una cama doble un camarote y un sofa-cama. Baño y terraza. Televisor",
                                        70000, 27000, 7},
                                    { 37, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 38, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 39, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 40, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 41, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 42, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 43, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 44, 4, true, true, true, true, true, true,
                                        "habitación que tiene dos camas gemelas y un camarote; baño, " +
                                        "terraza - comedor y cocina. Nevera y televisor.",
                                        70000, 27000, 7},
                                    { 45, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 46, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 47, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 48, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 49, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 50, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 51, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 52, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 53, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 54, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 55, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8},
                                    { 56, 4, false, false, false, false, false, false,
                                        "Zona húmeda: Baño turco, sauna, jacuzzi, baños y vestieres " +
                                        "Gimnasio sala de masajes Billar y juegos de mesa Salas de " +
                                        "música y video, lectura. Cafetería y sala social. Ejercicios:" +
                                        " Bicicleta estática, Aerobicos, Pilates Y Rumba tropical " +
                                        "(Lunes a viernes 5:30 a 6:30 p.m.)",
                                        70000, 27000, 8}});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
