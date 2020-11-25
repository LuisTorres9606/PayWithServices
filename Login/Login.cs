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
    public partial class Login : Form
    {
        private UsuarioModel Usuario;

        public Login()
        {
            InitializeComponent();
        }


        private void V_Email_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void v_Show_Click(object sender, EventArgs e)
        {
            v_Password.PasswordChar = '\0';

            v_Show.Enabled = false;
            v_Show.Visible = false;

            v_Hide.Enabled = true;
            v_Hide.Visible = true;
        }

        private void v_Hide_Click(object sender, EventArgs e)
        {
            v_Password.PasswordChar = '*';

            v_Show.Enabled = true;
            v_Show.Visible = true;

            v_Hide.Enabled = false;
            v_Hide.Visible = false;
        }

       
        private void v_Email_Enter(object sender, EventArgs e)
        {
            if(v_Email.Text == "User")
            {
                v_Email.Text = "";
            }
        }

        private void v_Email_Leave(object sender, EventArgs e)
        {
            if (v_Email.Text == "")
            {
                v_Email.Text = "User";
            }
        }

        private void v_Password_Enter(object sender, EventArgs e)
        {
            if (v_Password.Text == "Password")
            {
                v_Password.Text = "";
                v_Password.PasswordChar = '*';
                v_Hide.Visible = false;
                v_Show.Visible = true;

            }
        }

        private void v_Password_Leave(object sender, EventArgs e)
        {
            if (v_Password.Text == "")
            {
                v_Password.Text = "Password";
                v_Password.PasswordChar = '\0';
                v_Hide.Visible = true;
                v_Show.Visible = false;

            }
        }

        public void Reset()
        {
            v_Email.Text = "User";
            v_Password.Text = "Password";
        }

        private void GetStarted_Click(object sender, EventArgs e)
        {
            string UserAcount = v_Email.Text;
            string Password = v_Password.Text;

            Usuario = new Process().Login(UserAcount, Password);

            if (Usuario._UserAccount.Equals(UserAcount) && Usuario._Password.Equals(Password))
            {
                Reset();

                Login_Principal login = Parent as Login_Principal;

                this.Hide();
                login.Hide();

                DashBoard Menu_Principal = new DashBoard(Usuario);
                Menu_Principal.Show();

            }
            else
            {
                ErroLogin.Visible = true;
            }
        }
    }
}
