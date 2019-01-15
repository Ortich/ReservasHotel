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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarioReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCalendarioReservas
            // 
            this.dataGridViewCalendarioReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendarioReservas.Location = new System.Drawing.Point(548, 12);
            this.dataGridViewCalendarioReservas.Name = "dataGridViewCalendarioReservas";
            this.dataGridViewCalendarioReservas.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCalendarioReservas.TabIndex = 0;
            // 
            // FormVentananPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}