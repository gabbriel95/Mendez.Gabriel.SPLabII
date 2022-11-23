using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Entidades.Lapiz;

namespace Formulario
{
    public partial class FrmAgregarUtil : Form
    {
        Lapiz? lapiz;
        Goma? goma;
        Sacapunta? sacapunta;

        static int eleccion =0;
        public FrmAgregarUtil()
        {
            InitializeComponent();

        }

        private void radioButtonLapiz_CheckedChanged(object sender, EventArgs e)
        {
            this.cbxCaracteristica.Enabled = true;
            this.cbxCaracteristica.Items.Clear();
            this.cbxCaracteristica.Items.AddRange(new object[] {
            Entidades.Lapiz.eColor.Rojo,
            Entidades.Lapiz.eColor.Negro,
            Entidades.Lapiz.eColor.Azul,
            Entidades.Lapiz.eColor.Verde});
            eleccion = 1;
        }

        private void radioButtonGoma_CheckedChanged(object sender, EventArgs e)
        {
            this.cbxCaracteristica.Enabled = true;
            this.cbxCaracteristica.Items.Clear();
            this.cbxCaracteristica.Items.AddRange(new object[] {
            Entidades.Goma.eTamanio.Chico,
            Entidades.Goma.eTamanio.Mediana,
            Entidades.Goma.eTamanio.Grande});
            eleccion = 2;
        }

        private void radioButtonSacapunta_CheckedChanged(object sender, EventArgs e)
        {
            this.cbxCaracteristica.Enabled = true;
            this.cbxCaracteristica.Items.Clear();
            this.cbxCaracteristica.Items.AddRange(new object[] {
            Entidades.Sacapunta.eTipo.metal,
            Entidades.Sacapunta.eTipo.plastico,});
            eleccion = 3;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dgvCartuchera.Rows.Add();

            switch (eleccion) 
            {
                //Preguntar como se pasa un enum en un objecto, preguntar el tema del ID
                case 1:
                    lapiz = new Lapiz((int)numericUpDownId.Value, textBoxMarca.ToString(), (decimal)numericPrecio.TextAlign, eColor.Rojo);
                    dgvCartuchera.Rows[n].Cells[0].Value = numericUpDownId.Value;
                    dgvCartuchera.Rows[n].Cells[1].Value = "Lapiz" ;
                    dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                    dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                    dgvCartuchera.Rows[n].Cells[4].Value = null;
                    dgvCartuchera.Rows[n].Cells[5].Value = Lapiz.eColor.Rojo;
                    dgvCartuchera.Rows[n].Cells[6].Value = null;
                    LapizDao.InsertarLapiz(lapiz);
                    break;
                case 2:
                    goma = new Goma((int)numericUpDownId.Value, textBoxMarca.ToString(), (decimal)numericPrecio.TextAlign, Goma.eTamanio.Mediana);
                    dgvCartuchera.Rows[n].Cells[0].Value = numericUpDownId.Value;
                    dgvCartuchera.Rows[n].Cells[1].Value = "Goma";
                    dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                    dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                    dgvCartuchera.Rows[n].Cells[4].Value = null;
                    dgvCartuchera.Rows[n].Cells[5].Value = null;
                    dgvCartuchera.Rows[n].Cells[6].Value = Goma.eTamanio.Mediana;
                    GomaDao.InsertarGoma(goma);
                    break;
                case 3:
                    sacapunta = new Sacapunta((int)numericUpDownId.Value, textBoxMarca.ToString(), (decimal)numericPrecio.TextAlign, Sacapunta.eTipo.metal);
                    dgvCartuchera.Rows[n].Cells[0].Value = numericUpDownId.Value;
                    dgvCartuchera.Rows[n].Cells[1].Value = "Sacapunta";
                    dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                    dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                    dgvCartuchera.Rows[n].Cells[4].Value = Sacapunta.eTipo.metal;
                    dgvCartuchera.Rows[n].Cells[5].Value = null;
                    dgvCartuchera.Rows[n].Cells[6].Value = null;
                    SacapuntaDao.InsertarSacapuntas(sacapunta);
                    break;
            }

  


        }



    }
}
