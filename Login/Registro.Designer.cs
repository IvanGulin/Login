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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.entradaContraseña = new System.Windows.Forms.TextBox();
            this.entradaUsuario = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.entradaCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entradaContraseña2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckAdmin = new System.Windows.Forms.CheckBox();
            this.panelVentana = new System.Windows.Forms.Panel();
            this.labelVentana = new System.Windows.Forms.Label();
            this.panelMinimizar = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.panelCerrar = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelVentana.SuspendLayout();
            this.panelMinimizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.panelCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.botonRegistrar.Location = new System.Drawing.Point(175, 369);
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
            this.labelRegistro.Location = new System.Drawing.Point(169, 49);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(152, 39);
            this.labelRegistro.TabIndex = 11;
            this.labelRegistro.Text = "Registro";
            // 
            // entradaContraseña
            // 
            this.entradaContraseña.Location = new System.Drawing.Point(135, 267);
            this.entradaContraseña.MaxLength = 50;
            this.entradaContraseña.Name = "entradaContraseña";
            this.entradaContraseña.PasswordChar = '*';
            this.entradaContraseña.Size = new System.Drawing.Size(227, 20);
            this.entradaContraseña.TabIndex = 11;
            this.entradaContraseña.UseSystemPasswordChar = true;
            // 
            // entradaUsuario
            // 
            this.entradaUsuario.Location = new System.Drawing.Point(135, 136);
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
            this.labelContraseña.Location = new System.Drawing.Point(199, 246);
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
            this.labelUsuario.Location = new System.Drawing.Point(166, 115);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(162, 21);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "Nombre de usuario";
            // 
            // entradaCorreo
            // 
            this.entradaCorreo.Location = new System.Drawing.Point(135, 202);
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
            this.label1.Location = new System.Drawing.Point(166, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Correo electrónico";
            // 
            // entradaContraseña2
            // 
            this.entradaContraseña2.Location = new System.Drawing.Point(135, 337);
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
            this.label2.Location = new System.Drawing.Point(166, 316);
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
            this.CheckAdmin.Location = new System.Drawing.Point(378, 136);
            this.CheckAdmin.Name = "CheckAdmin";
            this.CheckAdmin.Size = new System.Drawing.Size(69, 20);
            this.CheckAdmin.TabIndex = 17;
            this.CheckAdmin.Text = "Admin";
            this.CheckAdmin.UseVisualStyleBackColor = true;
            // 
            // panelVentana
            // 
            this.panelVentana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVentana.Controls.Add(this.labelVentana);
            this.panelVentana.Controls.Add(this.panelMinimizar);
            this.panelVentana.Controls.Add(this.panelCerrar);
            this.panelVentana.Location = new System.Drawing.Point(-2, -2);
            this.panelVentana.Name = "panelVentana";
            this.panelVentana.Size = new System.Drawing.Size(507, 34);
            this.panelVentana.TabIndex = 18;
            this.panelVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseDown);
            this.panelVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseMove);
            this.panelVentana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseUp);
            // 
            // labelVentana
            // 
            this.labelVentana.AutoSize = true;
            this.labelVentana.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelVentana.Location = new System.Drawing.Point(215, 12);
            this.labelVentana.Name = "labelVentana";
            this.labelVentana.Size = new System.Drawing.Size(58, 11);
            this.labelVentana.TabIndex = 13;
            this.labelVentana.Text = "REGISTRO";
            this.labelVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseDown);
            this.labelVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseMove);
            this.labelVentana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseUp);
            // 
            // panelMinimizar
            // 
            this.panelMinimizar.Controls.Add(this.pbMinimizar);
            this.panelMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMinimizar.Location = new System.Drawing.Point(431, 1);
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
            this.panelCerrar.Location = new System.Drawing.Point(470, 1);
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Login.Properties.Resources.arriba_a_la_izquierda;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelVentana);
            this.Controls.Add(this.CheckAdmin);
            this.Controls.Add(this.entradaContraseña2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entradaCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.entradaContraseña);
            this.Controls.Add(this.entradaUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panelVentana.ResumeLayout(false);
            this.panelVentana.PerformLayout();
            this.panelMinimizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.panelCerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox entradaContraseña2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckAdmin;
        private System.Windows.Forms.Panel panelVentana;
        private System.Windows.Forms.Panel panelMinimizar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Panel panelCerrar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label labelVentana;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}