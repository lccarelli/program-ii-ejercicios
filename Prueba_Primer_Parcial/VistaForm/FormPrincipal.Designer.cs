namespace VistaForm
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnVerDatos = new System.Windows.Forms.Button();
            this.rtbDetalle = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bttnVerDatos
            // 
            this.bttnVerDatos.Location = new System.Drawing.Point(630, 22);
            this.bttnVerDatos.Name = "bttnVerDatos";
            this.bttnVerDatos.Size = new System.Drawing.Size(148, 50);
            this.bttnVerDatos.TabIndex = 0;
            this.bttnVerDatos.Text = "Ver Datos";
            this.bttnVerDatos.UseVisualStyleBackColor = true;
            this.bttnVerDatos.Click += new System.EventHandler(this.bttnVerDatos_Click);
            // 
            // rtbDetalle
            // 
            this.rtbDetalle.Location = new System.Drawing.Point(28, 91);
            this.rtbDetalle.Name = "rtbDetalle";
            this.rtbDetalle.Size = new System.Drawing.Size(750, 319);
            this.rtbDetalle.TabIndex = 1;
            this.rtbDetalle.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDetalle);
            this.Controls.Add(this.bttnVerDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Jardin -> Carelli.Laura.2C";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnVerDatos;
        private RichTextBox rtbDetalle;
    }
}