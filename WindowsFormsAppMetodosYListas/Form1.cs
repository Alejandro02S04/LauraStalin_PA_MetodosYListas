using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMetodosYListas
{
    public partial class Form1: Form
    {
        // Lista para almacenar elementos 

        private List<string> elementos = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        // Método para agregar elementos 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = txtElemento.Text;

            // Verifica si el texto no está vacío y solo contiene letras
            if (!string.IsNullOrWhiteSpace(nuevoElemento) && nuevoElemento.All(char.IsLetter))
            {
                elementos.Add(nuevoElemento);
                ActualizarLista();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingresa solo letras (sin números ni caracteres especiales).");
            }
        }

        // Método para eliminar elementos seleccionados 

        private void btnEliminar_Click(object sender, EventArgs e)

        {

            if (lstElementos.SelectedItem != null)

            {

                elementos.Remove(lstElementos.SelectedItem.ToString());

                ActualizarLista();

            }

            else

            {

                MessageBox.Show("Selecciona un elemento para eliminar.");

            }

        }



        // Método para actualizar ListBox 

        private void ActualizarLista()

        {

            lstElementos.DataSource = null;

            lstElementos.DataSource = elementos;

        }
    }
}
