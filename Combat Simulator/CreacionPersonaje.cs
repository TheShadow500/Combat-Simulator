namespace Combat_Simulator
{
    class CreacionPersonaje
    {
        public Personaje creacion_personaje(bool protagonista, int opcion)
        {
            Random random = new Random();
            int rama;
            string nombre;

            // Seleccion aleatoria del nombre segun clase
            string[,] nombres = new string[3, 10]{
                { "Leofric", "Eadric", "Aldric", "Beowulf", "Cedric", "Edmund", "Godric", "Harold", "Ivor", "Leofwin" }, // Nombres Guerrero
                { "Aelwen", "Branoc", "Caelan", "Deryn", "Eirian", "Farren", "Gareth", "Hawke", "Idris", "Jareth" }, // Nombres Arquero
                { "Arcturus", "Bramble", "Corbin", "Dorian", "Eldric", "Finnian", "Gideon", "Hadrian", "Isidore", "Jericho" } // Nombres Mago
            };

            if (!protagonista)
            {
                opcion = random.Next(0, 3);
            }

            nombre = nombres[opcion, random.Next(0, 10)];

            // Seleccion aleatoria de los atributos segun clase
            int[,,] atributos = new int[3, 3, 4]
            {
                { {4, 3, 2, 1 }, {5, 4, 1, 0}, {4, 3, 1, 1} }, // Combinaciones de Atributos del Guerrero
                { {2, 4, 3, 1 }, {1, 5, 4, 0}, {1, 4, 3, 1} }, // Combinaciones de Atributos del Arquero
                { {1, 2, 3, 4 }, {0, 1, 4, 5}, {1, 1, 3, 4} }, // Combinaciones de Atributos del Mago
            };

            rama = random.Next(0, 3);

            if (protagonista)
            {
                // Creacion del heroe con todos los valores obtenidos
                Personaje heroe = new Personaje(nombre, atributos[opcion, rama, 0], atributos[opcion, rama, 1], atributos[opcion, rama, 2], atributos[opcion, rama, 3], true, opcion);
                return heroe;
            }
            else
            {
                // Creacion del enemigo
                Personaje enemigo = new Personaje(nombre, atributos[opcion, rama, 0], atributos[opcion, rama, 1], atributos[opcion, rama, 2], atributos[opcion, rama, 3], false, opcion);
                return enemigo;
            }
        }
    }
}
