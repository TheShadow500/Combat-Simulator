namespace Combat_Simulator
{
    public class Personaje
    {
        /* Datos */
        protected string nombre;
        protected string clase;
        protected int nivel;

        /* Atributos */
        protected int fuerza;
        protected int destreza;
        protected int agilidad;
        protected int inteligencia;

        /* Bonificadores */
        protected int ataque;
        protected int defensa;
        protected int esquivar;
        protected int magia;

        /* Estado */
        protected int vida;
        protected int mana;

        /* Protagonista */
        protected bool protagonista;

        public Personaje(string nombre2, int fuerza2, int destreza2, int agilidad2, int inteligencia2, bool protagonista2, int opcion)
        {
            nombre = nombre2;
            nivel = 1;
            fuerza = fuerza2;
            destreza = destreza2;
            agilidad = agilidad2;
            inteligencia = inteligencia2;
            ataque = Convert.ToInt32(fuerza * 5);
            defensa = Convert.ToInt32(destreza * 5);
            esquivar = Convert.ToInt32(agilidad * 5);
            magia = Convert.ToInt32(inteligencia * 5);
            switch(opcion)
            {
                case 0:
                    clase = "Guerrero";
                    vida = 15 + Convert.ToInt32(fuerza * 0.5);
                    mana = 5 - Convert.ToInt32(inteligencia * 0.25);
                    break;
                case 1:
                    clase = "Arquero";
                    vida = 10 + Convert.ToInt32(fuerza * 0.25);
                    mana = 10 - Convert.ToInt32(inteligencia * 0.25);
                    break;
                case 2:
                    clase = "Mago";
                    vida = 5 + Convert.ToInt32(fuerza * 0.25);
                    mana = 15 - Convert.ToInt32(inteligencia * 0.5);
                    break;
                default:
                    clase = "Sin Clase";
                    break;
            }
            protagonista = protagonista2;
        }

        public string DevolverNombre
        {
            get { return nombre; }
        }

        public string DevolverClase
        {
            get { return clase; }
        }

        public int DevolverNivel
        {
            get { return nivel; }
        }

        public int DevolverFuerza
        {
            get { return fuerza; }
        }

        public int DevolverDestreza
        {
            get { return destreza; }
        }

        public int DevolverAgilidad
        {
            get { return agilidad; }
        }

        public int DevolverInteligencia
        {
            get { return inteligencia; }
        }

        public int DevolverAtaque
        {
            get { return ataque; }
        }

        public int DevolverDefensa
        {
            get { return defensa; }
        }

        public int DevolverEsquivar
        {
            get { return esquivar; }
        }

        public int DevolverMagia
        {
            get { return magia; }
        }

        public int DevolverVida
        {
            get { return vida; }
        }

        public int DevolverMana
        {
            get { return mana; }
        }

        public bool DevolverProtagonista
        {
            get { return protagonista; }
        }
    }
}
