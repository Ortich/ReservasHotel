namespace ReservasHotel
{
    partial class FormVentananPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentananPrincipal));
            this.dataGridViewCalendarioReservas = new System.Windows.Forms.DataGridView();
            this.buttonSiguienteMes = new System.Windows.Forms.Button();
            this.buttonAnteriorMes = new System.Windows.Forms.Button();
            this.labelMesAnno = new System.Windows.Forms.Label();
            this.buttonNuevaReserva = new System.Windows.Forms.Button();
            this.buttonBuscarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarioReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCalendarioReservas
            // 
            this.dataGridViewCalendarioReservas.AllowUserToAddRows = false;
            this.dataGridViewCalendarioReservas.AllowUserToDeleteRows = false;
            this.dataGridViewCalendarioReservas.AllowUserToOrderColumns = true;
            this.dataGridViewCalendarioReservas.AllowUserToResizeColumns = false;
            this.dataGridViewCalendarioReservas.AllowUserToResizeRows = false;
            this.dataGridViewCalendarioReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCalendarioReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendarioReservas.Location = new System.Drawing.Point(214, 51);
            this.dataGridViewCalendarioReservas.Name = "dataGridViewCalendarioReservas";
            this.dataGridViewCalendarioReservas.Size = new System.Drawing.Size(549, 426);
            this.dataGridViewCalendarioReservas.TabIndex = 0;
            // 
            // buttonSiguienteMes
            // 
            this.buttonSiguienteMes.Location = new System.Drawing.Point(769, 51);
            this.buttonSiguienteMes.Name = "buttonSiguienteMes";
            this.buttonSiguienteMes.Size = new System.Drawing.Size(75, 426);
            this.buttonSiguienteMes.TabIndex = 1;
            this.buttonSiguienteMes.Text = "→";
            this.buttonSiguienteMes.UseVisualStyleBackColor = true;
            this.buttonSiguienteMes.Click += new System.EventHandler(this.buttonSiguienteMes_Click);
            // 
            // buttonAnteriorMes
            // 
            this.buttonAnteriorMes.Location = new System.Drawing.Point(133, 51);
            this.buttonAnteriorMes.Name = "buttonAnteriorMes";
            this.buttonAnteriorMes.Size = new System.Drawing.Size(75, 426);
            this.buttonAnteriorMes.TabIndex = 2;
            this.buttonAnteriorMes.Text = "←";
            this.buttonAnteriorMes.UseVisualStyleBackColor = true;
            this.buttonAnteriorMes.Click += new System.EventHandler(this.buttonAnteriorMes_Click);
            // 
            // labelMesAnno
            // 
            this.labelMesAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMesAnno.Location = new System.Drawing.Point(133, 18);
            this.labelMesAnno.Name = "labelMesAnno";
            this.labelMesAnno.Size = new System.Drawing.Size(711, 30);
            this.labelMesAnno.TabIndex = 3;
            this.labelMesAnno.Text = "label1";
            this.labelMesAnno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNuevaReserva
            // 
            this.buttonNuevaReserva.Location = new System.Drawing.Point(13, 14);
            this.buttonNuevaReserva.Name = "buttonNuevaReserva";
            this.buttonNuevaReserva.Size = new System.Drawing.Size(115, 31);
            this.buttonNuevaReserva.TabIndex = 4;
            this.buttonNuevaReserva.Text = "Nueva Reserva";
            this.buttonNuevaReserva.UseVisualStyleBackColor = true;
            this.buttonNuevaReserva.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBuscarReserva
            // 
            this.buttonBuscarReserva.Location = new System.Drawing.Point(12, 51);
            this.buttonBuscarReserva.Name = "buttonBuscarReserva";
            this.buttonBuscarReserva.Size = new System.Drawing.Size(115, 31);
            this.buttonBuscarReserva.TabIndex = 5;
            this.buttonBuscarReserva.Text = "Buscar Reserva";
            this.buttonBuscarReserva.UseVisualStyleBackColor = true;
            this.buttonBuscarReserva.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormVentananPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 494);
            this.Controls.Add(this.buttonBuscarReserva);
            this.Controls.Add(this.buttonNuevaReserva);
            this.Controls.Add(this.labelMesAnno);
            this.Controls.Add(this.buttonAnteriorMes);
            this.Controls.Add(this.buttonSiguienteMes);
            this.Controls.Add(this.dataGridViewCalendarioReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVentananPrincipal";
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarioReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCalendarioReservas;
        private System.Windows.Forms.Button buttonSiguienteMes;
        private System.Windows.Forms.Button buttonAnteriorMes;
        private System.Windows.Forms.Label labelMesAnno;
        private System.Windows.Forms.Button buttonNuevaReserva;
        private System.Windows.Forms.Button buttonBuscarReserva;
    }
}