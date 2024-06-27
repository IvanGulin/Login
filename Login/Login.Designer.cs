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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.entradaUsuario = new System.Windows.Forms.TextBox();
            this.entradaContraseña = new System.Windows.Forms.TextBox();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.panelVentana = new System.Windows.Forms.Panel();
            this.panelMinimizar = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.panelCerrar = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.labelVentana = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelVentana.SuspendLayout();
            this.panelMinimizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.panelCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(210, 194);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(71, 21);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.White;
            this.labelContraseña.Location = new System.Drawing.Point(200, 295);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(99, 21);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña";
            // 
            // entradaUsuario
            // 
            this.entradaUsuario.Location = new System.Drawing.Point(136, 214);
            this.entradaUsuario.MaxLength = 25;
            this.entradaUsuario.Name = "entradaUsuario";
            this.entradaUsuario.Size = new System.Drawing.Size(227, 20);
            this.entradaUsuario.TabIndex = 2;
            // 
            // entradaContraseña
            // 
            this.entradaContraseña.Location = new System.Drawing.Point(136, 316);
            this.entradaContraseña.MaxLength = 50;
            this.entradaContraseña.Name = "entradaContraseña";
            this.entradaContraseña.PasswordChar = '*';
            this.entradaContraseña.Size = new System.Drawing.Size(227, 20);
            this.entradaContraseña.TabIndex = 3;
            this.entradaContraseña.UseSystemPasswordChar = true;
            this.entradaContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entradaContraseña_KeyDown);
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.botonEntrar.FlatAppearance.BorderSize = 0;
            this.botonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.botonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEntrar.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEntrar.ForeColor = System.Drawing.Color.White;
            this.botonEntrar.Location = new System.Drawing.Point(192, 351);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(107, 44);
            this.botonEntrar.TabIndex = 6;
            this.botonEntrar.Text = "Entrar";
            this.botonEntrar.UseVisualStyleBackColor = false;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // panelVentana
            // 
            this.panelVentana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVentana.Controls.Add(this.panelMinimizar);
            this.panelVentana.Controls.Add(this.panelCerrar);
            this.panelVentana.Location = new System.Drawing.Point(1, 1);
            this.panelVentana.Name = "panelVentana";
            this.panelVentana.Size = new System.Drawing.Size(498, 30);
            this.panelVentana.TabIndex = 9;
            this.panelVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseDown);
            this.panelVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseMove);
            this.panelVentana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseUp);
            // 
            // panelMinimizar
            // 
            this.panelMinimizar.Controls.Add(this.pbMinimizar);
            this.panelMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMinimizar.Location = new System.Drawing.Point(429, 0);
            this.panelMinimizar.Name = "panelMinimizar";
            this.panelMinimizar.Size = new System.Drawing.Size(30, 30);
            this.panelMinimizar.TabIndex = 11;
            this.panelMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            this.panelMinimizar.MouseEnter += new System.EventHandler(this.panelMinimizar_MouseEnter);
            this.panelMinimizar.MouseLeave += new System.EventHandler(this.panelMinimizar_MouseLeave);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::Login.Properties.Resources.minimize_sign;
            this.pbMinimizar.Location = new System.Drawing.Point(7, 7);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 0;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            this.pbMinimizar.MouseEnter += new System.EventHandler(this.panelMinimizar_MouseEnter);
            this.pbMinimizar.MouseLeave += new System.EventHandler(this.panelMinimizar_MouseLeave);
            // 
            // panelCerrar
            // 
            this.panelCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panelCerrar.Controls.Add(this.pbCerrar);
            this.panelCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCerrar.Location = new System.Drawing.Point(468, 0);
            this.panelCerrar.Name = "panelCerrar";
            this.panelCerrar.Size = new System.Drawing.Size(30, 30);
            this.panelCerrar.TabIndex = 10;
            this.panelCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            this.panelCerrar.MouseEnter += new System.EventHandler(this.panelCerrar_MouseEnter);
            this.panelCerrar.MouseLeave += new System.EventHandler(this.panelCerrar_MouseLeave);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::Login.Properties.Resources.close;
            this.pbCerrar.Location = new System.Drawing.Point(7, 7);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(15, 15);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            this.pbCerrar.MouseEnter += new System.EventHandler(this.panelCerrar_MouseEnter);
            this.pbCerrar.MouseLeave += new System.EventHandler(this.panelCerrar_MouseLeave);
            // 
            // labelVentana
            // 
            this.labelVentana.AutoSize = true;
            this.labelVentana.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelVentana.Location = new System.Drawing.Point(224, 12);
            this.labelVentana.Name = "labelVentana";
            this.labelVentana.Size = new System.Drawing.Size(38, 11);
            this.labelVentana.TabIndex = 12;
            this.labelVentana.Text = "LOGIN";
            this.labelVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseDown);
            this.labelVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseMove);
            this.labelVentana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.image_processing20191128_24941_zbq3ty;
            this.pictureBox2.Location = new System.Drawing.Point(93, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.entradaUsuario);
            this.Controls.Add(this.labelVentana);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.botonEntrar);
            this.Controls.Add(this.entradaContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.panelVentana);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelVentana.ResumeLayout(false);
            this.panelMinimizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.panelCerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox entradaUsuario;
        private System.Windows.Forms.TextBox entradaContraseña;
        private System.Windows.Forms.Button botonEntrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelVentana;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Panel panelCerrar;
        private System.Windows.Forms.Panel panelMinimizar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label labelVentana;
    }
}

