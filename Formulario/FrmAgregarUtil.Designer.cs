using Entidades;

namespace Formulario
{
    partial class FrmAgregarUtil
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
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.lblUtil = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbxCaracteristica = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.radioButtonLapiz = new System.Windows.Forms.RadioButton();
            this.radioButtonGoma = new System.Windows.Forms.RadioButton();
            this.radioButtonSacapunta = new System.Windows.Forms.RadioButton();
            this.numericPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(164, 109);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(121, 23);
            this.textBoxMarca.TabIndex = 0;
            // 
            // lblUtil
            // 
            this.lblUtil.AutoSize = true;
            this.lblUtil.Location = new System.Drawing.Point(91, 57);
            this.lblUtil.Name = "lblUtil";
            this.lblUtil.Size = new System.Drawing.Size(25, 15);
            this.lblUtil.TabIndex = 1;
            this.lblUtil.Text = "Util";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(91, 112);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caracteristica";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(91, 213);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // cbxCaracteristica
            // 
            this.cbxCaracteristica.Enabled = false;
            this.cbxCaracteristica.FormattingEnabled = true;
            this.cbxCaracteristica.Location = new System.Drawing.Point(164, 162);
            this.cbxCaracteristica.Name = "cbxCaracteristica";
            this.cbxCaracteristica.Size = new System.Drawing.Size(121, 23);
            this.cbxCaracteristica.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(116, 272);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar util";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // radioButtonLapiz
            // 
            this.radioButtonLapiz.AutoSize = true;
            this.radioButtonLapiz.Location = new System.Drawing.Point(164, 57);
            this.radioButtonLapiz.Name = "radioButtonLapiz";
            this.radioButtonLapiz.Size = new System.Drawing.Size(52, 19);
            this.radioButtonLapiz.TabIndex = 12;
            this.radioButtonLapiz.TabStop = true;
            this.radioButtonLapiz.Text = "Lapiz";
            this.radioButtonLapiz.UseVisualStyleBackColor = true;
            this.radioButtonLapiz.CheckedChanged += new System.EventHandler(this.radioButtonLapiz_CheckedChanged);
            // 
            // radioButtonGoma
            // 
            this.radioButtonGoma.AutoSize = true;
            this.radioButtonGoma.Location = new System.Drawing.Point(264, 57);
            this.radioButtonGoma.Name = "radioButtonGoma";
            this.radioButtonGoma.Size = new System.Drawing.Size(57, 19);
            this.radioButtonGoma.TabIndex = 13;
            this.radioButtonGoma.TabStop = true;
            this.radioButtonGoma.Text = "Goma";
            this.radioButtonGoma.UseVisualStyleBackColor = true;
            this.radioButtonGoma.CheckedChanged += new System.EventHandler(this.radioButtonGoma_CheckedChanged);
            // 
            // radioButtonSacapunta
            // 
            this.radioButtonSacapunta.AutoSize = true;
            this.radioButtonSacapunta.Location = new System.Drawing.Point(374, 57);
            this.radioButtonSacapunta.Name = "radioButtonSacapunta";
            this.radioButtonSacapunta.Size = new System.Drawing.Size(80, 19);
            this.radioButtonSacapunta.TabIndex = 14;
            this.radioButtonSacapunta.TabStop = true;
            this.radioButtonSacapunta.Text = "Sacapunta";
            this.radioButtonSacapunta.UseVisualStyleBackColor = true;
            this.radioButtonSacapunta.CheckedChanged += new System.EventHandler(this.radioButtonSacapunta_CheckedChanged);
            // 
            // numericPrecio
            // 
            this.numericPrecio.Location = new System.Drawing.Point(164, 211);
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(120, 23);
            this.numericPrecio.TabIndex = 15;
            // 
            // FrmAgregarUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericPrecio);
            this.Controls.Add(this.radioButtonSacapunta);
            this.Controls.Add(this.radioButtonGoma);
            this.Controls.Add(this.radioButtonLapiz);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxCaracteristica);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblUtil);
            this.Controls.Add(this.textBoxMarca);
            this.Name = "FrmAgregarUtil";
            this.Text = "FrmAgregarUtil";
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label lblUtil;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbxCaracteristica;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radioButtonLapiz;
        private System.Windows.Forms.RadioButton radioButtonGoma;
        private System.Windows.Forms.RadioButton radioButtonSacapunta;
        private System.Windows.Forms.NumericUpDown numericPrecio;
    }
}