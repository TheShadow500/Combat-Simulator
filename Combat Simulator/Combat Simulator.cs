using System.Diagnostics;

namespace Combat_Simulator
{
    public partial class fr_PantallaPartida : Form
    {
        CreacionPersonaje creacionPersonaje = new CreacionPersonaje();
        Personaje heroe;
        Personaje enemigo;
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
                enemigo = creacionPersonaje.creacion_personaje(false, 4);
                bt_Atacar.Enabled = true;
                bt_Defender.Enabled = true;
                bt_Magia.Enabled = true;
                MostrarEnemigo(enemigo);
            }
        }

        private void rd_Guerrero_CheckedChanged(object sender, EventArgs e)
        {
            // Seleccion de la clase Guerrero
            if (rd_Guerrero.Checked && MessageBox.Show("La clase Guerrero basa sus atributos en la Fuerza y Destreza.\n\nEstá pensado para el combate con armas cuerpo a cuerpo.\n\n¿Desea escoger esta clase?", "GUERRERO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ha escogido la clase GUERRERO", "Bienvenido a Combat Simulator");
                heroe = creacionPersonaje.creacion_personaje(true, 0);
                InicializarPartida(heroe);
            }
        }

        private void rd_Arquero_CheckedChanged(object sender, EventArgs e)
        {
            // Seleccion de la clase Arquero
            if (rd_Arquero.Checked && MessageBox.Show("La clase Arquero basa sus atributos en la Agilidad y la Destreza.\n\nEstá pensado para el combate con armas a distancia.\n\n¿Desea escoger esta clase?", "ARQUERO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ha escogido la clase ARQUERO", "Bienvenido a Combat Simulator");
                heroe = creacionPersonaje.creacion_personaje(true, 1);
                InicializarPartida(heroe);
            }
        }

        private void rd_Mago_CheckedChanged(object sender, EventArgs e)
        {
            // Seleccion de la clase Mago
            if (rd_Mago.Checked && MessageBox.Show("La clase Mago basa sus atributos en la Inteligencia y la Destreza.\n\nEstá pensado para el combate con armas a distancia.\n\n¿Desea escoger esta clase?", "MAGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ha escogido la clase MAGO", "Bienvenido a Combat Simulator");
                heroe = creacionPersonaje.creacion_personaje(true, 2);
                InicializarPartida(heroe);
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

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists("ChangeLog.txt"))
            {
                Process.Start("Notepad.exe", "ChangeLog.txt");
            }
            else
            {
                MessageBox.Show("El archivo ChangeLog.txt no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}