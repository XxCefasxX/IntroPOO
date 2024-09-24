using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento
{
    public partial class Seleccion : Form
    {

        // Lista de números a ordenar
        private int[] numeros = { 64, 25, 12, 22, 11 };
        //private int[] numeros = { 64, 34, 25, 12, 22, 11, 90 };

        // Variables del algoritmo
        private int i = 0;
        private int j = 0;
        private int minIdx = 0;

        public Seleccion()
        {
            InitializeComponent();
            InicializarLista();
        }

        // Inicializa la lista de números en el ListBox
        private void InicializarLista()
        {
            lstNumbers.Items.Clear();
            foreach (int num in numeros)
            {
                lstNumbers.Items.Add(num);
            }
        }

        // Botón para avanzar a la siguiente iteración
        private void btnNextIteration_Click(object sender, EventArgs e)
        {
            if (i < numeros.Length - 1)
            {
                // Algoritmo de selección: Paso 1 - Encontrar el valor mínimo
                if (j == 0)
                {
                    minIdx = i;
                }

                // Compara y encuentra el índice del menor valor
                if (numeros[j] < numeros[minIdx])
                {
                    minIdx = j;
                }

                j++;

                // Si ha terminado la comparación de una iteración
                if (j >= numeros.Length)
                {
                    // Intercambia el elemento más pequeño encontrado con el elemento en i
                    int temp = numeros[minIdx];
                    numeros[minIdx] = numeros[i];
                    numeros[i] = temp;

                    // Avanza al siguiente índice i
                    i++;
                    j = i;
                }

                // Actualiza la interfaz gráfica
                ActualizarInterfaz();
            }
            else
            {
                MessageBox.Show("Ordenamiento Completo");
            }
        }

        // Actualiza la lista y las etiquetas de las variables
        private void ActualizarInterfaz()
        {
            InicializarLista();

            // Mostrar el valor de las variables
            lblI.Text = $"i: {i}";
            lblJ.Text = $"j: {j}";
            lblMinIdx.Text = $"minIdx: {minIdx}";

            // Mostrar los valores correspondientes a i, j, y minIdx
            if (i < numeros.Length)
            {
                lblValueI.Text = $"Valor en i: {numeros[i]}";
            }

            if (j < numeros.Length)
            {
                lblValueJ.Text = $"Valor en j: {numeros[j]}";
            }

            if (minIdx < numeros.Length)
            {
                lblValueMinIdx.Text = $"Valor en minIdx: {numeros[minIdx]}";
            }
        }
    }
}
