namespace Combat_Simulator
{
    public partial class fr_PantallaPartida : Form
    {
        int opcion; // Clase escogida
        int nivelCombate = 1;

        public fr_PantallaPartida()
        {
            InitializeComponent();
        }

        private void bt_ComenzarPartida_Click(object sender, EventArgs e)
        {
            if (bt_ComenzarPartida.Text == "Comenzar Partida")
            {
                // Se desactiva el boton de comenzar partida y se visibilizan los botones de clase
                bt_ComenzarPartida.Enabled = false;
                rd_Guerrero.Visible = true;
                rd_Arquero.Visible = true;
                rd_Mago.Visible = true;
            }
            else
            {
                Creacion_Heroe(false);
                bt_Atacar.Enabled = true;
                bt_Defender.Enabled = true;
                bt_Magia.Enabled = true;
            }
        }

        private void rd_Guerrero_CheckedChanged(object sender, EventArgs e)
        {
            // Seleccion de la clase Guerrero
            if (rd_Guerrero.Checked && MessageBox.Show("La clase Guerrero basa sus atributos en la Fuerza y Destreza.\n\nEstá pensado para el combate con armas cuerpo a cuerpo.\n\n¿Desea escoger esta clase?", "GUERRERO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                opcion = 0;
                MessageBox.Show("Ha escogido la clase GUERRERO", "Bienvenido a Combat Simulator");
                Creacion_Heroe(true);
            }
        }

        private void rd_Arquero_CheckedChanged(object sender, EventArgs e)
        {
            // Seleccion de la clase Arquero
            if (rd_Arquero.Checked && MessageBox.Show("La clase Arquero basa sus atributos en la Agilidad y la Destreza.\n\nEstá pensado para el combate con armas a distancia.\n\n¿Desea escoger esta clase?", "ARQUERO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                opcion = 1;
                MessageBox.Show("Ha escogido la clase ARQUERO", "Bienvenido a Combat Simulator");
                Creacion_Heroe(true);
            }
        }

        private void rd_Mago_CheckedChanged(object sender, EventArgs e)
        {
            // Seleccion de la clase Mago
            if (rd_Mago.Checked && MessageBox.Show("La clase Mago basa sus atributos en la Inteligencia y la Destreza.\n\nEstá pensado para el combate con armas a distancia.\n\n¿Desea escoger esta clase?", "MAGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                opcion = 2;
                MessageBox.Show("Ha escogido la clase MAGO", "Bienvenido a Combat Simulator");
                Creacion_Heroe(true);
            }
        }

        private void Creacion_Heroe(bool protagonista)
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
                InicializarPartida(heroe);
            }
            else
            {
                // Creacion del enemigo
                Personaje enemigo = new Personaje(nombre, atributos[opcion, rama, 0], atributos[opcion, rama, 1], atributos[opcion, rama, 2], atributos[opcion, rama, 3], false, opcion);
                MostrarEnemigo(enemigo);
            }
        }

        private void InicializarPartida(Personaje heroe)
        {
            // Ocultando las opciones de seleccion de clase
            rd_Guerrero.Visible = false;
            rd_Arquero.Visible = false;
            rd_Mago.Visible = false;

            // Mostrando los valores en pantalla
            lb_Vida.Text = "Vida: " + heroe.DevolverVida;
            lb_Mana.Text = "Maná: " + heroe.DevolverMana;
            lb_Nombre.Text = "Nombre: " + heroe.DevolverNombre;
            lb_Clase.Text = "Clase: " + heroe.DevolverClase;
            lb_Fuerza.Text = "Fuerza: " + heroe.DevolverFuerza;
            lb_Destreza.Text = "Destreza: " + heroe.DevolverDestreza;
            lb_Agilidad.Text = "Agilidad: " + heroe.DevolverAgilidad;
            lb_Inteligencia.Text = "Inteligencia: " + heroe.DevolverInteligencia;
            lb_Ataque.Text = "Bon.Ataque: " + heroe.DevolverAtaque + "%";
            lb_Defensa.Text = "Bon.Defensa: " + heroe.DevolverDefensa + "%";
            lb_Esquivar.Text = "Bon.Esquivar: " + heroe.DevolverEsquivar + "%";
            lb_Magia.Text = "Bon.Magia: " + heroe.DevolverMagia + "%";
            bt_ComenzarPartida.Text = "Combate";
            bt_ComenzarPartida.Enabled = true;
        }

        private void MostrarEnemigo(Personaje enemigo)
        {
            bt_ComenzarPartida.Enabled = false;
            MessageBox.Show("Combate: " + nivelCombate + "\n\nTe encuentras con un enemigo llamado " + enemigo.DevolverNombre + ".\nClase: " + enemigo.DevolverClase, "COMBATE", MessageBoxButtons.OK);
            MessageBox.Show("Cada turno debes escoger una sola acción de las tres disponibles: \n\n- Atacar: Atacarás al enemigo empleando la Fuerza\n- Defensa: Recuperarás una cantidad aleatoria de Vida\n- Magia: Atacarás al enemigo empleando Maná\n\nEn el turno del enemigo tomará una acción aleatoria.\n\nPierde el primero que pierda toda su vida.", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gb_Enemigo.Visible = true;
            lb_VidaEnemigo.Text = "Vida: " + enemigo.DevolverVida;
            lb_ManaEnemigo.Text = "Maná: " + enemigo.DevolverMana;
            lb_NombreEnemigo.Text = "Nombre: " + enemigo.DevolverNombre;
            lb_ClaseEnemigo.Text = "Clase: " + enemigo.DevolverClase;
            lb_FuerzaEnemigo.Text = "Fuerza: " + enemigo.DevolverFuerza;
            lb_DestrezaEnemigo.Text = "Destreza: " + enemigo.DevolverDestreza;
            lb_AgilidadEnemigo.Text = "Agilidad: " + enemigo.DevolverAgilidad;
            lb_InteligenciaEnemigo.Text = "Inteligencia: " + enemigo.DevolverInteligencia;
            lb_AtaqueEnemigo.Text = "Bon.Ataque: " + enemigo.DevolverAtaque + "%";
            lb_DefensaEnemigo.Text = "Bon.Defensa: " + enemigo.DevolverDefensa + "%";
            lb_EsquivarEnemigo.Text = "Bon.Esquivar: " + enemigo.DevolverEsquivar + "%";
            lb_MagiaEnemigo.Text = "Bon.Magia: " + enemigo.DevolverMagia + "%";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}