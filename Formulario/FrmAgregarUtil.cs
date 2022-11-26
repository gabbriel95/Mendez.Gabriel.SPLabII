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
using static Entidades.Goma;
using static Entidades.Lapiz;
using static Entidades.Sacapunta;

namespace Formulario
{
    public partial class FrmAgregarUtil : Form
    {
        Lapiz? lapiz;
        Goma? goma;
        Sacapunta? sacapunta;

        List<Utiles>? listaUtiles;
 

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
                case 1:
                    lapiz = new Lapiz((int)numericUpDownId.Value, textBoxMarca.Text, numericPrecio.Value, (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), 1);
                    dgvCartuchera.Rows[n].Cells[0].Value = numericUpDownId.Value;
                    dgvCartuchera.Rows[n].Cells[1].Value = "Lapiz" ;
                    dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                    dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                    dgvCartuchera.Rows[n].Cells[4].Value = null;
                    dgvCartuchera.Rows[n].Cells[5].Value = cbxCaracteristica.Text;
                    dgvCartuchera.Rows[n].Cells[6].Value = null;
                    LapizDao.InsertarUtil(lapiz);
                    break;
                case 2:
                    goma = new Goma((int)numericUpDownId.Value, textBoxMarca.Text, numericPrecio.Value, (eTamanio)Enum.Parse(typeof(eTamanio), cbxCaracteristica.Text), 1);
                    dgvCartuchera.Rows[n].Cells[0].Value = numericUpDownId.Value;
                    dgvCartuchera.Rows[n].Cells[1].Value = "Goma";
                    dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                    dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                    dgvCartuchera.Rows[n].Cells[4].Value = null;
                    dgvCartuchera.Rows[n].Cells[5].Value = null;
                    dgvCartuchera.Rows[n].Cells[6].Value = cbxCaracteristica.Text;
                    LapizDao.InsertarUtil(goma);
         
                    break;
                case 3:
                    sacapunta = new Sacapunta((int)numericUpDownId.Value, textBoxMarca.Text, numericPrecio.Value, (eTipo)Enum.Parse(typeof(eTipo), cbxCaracteristica.Text), 1);
                    dgvCartuchera.Rows[n].Cells[0].Value = numericUpDownId.Value;
                    dgvCartuchera.Rows[n].Cells[1].Value = "Sacapunta";
                    dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                    dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                    dgvCartuchera.Rows[n].Cells[4].Value = cbxCaracteristica.Text;
                    dgvCartuchera.Rows[n].Cells[5].Value = null;
                    dgvCartuchera.Rows[n].Cells[6].Value = null;
                    LapizDao.InsertarUtil(sacapunta);
                    break;
            }

  


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LapizDao.EliminarUtil(1);
        }

        private void FrmAgregarUtil_Load(object sender, EventArgs e)
        {
            listaUtiles = LapizDao.LeerUtiles();

            for (int i = 0; i < listaUtiles.Count; i++) 
            {
                int n = dgvCartuchera.Rows.Add();
                dgvCartuchera.Rows[n].Cells[0].Value = listaUtiles[i].IdUtil;
                dgvCartuchera.Rows[n].Cells[1].Value = listaUtiles[i].GetType();
                dgvCartuchera.Rows[n].Cells[2].Value = listaUtiles[i].Marca;
                dgvCartuchera.Rows[n].Cells[3].Value = listaUtiles[i].Precio;

                if (listaUtiles[i].GetType() == typeof(Sacapunta))
                {
                    Sacapunta sacapunta = (Sacapunta)listaUtiles[i];
                    this.CargarDataGrid(n, 4, sacapunta.Tipo.ToString());
                }
                if (listaUtiles[i].GetType() == typeof(Lapiz))
                {
                    Lapiz lapiz = (Lapiz)listaUtiles[i];
                    this.CargarDataGrid(n, 5, lapiz.Color.ToString());
                }
                if (listaUtiles[i].GetType() == typeof(Goma))
                {
                    Goma goma = (Goma)listaUtiles[i];
                    this.CargarDataGrid(n, 6, goma.Tamanio.ToString());
                }
            } 
            
        }

        private void CargarDataGrid(int iCol, int iCell, string atributo)
        {
            dgvCartuchera.Rows[iCol].Cells[iCell].Value = atributo;

        }
    }
}
