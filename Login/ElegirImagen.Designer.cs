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
            this.panelVentana = new System.Windows.Forms.Panel();
            this.panelMinimizar = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.panelCerrar = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.labelVentana = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.listaViewImagenes = new System.Windows.Forms.ListView();
            this.panelVentana.SuspendLayout();
            this.panelMinimizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.panelCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVentana
            // 
            this.panelVentana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVentana.Controls.Add(this.labelVentana);
            this.panelVentana.Controls.Add(this.panelMinimizar);
            this.panelVentana.Controls.Add(this.panelCerrar);
            this.panelVentana.Location = new System.Drawing.Point(1, 0);
            this.panelVentana.Name = "panelVentana";
            this.panelVentana.Size = new System.Drawing.Size(769, 30);
            this.panelVentana.TabIndex = 14;
            this.panelVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseDown);
            this.panelVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseMove);
            this.panelVentana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseUp);
            // 
            // panelMinimizar
            // 
            this.panelMinimizar.Controls.Add(this.pbMinimizar);
            this.panelMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMinimizar.Location = new System.Drawing.Point(699, -1);
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
            this.panelCerrar.Location = new System.Drawing.Point(738, -1);
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
            this.labelVentana.Location = new System.Drawing.Point(341, 10);
            this.labelVentana.Name = "labelVentana";
            this.labelVentana.Size = new System.Drawing.Size(87, 11);
            this.labelVentana.TabIndex = 13;
            this.labelVentana.Text = "ELEGIR IMAGEN";
            this.labelVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseDown);
            this.labelVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseMove);
            this.labelVentana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVentana_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.botonRegistrar);
            this.panel1.Controls.Add(this.listaViewImagenes);
            this.panel1.Location = new System.Drawing.Point(-2, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 347);
            this.panel1.TabIndex = 15;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.botonRegistrar.FlatAppearance.BorderSize = 0;
            this.botonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.botonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrar.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.botonRegistrar.ForeColor = System.Drawing.Color.White;
            this.botonRegistrar.Location = new System.Drawing.Point(550, 278);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(163, 44);
            this.botonRegistrar.TabIndex = 15;
            this.botonRegistrar.Text = "Seleccionar";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.boton_ImagenClick);
            // 
            // listaViewImagenes
            // 
            this.listaViewImagenes.HideSelection = false;
            this.listaViewImagenes.Location = new System.Drawing.Point(57, 26);
            this.listaViewImagenes.Name = "listaViewImagenes";
            this.listaViewImagenes.Size = new System.Drawing.Size(656, 241);
            this.listaViewImagenes.TabIndex = 14;
            this.listaViewImagenes.UseCompatibleStateImageBehavior = false;
            // 
            // ElegirImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(771, 375);
            this.Controls.Add(this.panelVentana);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(771, 375);
            this.MinimumSize = new System.Drawing.Size(771, 375);
            this.Name = "ElegirImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Imagen";
            this.panelVentana.ResumeLayout(false);
            this.panelVentana.PerformLayout();
            this.panelMinimizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.panelCerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelVentana;
        private System.Windows.Forms.Panel panelMinimizar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Panel panelCerrar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label labelVentana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.ListView listaViewImagenes;
    }
}