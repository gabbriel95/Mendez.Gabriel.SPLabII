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
    public partial class FrmAgregarUtil : Form
    {

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
        }

        private void radioButtonGoma_CheckedChanged(object sender, EventArgs e)
        {
            this.cbxCaracteristica.Enabled = true;
            this.cbxCaracteristica.Items.Clear();
            this.cbxCaracteristica.Items.AddRange(new object[] {
            Entidades.Goma.eTamanio.Chico,
            Entidades.Goma.eTamanio.Mediana,
            Entidades.Goma.eTamanio.Grande});
        }

        private void radioButtonSacapunta_CheckedChanged(object sender, EventArgs e)
        {
            this.cbxCaracteristica.Enabled = true;
            this.cbxCaracteristica.Items.Clear();
            this.cbxCaracteristica.Items.AddRange(new object[] {
            Entidades.Sacapunta.eTipo.metal,
            Entidades.Sacapunta.eTipo.plastico,});
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch
        }
    }
}
