namespace ReservasHotel
{
    partial class FormNuevaReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaReserva));
            this.buttonTerminar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.labelFechaEntrada = new System.Windows.Forms.Label();
            this.labelFechaSalida = new System.Windows.Forms.Label();
            this.labelHabitacion = new System.Windows.Forms.Label();
            this.comboBoxHabitaciones = new System.Windows.Forms.ComboBox();
            this.textBoxNumeroPersonas = new System.Windows.Forms.TextBox();
            this.labelNumeroPersonas = new System.Windows.Forms.Label();
            this.labelTBCamasSupletorias = new System.Windows.Forms.Label();
            this.textBoxBCamasSupletorias = new System.Windows.Forms.TextBox();
            this.labelTCamasSupletorias = new System.Windows.Forms.Label();
            this.labelCamasSupletorias = new System.Windows.Forms.Label();
            this.labeTCamasMatrimonio = new System.Windows.Forms.Label();
            this.labelCamasIndividuales = new System.Windows.Forms.Label();
            this.labelCamasMatrimonio = new System.Windows.Forms.Label();
            this.labelTCamasIndividuales = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDatosCliente = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonTerminar
            // 
            this.buttonTerminar.Location = new System.Drawing.Point(429, 198);
            this.buttonTerminar.Name = "buttonTerminar";
            this.buttonTerminar.Size = new System.Drawing.Size(75, 23);
            this.buttonTerminar.TabIndex = 0;
            this.buttonTerminar.Text = "Comprobar";
            this.buttonTerminar.UseVisualStyleBackColor = true;
            this.buttonTerminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerFechaEntrada
            // 
            this.dateTimePickerFechaEntrada.Location = new System.Drawing.Point(119, 107);
            this.dateTimePickerFechaEntrada.Name = "dateTimePickerFechaEntrada";
            this.dateTimePickerFechaEntrada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEntrada.TabIndex = 1;
            // 
            // dateTimePickerFechaSalida
            // 
            this.dateTimePickerFechaSalida.Location = new System.Drawing.Point(119, 153);
            this.dateTimePickerFechaSalida.Name = "dateTimePickerFechaSalida";
            this.dateTimePickerFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaSalida.TabIndex = 2;
            // 
            // labelFechaEntrada
            // 
            this.labelFechaEntrada.AutoSize = true;
            this.labelFechaEntrada.Location = new System.Drawing.Point(12, 110);
            this.labelFechaEntrada.Name = "labelFechaEntrada";
            this.labelFechaEntrada.Size = new System.Drawing.Size(77, 13);
            this.labelFechaEntrada.TabIndex = 3;
            this.labelFechaEntrada.Text = "Fecha Entrada";
            // 
            // labelFechaSalida
            // 
            this.labelFechaSalida.AutoSize = true;
            this.labelFechaSalida.Location = new System.Drawing.Point(12, 156);
            this.labelFechaSalida.Name = "labelFechaSalida";
            this.labelFechaSalida.Size = new System.Drawing.Size(69, 13);
            this.labelFechaSalida.TabIndex = 4;
            this.labelFechaSalida.Text = "Fecha Salida";
            // 
            // labelHabitacion
            // 
            this.labelHabitacion.AutoSize = true;
            this.labelHabitacion.Location = new System.Drawing.Point(12, 13);
            this.labelHabitacion.Name = "labelHabitacion";
            this.labelHabitacion.Size = new System.Drawing.Size(58, 13);
            this.labelHabitacion.TabIndex = 6;
            this.labelHabitacion.Text = "Habitacion";
            // 
            // comboBoxHabitaciones
            // 
            this.comboBoxHabitaciones.FormattingEnabled = true;
            this.comboBoxHabitaciones.Location = new System.Drawing.Point(76, 10);
            this.comboBoxHabitaciones.Name = "comboBoxHabitaciones";
            this.comboBoxHabitaciones.Size = new System.Drawing.Size(79, 21);
            this.comboBoxHabitaciones.TabIndex = 7;
            // 
            // textBoxNumeroPersonas
            // 
            this.textBoxNumeroPersonas.Location = new System.Drawing.Point(76, 200);
            this.textBoxNumeroPersonas.Name = "textBoxNumeroPersonas";
            this.textBoxNumeroPersonas.Size = new System.Drawing.Size(41, 20);
            this.textBoxNumeroPersonas.TabIndex = 8;
            // 
            // labelNumeroPersonas
            // 
            this.labelNumeroPersonas.AutoSize = true;
            this.labelNumeroPersonas.Location = new System.Drawing.Point(12, 203);
            this.labelNumeroPersonas.Name = "labelNumeroPersonas";
            this.labelNumeroPersonas.Size = new System.Drawing.Size(51, 13);
            this.labelNumeroPersonas.TabIndex = 9;
            this.labelNumeroPersonas.Text = "Personas";
            // 
            // labelTBCamasSupletorias
            // 
            this.labelTBCamasSupletorias.AutoSize = true;
            this.labelTBCamasSupletorias.Location = new System.Drawing.Point(150, 203);
            this.labelTBCamasSupletorias.Name = "labelTBCamasSupletorias";
            this.labelTBCamasSupletorias.Size = new System.Drawing.Size(94, 13);
            this.labelTBCamasSupletorias.TabIndex = 11;
            this.labelTBCamasSupletorias.Text = "Camas Supletorias";
            // 
            // textBoxBCamasSupletorias
            // 
            this.textBoxBCamasSupletorias.Location = new System.Drawing.Point(260, 200);
            this.textBoxBCamasSupletorias.Name = "textBoxBCamasSupletorias";
            this.textBoxBCamasSupletorias.Size = new System.Drawing.Size(41, 20);
            this.textBoxBCamasSupletorias.TabIndex = 10;
            // 
            // labelTCamasSupletorias
            // 
            this.labelTCamasSupletorias.AutoSize = true;
            this.labelTCamasSupletorias.Location = new System.Drawing.Point(215, 52);
            this.labelTCamasSupletorias.Name = "labelTCamasSupletorias";
            this.labelTCamasSupletorias.Size = new System.Drawing.Size(94, 13);
            this.labelTCamasSupletorias.TabIndex = 12;
            this.labelTCamasSupletorias.Text = "Camas Supletorias";
            // 
            // labelCamasSupletorias
            // 
            this.labelCamasSupletorias.AutoSize = true;
            this.labelCamasSupletorias.Location = new System.Drawing.Point(219, 70);
            this.labelCamasSupletorias.Name = "labelCamasSupletorias";
            this.labelCamasSupletorias.Size = new System.Drawing.Size(35, 13);
            this.labelCamasSupletorias.TabIndex = 13;
            this.labelCamasSupletorias.Text = "label7";
            // 
            // labeTCamasMatrimonio
            // 
            this.labeTCamasMatrimonio.AutoSize = true;
            this.labeTCamasMatrimonio.Location = new System.Drawing.Point(116, 52);
            this.labeTCamasMatrimonio.Name = "labeTCamasMatrimonio";
            this.labeTCamasMatrimonio.Size = new System.Drawing.Size(93, 13);
            this.labeTCamasMatrimonio.TabIndex = 14;
            this.labeTCamasMatrimonio.Text = "Camas Matrimonio";
            // 
            // labelCamasIndividuales
            // 
            this.labelCamasIndividuales.AutoSize = true;
            this.labelCamasIndividuales.Location = new System.Drawing.Point(16, 70);
            this.labelCamasIndividuales.Name = "labelCamasIndividuales";
            this.labelCamasIndividuales.Size = new System.Drawing.Size(35, 13);
            this.labelCamasIndividuales.TabIndex = 15;
            this.labelCamasIndividuales.Text = "label9";
            // 
            // labelCamasMatrimonio
            // 
            this.labelCamasMatrimonio.AutoSize = true;
            this.labelCamasMatrimonio.Location = new System.Drawing.Point(120, 70);
            this.labelCamasMatrimonio.Name = "labelCamasMatrimonio";
            this.labelCamasMatrimonio.Size = new System.Drawing.Size(35, 13);
            this.labelCamasMatrimonio.TabIndex = 15;
            this.labelCamasMatrimonio.Text = "label9";
            // 
            // labelTCamasIndividuales
            // 
            this.labelTCamasIndividuales.AutoSize = true;
            this.labelTCamasIndividuales.Location = new System.Drawing.Point(0, 0);
            this.labelTCamasIndividuales.Name = "labelTCamasIndividuales";
            this.labelTCamasIndividuales.Size = new System.Drawing.Size(98, 13);
            this.labelTCamasIndividuales.TabIndex = 16;
            this.labelTCamasIndividuales.Text = "Camas Individuales";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(372, 48);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 18;
            this.labelDNI.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(404, 45);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 17;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(354, 74);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 20;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(404, 71);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 19;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(354, 100);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 21;
            this.labelApellido.Text = "Apellido";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(366, 126);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(349, 152);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 23;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelDatosCliente
            // 
            this.labelDatosCliente.AutoSize = true;
            this.labelDatosCliente.Location = new System.Drawing.Point(434, 13);
            this.labelDatosCliente.Name = "labelDatosCliente";
            this.labelDatosCliente.Size = new System.Drawing.Size(70, 13);
            this.labelDatosCliente.TabIndex = 24;
            this.labelDatosCliente.Text = "Datos Cliente";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(404, 97);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(404, 123);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 26;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(404, 149);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 27;
            // 
            // FormNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 237);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelDatosCliente);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labeTCamasMatrimonio);
            this.Controls.Add(this.labelCamasMatrimonio);
            this.Controls.Add(this.labelTCamasIndividuales);
            this.Controls.Add(this.labelCamasIndividuales);
            this.Controls.Add(this.labelCamasSupletorias);
            this.Controls.Add(this.labelTCamasSupletorias);
            this.Controls.Add(this.labelTBCamasSupletorias);
            this.Controls.Add(this.textBoxBCamasSupletorias);
            this.Controls.Add(this.labelNumeroPersonas);
            this.Controls.Add(this.textBoxNumeroPersonas);
            this.Controls.Add(this.comboBoxHabitaciones);
            this.Controls.Add(this.labelHabitacion);
            this.Controls.Add(this.labelFechaSalida);
            this.Controls.Add(this.labelFechaEntrada);
            this.Controls.Add(this.dateTimePickerFechaSalida);
            this.Controls.Add(this.dateTimePickerFechaEntrada);
            this.Controls.Add(this.buttonTerminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormNuevaReserva";
            this.Text = "Nueva Reserva";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTerminar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEntrada;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSalida;
        private System.Windows.Forms.Label labelFechaSalida;
        private System.Windows.Forms.Label labelHabitacion;
        private System.Windows.Forms.ComboBox comboBoxHabitaciones;
        private System.Windows.Forms.TextBox textBoxNumeroPersonas;
        private System.Windows.Forms.Label labelNumeroPersonas;
        private System.Windows.Forms.Label labelTBCamasSupletorias;
        private System.Windows.Forms.TextBox textBoxBCamasSupletorias;
        private System.Windows.Forms.Label labelTCamasSupletorias;
        private System.Windows.Forms.Label labelCamasSupletorias;
        private System.Windows.Forms.Label labeTCamasMatrimonio;
        private System.Windows.Forms.Label labelCamasIndividuales;
        private System.Windows.Forms.Label labelCamasMatrimonio;
        private System.Windows.Forms.Label labelTCamasIndividuales;
        private System.Windows.Forms.Label labelFechaEntrada;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDatosCliente;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
    }
}