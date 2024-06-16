namespace Login
{
    partial class Aplicacion
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
            this.entradaCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelTemperatura = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "El Tiempo";
            // 
            // entradaCiudad
            // 
            this.entradaCiudad.Location = new System.Drawing.Point(309, 221);
            this.entradaCiudad.Name = "entradaCiudad";
            this.entradaCiudad.Size = new System.Drawing.Size(171, 20);
            this.entradaCiudad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la ciudad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelTemperatura
            // 
            this.LabelTemperatura.AutoSize = true;
            this.LabelTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTemperatura.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTemperatura.Location = new System.Drawing.Point(0, 0);
            this.LabelTemperatura.Name = "LabelTemperatura";
            this.LabelTemperatura.Size = new System.Drawing.Size(65, 20);
            this.LabelTemperatura.TabIndex = 4;
            this.LabelTemperatura.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelTemperatura);
            this.panel1.Location = new System.Drawing.Point(248, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 46);
            this.panel1.TabIndex = 5;
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entradaCiudad);
            this.Controls.Add(this.label1);
            this.Name = "Aplicacion";
            this.Text = "Applicacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entradaCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelTemperatura;
        private System.Windows.Forms.Panel panel1;
    }
}