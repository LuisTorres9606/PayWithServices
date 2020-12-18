﻿using System;
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
using Domain.Process;

namespace Presentation
{
    public partial class DashBoard : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        Domain.Process.Process Pro = new Domain.Process.Process();


        public DashBoard()
        {
            InitializeComponent();

            if (OpenChildForm(new Service())){Service.BackColor = System.Drawing.Color.FromArgb(31, 82, 107);AddService.BackColor = System.Drawing.Color.Transparent;}
            
            User.Text = UserLoginCache.UserId.ToString();
            PictureUser.Image = UserLoginCache.Picture.Image;
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

        private void Service_Click(object sender, EventArgs e)
        {
            if (OpenChildForm(new Service()))
            {
                Service.BackColor = Color.FromArgb(31, 82, 107);
                AddService.BackColor = Color.Transparent;
            }
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            if(OpenChildForm(new AddService()))
            {
                AddService.BackColor = Color.FromArgb(31, 82, 107);
                Service.BackColor = Color.Transparent;
            }
        }

        private void PictureUser_Click(object sender, EventArgs e)
        {
            string User = UserLoginCache.UserId;
            try
            {
                openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    PictureUser.Load(this.openFileDialog1.FileName);

                    Pro.UpdateProfilePicture(User, PictureUser);

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("No se pudo cargar la imagen de perfil");
            }
        }
    }
}
