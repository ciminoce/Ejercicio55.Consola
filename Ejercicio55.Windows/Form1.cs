using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio55.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtNroIngresado.Clear();
            txtLimiteInferior.Clear();
            txtLimiteSuperior.Clear();
            txtNroIngresado.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var nroIngresado = int.Parse(txtNroIngresado.Text);
                var menor = int.Parse(txtLimiteInferior.Text);
                var mayor = int.Parse(txtLimiteSuperior.Text);

                MostrarMultiplos(nroIngresado,menor, mayor);
            }
        }

        private void MostrarMultiplos(int nroIngresado, int menor, int mayor)
        {
            LimpiarListBox();
            for (int contador = menor; contador <= mayor; contador++)
            {
                if (EsMultiplo(contador, nroIngresado))
                {
                    lstMultiplos.Items.Add(contador);
                }
            }
        }
        private bool EsMultiplo(int contador, int nroIngresado)
        {
            return contador % nroIngresado == 0;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtNroIngresado.Text, out int numero))
            {
                esValido = false;
                errorProvider1.SetError(txtNroIngresado, "Nro. mal ingresado");
            }
            if (!int.TryParse(txtLimiteInferior.Text, out int menor))
            {
                esValido = false;
                errorProvider1.SetError(txtLimiteInferior, "Nro. mal ingresado");
            }
            if (!int.TryParse(txtLimiteSuperior.Text, out int mayor))
            {
                esValido = false;
                errorProvider1.SetError(txtLimiteSuperior, "Nro. mal ingresado");
            }
            else if (menor>mayor)
            {
                esValido = false;
                errorProvider1.SetError(txtNroIngresado, "Limite menor mayor al limite mayor");
            }
            return esValido;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            InicializarControles();
            LimpiarListBox();
        }

        private void LimpiarListBox()
        {
            lstMultiplos.Items.Clear();
        }
    }
}
