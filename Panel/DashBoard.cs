using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Common.Cache;
using System.IO;
using System.Threading;

namespace Presentation
{
    public partial class DashBoard : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public DashBoard()
        {
            InitializeComponent();

            User.Text = UserLoginCache.UserId.ToString();
            Thread Session = new Thread(new ThreadStart(Registro));
            Session.Start();

           

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bar_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void Registro()
        {
            string DataTime = DateTime.Now.ToString("d:MMMM:yyyy");
            string DataHour = DateTime.Now.ToString("HH:mm:ss");

            try
            {
                List<string> Usuario = new List<string>() { "Nombre:" + UserLoginCache.Nombre, "Apellidos: " + UserLoginCache.Apellidos, "Cedula: " + UserLoginCache.Cedula, "Día de Inicio Sesión " + DataTime, "Hora de Inicio Sesión " + DataHour };
                using (StreamWriter Write = new StreamWriter("Registro" + UserLoginCache.UserId + ".txt"))
                {
                    foreach (string read in Usuario)
                    {
                        Write.WriteLine(read);
                    }

                    Write.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing Finally Block");

            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Principal _Principal = new Login_Principal();
            _Principal.Show();
        }
    }
}
