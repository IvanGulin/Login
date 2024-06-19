namespace Login
{
    partial class Login
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
            if (disposing && (components != null))
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.entradaUsuario = new System.Windows.Forms.TextBox();
            this.entradaContraseña = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(205, 164);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(72, 29);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(195, 265);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(99, 29);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña";
            // 
            // entradaUsuario
            // 
            this.entradaUsuario.Location = new System.Drawing.Point(131, 184);
            this.entradaUsuario.MaxLength = 25;
            this.entradaUsuario.Name = "entradaUsuario";
            this.entradaUsuario.Size = new System.Drawing.Size(227, 20);
            this.entradaUsuario.TabIndex = 2;
            // 
            // entradaContraseña
            // 
            this.entradaContraseña.Location = new System.Drawing.Point(131, 286);
            this.entradaContraseña.MaxLength = 50;
            this.entradaContraseña.Name = "entradaContraseña";
            this.entradaContraseña.PasswordChar = '*';
            this.entradaContraseña.Size = new System.Drawing.Size(227, 20);
            this.entradaContraseña.TabIndex = 3;
            this.entradaContraseña.UseSystemPasswordChar = true;
            this.entradaContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entradaContraseña_KeyDown);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(194, 92);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(92, 34);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botonEntrar.FlatAppearance.BorderSize = 0;
            this.botonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.botonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEntrar.Location = new System.Drawing.Point(200, 312);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(87, 44);
            this.botonEntrar.TabIndex = 6;
            this.botonEntrar.Text = "Entrar";
            this.botonEntrar.UseVisualStyleBackColor = false;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.botonEntrar);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.entradaContraseña);
            this.Controls.Add(this.entradaUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox entradaUsuario;
        private System.Windows.Forms.TextBox entradaContraseña;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button botonEntrar;
    }
}

