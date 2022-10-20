using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Promedio
{
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

            //busca la mayor nota

            decimal[] notas = { nota1, nota2, nota3, nota4 };
            decimal mayor = notas.Max();

            //calculo promedio

            decimal promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio >= 9)
            {
                MessageBox.Show("Mayor nota: " + mayor + " Promedio: " + promedio + " Excelente");
            }
            else if (promedio >= 7 & promedio < 9)
            {
                MessageBox.Show("Mayor nota: " + mayor + " Promedio: " + promedio + " Muy Bien");
            }
            else if (promedio < 7 & promedio >= 4)
            {
                MessageBox.Show("Mayor nota: " + mayor + " Promedio: " + promedio + " Regular");
            }
            else
            {
                MessageBox.Show("Mayor nota: " + mayor + " Promedio: " + promedio + " En proceso de aprendizaje");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
        }
    }
}
