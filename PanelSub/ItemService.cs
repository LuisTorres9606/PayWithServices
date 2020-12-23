using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain.Process;
using Presentation.ReportView;

namespace Presentation.PanelSub
{
    public partial class ItemService : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );

        readonly Process Pro = new Process();
        readonly Servicio Servi;

        public ItemService(Servicio servicio)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            Servi = servicio;

            Item();
        }

        public void Item()
        {
            Id.Text = "ID: " + Servi.Id_Servicio;
            User.Text = Servi.User;
            Fecha.Text = "Publicado: " + Servi.Fecha;
            Brind.Text = Servi.NombreBrin;
            Busque.Text = Servi.NombreBusq;
            ValorPromedio.Text = "₡ " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.0}", Servi.ValorPromedio);

            if (Servi.User == UserLoginCache.UserId)
            {
                DeleteService.Visible = true;
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            InfoUser info = new InfoUser(User.Text);
            info.Show();

        }

        private void DeleteService_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el Servicio?", "Eliminar Servicio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Pro.EliminarService(Servi.Id_Servicio))
                {
                    MessageBox.Show("Servicio Eliminado");
                }
            }
        }

        private void v_Login_Click(object sender, EventArgs e)
        {
            Report ReportServicio = new Report(Servi.Id_Servicio);
            ReportServicio.Show();
        }
    }
}
