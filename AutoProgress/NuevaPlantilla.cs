using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoProgress
{
    public partial class NuevaPlantilla : Form
    {
        public NuevaPlantilla()
        {
            InitializeComponent();
        }

        private void NuevaPlantilla_Load(object sender, EventArgs e)
        {
            dgNuevaPlantilla.Columns.Add("num", "Num");
            dgNuevaPlantilla.Columns["num"].Width = 67;
            dgNuevaPlantilla.Columns["num"].ReadOnly = true;
            dgNuevaPlantilla.Columns.Add("respuesta", "Respuesta");
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Plantilla p = new Plantilla();
                p.Codigo = tbCodigo.Text;
                foreach (DataGridViewRow d in dgNuevaPlantilla.Rows)
                {
                    if (d.Cells["num"].Value != null && d.Cells["respuesta"].Value != null)
                    {
                        p.SetRespuesta((int)d.Cells["num"].Value, (string)d.Cells["respuesta"].Value);
                    }
                }

                DBI.Interfaz.AddPlantilla(p);                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgNuevaPlantilla_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["num"].Value = e.Row.Index+1;
        }

        private void dgNuevaPlantilla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgNuevaPlantilla.Rows[e.RowIndex].Cells["num"].Value = e.RowIndex+1;
        }

    }
}