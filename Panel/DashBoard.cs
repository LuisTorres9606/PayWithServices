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

namespace Presentation
{
    public partial class DashBoard : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private Login_Principal Log = new Login_Principal();

        public DashBoard(UsuarioModel usuario)
        {
            InitializeComponent();

            User.Text = usuario._UserAccount.ToUpper();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bar_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Presentation"))
            {
                process.Kill();
            }
        }
    }
}
