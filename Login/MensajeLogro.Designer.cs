namespace Login
{
    partial class MensajeLogro
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
            this.panelLogros = new System.Windows.Forms.Panel();
            this.labelTextoLogro = new System.Windows.Forms.Label();
            this.panelLogros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogros
            // 
            this.panelLogros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.panelLogros.Controls.Add(this.labelTextoLogro);
            this.panelLogros.Location = new System.Drawing.Point(0, 0);
            this.panelLogros.Name = "panelLogros";
            this.panelLogros.Size = new System.Drawing.Size(312, 100);
            this.panelLogros.TabIndex = 18;
            // 
            // labelTextoLogro
            // 
            this.labelTextoLogro.AutoSize = true;
            this.labelTextoLogro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoLogro.ForeColor = System.Drawing.Color.White;
            this.labelTextoLogro.Location = new System.Drawing.Point(3, 25);
            this.labelTextoLogro.Name = "labelTextoLogro";
            this.labelTextoLogro.Size = new System.Drawing.Size(41, 13);
            this.labelTextoLogro.TabIndex = 0;
            this.labelTextoLogro.Text = "label1";
            // 
            // MensajeLogro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 99);
            this.Controls.Add(this.panelLogros);
            this.Name = "MensajeLogro";
            this.Text = "MensajeLogro";
            this.panelLogros.ResumeLayout(false);
            this.panelLogros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogros;
        private System.Windows.Forms.Label labelTextoLogro;
    }
}