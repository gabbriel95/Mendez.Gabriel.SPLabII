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
            this.dgvCartuchera = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCartuchera = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.btnDeserializarXML = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartuchera)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(114, 75);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(121, 23);
            this.textBoxMarca.TabIndex = 0;
            // 
            // lblUtil
            // 
            this.lblUtil.AutoSize = true;
            this.lblUtil.Location = new System.Drawing.Point(70, 27);
            this.lblUtil.Name = "lblUtil";
            this.lblUtil.Size = new System.Drawing.Size(25, 15);
            this.lblUtil.TabIndex = 1;
            this.lblUtil.Text = "Util";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(55, 78);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caracteristica";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(55, 125);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // cbxCaracteristica
            // 
            this.cbxCaracteristica.Enabled = false;
            this.cbxCaracteristica.FormattingEnabled = true;
            this.cbxCaracteristica.Location = new System.Drawing.Point(324, 75);
            this.cbxCaracteristica.Name = "cbxCaracteristica";
            this.cbxCaracteristica.Size = new System.Drawing.Size(121, 23);
            this.cbxCaracteristica.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(515, 52);
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
            this.radioButtonLapiz.Location = new System.Drawing.Point(142, 27);
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
            this.radioButtonGoma.Location = new System.Drawing.Point(240, 27);
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
            this.radioButtonSacapunta.Location = new System.Drawing.Point(326, 27);
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
            this.numericPrecio.Location = new System.Drawing.Point(115, 123);
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(120, 23);
            this.numericPrecio.TabIndex = 15;
            // 
            // dgvCartuchera
            // 
            this.dgvCartuchera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartuchera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Util,
            this.Marca,
            this.Precio,
            this.Tipo,
            this.Color,
            this.Tamanio});
            this.dgvCartuchera.Location = new System.Drawing.Point(31, 227);
            this.dgvCartuchera.Name = "dgvCartuchera";
            this.dgvCartuchera.RowTemplate.Height = 25;
            this.dgvCartuchera.Size = new System.Drawing.Size(742, 211);
            this.dgvCartuchera.TabIndex = 18;
            this.dgvCartuchera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartuchera_CellContentClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // Util
            // 
            this.Util.Frozen = true;
            this.Util.HeaderText = "Util";
            this.Util.Name = "Util";
            // 
            // Marca
            // 
            this.Marca.Frozen = true;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo Sacapuntas";
            this.Tipo.Name = "Tipo";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color Lapiz";
            this.Color.Name = "Color";
            // 
            // Tamanio
            // 
            this.Tamanio.HeaderText = "Tamanio Goma";
            this.Tamanio.Name = "Tamanio";
            // 
            // lblCartuchera
            // 
            this.lblCartuchera.AutoSize = true;
            this.lblCartuchera.Location = new System.Drawing.Point(21, 186);
            this.lblCartuchera.Name = "lblCartuchera";
            this.lblCartuchera.Size = new System.Drawing.Size(123, 15);
            this.lblCartuchera.TabIndex = 19;
            this.lblCartuchera.Text = "Items de la cartuchera";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(515, 83);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(155, 23);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar util";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(515, 112);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Modificar util";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(265, 122);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(48, 23);
            this.txtBoxId.TabIndex = 22;
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Enabled = false;
            this.btnSerializarXML.Location = new System.Drawing.Point(515, 151);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(155, 23);
            this.btnSerializarXML.TabIndex = 23;
            this.btnSerializarXML.Text = "Serializar Lapiz XML";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // btnDeserializarXML
            // 
            this.btnDeserializarXML.Enabled = false;
            this.btnDeserializarXML.Location = new System.Drawing.Point(515, 180);
            this.btnDeserializarXML.Name = "btnDeserializarXML";
            this.btnDeserializarXML.Size = new System.Drawing.Size(155, 23);
            this.btnDeserializarXML.TabIndex = 24;
            this.btnDeserializarXML.Text = "Deserializar Lapiz XML";
            this.btnDeserializarXML.UseVisualStyleBackColor = true;
            this.btnDeserializarXML.Click += new System.EventHandler(this.btnDeserializarXML_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(241, 125);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "ID";
            // 
            // FrmAgregarUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDeserializarXML);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblCartuchera);
            this.Controls.Add(this.dgvCartuchera);
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
            this.Load += new System.EventHandler(this.FrmAgregarUtil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartuchera)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCartuchera;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanio;
        private System.Windows.Forms.Label lblCartuchera;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button btnSerializarXML;
        private System.Windows.Forms.Button btnDeserializarXML;
        private System.Windows.Forms.Label lblId;
    }
}