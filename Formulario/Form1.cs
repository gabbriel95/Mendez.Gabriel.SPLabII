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

namespace Formulario
{
    public partial class Form1 : Form
    {
        List<Utiles> listaUtiles;
        Cartuchera<Utiles> cartuchera;
        Cartuchera<Utiles>? cartucheraFibrones;
        List<Utiles>? listaFibrones;

        Fibron? fibron1;
        Fibron? fibron2;
        Fibron? fibron3;

        public Form1()
        {
            InitializeComponent();
            listaUtiles = new List<Utiles>();
            cartuchera = new Cartuchera<Utiles>(1, listaUtiles, 5);
        }

        private void btnAnadirUtil_Click(object sender, EventArgs e)
        {
            FrmAgregarUtil frmAgregarUtil = new FrmAgregarUtil();
            frmAgregarUtil.ShowDialog();

        }

        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxLeerArchivo.Text = GestorDeArchivos.LeerArchivo("tickets.txt");

            }
            catch (Exception)
            {
                MessageBox.Show("No existe un archivo para cargar datos");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fibron1 = new Fibron("Faber Cassel", 20, 10, Fibron.eColorFibron.Rojo, 2);
            fibron2 = new Fibron("Arti", 20, 4, Fibron.eColorFibron.Negro, 2);
            fibron3 = new Fibron("Fibron La salada", 2, 10, Fibron.eColorFibron.Verde, 2);
            fibron1.SinTintaEvento += CrearArchivoFibron;
            fibron2.SinTintaEvento += CrearArchivoFibron;
            fibron3.SinTintaEvento += CrearArchivoFibron; // usar for

            listaFibrones = new List<Utiles>();

            listaFibrones.Add(fibron1);
            listaFibrones.Add(fibron2);
            listaFibrones.Add(fibron3);

            cartucheraFibrones = new Cartuchera<Utiles>(2, listaFibrones, 5);


        }

        private void brnResaltar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cantidadR = random.Next(1, 10);
            int fibronR = random.Next(0, 2);
            Fibron fibronAux = new Fibron();


            try
            {
                if (cartucheraFibrones?.Utiles[fibronR] is Fibron)
                {
                    fibronAux = (Fibron)cartucheraFibrones.Utiles[fibronR];
                    fibronAux.Resaltar(cantidadR);
                    MessageBox.Show($"Usted uso {cantidadR} de tinta del fibron {fibronAux.Marca}, le queda {fibronAux.CantidadTinta}");

                }
            }
            catch (SinTintaException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CrearArchivoFibron(object fibron)
        {
            try
            {
                GestorDeArchivos.CrearArchivo("errors.log", fibron.ToString(), true);
                MessageBox.Show("Se creo un archivo");
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado al intentar crear el archivo .txt");
            }

        }

    }
}
