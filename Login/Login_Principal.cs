using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class Login_Principal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Login_Principal()
        {
            InitializeComponent();
            //OpenChildForm(new Login());
            //v_Login.BackColor = Color.FromArgb(39, 56, 61);

        }

        //Método del ChildForm Login-SignIn
        private new Form ActiveForm = null;

        private bool OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

                ActiveForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                ChildForm.Parent = this;
                v_Panel_ChildForm.Controls.Add(ChildForm);
                v_Panel_ChildForm.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();

            return true;
        }
      
        private void v_Login_Click(object sender, EventArgs e)
        {
            if (OpenChildForm(new Login()))
            {
                v_Login.BackColor = Color.FromArgb(39, 56, 61);
                v_SignIn.BackColor = Color.Transparent;
            }
        }

        private void v_SignIn_Click(object sender, EventArgs e)
        {
            if (OpenChildForm(new SignIn()))
            {
                v_SignIn.BackColor = Color.FromArgb(39, 56, 61);
                v_Login.BackColor = Color.Transparent;
            }            
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel_Imagen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_Botones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void v_Panel_ChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
