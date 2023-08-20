using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class practica2 : Form
    {
        public practica2()
        {
            InitializeComponent();
        }
        private void practica2_Load(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double montoInicial = double.Parse(txtMontoInicial.Text);
                double porcentaje = double.Parse(txtPorcentaje.Text);

                double interesCompuesto = montoInicial + (montoInicial * (porcentaje / 100));

                lblResultado.Text = $"El interés compuesto es: {interesCompuesto:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
