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
            this.components = new System.ComponentModel.Container();
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
            this.dgvCartuchera = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCartuchera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.btnDeserializarXML = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSerializarJson = new System.Windows.Forms.Button();
            this.btnDeserializarJson = new System.Windows.Forms.Button();
            this.lblIdCartuchera = new System.Windows.Forms.Label();
            this.txtBoxIdCartuchera = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblErrorFloat = new System.Windows.Forms.Label();
            this.lblErrorIdCartuchera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartuchera)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(78, 37);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(121, 23);
            this.textBoxMarca.TabIndex = 0;
            // 
            // lblUtil
            // 
            this.lblUtil.AutoSize = true;
            this.lblUtil.Location = new System.Drawing.Point(12, 9);
            this.lblUtil.Name = "lblUtil";
            this.lblUtil.Size = new System.Drawing.Size(25, 15);
            this.lblUtil.TabIndex = 1;
            this.lblUtil.Text = "Util";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 45);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caracteristica";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 107);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // cbxCaracteristica
            // 
            this.cbxCaracteristica.Enabled = false;
            this.cbxCaracteristica.FormattingEnabled = true;
            this.cbxCaracteristica.Location = new System.Drawing.Point(96, 66);
            this.cbxCaracteristica.Name = "cbxCaracteristica";
            this.cbxCaracteristica.Size = new System.Drawing.Size(121, 23);
            this.cbxCaracteristica.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(284, 21);
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
            this.radioButtonLapiz.Location = new System.Drawing.Point(55, 5);
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
            this.radioButtonGoma.Location = new System.Drawing.Point(115, 5);
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
            this.radioButtonSacapunta.Location = new System.Drawing.Point(179, 5);
            this.radioButtonSacapunta.Name = "radioButtonSacapunta";
            this.radioButtonSacapunta.Size = new System.Drawing.Size(80, 19);
            this.radioButtonSacapunta.TabIndex = 14;
            this.radioButtonSacapunta.TabStop = true;
            this.radioButtonSacapunta.Text = "Sacapunta";
            this.radioButtonSacapunta.UseVisualStyleBackColor = true;
            this.radioButtonSacapunta.CheckedChanged += new System.EventHandler(this.radioButtonSacapunta_CheckedChanged);
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
            this.Tamanio,
            this.idCartuchera});
            this.dgvCartuchera.Location = new System.Drawing.Point(0, 223);
            this.dgvCartuchera.Name = "dgvCartuchera";
            this.dgvCartuchera.RowTemplate.Height = 25;
            this.dgvCartuchera.Size = new System.Drawing.Size(796, 211);
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
            // idCartuchera
            // 
            this.idCartuchera.HeaderText = "ID cartuchera";
            this.idCartuchera.Name = "idCartuchera";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(284, 50);
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
            this.btnEditar.Location = new System.Drawing.Point(284, 79);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Modificar util";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(42, 130);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(48, 23);
            this.txtBoxId.TabIndex = 22;
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Location = new System.Drawing.Point(284, 108);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(155, 23);
            this.btnSerializarXML.TabIndex = 23;
            this.btnSerializarXML.Text = "Serializar Lapiz XML";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // btnDeserializarXML
            // 
            this.btnDeserializarXML.Location = new System.Drawing.Point(284, 137);
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
            this.lblId.Location = new System.Drawing.Point(12, 138);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "ID";
            // 
            // btnSerializarJson
            // 
            this.btnSerializarJson.Location = new System.Drawing.Point(284, 166);
            this.btnSerializarJson.Name = "btnSerializarJson";
            this.btnSerializarJson.Size = new System.Drawing.Size(155, 23);
            this.btnSerializarJson.TabIndex = 26;
            this.btnSerializarJson.Text = "Serializar Lapiz JSON";
            this.btnSerializarJson.UseVisualStyleBackColor = true;
            this.btnSerializarJson.Click += new System.EventHandler(this.btnSerializarJson_Click);
            // 
            // btnDeserializarJson
            // 
            this.btnDeserializarJson.Location = new System.Drawing.Point(284, 195);
            this.btnDeserializarJson.Name = "btnDeserializarJson";
            this.btnDeserializarJson.Size = new System.Drawing.Size(155, 22);
            this.btnDeserializarJson.TabIndex = 27;
            this.btnDeserializarJson.Text = "Deserializar Lapiz Json";
            this.btnDeserializarJson.UseVisualStyleBackColor = true;
            this.btnDeserializarJson.Click += new System.EventHandler(this.btnDeserializarJson_Click);
            // 
            // lblIdCartuchera
            // 
            this.lblIdCartuchera.AutoSize = true;
            this.lblIdCartuchera.Location = new System.Drawing.Point(12, 174);
            this.lblIdCartuchera.Name = "lblIdCartuchera";
            this.lblIdCartuchera.Size = new System.Drawing.Size(77, 15);
            this.lblIdCartuchera.TabIndex = 28;
            this.lblIdCartuchera.Text = "ID cartuchera";
            // 
            // txtBoxIdCartuchera
            // 
            this.txtBoxIdCartuchera.Location = new System.Drawing.Point(96, 167);
            this.txtBoxIdCartuchera.Name = "txtBoxIdCartuchera";
            this.txtBoxIdCartuchera.Size = new System.Drawing.Size(48, 23);
            this.txtBoxIdCartuchera.TabIndex = 29;
            this.txtBoxIdCartuchera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxIdCartuchera_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(55, 101);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 31;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblErrorFloat
            // 
            this.lblErrorFloat.AutoSize = true;
            this.lblErrorFloat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFloat.Location = new System.Drawing.Point(167, 106);
            this.lblErrorFloat.Name = "lblErrorFloat";
            this.lblErrorFloat.Size = new System.Drawing.Size(80, 15);
            this.lblErrorFloat.TabIndex = 33;
            this.lblErrorFloat.Text = "Solo numeros";
            this.lblErrorFloat.Visible = false;
            // 
            // lblErrorIdCartuchera
            // 
            this.lblErrorIdCartuchera.AutoSize = true;
            this.lblErrorIdCartuchera.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIdCartuchera.Location = new System.Drawing.Point(150, 174);
            this.lblErrorIdCartuchera.Name = "lblErrorIdCartuchera";
            this.lblErrorIdCartuchera.Size = new System.Drawing.Size(80, 15);
            this.lblErrorIdCartuchera.TabIndex = 34;
            this.lblErrorIdCartuchera.Text = "Solo numeros";
            this.lblErrorIdCartuchera.Visible = false;
            // 
            // FrmAgregarUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorIdCartuchera);
            this.Controls.Add(this.lblErrorFloat);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtBoxIdCartuchera);
            this.Controls.Add(this.lblIdCartuchera);
            this.Controls.Add(this.btnDeserializarJson);
            this.Controls.Add(this.btnSerializarJson);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDeserializarXML);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvCartuchera);
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
        private System.Windows.Forms.DataGridView dgvCartuchera;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanio;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button btnSerializarXML;
        private System.Windows.Forms.Button btnDeserializarXML;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSerializarJson;
        private System.Windows.Forms.Button btnDeserializarJson;
        private System.Windows.Forms.Label lblIdCartuchera;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCartuchera;
        private System.Windows.Forms.TextBox txtBoxIdCartuchera;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblErrorFloat;
        private System.Windows.Forms.Label lblErrorIdCartuchera;
    }
}