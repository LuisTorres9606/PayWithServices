using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ReportView
{
    public partial class Report : Form
    {
        string id;
        public Report(string Id_Servicio)
        {
            InitializeComponent();
            id = Id_Servicio;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ServicioCD.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.ServicioCD.DataTable1,id);

            this.reportViewer1.RefreshReport();
        }
    }
}
