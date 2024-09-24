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
    public partial class Burbuja : Form
    {
        // Lista de números a ordenar
        private int[] numeros = { 5, 1, 4, 2, 8};
        //private int[] numeros = { 64, 34, 25, 12, 22, 11, 90 };

        // Variables del algoritmo de burbuja
        private int i = 0;
        private int j = 0;
        private bool swapped = false;

        public Burbuja()
        {
            InitializeComponent();

            // Configurar el ListBox para que use OwnerDraw
            lstNumbers.DrawMode = DrawMode.OwnerDrawFixed;
            lstNumbers.DrawItem += lstNumbers_DrawItem;

            InicializarLista();
            ActualizarEtiquetas(); // Actualizar las etiquetas inicialmente
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

        // Evento para dibujar los elementos del ListBox
        private void lstNumbers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Obtener el valor del número en la posición actual
            int number = numeros[e.Index];

            // Configurar el color por defecto
            Color textColor = Color.Black;
            Color backgroundColor = Color.White;

            // Si el índice es i o j, cambiar el color
            if (e.Index == i)
            {
                textColor = Color.Red; // Color para el índice i
            }
            else if (e.Index == j)
            {
                textColor = Color.Blue; // Color para el índice j
            }

            // Dibujar el fondo
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            // Dibujar el texto con el color elegido
            TextRenderer.DrawText(e.Graphics, number.ToString(), e.Font, e.Bounds, textColor, TextFormatFlags.Left);

            // Dibujar el borde de selección (opcional)
            e.DrawFocusRectangle();
        }

        // Botón para avanzar a la siguiente iteración del algoritmo de burbuja
        private void btnNextIteration_Click(object sender, EventArgs e)
        {
            if (i < numeros.Length - 1)
            {
                // Si estamos al inicio de una nueva pasada
                if (j == 0)
                {
                    swapped = false;
                }

                // Comparar los elementos actuales
                if (numeros[j] > numeros[j + 1])
                {
                    // Intercambiar si es necesario
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                    swapped = true;
                }

                // Avanzar al siguiente elemento
                j++;

                // Si hemos llegado al final de la pasada
                if (j >= numeros.Length - i - 1)
                {
                    j = 0;
                    i++;

                    // Si no se realizó ningún intercambio, el arreglo está ordenado
                    if (!swapped)
                    {
                        MessageBox.Show("Ordenamiento Completo");
                        return;
                    }
                }

                // Actualizar la interfaz gráfica
                lstNumbers.Invalidate(); // Redibujar la lista
                ActualizarEtiquetas(); // Actualizar las etiquetas con los valores de i y j
            }
            else
            {
                MessageBox.Show("Ordenamiento Completo");
            }
        }

        // Método para actualizar las etiquetas con los valores de i, j y sus respectivos números
        // Método para actualizar las etiquetas con los valores de i, j, j+1 y sus respectivos números
        private void ActualizarEtiquetas()
        {
            if (i < numeros.Length)
            {
                lblIndexI.Text = $"i: {i}";
                lblValueI.Text = $"Número en i: {numeros[i]}";
            }
            else
            {
                lblIndexI.Text = $"i: {i}";
                lblValueI.Text = "Número en i: -";
            }

            if (j < numeros.Length - 1)
            {
                lblIndexJ.Text = $"j: {j}";
                lblValueJ.Text = $"Número en j: {numeros[j]}";
            }
            else
            {
                lblIndexJ.Text = $"j: {j}";
                lblValueJ.Text = "Número en j: -";
            }

            // Mostrar j + 1 si no estamos al final
            if (j + 1 < numeros.Length)
            {
                lblIndexJ1.Text = $"j+1: {j + 1}";
                lblValueJ1.Text = $"Número en j+1: {numeros[j + 1]}";
            }
            else
            {
                lblIndexJ1.Text = $"j+1: {j + 1}";
                lblValueJ1.Text = "Número en j+1: -";
            }
        }
    }
}
