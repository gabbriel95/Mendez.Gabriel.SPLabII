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
            this.SuspendLayout();
            // 
            // btnAnadirUtil
            // 
            this.btnAnadirUtil.Location = new System.Drawing.Point(198, 73);
            this.btnAnadirUtil.Name = "btnAnadirUtil";
            this.btnAnadirUtil.Size = new System.Drawing.Size(116, 54);
            this.btnAnadirUtil.TabIndex = 0;
            this.btnAnadirUtil.Text = "Nuevo Util";
            this.btnAnadirUtil.UseVisualStyleBackColor = true;
            this.btnAnadirUtil.Click += new System.EventHandler(this.btnAnadirUtil_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.btnAnadirUtil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadirUtil;
        private System.Windows.Forms.Button btnLeerArchivo;
    }
}
