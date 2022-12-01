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
using static Entidades.Fibron;
using static Entidades.Goma;
using static Entidades.Lapiz;
using static Entidades.Sacapunta;

namespace Formulario
{
    public partial class FrmAgregarUtil : Form
    {
        Lapiz? lapiz;
        Goma? goma;
        Fibron? fibron;
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

        private void radioButtonFibron_CheckedChanged(object sender, EventArgs e)
        {
            this.cbxCaracteristica.Enabled = true;
            this.cbxCaracteristica.Items.Clear();
            this.cbxCaracteristica.Items.AddRange(new object[] {
            Entidades.Fibron.eColorFibron.Rojo,
            Entidades.Fibron.eColorFibron.Negro,
            Entidades.Fibron.eColorFibron.Azul,
            Entidades.Fibron.eColorFibron.Verde});
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
                        lapiz = new Lapiz(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                        cartuchera = cartuchera + lapiz;
                        LapizDao.InsertarUtil(lapiz);
                        listaUtiles?.Add(lapiz);
                        n = dgvCartuchera.Rows.Add();
                        dgvCartuchera.Rows[n].Cells[0].Value = LapizDao.GetIdMaximo();
                        dgvCartuchera.Rows[n].Cells[1].Value = lapiz.GetType();
                        dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                        dgvCartuchera.Rows[n].Cells[3].Value = txtPrecio.Text;
                        dgvCartuchera.Rows[n].Cells[4].Value = null;
                        dgvCartuchera.Rows[n].Cells[5].Value = cbxCaracteristica.Text;
                        dgvCartuchera.Rows[n].Cells[6].Value = null;
                        dgvCartuchera.Rows[n].Cells[7].Value = txtBoxIdCartuchera.Text;
               
                        break;
                    case 2:
                        goma = new Goma(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eTamanio)Enum.Parse(typeof(eTamanio), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                        cartuchera = cartuchera + goma;
                        LapizDao.InsertarUtil(goma);
                        listaUtiles?.Add(goma);

                        n = dgvCartuchera.Rows.Add();
                        dgvCartuchera.Rows[n].Cells[0].Value = goma.IdUtil;
                        dgvCartuchera.Rows[n].Cells[1].Value = goma.GetType();
                        dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                        dgvCartuchera.Rows[n].Cells[3].Value = txtPrecio.Text;
                        dgvCartuchera.Rows[n].Cells[4].Value = null;
                        dgvCartuchera.Rows[n].Cells[5].Value = null;
                        dgvCartuchera.Rows[n].Cells[6].Value = cbxCaracteristica.Text;
                        dgvCartuchera.Rows[n].Cells[7].Value = txtBoxIdCartuchera.Text;

                        break;
                    case 3:
                        sacapunta = new Sacapunta(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eTipo)Enum.Parse(typeof(eTipo), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                       
                        cartuchera = cartuchera + sacapunta;
                        LapizDao.InsertarUtil(sacapunta);
                        listaUtiles?.Add(sacapunta);

                        n = dgvCartuchera.Rows.Add();
                        dgvCartuchera.Rows[n].Cells[0].Value = sacapunta.IdUtil;
                        dgvCartuchera.Rows[n].Cells[1].Value = sacapunta.GetType();
                        dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                        dgvCartuchera.Rows[n].Cells[3].Value = txtPrecio.Text;
                        dgvCartuchera.Rows[n].Cells[4].Value = cbxCaracteristica.Text;
                        dgvCartuchera.Rows[n].Cells[5].Value = null;
                        dgvCartuchera.Rows[n].Cells[6].Value = null;
                        dgvCartuchera.Rows[n].Cells[7].Value = txtBoxIdCartuchera.Text;

                        break;
                    case 4:
                        fibron = new Fibron(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtCantidadTinta.Text), (eColorFibron)Enum.Parse(typeof(eColorFibron), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));


                        cartuchera = cartuchera + fibron;
                        LapizDao.InsertarUtil(fibron);
                        listaUtiles?.Add(fibron);


                        n = dgvCartuchera.Rows.Add();
                        dgvCartuchera.Rows[n].Cells[0].Value = fibron.IdUtil;
                        dgvCartuchera.Rows[n].Cells[1].Value = fibron.GetType();
                        dgvCartuchera.Rows[n].Cells[2].Value = textBoxMarca.Text;
                        dgvCartuchera.Rows[n].Cells[3].Value = txtPrecio.Text;
                        dgvCartuchera.Rows[n].Cells[4].Value = cbxCaracteristica.Text;
                        dgvCartuchera.Rows[n].Cells[5].Value = null;
                        dgvCartuchera.Rows[n].Cells[6].Value = null;
                        dgvCartuchera.Rows[n].Cells[7].Value = txtBoxIdCartuchera.Text;
                        dgvCartuchera.Rows[n].Cells[8].Value = txtCantidadTinta.Text;
                        break;
                }   
                if(cartuchera.PrecioTotal > 500) 
                {
                    cartuchera.EventoPrecio += CrearArchivo;
                    cartuchera.Ejecutar();
                }
        
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                LapizDao.EliminarUtil((int)dgvCartuchera.Rows[indiceFilaDataGridView].Cells[0].Value);
                dgvCartuchera.Rows.RemoveAt(indiceFilaDataGridView);
            }
            catch (Exception) 
            {
                MessageBox.Show("Error, al intentar eliminar util");
            }
      
        }

        private void FrmAgregarUtil_Load(object sender, EventArgs e)
        {
        
            try
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
                    if (listaUtiles[i].GetType() == typeof(Goma))
                    {
                        Fibron fibra = (Fibron)listaUtiles[i];
                        this.CargarDataGrid(n, 5, fibra.Color.ToString());
                        dgvCartuchera.Rows[n].Cells[8].Value = fibra.CantidadTinta;
                    }
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Error, al intentar cargar utiles desde la base de datos");
            }

        }

        private void CargarDataGrid(int iCol, int iCell, string atributo)
        {
            dgvCartuchera.Rows[iCol].Cells[iCell].Value = atributo;

        }

        /// <summary>
        /// Vuelve a insertar los datos de un util del DataGridView en los diferentes campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (dgvCartuchera.Rows[indiceFilaDataGridView].Cells[1].Value.ToString() == typeof(Fibron).ToString()) 
                {
                    radioButtonFibron.Checked = true;
                    cbxCaracteristica.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[5].Value.ToString();
                    txtCantidadTinta.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[8].Value.ToString();
                }
            }

            textBoxMarca.Text = (string)dgvCartuchera.Rows[indiceFilaDataGridView].Cells[2].Value;
            txtPrecio.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[3].Value.ToString();
            txtBoxIdCartuchera.Text = dgvCartuchera.Rows[indiceFilaDataGridView].Cells[7].Value.ToString();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonLapiz.Checked)
                {
                    lapiz = new Lapiz(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));

                    LapizDao.ModificarUtil(lapiz, int.Parse(txtBoxId.Text));
                }

                if (radioButtonGoma.Checked)
                {
                    goma = new Goma(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eTamanio)Enum.Parse(typeof(eTamanio), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                    LapizDao.ModificarUtil(goma, int.Parse(txtBoxId.Text));
                }

                if (radioButtonSacapunta.Checked)
                {
                    sacapunta = new Sacapunta(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eTipo)Enum.Parse(typeof(eTipo), cbxCaracteristica.Text), Convert.ToInt32(txtBoxIdCartuchera.Text));
                    LapizDao.ModificarUtil(sacapunta, int.Parse(txtBoxId.Text));
                }
                if (radioButtonFibron.Checked) 
                {
                    fibron = new Fibron(textBoxMarca.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtCantidadTinta.Text), (eColorFibron)Enum.Parse(typeof(eColorFibron), cbxCaracteristica.Text));
                    LapizDao.ModificarUtil(fibron, int.Parse(txtBoxId.Text));
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           


        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                lapiz = new Lapiz(int.Parse(txtBoxId.Text), textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), 1);
                ISerializa<Lapiz, Fibron>.Serializar_XmlTextWritter("lapizXML", lapiz);
                btnDeserializarXML.Enabled = true;
            }
            catch (Exception) 
            {
                MessageBox.Show("El objecto a serializar debe ser un LAPIZ");
            }
      
        }

        private void btnDeserializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                lapiz = IDeserializa<Lapiz,Fibron>.Deserializar_xmlTextReader("lapizXML");
                radioButtonLapiz.Checked = true;
                textBoxMarca.Text = lapiz.Marca;
                txtPrecio.Text = lapiz.Precio.ToString();
                cbxCaracteristica.Text = lapiz.Color.ToString();
                txtBoxId.Text = lapiz.IdUtil.ToString();
            }
            catch 
            {
                MessageBox.Show("No se encontro un archivo para deserializar");
            }

        }

        private void btnSerializarJson_Click(object sender, EventArgs e)
        {
            try
            {
                lapiz = new Lapiz(int.Parse(txtBoxId.Text), textBoxMarca.Text, decimal.Parse(txtPrecio.Text), (eColor)Enum.Parse(typeof(eColor), cbxCaracteristica.Text), 1);
                ISerializa<Lapiz, Fibron>.Serializar_JSON("lapizJson", lapiz);
                btnDeserializarJson.Enabled = true;
            }
            catch (Exception) 
            {
                MessageBox.Show("El objecto a serializar debe ser un LAPIZ");
            }
         
        }

        private void btnDeserializarJson_Click(object sender, EventArgs e)
        {
            try
            {
                lapiz = IDeserializa<Lapiz, Fibron>.DesSerializar_JSON("lapizJson");
                radioButtonLapiz.Checked = true;
                textBoxMarca.Text = lapiz.Marca;
                txtPrecio.Text = lapiz.Precio.ToString();
                cbxCaracteristica.Text = lapiz.Color.ToString();
                txtBoxId.Text = lapiz.IdUtil.ToString();

            }
            catch (Exception) 
            {
                MessageBox.Show("No se encontro un archivo para deserializar");
            }
         
        }

        public void CrearArchivo(object cartuchera, EventArgs e)
        {
            try 
            {
                GestorDeArchivos.CrearArchivo("tickets.txt", cartuchera.ToString(), true);
                MessageBox.Show("Se creo un archivo");
            }
            catch(Exception) 
            {
                MessageBox.Show("Error inesperado al intentar crear el archivo .txt");
            }
           
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                lblErrorFloat.Visible = true;
                e.Handled = true;
            }
            else
            {
                lblErrorFloat.Visible = false;
            }
        }
        //Preguntar como se podria simplificar este codigo repetido
        private void txtBoxIdCartuchera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                lblErrorIdCartuchera.Visible = true;
                e.Handled = true;
            }
            else
            {
                lblErrorIdCartuchera.Visible = false;
            }
        }

      
    }
}

