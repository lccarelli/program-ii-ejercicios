namespace Vista
{
    partial class FrmAtencion
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
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.rtbInfoMedico = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(681, 71);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(94, 29);
            this.btnAtender.TabIndex = 0;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(681, 121);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 20;
            this.lstMedicos.Location = new System.Drawing.Point(24, 71);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(295, 204);
            this.lstMedicos.TabIndex = 2;
            this.lstMedicos.SelectedIndexChanged += new System.EventHandler(this.lstMedicos_SelectedIndexChanged);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 20;
            this.lstPacientes.Location = new System.Drawing.Point(339, 71);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(320, 204);
            this.lstPacientes.TabIndex = 3;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(24, 37);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(65, 20);
            this.lblMedicos.TabIndex = 4;
            this.lblMedicos.Text = "Medicos";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(339, 37);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(70, 20);
            this.lblPacientes.TabIndex = 5;
            this.lblPacientes.Text = "Pacientes";
            // 
            // rtbInfoMedico
            // 
            this.rtbInfoMedico.Location = new System.Drawing.Point(24, 338);
            this.rtbInfoMedico.Name = "rtbInfoMedico";
            this.rtbInfoMedico.Size = new System.Drawing.Size(635, 257);
            this.rtbInfoMedico.TabIndex = 6;
            this.rtbInfoMedico.Text = "";
            // 
            // FrmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 642);
            this.Controls.Add(this.rtbInfoMedico);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtender);
            this.Name = "FrmAtencion";
            this.Text = "PP.Laura.Carelli.2.C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAtencion_FormClosing);
            this.Load += new System.EventHandler(this.FrmAtencion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.RichTextBox rtbInfoMedico;
    }
}
