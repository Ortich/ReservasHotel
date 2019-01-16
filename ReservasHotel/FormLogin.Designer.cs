namespace ReservasHotel
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxusuarioLogin = new System.Windows.Forms.TextBox();
            this.labelUsuarioLogin = new System.Windows.Forms.Label();
            this.labelPassLogin = new System.Windows.Forms.Label();
            this.textBoxPassLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(161, 99);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Entrar";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxusuarioLogin
            // 
            this.textBoxusuarioLogin.Location = new System.Drawing.Point(79, 47);
            this.textBoxusuarioLogin.Name = "textBoxusuarioLogin";
            this.textBoxusuarioLogin.Size = new System.Drawing.Size(157, 20);
            this.textBoxusuarioLogin.TabIndex = 1;
            // 
            // labelUsuarioLogin
            // 
            this.labelUsuarioLogin.AutoSize = true;
            this.labelUsuarioLogin.Location = new System.Drawing.Point(30, 50);
            this.labelUsuarioLogin.Name = "labelUsuarioLogin";
            this.labelUsuarioLogin.Size = new System.Drawing.Size(43, 13);
            this.labelUsuarioLogin.TabIndex = 2;
            this.labelUsuarioLogin.Text = "Usuario";
            // 
            // labelPassLogin
            // 
            this.labelPassLogin.AutoSize = true;
            this.labelPassLogin.Location = new System.Drawing.Point(12, 76);
            this.labelPassLogin.Name = "labelPassLogin";
            this.labelPassLogin.Size = new System.Drawing.Size(61, 13);
            this.labelPassLogin.TabIndex = 4;
            this.labelPassLogin.Text = "Contraseña";
            // 
            // textBoxPassLogin
            // 
            this.textBoxPassLogin.Location = new System.Drawing.Point(79, 73);
            this.textBoxPassLogin.Name = "textBoxPassLogin";
            this.textBoxPassLogin.PasswordChar = '♥';
            this.textBoxPassLogin.Size = new System.Drawing.Size(157, 20);
            this.textBoxPassLogin.TabIndex = 3;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 187);
            this.Controls.Add(this.labelUsuarioLogin);
            this.Controls.Add(this.textBoxusuarioLogin);
            this.Controls.Add(this.labelPassLogin);
            this.Controls.Add(this.textBoxPassLogin);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxusuarioLogin;
        private System.Windows.Forms.Label labelUsuarioLogin;
        private System.Windows.Forms.Label labelPassLogin;
        private System.Windows.Forms.TextBox textBoxPassLogin;
    }
}

