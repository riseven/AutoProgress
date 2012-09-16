using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoProgress
{
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dgTests.Rows.Clear();

            List<Test> listaTests = DBI.Interfaz.GetListaTests();

            foreach (Test t in listaTests)
            {
                DBI.Interfaz.GetTest(t);
                List<Realizacion> listaRealizaciones = DBI.Interfaz.GetListaRealizaciones(t);

                float total = t.NumPreguntas;
                float ultimo;
                float media;
                float puntuacion;
                if (listaRealizaciones.Count > 0)
                {
                    ultimo = 1.0f - listaRealizaciones[listaRealizaciones.Count - 1].Fallos / total;

                    ultimo *= 100.0f;
                    float rmedia = 0.0f;

                    foreach (Realizacion r in listaRealizaciones)
                    {
                        rmedia += r.Fallos;
                    }
                    float ptemp = rmedia + total;
                    ptemp /= (total * (listaRealizaciones.Count + 1));
                    rmedia /= (total * listaRealizaciones.Count);
                    media = 100.0f * (1.0f - rmedia);
                    puntuacion = 100.0f * (1.0f - ptemp);
                }
                else
                {
                    ultimo = 0.0f;
                    media = 0.0f;
                    puntuacion = 0.0f;
                }


                dgTests.Rows.Add(t.Codigo, listaRealizaciones.Count, (int)ultimo, (int)media, (int)puntuacion);
            }
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            dgTests.Columns.Add("codTest", "Test");
            dgTests.Columns["codTest"].Width = 70;
            dgTests.Columns.Add("vecesRealizada", "Veces");
            dgTests.Columns["vecesRealizada"].Width = 50;
            dgTests.Columns.Add("ultimaVez", "Ultimo");
            dgTests.Columns["ultimaVez"].Width = 50;
            dgTests.Columns.Add("media", "Media");
            dgTests.Columns["media"].Width = 50;
            dgTests.Columns.Add("punt", "Puntuación");
            dgTests.Columns["punt"].Width = 50;

            ActualizarDataGrid();
        }

        private void dgTests_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = dgTests.SelectedRows;
            if (filas.Count < 1)
            {
                return;
            }

            string codTest = (string)filas[0].Cells["codTest"].Value;
            Test t = new Test();
            t.Codigo = codTest;

            RealizarTest realizarTest = new RealizarTest();
            realizarTest.TestElegido = t;
            realizarTest.ShowDialog();
            
            ActualizarDataGrid();
        }
    }
}