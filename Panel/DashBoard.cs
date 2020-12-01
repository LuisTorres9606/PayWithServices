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
using Presentation.PanelSub;

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

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Principal _Principal = new Login_Principal();
            _Principal.Show();
        }

        //Método del ChildForm Login-SignIn
        private new Form ActiveForm = null;
        private bool OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            AddOwnedForm(ChildForm); /////<------Aquí
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(ChildForm);
            ChildPanel.Tag = ChildForm;

            ChildForm.BringToFront();

            ChildForm.Show();

            return true;
        }

        private void Works_Click(object sender, EventArgs e)
        {
            if (OpenChildForm(new ChildWorks()))
            {
                Works.BackColor = Color.FromArgb(19, 166, 212);
            }
        }

        private void AddWorks_Click(object sender, EventArgs e)
        {

        }
    }
}
