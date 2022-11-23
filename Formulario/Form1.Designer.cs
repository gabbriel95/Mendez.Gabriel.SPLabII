namespace Formulario
{
    partial class Form1
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
            this.btnAnadirUtil = new System.Windows.Forms.Button();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.btnDeserializarXML = new System.Windows.Forms.Button();
            this.btnDeserializarJson = new System.Windows.Forms.Button();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.btnSerializarJson = new System.Windows.Forms.Button();
            this.btnGuardarElementosBD = new System.Windows.Forms.Button();
            this.btnDesdeCargarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnadirUtil
            // 
            this.btnAnadirUtil.Location = new System.Drawing.Point(25, 53);
            this.btnAnadirUtil.Name = "btnAnadirUtil";
            this.btnAnadirUtil.Size = new System.Drawing.Size(116, 54);
            this.btnAnadirUtil.TabIndex = 0;
            this.btnAnadirUtil.Text = "Nuevo Util";
            this.btnAnadirUtil.UseVisualStyleBackColor = true;
            this.btnAnadirUtil.Click += new System.EventHandler(this.btnAnadirUtil_Click);
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Location = new System.Drawing.Point(181, 53);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(137, 59);
            this.btnSerializarXML.TabIndex = 2;
            this.btnSerializarXML.Text = "Serializar Lapiz XML";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            // 
            // btnDeserializarXML
            // 
            this.btnDeserializarXML.Location = new System.Drawing.Point(183, 140);
            this.btnDeserializarXML.Name = "btnDeserializarXML";
            this.btnDeserializarXML.Size = new System.Drawing.Size(135, 64);
            this.btnDeserializarXML.TabIndex = 3;
            this.btnDeserializarXML.Text = "Deserializar Lapiz XML";
            this.btnDeserializarXML.UseVisualStyleBackColor = true;
            // 
            // btnDeserializarJson
            // 
            this.btnDeserializarJson.Location = new System.Drawing.Point(352, 146);
            this.btnDeserializarJson.Name = "btnDeserializarJson";
            this.btnDeserializarJson.Size = new System.Drawing.Size(120, 52);
            this.btnDeserializarJson.TabIndex = 4;
            this.btnDeserializarJson.Text = "Deserializar Lapiz Json";
            this.btnDeserializarJson.UseVisualStyleBackColor = true;
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(501, 53);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(115, 54);
            this.btnLeerArchivo.TabIndex = 5;
            this.btnLeerArchivo.Text = "Leer archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            // 
            // btnSerializarJson
            // 
            this.btnSerializarJson.Location = new System.Drawing.Point(352, 53);
            this.btnSerializarJson.Name = "btnSerializarJson";
            this.btnSerializarJson.Size = new System.Drawing.Size(120, 55);
            this.btnSerializarJson.TabIndex = 6;
            this.btnSerializarJson.Text = "Serializar Lapiz JSON";
            this.btnSerializarJson.UseVisualStyleBackColor = true;
            // 
            // btnGuardarElementosBD
            // 
            this.btnGuardarElementosBD.Location = new System.Drawing.Point(525, 136);
            this.btnGuardarElementosBD.Name = "btnGuardarElementosBD";
            this.btnGuardarElementosBD.Size = new System.Drawing.Size(162, 72);
            this.btnGuardarElementosBD.TabIndex = 7;
            this.btnGuardarElementosBD.Text = "Guardar en BD";
            this.btnGuardarElementosBD.UseVisualStyleBackColor = true;
            // 
            // btnDesdeCargarBD
            // 
            this.btnDesdeCargarBD.Location = new System.Drawing.Point(626, 53);
            this.btnDesdeCargarBD.Name = "btnDesdeCargarBD";
            this.btnDesdeCargarBD.Size = new System.Drawing.Size(162, 70);
            this.btnDesdeCargarBD.TabIndex = 8;
            this.btnDesdeCargarBD.Text = "Cargar desdes BD";
            this.btnDesdeCargarBD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesdeCargarBD);
            this.Controls.Add(this.btnGuardarElementosBD);
            this.Controls.Add(this.btnSerializarJson);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.btnDeserializarJson);
            this.Controls.Add(this.btnDeserializarXML);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.btnAnadirUtil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadirUtil;
        private System.Windows.Forms.Button btnSerializarXML;
        private System.Windows.Forms.Button btnDeserializarXML;
        private System.Windows.Forms.Button btnDeserializarJson;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.Button btnSerializarJson;
        private System.Windows.Forms.Button btnGuardarElementosBD;
        private System.Windows.Forms.Button btnDesdeCargarBD;
    }
}
