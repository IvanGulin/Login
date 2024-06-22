namespace Login
{
    partial class MenuAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_MostrarTodosUsuarios = new System.Windows.Forms.Button();
            this.EliminarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU ADMIN";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.Silver;
            this.btn_Registrar.Location = new System.Drawing.Point(110, 143);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(138, 69);
            this.btn_Registrar.TabIndex = 1;
            this.btn_Registrar.Text = "Registrar Usuarios";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_MostrarTodosUsuarios
            // 
            this.btn_MostrarTodosUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_MostrarTodosUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_MostrarTodosUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MostrarTodosUsuarios.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarTodosUsuarios.ForeColor = System.Drawing.Color.Silver;
            this.btn_MostrarTodosUsuarios.Location = new System.Drawing.Point(270, 143);
            this.btn_MostrarTodosUsuarios.Name = "btn_MostrarTodosUsuarios";
            this.btn_MostrarTodosUsuarios.Size = new System.Drawing.Size(135, 69);
            this.btn_MostrarTodosUsuarios.TabIndex = 2;
            this.btn_MostrarTodosUsuarios.Text = "Mostrar todos los usuarios";
            this.btn_MostrarTodosUsuarios.UseVisualStyleBackColor = false;
            this.btn_MostrarTodosUsuarios.Click += new System.EventHandler(this.btn_MostrarTodosUsuarios_Click);
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.EliminarUsuario.FlatAppearance.BorderSize = 0;
            this.EliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarUsuario.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarUsuario.ForeColor = System.Drawing.Color.Silver;
            this.EliminarUsuario.Location = new System.Drawing.Point(427, 143);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Size = new System.Drawing.Size(135, 69);
            this.EliminarUsuario.TabIndex = 3;
            this.EliminarUsuario.Text = "Eliminar Usuario";
            this.EliminarUsuario.UseVisualStyleBackColor = false;
            this.EliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.EliminarUsuario);
            this.Controls.Add(this.btn_MostrarTodosUsuarios);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MenuAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_MostrarTodosUsuarios;
        private System.Windows.Forms.Button EliminarUsuario;
    }
}