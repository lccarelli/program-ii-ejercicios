
namespace vista
{
    partial class FrmAltaModificacion
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
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.bttnConfirmar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObjeto
            // 
            this.txtObjeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObjeto.Location = new System.Drawing.Point(12, 12);
            this.txtObjeto.MaxLength = 50;
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(511, 29);
            this.txtObjeto.TabIndex = 0;
            // 
            // bttnConfirmar
            // 
            this.bttnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnConfirmar.Location = new System.Drawing.Point(385, 57);
            this.bttnConfirmar.Name = "bttnConfirmar";
            this.bttnConfirmar.Size = new System.Drawing.Size(138, 31);
            this.bttnConfirmar.TabIndex = 1;
            this.bttnConfirmar.Text = "Confirmar";
            this.bttnConfirmar.UseVisualStyleBackColor = true;
            this.bttnConfirmar.Click += new System.EventHandler(this.bttnConfirmar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnCancelar.Location = new System.Drawing.Point(221, 57);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(138, 31);
            this.bttnCancelar.TabIndex = 2;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // FrmAltaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 96);
            this.ControlBox = false;
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnConfirmar);
            this.Controls.Add(this.txtObjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAltaModificacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.Button bttnConfirmar;
        private System.Windows.Forms.Button bttnCancelar;
    }
}

