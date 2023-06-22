namespace Combat_Simulator
{
    partial class fr_PantallaPartida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_ComenzarPartida = new Button();
            gb_Atributos = new GroupBox();
            lb_Clase = new Label();
            lb_Nombre = new Label();
            lb_Magia = new Label();
            lb_Esquivar = new Label();
            lb_Defensa = new Label();
            lb_Ataque = new Label();
            lb_Inteligencia = new Label();
            lb_Agilidad = new Label();
            lb_Destreza = new Label();
            lb_Fuerza = new Label();
            bt_Atacar = new Button();
            bt_Defender = new Button();
            bt_Magia = new Button();
            gb_Acciones = new GroupBox();
            groupBox1 = new GroupBox();
            rd_Guerrero = new RadioButton();
            rd_Arquero = new RadioButton();
            rd_Mago = new RadioButton();
            gb_Enemigo = new GroupBox();
            lb_ClaseEnemigo = new Label();
            lb_ManaEnemigo = new Label();
            lb_VidaEnemigo = new Label();
            lb_NombreEnemigo = new Label();
            lb_MagiaEnemigo = new Label();
            lb_EsquivarEnemigo = new Label();
            lb_DefensaEnemigo = new Label();
            lb_AtaqueEnemigo = new Label();
            lb_InteligenciaEnemigo = new Label();
            lb_AgilidadEnemigo = new Label();
            lb_DestrezaEnemigo = new Label();
            lb_FuerzaEnemigo = new Label();
            gb_Estado = new GroupBox();
            lb_Mana = new Label();
            lb_Vida = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            changeLogToolStripMenuItem = new ToolStripMenuItem();
            readMeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            gb_Atributos.SuspendLayout();
            gb_Acciones.SuspendLayout();
            gb_Enemigo.SuspendLayout();
            gb_Estado.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_ComenzarPartida
            // 
            bt_ComenzarPartida.Font = new Font("Hobo Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_ComenzarPartida.Location = new Point(12, 36);
            bt_ComenzarPartida.Name = "bt_ComenzarPartida";
            bt_ComenzarPartida.Size = new Size(175, 37);
            bt_ComenzarPartida.TabIndex = 0;
            bt_ComenzarPartida.Text = "Comenzar Partida";
            bt_ComenzarPartida.UseVisualStyleBackColor = true;
            bt_ComenzarPartida.Click += bt_ComenzarPartida_Click;
            // 
            // gb_Atributos
            // 
            gb_Atributos.Controls.Add(lb_Clase);
            gb_Atributos.Controls.Add(lb_Nombre);
            gb_Atributos.Controls.Add(lb_Magia);
            gb_Atributos.Controls.Add(lb_Esquivar);
            gb_Atributos.Controls.Add(lb_Defensa);
            gb_Atributos.Controls.Add(lb_Ataque);
            gb_Atributos.Controls.Add(lb_Inteligencia);
            gb_Atributos.Controls.Add(lb_Agilidad);
            gb_Atributos.Controls.Add(lb_Destreza);
            gb_Atributos.Controls.Add(lb_Fuerza);
            gb_Atributos.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_Atributos.ForeColor = Color.White;
            gb_Atributos.Location = new Point(21, 334);
            gb_Atributos.Name = "gb_Atributos";
            gb_Atributos.Size = new Size(462, 215);
            gb_Atributos.TabIndex = 1;
            gb_Atributos.TabStop = false;
            gb_Atributos.Text = "Atributos";
            // 
            // lb_Clase
            // 
            lb_Clase.AutoSize = true;
            lb_Clase.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Clase.ForeColor = Color.Black;
            lb_Clase.Location = new Point(266, 40);
            lb_Clase.Name = "lb_Clase";
            lb_Clase.Size = new Size(58, 23);
            lb_Clase.TabIndex = 9;
            lb_Clase.Text = "Clase:";
            // 
            // lb_Nombre
            // 
            lb_Nombre.AutoSize = true;
            lb_Nombre.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Nombre.ForeColor = Color.Black;
            lb_Nombre.Location = new Point(68, 40);
            lb_Nombre.Name = "lb_Nombre";
            lb_Nombre.Size = new Size(75, 23);
            lb_Nombre.TabIndex = 8;
            lb_Nombre.Text = "Nombre:";
            // 
            // lb_Magia
            // 
            lb_Magia.AutoSize = true;
            lb_Magia.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Magia.ForeColor = Color.Black;
            lb_Magia.Location = new Point(287, 170);
            lb_Magia.Name = "lb_Magia";
            lb_Magia.Size = new Size(95, 23);
            lb_Magia.TabIndex = 7;
            lb_Magia.Text = "Bon.Magia:";
            // 
            // lb_Esquivar
            // 
            lb_Esquivar.AutoSize = true;
            lb_Esquivar.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Esquivar.ForeColor = Color.Black;
            lb_Esquivar.Location = new Point(266, 140);
            lb_Esquivar.Name = "lb_Esquivar";
            lb_Esquivar.Size = new Size(116, 23);
            lb_Esquivar.TabIndex = 6;
            lb_Esquivar.Text = "Bon.Esquivar:";
            // 
            // lb_Defensa
            // 
            lb_Defensa.AutoSize = true;
            lb_Defensa.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Defensa.ForeColor = Color.Black;
            lb_Defensa.Location = new Point(271, 110);
            lb_Defensa.Name = "lb_Defensa";
            lb_Defensa.Size = new Size(111, 23);
            lb_Defensa.TabIndex = 5;
            lb_Defensa.Text = "Bon.Defensa:";
            // 
            // lb_Ataque
            // 
            lb_Ataque.AutoSize = true;
            lb_Ataque.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ataque.ForeColor = Color.Black;
            lb_Ataque.Location = new Point(279, 80);
            lb_Ataque.Name = "lb_Ataque";
            lb_Ataque.Size = new Size(103, 23);
            lb_Ataque.TabIndex = 4;
            lb_Ataque.Text = "Bon.Ataque:";
            // 
            // lb_Inteligencia
            // 
            lb_Inteligencia.AutoSize = true;
            lb_Inteligencia.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Inteligencia.ForeColor = Color.Black;
            lb_Inteligencia.Location = new Point(39, 170);
            lb_Inteligencia.Name = "lb_Inteligencia";
            lb_Inteligencia.Size = new Size(104, 23);
            lb_Inteligencia.TabIndex = 3;
            lb_Inteligencia.Text = "Inteligencia:";
            // 
            // lb_Agilidad
            // 
            lb_Agilidad.AutoSize = true;
            lb_Agilidad.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Agilidad.ForeColor = Color.Black;
            lb_Agilidad.Location = new Point(65, 140);
            lb_Agilidad.Name = "lb_Agilidad";
            lb_Agilidad.Size = new Size(78, 23);
            lb_Agilidad.TabIndex = 2;
            lb_Agilidad.Text = "Agilidad:";
            // 
            // lb_Destreza
            // 
            lb_Destreza.AutoSize = true;
            lb_Destreza.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Destreza.ForeColor = Color.Black;
            lb_Destreza.Location = new Point(60, 110);
            lb_Destreza.Name = "lb_Destreza";
            lb_Destreza.Size = new Size(83, 23);
            lb_Destreza.TabIndex = 1;
            lb_Destreza.Text = "Destreza:";
            // 
            // lb_Fuerza
            // 
            lb_Fuerza.AutoSize = true;
            lb_Fuerza.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Fuerza.ForeColor = Color.Black;
            lb_Fuerza.Location = new Point(77, 80);
            lb_Fuerza.Name = "lb_Fuerza";
            lb_Fuerza.Size = new Size(66, 23);
            lb_Fuerza.TabIndex = 0;
            lb_Fuerza.Text = "Fuerza:";
            // 
            // bt_Atacar
            // 
            bt_Atacar.Enabled = false;
            bt_Atacar.Font = new Font("Hobo Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Atacar.ForeColor = Color.Black;
            bt_Atacar.Location = new Point(6, 30);
            bt_Atacar.Name = "bt_Atacar";
            bt_Atacar.Size = new Size(145, 37);
            bt_Atacar.TabIndex = 2;
            bt_Atacar.Text = "Atacar";
            bt_Atacar.UseVisualStyleBackColor = true;
            // 
            // bt_Defender
            // 
            bt_Defender.Enabled = false;
            bt_Defender.Font = new Font("Hobo Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Defender.ForeColor = Color.Black;
            bt_Defender.Location = new Point(158, 30);
            bt_Defender.Name = "bt_Defender";
            bt_Defender.Size = new Size(145, 37);
            bt_Defender.TabIndex = 8;
            bt_Defender.Text = "Defender";
            bt_Defender.UseVisualStyleBackColor = true;
            // 
            // bt_Magia
            // 
            bt_Magia.Enabled = false;
            bt_Magia.Font = new Font("Hobo Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Magia.ForeColor = Color.Black;
            bt_Magia.Location = new Point(311, 30);
            bt_Magia.Name = "bt_Magia";
            bt_Magia.Size = new Size(145, 37);
            bt_Magia.TabIndex = 9;
            bt_Magia.Text = "Magia";
            bt_Magia.UseVisualStyleBackColor = true;
            // 
            // gb_Acciones
            // 
            gb_Acciones.Controls.Add(bt_Atacar);
            gb_Acciones.Controls.Add(bt_Magia);
            gb_Acciones.Controls.Add(bt_Defender);
            gb_Acciones.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_Acciones.ForeColor = Color.White;
            gb_Acciones.Location = new Point(504, 471);
            gb_Acciones.Name = "gb_Acciones";
            gb_Acciones.Size = new Size(462, 79);
            gb_Acciones.TabIndex = 10;
            gb_Acciones.TabStop = false;
            gb_Acciones.Text = "Acciones";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(504, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 131);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventario";
            // 
            // rd_Guerrero
            // 
            rd_Guerrero.AutoSize = true;
            rd_Guerrero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rd_Guerrero.Location = new Point(57, 88);
            rd_Guerrero.Name = "rd_Guerrero";
            rd_Guerrero.Size = new Size(71, 19);
            rd_Guerrero.TabIndex = 12;
            rd_Guerrero.TabStop = true;
            rd_Guerrero.Text = "Guerrero";
            rd_Guerrero.UseVisualStyleBackColor = true;
            rd_Guerrero.Visible = false;
            rd_Guerrero.CheckedChanged += rd_Guerrero_CheckedChanged;
            // 
            // rd_Arquero
            // 
            rd_Arquero.AutoSize = true;
            rd_Arquero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rd_Arquero.Location = new Point(57, 113);
            rd_Arquero.Name = "rd_Arquero";
            rd_Arquero.Size = new Size(68, 19);
            rd_Arquero.TabIndex = 13;
            rd_Arquero.TabStop = true;
            rd_Arquero.Text = "Arquero";
            rd_Arquero.UseVisualStyleBackColor = true;
            rd_Arquero.Visible = false;
            rd_Arquero.CheckedChanged += rd_Arquero_CheckedChanged;
            // 
            // rd_Mago
            // 
            rd_Mago.AutoSize = true;
            rd_Mago.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rd_Mago.Location = new Point(57, 138);
            rd_Mago.Name = "rd_Mago";
            rd_Mago.Size = new Size(56, 19);
            rd_Mago.TabIndex = 14;
            rd_Mago.TabStop = true;
            rd_Mago.Text = "Mago";
            rd_Mago.UseVisualStyleBackColor = true;
            rd_Mago.Visible = false;
            rd_Mago.CheckedChanged += rd_Mago_CheckedChanged;
            // 
            // gb_Enemigo
            // 
            gb_Enemigo.Controls.Add(lb_ClaseEnemigo);
            gb_Enemigo.Controls.Add(lb_ManaEnemigo);
            gb_Enemigo.Controls.Add(lb_VidaEnemigo);
            gb_Enemigo.Controls.Add(lb_NombreEnemigo);
            gb_Enemigo.Controls.Add(lb_MagiaEnemigo);
            gb_Enemigo.Controls.Add(lb_EsquivarEnemigo);
            gb_Enemigo.Controls.Add(lb_DefensaEnemigo);
            gb_Enemigo.Controls.Add(lb_AtaqueEnemigo);
            gb_Enemigo.Controls.Add(lb_InteligenciaEnemigo);
            gb_Enemigo.Controls.Add(lb_AgilidadEnemigo);
            gb_Enemigo.Controls.Add(lb_DestrezaEnemigo);
            gb_Enemigo.Controls.Add(lb_FuerzaEnemigo);
            gb_Enemigo.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_Enemigo.ForeColor = Color.White;
            gb_Enemigo.Location = new Point(504, 36);
            gb_Enemigo.Name = "gb_Enemigo";
            gb_Enemigo.Size = new Size(462, 292);
            gb_Enemigo.TabIndex = 15;
            gb_Enemigo.TabStop = false;
            gb_Enemigo.Text = "Enemigo";
            gb_Enemigo.Visible = false;
            // 
            // lb_ClaseEnemigo
            // 
            lb_ClaseEnemigo.AutoSize = true;
            lb_ClaseEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ClaseEnemigo.ForeColor = Color.Black;
            lb_ClaseEnemigo.Location = new Point(277, 115);
            lb_ClaseEnemigo.Name = "lb_ClaseEnemigo";
            lb_ClaseEnemigo.Size = new Size(58, 23);
            lb_ClaseEnemigo.TabIndex = 10;
            lb_ClaseEnemigo.Text = "Clase:";
            // 
            // lb_ManaEnemigo
            // 
            lb_ManaEnemigo.AutoSize = true;
            lb_ManaEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ManaEnemigo.ForeColor = Color.Black;
            lb_ManaEnemigo.Location = new Point(277, 36);
            lb_ManaEnemigo.Name = "lb_ManaEnemigo";
            lb_ManaEnemigo.Size = new Size(56, 23);
            lb_ManaEnemigo.TabIndex = 19;
            lb_ManaEnemigo.Text = "Maná:";
            // 
            // lb_VidaEnemigo
            // 
            lb_VidaEnemigo.AutoSize = true;
            lb_VidaEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_VidaEnemigo.ForeColor = Color.Black;
            lb_VidaEnemigo.Location = new Point(50, 36);
            lb_VidaEnemigo.Name = "lb_VidaEnemigo";
            lb_VidaEnemigo.Size = new Size(50, 23);
            lb_VidaEnemigo.TabIndex = 18;
            lb_VidaEnemigo.Text = "Vida:";
            // 
            // lb_NombreEnemigo
            // 
            lb_NombreEnemigo.AutoSize = true;
            lb_NombreEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_NombreEnemigo.ForeColor = Color.Black;
            lb_NombreEnemigo.Location = new Point(79, 115);
            lb_NombreEnemigo.Name = "lb_NombreEnemigo";
            lb_NombreEnemigo.Size = new Size(75, 23);
            lb_NombreEnemigo.TabIndex = 17;
            lb_NombreEnemigo.Text = "Nombre:";
            // 
            // lb_MagiaEnemigo
            // 
            lb_MagiaEnemigo.AutoSize = true;
            lb_MagiaEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MagiaEnemigo.ForeColor = Color.Black;
            lb_MagiaEnemigo.Location = new Point(298, 245);
            lb_MagiaEnemigo.Name = "lb_MagiaEnemigo";
            lb_MagiaEnemigo.Size = new Size(95, 23);
            lb_MagiaEnemigo.TabIndex = 16;
            lb_MagiaEnemigo.Text = "Bon.Magia:";
            // 
            // lb_EsquivarEnemigo
            // 
            lb_EsquivarEnemigo.AutoSize = true;
            lb_EsquivarEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_EsquivarEnemigo.ForeColor = Color.Black;
            lb_EsquivarEnemigo.Location = new Point(277, 215);
            lb_EsquivarEnemigo.Name = "lb_EsquivarEnemigo";
            lb_EsquivarEnemigo.Size = new Size(116, 23);
            lb_EsquivarEnemigo.TabIndex = 15;
            lb_EsquivarEnemigo.Text = "Bon.Esquivar:";
            // 
            // lb_DefensaEnemigo
            // 
            lb_DefensaEnemigo.AutoSize = true;
            lb_DefensaEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DefensaEnemigo.ForeColor = Color.Black;
            lb_DefensaEnemigo.Location = new Point(282, 185);
            lb_DefensaEnemigo.Name = "lb_DefensaEnemigo";
            lb_DefensaEnemigo.Size = new Size(111, 23);
            lb_DefensaEnemigo.TabIndex = 14;
            lb_DefensaEnemigo.Text = "Bon.Defensa:";
            // 
            // lb_AtaqueEnemigo
            // 
            lb_AtaqueEnemigo.AutoSize = true;
            lb_AtaqueEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_AtaqueEnemigo.ForeColor = Color.Black;
            lb_AtaqueEnemigo.Location = new Point(290, 155);
            lb_AtaqueEnemigo.Name = "lb_AtaqueEnemigo";
            lb_AtaqueEnemigo.Size = new Size(103, 23);
            lb_AtaqueEnemigo.TabIndex = 13;
            lb_AtaqueEnemigo.Text = "Bon.Ataque:";
            // 
            // lb_InteligenciaEnemigo
            // 
            lb_InteligenciaEnemigo.AutoSize = true;
            lb_InteligenciaEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_InteligenciaEnemigo.ForeColor = Color.Black;
            lb_InteligenciaEnemigo.Location = new Point(50, 245);
            lb_InteligenciaEnemigo.Name = "lb_InteligenciaEnemigo";
            lb_InteligenciaEnemigo.Size = new Size(104, 23);
            lb_InteligenciaEnemigo.TabIndex = 12;
            lb_InteligenciaEnemigo.Text = "Inteligencia:";
            // 
            // lb_AgilidadEnemigo
            // 
            lb_AgilidadEnemigo.AutoSize = true;
            lb_AgilidadEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_AgilidadEnemigo.ForeColor = Color.Black;
            lb_AgilidadEnemigo.Location = new Point(76, 215);
            lb_AgilidadEnemigo.Name = "lb_AgilidadEnemigo";
            lb_AgilidadEnemigo.Size = new Size(78, 23);
            lb_AgilidadEnemigo.TabIndex = 11;
            lb_AgilidadEnemigo.Text = "Agilidad:";
            // 
            // lb_DestrezaEnemigo
            // 
            lb_DestrezaEnemigo.AutoSize = true;
            lb_DestrezaEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DestrezaEnemigo.ForeColor = Color.Black;
            lb_DestrezaEnemigo.Location = new Point(71, 185);
            lb_DestrezaEnemigo.Name = "lb_DestrezaEnemigo";
            lb_DestrezaEnemigo.Size = new Size(83, 23);
            lb_DestrezaEnemigo.TabIndex = 10;
            lb_DestrezaEnemigo.Text = "Destreza:";
            // 
            // lb_FuerzaEnemigo
            // 
            lb_FuerzaEnemigo.AutoSize = true;
            lb_FuerzaEnemigo.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_FuerzaEnemigo.ForeColor = Color.Black;
            lb_FuerzaEnemigo.Location = new Point(88, 155);
            lb_FuerzaEnemigo.Name = "lb_FuerzaEnemigo";
            lb_FuerzaEnemigo.Size = new Size(66, 23);
            lb_FuerzaEnemigo.TabIndex = 9;
            lb_FuerzaEnemigo.Text = "Fuerza:";
            // 
            // gb_Estado
            // 
            gb_Estado.Controls.Add(lb_Mana);
            gb_Estado.Controls.Add(lb_Vida);
            gb_Estado.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_Estado.ForeColor = Color.White;
            gb_Estado.Location = new Point(21, 252);
            gb_Estado.Name = "gb_Estado";
            gb_Estado.Size = new Size(462, 76);
            gb_Estado.TabIndex = 16;
            gb_Estado.TabStop = false;
            gb_Estado.Text = "Estado";
            // 
            // lb_Mana
            // 
            lb_Mana.AutoSize = true;
            lb_Mana.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Mana.ForeColor = Color.Black;
            lb_Mana.Location = new Point(266, 33);
            lb_Mana.Name = "lb_Mana";
            lb_Mana.Size = new Size(56, 23);
            lb_Mana.TabIndex = 10;
            lb_Mana.Text = "Maná:";
            // 
            // lb_Vida
            // 
            lb_Vida.AutoSize = true;
            lb_Vida.Font = new Font("Hobo Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Vida.ForeColor = Color.Black;
            lb_Vida.Location = new Point(39, 33);
            lb_Vida.Name = "lb_Vida";
            lb_Vida.Size = new Size(50, 23);
            lb_Vida.TabIndex = 9;
            lb_Vida.Text = "Vida:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeLogToolStripMenuItem, readMeToolStripMenuItem, toolStripSeparator1, aboutToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // changeLogToolStripMenuItem
            // 
            changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            changeLogToolStripMenuItem.Size = new Size(180, 22);
            changeLogToolStripMenuItem.Text = "ChangeLog";
            changeLogToolStripMenuItem.Click += changeLogToolStripMenuItem_Click;
            // 
            // readMeToolStripMenuItem
            // 
            readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            readMeToolStripMenuItem.Size = new Size(180, 22);
            readMeToolStripMenuItem.Text = "ReadMe";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // fr_PantallaPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(984, 561);
            Controls.Add(gb_Estado);
            Controls.Add(gb_Enemigo);
            Controls.Add(rd_Mago);
            Controls.Add(rd_Arquero);
            Controls.Add(rd_Guerrero);
            Controls.Add(groupBox1);
            Controls.Add(gb_Acciones);
            Controls.Add(gb_Atributos);
            Controls.Add(bt_ComenzarPartida);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fr_PantallaPartida";
            Text = "Combat Simulator - 0.01b";
            gb_Atributos.ResumeLayout(false);
            gb_Atributos.PerformLayout();
            gb_Acciones.ResumeLayout(false);
            gb_Enemigo.ResumeLayout(false);
            gb_Enemigo.PerformLayout();
            gb_Estado.ResumeLayout(false);
            gb_Estado.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_ComenzarPartida;
        private GroupBox gb_Atributos;
        private Label lb_Magia;
        private Label lb_Esquivar;
        private Label lb_Defensa;
        private Label lb_Ataque;
        private Label lb_Inteligencia;
        private Label lb_Agilidad;
        private Label lb_Destreza;
        private Label lb_Fuerza;
        private Button bt_Atacar;
        private Button bt_Defender;
        private Button bt_Magia;
        private GroupBox gb_Acciones;
        private GroupBox groupBox1;
        private RadioButton rd_Guerrero;
        private RadioButton rd_Arquero;
        private RadioButton rd_Mago;
        private Label lb_Nombre;
        private GroupBox gb_Enemigo;
        private GroupBox gb_Estado;
        private Label lb_Mana;
        private Label lb_Vida;
        private Label lb_ManaEnemigo;
        private Label lb_VidaEnemigo;
        private Label lb_NombreEnemigo;
        private Label lb_MagiaEnemigo;
        private Label lb_EsquivarEnemigo;
        private Label lb_DefensaEnemigo;
        private Label lb_AtaqueEnemigo;
        private Label lb_InteligenciaEnemigo;
        private Label lb_AgilidadEnemigo;
        private Label lb_DestrezaEnemigo;
        private Label lb_FuerzaEnemigo;
        private Label lb_Clase;
        private Label lb_ClaseEnemigo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem changeLogToolStripMenuItem;
        private ToolStripMenuItem readMeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}