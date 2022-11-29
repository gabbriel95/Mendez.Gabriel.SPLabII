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
        Cartuchera<Utiles> cartuchera;
        private int indiceFilaDataGridView = 0;
        static int eleccion = 0;

        public FrmAgregarUtil()
        {
            InitializeComponent();
            listaUtiles = new List<Utiles>();
            cartuchera = new Cartuchera<Utiles>(listaUtiles, 5);
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
            int n;

            try
            {
                switch (eleccion)
                {
                    case 1:
                        lapiz = new Lapiz(textBoxMarca.Text, numericPrecio.Value, (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                        cartuchera = cartuchera + lapiz;
                        LapizDao.InsertarUtil(lapiz);
                        listaUtiles.Add(lapiz);
                        n = dgvCartuchera.Rows.Add();
                        dgvCartuchera.Rows[n].Cells[0].Value = LapizDao.GetIdMaximo();
                        dgvCartuchera.Rows[n].Cells[1].Value = lapiz.GetType();
                        dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                        dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                        dgvCartuchera.Rows[n].Cells[4].Value = null;
                        dgvCartuchera.Rows[n].Cells[5].Value = cbxCaracteristica.Text;
                        dgvCartuchera.Rows[n].Cells[6].Value = null;
                        dgvCartuchera.Rows[n].Cells[7].Value = txtBoxIdCartuchera.Text;
               
                        break;
                    case 2:
                        goma = new Goma(textBoxMarca.Text, numericPrecio.Value, (eTamanio)Enum.Parse(typeof(eTamanio), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                        cartuchera = cartuchera + goma;
                        LapizDao.InsertarUtil(goma);
                        listaUtiles.Add(goma);

                        n = dgvCartuchera.Rows.Add();
                        dgvCartuchera.Rows[n].Cells[0].Value = goma.IdUtil;
                        dgvCartuchera.Rows[n].Cells[1].Value = goma.GetType();
                        dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                        dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                        dgvCartuchera.Rows[n].Cells[4].Value = null;
                        dgvCartuchera.Rows[n].Cells[5].Value = null;
                        dgvCartuchera.Rows[n].Cells[6].Value = cbxCaracteristica.Text;
                        dgvCartuchera.Rows[n].Cells[7].Value = txtBoxIdCartuchera.Text;

                        break;
                    case 3:
                        sacapunta = new Sacapunta(textBoxMarca.Text, numericPrecio.Value, (eTipo)Enum.Parse(typeof(eTipo), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                       
                        cartuchera = cartuchera + sacapunta;
                        LapizDao.InsertarUtil(sacapunta);
                        listaUtiles.Add(sacapunta);

                        n = dgvCartuchera.Rows.Add();
                        dgvCartuchera.Rows[n].Cells[0].Value = sacapunta.IdUtil;
                        dgvCartuchera.Rows[n].Cells[1].Value = sacapunta.GetType();
                        dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                        dgvCartuchera.Rows[n].Cells[3].Value = numericPrecio.Value;
                        dgvCartuchera.Rows[n].Cells[4].Value = cbxCaracteristica.Text;
                        dgvCartuchera.Rows[n].Cells[5].Value = null;
                        dgvCartuchera.Rows[n].Cells[6].Value = null;
                        dgvCartuchera.Rows[n].Cells[7].Value = txtBoxIdCartuchera.Text;

                        break;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LapizDao.EliminarUtil((int)dgvCartuchera.Rows[indiceFilaDataGridView].Cells[0].Value);
            dgvCartuchera.Rows.RemoveAt(indiceFilaDataGridView);
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
                dgvCartuchera.Rows[n].Cells[7].Value = listaUtiles[i].IdCartuchera;
                cartuchera.Utiles.Add(listaUtiles[i]);

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

            MessageBox.Show(cartuchera.ToString());
            //MessageBox.Show(listaUtiles[0].ToString());

        }

        private void CargarDataGrid(int iCol, int iCell, string atributo)
        {
            dgvCartuchera.Rows[iCol].Cells[iCell].Value = atributo;

        }

        private void dgvCartuchera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceFilaDataGridView = e.RowIndex;
            btnEditar.Enabled = true;
            txtBoxId.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[0].Value.ToString();
            if (indiceFilaDataGridView != -1)
            {
                if (dgvCartuchera.Rows[indiceFilaDataGridView].Cells[1].Value.ToString() == typeof(Lapiz).ToString())
                {
                    radioButtonLapiz.Checked = true;
                    cbxCaracteristica.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[5].Value.ToString();
                }
                if (dgvCartuchera.Rows[indiceFilaDataGridView].Cells[1].Value.ToString() == typeof(Goma).ToString())
                {
                    radioButtonGoma.Checked = true;
                    cbxCaracteristica.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[6].Value.ToString();

                }
                if (dgvCartuchera.Rows[indiceFilaDataGridView].Cells[1].Value.ToString() == typeof(Sacapunta).ToString())
                {
                    radioButtonSacapunta.Checked = true;
                    cbxCaracteristica.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[4].Value.ToString();

                }
            }

            textBoxMarca.Text = (string)dgvCartuchera.Rows[indiceFilaDataGridView].Cells[2].Value;
            numericPrecio.Value = (decimal)dgvCartuchera.Rows[indiceFilaDataGridView].Cells[3].Value;
            txtBoxIdCartuchera.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[7].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (radioButtonLapiz.Checked)
            {
                lapiz = new Lapiz(textBoxMarca.Text, numericPrecio.Value, (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));

                LapizDao.ModificarUtil(lapiz, int.Parse(txtBoxId.Text));
            }

            if (radioButtonGoma.Checked)
            {
                goma = new Goma(textBoxMarca.Text, numericPrecio.Value, (eTamanio)Enum.Parse(typeof(eTamanio), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                LapizDao.ModificarUtil(goma, int.Parse(txtBoxId.Text));
            }

            if (radioButtonSacapunta.Checked)
            {
                sacapunta = new Sacapunta(textBoxMarca.Text, numericPrecio.Value, (eTipo)Enum.Parse(typeof(eTipo), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                LapizDao.ModificarUtil(sacapunta, int.Parse(txtBoxId.Text));
            }


        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {

            lapiz = new Lapiz(int.Parse(txtBoxId.Text), textBoxMarca.Text, numericPrecio.Value, (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), 1);
            ISerializa.Serializar_XmlTextWritter("lapizXML", lapiz);
            btnDeserializarXML.Enabled = true;
        }

        private void btnDeserializarXML_Click(object sender, EventArgs e)
        {
            lapiz = IDeserializa.Deserializar_xmlTextReader("lapizXML");
            radioButtonLapiz.Checked = true;
            textBoxMarca.Text = lapiz.Marca;
            numericPrecio.Value = lapiz.Precio;
            cbxCaracteristica.Text = lapiz.Color.ToString();
            txtBoxId.Text = lapiz.IdUtil.ToString();

        }

        private void btnSerializarJson_Click(object sender, EventArgs e)
        {
            lapiz = new Lapiz(int.Parse(txtBoxId.Text), textBoxMarca.Text, numericPrecio.Value, (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), 1);
            ISerializa.Serializar_JSON("lapizJson", lapiz);
            btnDeserializarJson.Enabled = true;
        }

        private void btnDeserializarJson_Click(object sender, EventArgs e)
        {
            lapiz = IDeserializa.DesSerializar_JSON("lapizJson");
            radioButtonLapiz.Checked = true;
            textBoxMarca.Text = lapiz.Marca;
            numericPrecio.Value = lapiz.Precio;
            cbxCaracteristica.Text = lapiz.Color.ToString();
            txtBoxId.Text = lapiz.IdUtil.ToString();
        }


    }
}

