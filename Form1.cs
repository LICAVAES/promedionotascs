using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_2_promedio_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(TxtNota1.Text);
            double nota2 = double.Parse(TxtNota2.Text);
            double nota3 = double.Parse(TxtNota3.Text);
            double promedio = 0;

            promedio = ((nota1 + nota2 + nota3) / 3);

            LblPromedio.Text = Convert.ToString(promedio);

            if (promedio >= 3.5)
            {
                MessageBox.Show("APROBO LA MATERIA",
                "Mensaje del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("REPROBO LA MATERIA",
                    "Mensaje del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNota1.Text = String.Empty;
            TxtNota2.Text = String.Empty;
            TxtNota3.Text = String.Empty;
            LblPromedio.Text = "0";
            TxtNota1.Focus();
        }
    }
}
