using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Common.Cache;
using Domain.Process;

namespace Presentation.PanelSub
{
    public partial class InfoUser : Form
    {
        Process Pro = new Process();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public InfoUser(string user)
        {
            InitializeComponent();
            CargarInformacion(user);
        }

        private void CargarInformacion(string User)
        {

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, PictureUser.Width - 3, PictureUser.Height - 3);
            Region rg = new Region(gp);
            PictureUser.Region = rg;

            if (Pro.UserConsult(User))
            {
                PictureUser.Image = Consulta.Picture.Image;
                Nombre.Text = Consulta.Nombre + " " + Consulta.Apellidos;
                Cedula.Text = Consulta.Cedula;
                Correo.Text = Consulta.Email;
                Carrera.Text = Consulta.AreaLab;
                Telefono.Text = Consulta.Telefono;
            }
            else
                MessageBox.Show("Error al cargar el usuario");

            if (Consulta.Sexo != "Femenino")
                PortadaM.Visible = true;
            else
                PortadaF.Visible = true;
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_Botones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
