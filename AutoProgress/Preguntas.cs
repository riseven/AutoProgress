using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoProgress
{
    public partial class Preguntas : Form
    {
        public Preguntas()
        {
            InitializeComponent();
        }

        private void Preguntas_Load(object sender, EventArgs e)
        {
            // Aqui creamos las columnas del datagrid
            dgPreguntas.Columns.Add("test", "Test");
            dgPreguntas.Columns["test"].Width = 70;
            dgPreguntas.Columns.Add("num", "Num");
            dgPreguntas.Columns["num"].Width = 50;
            dgPreguntas.Columns.Add("media", "Media");
            dgPreguntas.Columns["media"].Width = 50;
            dgPreguntas.Columns.Add("punt", "Puntuación");
            dgPreguntas.Columns["punt"].Width = 50;

            // Y mostramos los datos aqui ya que no se van a modificar
            List<Pregunta> lista = DBI.Interfaz.GetListaPreguntas();

            foreach (Pregunta p in lista)
            {
                string test = p.CodTest;
                int num = p.Num;
                int media, puntuacion;
                if (p.VecesContestada > 0)
                {
                    media = (int)((1.0f - (p.VecesFallada * 1.0f / p.VecesContestada)) * 100.0f);
                    puntuacion = (int)((1.0f - ((p.VecesFallada + 1) * 1.0f / (p.VecesContestada + 1))) * 100.0f);
                }
                else
                {
                    media = 0;
                    puntuacion = 0;
                }

                dgPreguntas.Rows.Add(test, num, media, puntuacion);
            }
        }
    }
}