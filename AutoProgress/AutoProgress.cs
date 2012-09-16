using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoProgress
{
    public partial class AutoProgressForm : Form
    {
        public AutoProgressForm()
        {
            InitializeComponent();
        }

        private void btIntroducirPlantilla_Click(object sender, EventArgs e)
        {
            NuevaPlantilla nuevaPlantilla = new NuevaPlantilla();
            nuevaPlantilla.ShowDialog();
        }

        private void btNuevoTest_Click(object sender, EventArgs e)
        {
            NuevoTest nuevoTest = new NuevoTest();
            nuevoTest.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests();
            tests.ShowDialog();
        }

        private void btPreguntas_Click(object sender, EventArgs e)
        {
            Preguntas preguntas = new Preguntas();
            preguntas.ShowDialog();
        }
    }
}