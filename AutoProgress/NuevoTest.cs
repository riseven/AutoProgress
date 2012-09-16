using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoProgress
{
    public partial class NuevoTest : Form
    {
        public NuevoTest()
        {
            InitializeComponent();
        }

        private void NuevoTest_Load(object sender, EventArgs e)
        {
            List<Plantilla> plantillas = DBI.Interfaz.GetListaPlantillas();

            foreach (Plantilla p in plantillas)
            {
                cbPlantilla.Items.Add(p.Codigo);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Test t = new Test();

                t.Codigo = tbCodigo.Text;
                t.CodPlantilla = cbPlantilla.SelectedItem.ToString();

                int numPreguntas = int.Parse(tbNumPreguntas.Text);

                for (int i = 1; i <= numPreguntas; i++)
                {
                    Pregunta p = new Pregunta();
                    p.CodTest = t.Codigo;
                    p.Num = i;
                    p.VecesContestada = 0;
                    p.VecesFallada = 0;

                    t.SetPregunta(i, p);
                }

                DBI.Interfaz.AddTest(t);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}