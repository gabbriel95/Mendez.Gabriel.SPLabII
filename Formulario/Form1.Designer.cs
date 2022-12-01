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
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.richTextBoxLeerArchivo = new System.Windows.Forms.RichTextBox();
            this.brnResaltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnadirUtil
            // 
            this.btnAnadirUtil.Location = new System.Drawing.Point(213, 111);
            this.btnAnadirUtil.Name = "btnAnadirUtil";
            this.btnAnadirUtil.Size = new System.Drawing.Size(116, 54);
            this.btnAnadirUtil.TabIndex = 0;
            this.btnAnadirUtil.Text = "Nuevo Util";
            this.btnAnadirUtil.UseVisualStyleBackColor = true;
            this.btnAnadirUtil.Click += new System.EventHandler(this.btnAnadirUtil_Click);
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(358, 111);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(115, 54);
            this.btnLeerArchivo.TabIndex = 5;
            this.btnLeerArchivo.Text = "Leer archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
            // 
            // richTextBoxLeerArchivo
            // 
            this.richTextBoxLeerArchivo.Location = new System.Drawing.Point(99, 171);
            this.richTextBoxLeerArchivo.Name = "richTextBoxLeerArchivo";
            this.richTextBoxLeerArchivo.Size = new System.Drawing.Size(603, 189);
            this.richTextBoxLeerArchivo.TabIndex = 6;
            this.richTextBoxLeerArchivo.Text = "";
            // 
            // brnResaltar
            // 
            this.brnResaltar.Location = new System.Drawing.Point(506, 111);
            this.brnResaltar.Name = "brnResaltar";
            this.brnResaltar.Size = new System.Drawing.Size(115, 54);
            this.brnResaltar.TabIndex = 7;
            this.brnResaltar.Text = "Resaltar";
            this.brnResaltar.UseVisualStyleBackColor = true;
            this.brnResaltar.Click += new System.EventHandler(this.brnResaltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brnResaltar);
            this.Controls.Add(this.richTextBoxLeerArchivo);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.btnAnadirUtil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadirUtil;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.RichTextBox richTextBoxLeerArchivo;
        private System.Windows.Forms.Button brnResaltar;
    }
}
