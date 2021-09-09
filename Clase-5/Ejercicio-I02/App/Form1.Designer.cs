
namespace App
{
    partial class frmResgistro
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gruopBoxGenero = new System.Windows.Forms.GroupBox();
            this.rdBtnNoBinario = new System.Windows.Forms.RadioButton();
            this.rdBtnMaculino = new System.Windows.Forms.RadioButton();
            this.rdBtnFemenino = new System.Windows.Forms.RadioButton();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.chckBoxJavascript = new System.Windows.Forms.CheckBox();
            this.chckBoxCMasMas = new System.Windows.Forms.CheckBox();
            this.chckBoxCSharp = new System.Windows.Forms.CheckBox();
            this.listPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBoxDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gruopBoxGenero.SuspendLayout();
            this.groupBoxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatosUsuario
            // 
            this.groupBoxDatosUsuario.Controls.Add(this.nupEdad);
            this.groupBoxDatosUsuario.Controls.Add(this.txtBoxDireccion);
            this.groupBoxDatosUsuario.Controls.Add(this.txtBoxNombre);
            this.groupBoxDatosUsuario.Controls.Add(this.lblEdad);
            this.groupBoxDatosUsuario.Controls.Add(this.lblDireccion);
            this.groupBoxDatosUsuario.Controls.Add(this.lblNombre);
            this.groupBoxDatosUsuario.Location = new System.Drawing.Point(33, 31);
            this.groupBoxDatosUsuario.Name = "groupBoxDatosUsuario";
            this.groupBoxDatosUsuario.Size = new System.Drawing.Size(262, 145);
            this.groupBoxDatosUsuario.TabIndex = 1;
            this.groupBoxDatosUsuario.TabStop = false;
            this.groupBoxDatosUsuario.Text = "Detalles del Usuario";
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(101, 101);
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(137, 23);
            this.nupEdad.TabIndex = 5;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(101, 63);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(137, 23);
            this.txtBoxDireccion.TabIndex = 4;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(101, 30);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(137, 23);
            this.txtBoxNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 101);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 66);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gruopBoxGenero
            // 
            this.gruopBoxGenero.Controls.Add(this.rdBtnNoBinario);
            this.gruopBoxGenero.Controls.Add(this.rdBtnMaculino);
            this.gruopBoxGenero.Controls.Add(this.rdBtnFemenino);
            this.gruopBoxGenero.Location = new System.Drawing.Point(337, 31);
            this.gruopBoxGenero.Name = "gruopBoxGenero";
            this.gruopBoxGenero.Size = new System.Drawing.Size(137, 145);
            this.gruopBoxGenero.TabIndex = 2;
            this.gruopBoxGenero.TabStop = false;
            this.gruopBoxGenero.Text = "Genero";
            // 
            // rdBtnNoBinario
            // 
            this.rdBtnNoBinario.AutoSize = true;
            this.rdBtnNoBinario.Location = new System.Drawing.Point(21, 97);
            this.rdBtnNoBinario.Name = "rdBtnNoBinario";
            this.rdBtnNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdBtnNoBinario.TabIndex = 8;
            this.rdBtnNoBinario.TabStop = true;
            this.rdBtnNoBinario.Text = "No Binario";
            this.rdBtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdBtnMaculino
            // 
            this.rdBtnMaculino.AutoSize = true;
            this.rdBtnMaculino.Location = new System.Drawing.Point(21, 62);
            this.rdBtnMaculino.Name = "rdBtnMaculino";
            this.rdBtnMaculino.Size = new System.Drawing.Size(80, 19);
            this.rdBtnMaculino.TabIndex = 7;
            this.rdBtnMaculino.TabStop = true;
            this.rdBtnMaculino.Text = "Masculino";
            this.rdBtnMaculino.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemenino
            // 
            this.rdBtnFemenino.AutoSize = true;
            this.rdBtnFemenino.Location = new System.Drawing.Point(21, 29);
            this.rdBtnFemenino.Name = "rdBtnFemenino";
            this.rdBtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdBtnFemenino.TabIndex = 6;
            this.rdBtnFemenino.TabStop = true;
            this.rdBtnFemenino.Text = "Femenino";
            this.rdBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.chckBoxJavascript);
            this.groupBoxCursos.Controls.Add(this.chckBoxCMasMas);
            this.groupBoxCursos.Controls.Add(this.chckBoxCSharp);
            this.groupBoxCursos.Location = new System.Drawing.Point(337, 210);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(137, 145);
            this.groupBoxCursos.TabIndex = 3;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Cursos";
            // 
            // chckBoxJavascript
            // 
            this.chckBoxJavascript.AutoSize = true;
            this.chckBoxJavascript.Location = new System.Drawing.Point(21, 109);
            this.chckBoxJavascript.Name = "chckBoxJavascript";
            this.chckBoxJavascript.Size = new System.Drawing.Size(77, 19);
            this.chckBoxJavascript.TabIndex = 2;
            this.chckBoxJavascript.Text = "Javascript";
            this.chckBoxJavascript.UseVisualStyleBackColor = true;
            // 
            // chckBoxCMasMas
            // 
            this.chckBoxCMasMas.AutoSize = true;
            this.chckBoxCMasMas.Location = new System.Drawing.Point(21, 73);
            this.chckBoxCMasMas.Name = "chckBoxCMasMas";
            this.chckBoxCMasMas.Size = new System.Drawing.Size(56, 19);
            this.chckBoxCMasMas.TabIndex = 1;
            this.chckBoxCMasMas.Text = "C + +";
            this.chckBoxCMasMas.UseVisualStyleBackColor = true;
            // 
            // chckBoxCSharp
            // 
            this.chckBoxCSharp.AutoSize = true;
            this.chckBoxCSharp.Location = new System.Drawing.Point(21, 37);
            this.chckBoxCSharp.Name = "chckBoxCSharp";
            this.chckBoxCSharp.Size = new System.Drawing.Size(41, 19);
            this.chckBoxCSharp.TabIndex = 0;
            this.chckBoxCSharp.Text = "C#";
            this.chckBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // listPaises
            // 
            this.listPaises.FormattingEnabled = true;
            this.listPaises.ItemHeight = 15;
            this.listPaises.Location = new System.Drawing.Point(33, 225);
            this.listPaises.Name = "listPaises";
            this.listPaises.Size = new System.Drawing.Size(262, 169);
            this.listPaises.TabIndex = 4;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(39, 197);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(337, 371);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(135, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngrarClick);
            // 
            // frmResgistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 417);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.listPaises);
            this.Controls.Add(this.groupBoxCursos);
            this.Controls.Add(this.gruopBoxGenero);
            this.Controls.Add(this.groupBoxDatosUsuario);
            this.Name = "frmResgistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmResgistro_Load);
            this.groupBoxDatosUsuario.ResumeLayout(false);
            this.groupBoxDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gruopBoxGenero.ResumeLayout(false);
            this.gruopBoxGenero.PerformLayout();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxDatosUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox gruopBoxGenero;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.ListBox listPaises;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.RadioButton rdBtnNoBinario;
        private System.Windows.Forms.RadioButton rdBtnMaculino;
        private System.Windows.Forms.RadioButton rdBtnFemenino;
        private System.Windows.Forms.CheckBox chckBoxJavascript;
        private System.Windows.Forms.CheckBox chckBoxCMasMas;
        private System.Windows.Forms.CheckBox chckBoxCSharp;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.NumericUpDown nupEdad;
    }
}

