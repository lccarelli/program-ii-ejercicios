
namespace vista
{
    partial class FrmListaSuper
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
            this.lstObjetos = new System.Windows.Forms.ListBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstObjetos
            // 
            this.lstObjetos.FormattingEnabled = true;
            this.lstObjetos.ItemHeight = 15;
            this.lstObjetos.Location = new System.Drawing.Point(12, 12);
            this.lstObjetos.Name = "lstObjetos";
            this.lstObjetos.Size = new System.Drawing.Size(350, 424);
            this.lstObjetos.TabIndex = 0;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnAgregar.Location = new System.Drawing.Point(381, 12);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(47, 44);
            this.bttnAgregar.TabIndex = 1;
            this.bttnAgregar.Text = "+";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnEliminar.Location = new System.Drawing.Point(381, 71);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(47, 44);
            this.bttnEliminar.TabIndex = 2;
            this.bttnEliminar.Text = "-";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            // 
            // bttnModificar
            // 
            this.bttnModificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnModificar.Location = new System.Drawing.Point(381, 130);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(47, 44);
            this.bttnModificar.TabIndex = 3;
            this.bttnModificar.Text = "M";
            this.bttnModificar.UseVisualStyleBackColor = true;
            // 
            // FrmListaSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.lstObjetos);
            this.Name = "FrmListaSuper";
            this.Text = "FrmListaSuper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstObjetos;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnModificar;
    }
}