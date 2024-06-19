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
            this.label1.Location = new System.Drawing.Point(299, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU ADMIN";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(55, 140);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(83, 47);
            this.btn_Registrar.TabIndex = 1;
            this.btn_Registrar.Text = "Registrar Usuarios";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_MostrarTodosUsuarios
            // 
            this.btn_MostrarTodosUsuarios.Location = new System.Drawing.Point(144, 140);
            this.btn_MostrarTodosUsuarios.Name = "btn_MostrarTodosUsuarios";
            this.btn_MostrarTodosUsuarios.Size = new System.Drawing.Size(80, 47);
            this.btn_MostrarTodosUsuarios.TabIndex = 2;
            this.btn_MostrarTodosUsuarios.Text = "Mostrar todos los usuarios";
            this.btn_MostrarTodosUsuarios.UseVisualStyleBackColor = true;
            this.btn_MostrarTodosUsuarios.Click += new System.EventHandler(this.btn_MostrarTodosUsuarios_Click);
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.Location = new System.Drawing.Point(230, 140);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Size = new System.Drawing.Size(80, 47);
            this.EliminarUsuario.TabIndex = 3;
            this.EliminarUsuario.Text = "Eliminar Usuario";
            this.EliminarUsuario.UseVisualStyleBackColor = true;
            this.EliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.EliminarUsuario);
            this.Controls.Add(this.btn_MostrarTodosUsuarios);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MenuAdmin";
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