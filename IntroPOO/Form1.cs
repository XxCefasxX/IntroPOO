using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroPOO
{
    public partial class Form1 : Form
    {
        //realizar las operaciones matematcas resta, multiplicacion y divicion
        /*crear otra clase en la que realicen las sentencias de control y que 
        hagan uso de los operadores relacionales y logicos*/
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            Operaciones op=new Operaciones();
            int resultado = op.Suma(num1, num2);
            
        }

       
    }
    class Operaciones
    {
        public int Suma(int a, int b)
        {
            int toalsuma = a + b;
            return toalsuma;
        }
       
    }


}
