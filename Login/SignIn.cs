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
using Common.Cache;

namespace Presentation
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            Carreras();
        }

        public void Carreras()
        {
            List<Carrera> Item = new Process().Carreras();

            foreach(Carrera Ca in Item)
            {
                R_AreaLab.Items.Add(Ca.NombreCarrera);
            }

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

        private void R_UserAccount_Enter(object sender, EventArgs e)
        {
            if (R_UserAccount.Text == "User")
            {
                R_UserAccount.Text = "";
            }
        }

        private void R_UserAccount_Leave(object sender, EventArgs e)
        {
            if (R_UserAccount.Text == "")
            {
                R_UserAccount.Text = "User";
            }
        }

        private void v_Password_Enter(object sender, EventArgs e)
        {
            if (R_Password.Text == "Password")
            {
                R_Password.Text = "";
                R_Password.PasswordChar = '*';
                v_Hide.Visible = false;
                v_Show.Visible = true;
            }
        }

        private void v_Password_Leave(object sender, EventArgs e)
        {
            if(R_Password.Text == "")
            {
                R_Password.Text = "Password";
                R_Password.PasswordChar = '\0';
                v_Hide.Visible = true;
                v_Show.Visible = false;
            }
        }

        private void Con_Password_Enter(object sender, EventArgs e)
        {
            if (R_PasswordCon.Text == "Confirmar Password")
            {
                R_PasswordCon.Text = "";
                R_PasswordCon.PasswordChar = '*';
                v_Hide.Visible = false;
                v_Show.Visible = true;

            }
        }

        private void Con_Password_Leave(object sender, EventArgs e)
        {
            if (R_PasswordCon.Text == "")
            {
                R_PasswordCon.Text = "Confirmar Password";
                R_PasswordCon.PasswordChar = '\0';
                v_Hide.Visible = true;
                v_Show.Visible = false;

            }else if(R_Password.Text != R_PasswordCon.Text)
            {
                ErrorPassword.Visible = true;
            }
        }

        private void R_Nombre_Enter(object sender, EventArgs e)
        {
            if(R_Nombre.Text == "Nombre Completo")
            {
                R_Nombre.Text = "";
            }
        }

        private void R_Nombre_Leave(object sender, EventArgs e)
        {
            if (R_Nombre.Text == "")
            {
                R_Nombre.Text = "Nombre Completo";
            }
        }

        private void R_Apellidos_Enter(object sender, EventArgs e)
        {
            if (R_Apellidos.Text == "Apellidos")
            {
                R_Apellidos.Text = "";
            }
        }

        private void R_Apellidos_Leave(object sender, EventArgs e)
        {
            if (R_Apellidos.Text == "")
            {
                R_Apellidos.Text = "Apellidos";
            }
        }

        private void R_Cedula_Enter(object sender, EventArgs e)
        {
            if (R_Cedula.Text == "Cedula")
            {
                R_Cedula.Text = "";
            }
        }

        private void R_Cedula_Leave(object sender, EventArgs e)
        {
            if (R_Cedula.Text == "")
            {
                R_Cedula.Text = "Cedula";
            }
        }

        private void R_Email_Enter(object sender, EventArgs e)
        {
            if (R_Email.Text == "Email")
            {
                R_Email.Text = "";
            }
        }

        private void R_Email_Leave(object sender, EventArgs e)
        {
            if (R_Email.Text == "")
            {
                R_Email.Text = "Email";
            }
        }

        private void R_Telefono_Enter(object sender, EventArgs e)
        {
            if (R_Telefono.Text == "Telefono")
            {
                R_Telefono.Text = "";
            }
        }

        private void R_Telefono_Leave(object sender, EventArgs e)
        {
            if (R_Telefono.Text == "")
            {
                R_Telefono.Text = "Telefono";
            }
        }

        private UsuarioModel Model()
        {
            UsuarioModel model = new UsuarioModel();

            model._UserAccount = R_UserAccount.Text;
            model._Password = R_PasswordCon.Text;
            model._Cedula = R_Cedula.Text;
            model._Nombre = R_Nombre.Text;
            model._Apellidos = R_Apellidos.Text;
            model._Email = R_Email.Text;
            model._Telefono = R_Telefono.Text;
            model._AreaLaboral = R_AreaLab.Text;

            return model;
        }

        private void Added_Click(object sender, EventArgs e)
        {
            var Insertar = new Process();

            if (R_Password.Text == R_PasswordCon.Text)
            {
                if (Insertar.InsertarUsuario(Model()))
                {
                    MessageBox.Show("El Usuario ha sido creado exitosamente");
                }
                else
                    MessageBox.Show("Error al Crear el Usuario");
       
            }
            else
                ErrorPassword.Visible = true;
        }
    }
}
