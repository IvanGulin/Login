namespace Login
{
    partial class Registro
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
            if (disposing && (components != null))
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
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.entradaContraseña = new System.Windows.Forms.TextBox();
            this.entradaUsuario = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.entradaCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonLogin = new System.Windows.Forms.Button();
            this.entradaContraseña2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.botonRegistrar.FlatAppearance.BorderSize = 0;
            this.botonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.botonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrar.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.botonRegistrar.ForeColor = System.Drawing.Color.White;
            this.botonRegistrar.Location = new System.Drawing.Point(169, 344);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(139, 44);
            this.botonRegistrar.TabIndex = 12;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRegistro.Location = new System.Drawing.Point(170, 24);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(152, 39);
            this.labelRegistro.TabIndex = 11;
            this.labelRegistro.Text = "Registro";
            // 
            // entradaContraseña
            // 
            this.entradaContraseña.Location = new System.Drawing.Point(129, 242);
            this.entradaContraseña.MaxLength = 50;
            this.entradaContraseña.Name = "entradaContraseña";
            this.entradaContraseña.PasswordChar = '*';
            this.entradaContraseña.Size = new System.Drawing.Size(227, 20);
            this.entradaContraseña.TabIndex = 11;
            this.entradaContraseña.UseSystemPasswordChar = true;
            // 
            // entradaUsuario
            // 
            this.entradaUsuario.Location = new System.Drawing.Point(129, 111);
            this.entradaUsuario.MaxLength = 25;
            this.entradaUsuario.Name = "entradaUsuario";
            this.entradaUsuario.Size = new System.Drawing.Size(227, 20);
            this.entradaUsuario.TabIndex = 9;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.labelContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelContraseña.Location = new System.Drawing.Point(193, 221);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(99, 21);
            this.labelContraseña.TabIndex = 8;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsuario.Location = new System.Drawing.Point(160, 90);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(162, 21);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "Nombre de usuario";
            // 
            // entradaCorreo
            // 
            this.entradaCorreo.Location = new System.Drawing.Point(129, 177);
            this.entradaCorreo.MaxLength = 60;
            this.entradaCorreo.Name = "entradaCorreo";
            this.entradaCorreo.Size = new System.Drawing.Size(227, 20);
            this.entradaCorreo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Correo electrónico";
            // 
            // botonLogin
            // 
            this.botonLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botonLogin.FlatAppearance.BorderSize = 0;
            this.botonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.botonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLogin.Location = new System.Drawing.Point(397, 426);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(75, 23);
            this.botonLogin.TabIndex = 15;
            this.botonLogin.Text = "Menú Admin";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // entradaContraseña2
            // 
            this.entradaContraseña2.Location = new System.Drawing.Point(129, 312);
            this.entradaContraseña2.MaxLength = 50;
            this.entradaContraseña2.Name = "entradaContraseña2";
            this.entradaContraseña2.PasswordChar = '*';
            this.entradaContraseña2.Size = new System.Drawing.Size(227, 20);
            this.entradaContraseña2.TabIndex = 12;
            this.entradaContraseña2.UseSystemPasswordChar = true;
            this.entradaContraseña2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entradaContraseña2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(160, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirma Contraseña";
            // 
            // CheckAdmin
            // 
            this.CheckAdmin.AutoSize = true;
            this.CheckAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAdmin.ForeColor = System.Drawing.Color.Silver;
            this.CheckAdmin.Location = new System.Drawing.Point(372, 111);
            this.CheckAdmin.Name = "CheckAdmin";
            this.CheckAdmin.Size = new System.Drawing.Size(69, 20);
            this.CheckAdmin.TabIndex = 17;
            this.CheckAdmin.Text = "Admin";
            this.CheckAdmin.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.CheckAdmin);
            this.Controls.Add(this.entradaContraseña2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.entradaCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.entradaContraseña);
            this.Controls.Add(this.entradaUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Registro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.TextBox entradaContraseña;
        private System.Windows.Forms.TextBox entradaUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox entradaCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.TextBox entradaContraseña2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckAdmin;
    }
}