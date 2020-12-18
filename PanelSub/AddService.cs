using Common.Cache;
using Domain.Process;
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

namespace Presentation.PanelSub
{
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
            Carreras();
        }

        Process Pro = new Process();


        private void Carreras()
        {
            List<Carrera> Item = new Process().Carreras();

            AreaPro1.DropDownStyle = ComboBoxStyle.DropDownList;
            AreaPro2.DropDownStyle = ComboBoxStyle.DropDownList;

            AreaPro1.Items.Insert(0, UserLoginCache.AreaLab);
            AreaPro2.Items.Insert(0, "Selecciona la Carrera: ");

            AreaPro1.SelectedIndex = 0;
            AreaPro2.SelectedIndex = 0;

            foreach (Carrera Ca in Item)
            {
                AreaPro2.Items.Add(Ca.NombreCarrera);
            }
        }

        private ServicioModel Servicio()
        {
            var Servicio = new ServicioModel();

            Servicio.Id_servicio = Id_Servicio.Text;
            Servicio.User = UserLoginCache.UserId;
            Servicio.Fecha = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(Servicio.Fecha);
            Servicio.Area_Bri = AreaPro1.Text;
            Servicio.Nombre_Brin = NombreServicio1.Text;
            Servicio.Description1 = Description1.Text;
            Servicio.Area_Busq = AreaPro2.Text;
            Servicio.Nombre_Busq = NombreServicio2.Text;
            Servicio.Description2 = Description2.Text;
            Servicio.ValorPromedio = double.Parse(ValorPRomedio.Text);

            return Servicio;
        }

        private void addServicio()
        {
            var servicio = Servicio();

            if (Pro.InsertarServicio(servicio))
            {
                MessageBox.Show("El servicio se ha publicado exitosamente");
            }
            else
                MessageBox.Show("Error al publicar el servicio");
        }

        private void Process_Click(object sender, EventArgs e)
        {
            addServicio();
        }
    }
}
