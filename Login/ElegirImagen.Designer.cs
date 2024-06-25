namespace Login
{
    partial class ElegirImagen
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
            this.listaViewImagenes = new System.Windows.Forms.ListView();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaViewImagenes
            // 
            this.listaViewImagenes.HideSelection = false;
            this.listaViewImagenes.Location = new System.Drawing.Point(47, 28);
            this.listaViewImagenes.Name = "listaViewImagenes";
            this.listaViewImagenes.Size = new System.Drawing.Size(656, 241);
            this.listaViewImagenes.TabIndex = 0;
            this.listaViewImagenes.UseCompatibleStateImageBehavior = false;
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
            this.botonRegistrar.Location = new System.Drawing.Point(564, 312);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(139, 44);
            this.botonRegistrar.TabIndex = 13;
            this.botonRegistrar.Text = "Elegir";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // ElegirImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(755, 386);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.listaViewImagenes);
            this.Name = "ElegirImagen";
            this.Text = "Elegir Imagen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listaViewImagenes;
        private System.Windows.Forms.Button botonRegistrar;
    }
}