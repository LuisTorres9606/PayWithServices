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
using Domain.Process;

namespace Presentation
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void v_Show_Click(object sender, EventArgs e)
        {
            R_Password.PasswordChar = '\0';

            v_Show.Enabled = false;
            v_Show.Visible = false;

            v_Hide.Enabled = true;
            v_Hide.Visible = true;
        }

        private void v_Hide_Click(object sender, EventArgs e)
        {
            R_Password.PasswordChar = '*';

            v_Show.Enabled = true;
            v_Show.Visible = true;

            v_Hide.Enabled = false;
            v_Hide.Visible = false;
        }

        private void Show_C_Click(object sender, EventArgs e)
        {
            R_PasswordCon.PasswordChar = '\0';

            Show_C.Enabled = false;
            Show_C.Visible = false;

            Hide_C.Enabled = true;
            Hide_C.Visible = true;
        }

        private void Hide_C_Click(object sender, EventArgs e)
        {
            R_PasswordCon.PasswordChar = '*';

            Show_C.Enabled = true;
            Show_C.Visible = true;

            Hide_C.Enabled = false;
            Hide_C.Visible = false;
        }

        private void v_Email_Enter(object sender, EventArgs e)
        {
            if (R_UserAccount.Text == "Email")
            {
                R_UserAccount.Text = "";
            }
        }

        private void v_Email_Leave(object sender, EventArgs e)
        {
            if (R_UserAccount.Text == "")
            {
                R_UserAccount.Text = "Email";
            }
        }

        private void v_Password_Enter(object sender, EventArgs e)
        {
            if (R_Password.Text == "Password")
            {
                R_Password.Text = "";
                R_Password.PasswordChar = '*';
            }
        }

        private void v_Password_Leave(object sender, EventArgs e)
        {
            if(R_Password.Text == "")
            {
                R_Password.Text = "Password";
                R_Password.PasswordChar = '\0';
            }
        }

        private void Con_Password_Enter(object sender, EventArgs e)
        {
            if (R_PasswordCon.Text == "Confirmar Password")
            {
                R_PasswordCon.Text = "";
                R_PasswordCon.PasswordChar = '*';

            }
        }

        private void Con_Password_Leave(object sender, EventArgs e)
        {
            if (R_PasswordCon.Text == "")
            {
                R_PasswordCon.Text = "Confirmar Password";
                R_PasswordCon.PasswordChar = '\0';
            }
        }

        private void Added_Click(object sender, EventArgs e)
        {
            if(R_Password.Text == R_PasswordCon.Text)
            {
                var Insertar = new Process().InsertarUsuario(R_UserAccount.Text,R_Password.Text,R_Cedula.Text,R_Nombre.Text,R_Apellidos.Text,R_Email.Text,R_Telefono.Text,R_Area.Text);
            }
        }
    }
}
