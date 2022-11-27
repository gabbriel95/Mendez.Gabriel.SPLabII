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

        public Form1()
        {
            InitializeComponent();
            listaUtiles = new List<Utiles>();
            cartuchera = new Cartuchera<Utiles>(1,listaUtiles, 5);
        }

        private void btnAnadirUtil_Click(object sender, EventArgs e)
        {
            FrmAgregarUtil frmAgregarUtil = new FrmAgregarUtil();
            frmAgregarUtil.ShowDialog();
            cartuchera.EventoPrecio += CrearArchivo;
        }

        public void CrearArchivo(object cartuchera) 
        {
            GestorDeArchivos.CrearArchivo("tickets.txt", cartuchera.ToString(), true);
        }

    }
}
