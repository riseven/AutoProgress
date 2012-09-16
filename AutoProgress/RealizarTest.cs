using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoProgress
{
    public partial class RealizarTest : Form
    {
        private Test testElegido;
        private Plantilla plantilla;
        private int preguntaActual;
        private int fallos;


        public RealizarTest()
        {
            InitializeComponent();
        }

        public Test TestElegido
        {
            get
            {
                return testElegido;
            }
            set
            {
                testElegido = value;
            }
        }

        private void RealizarTest_Load(object sender, EventArgs e)
        {
            // Primero obtengo toda la información del test
            DBI.Interfaz.GetTest(testElegido);
            plantilla = new Plantilla();
            plantilla.Codigo = testElegido.CodPlantilla;
            DBI.Interfaz.GetPlantilla(plantilla);
            fallos = 0;
            MostrarPregunta(1);
        }

        private void MostrarPregunta(int num)
        {
            if (num > testElegido.NumPreguntas)
            {
                float porcentaje = ((testElegido.NumPreguntas - fallos)*1.0f / testElegido.NumPreguntas) * 100.0f;
                MessageBox.Show("TEST FINALIZADO. Porcentaje de aciertos: " + ((int)porcentaje).ToString());

                // Ahora generamos una realizacion
                Realizacion r = new Realizacion();
                r.CodTest = testElegido.Codigo;
                r.Num = DBI.Interfaz.GetListaRealizaciones(testElegido).Count + 1;
                r.Fecha = DateTime.Now;
                r.Fallos = fallos;
                DBI.Interfaz.AddRealizacion(r);

                Close();
            }

            preguntaActual = num;
            lbPregunta.Text = "Pregunta " + preguntaActual.ToString();
        }

        private void ResponderPregunta(string respuesta)
        {
            // Obtengo la respuesta esperada
            string esperado = plantilla.GetRespuesta(preguntaActual).Trim();

            Pregunta p = testElegido.GetPregunta(preguntaActual);
            Pregunta orig_p = (Pregunta)p.Clone();

            p.VecesContestada++;

            if (respuesta != esperado)
            {
                MessageBox.Show("La respuesta correcta era: " + esperado);
                fallos++;
                p.VecesFallada++;
            }

            DBI.Interfaz.UpdatePregunta(p, orig_p);
            MostrarPregunta(preguntaActual + 1);
        }

        private void btA_Click(object sender, EventArgs e)
        {
            ResponderPregunta("A");
        }

        private void btB_Click(object sender, EventArgs e)
        {
            ResponderPregunta("B");
        }

        private void btC_Click(object sender, EventArgs e)
        {
            ResponderPregunta("C");
        }

        private void btD_Click(object sender, EventArgs e)
        {
            ResponderPregunta("D");
        }
    }
}