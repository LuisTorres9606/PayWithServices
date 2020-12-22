using Common.Cache;
using Domain.Process;
using System;
using System.Collections.Generic;
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
                MessageBox.Show("El servicio se ha publicado exitosamente","Publicación del Servicio");
                LimpiarCasillas(); 
            }
            else
                MessageBox.Show("Error al publicar el servicio","Error en el Sistema");
        }

        private void UpServicio()
        {
            var servicio = Servicio();

            if (Pro.UpServicio(servicio))
            {
                MessageBox.Show("El servicio se ha actualizado exitosamente", "Publicación del Servicio");
                LimpiarCasillas();
            }
            else
                MessageBox.Show("Error al actualizar el servicio", "Error en el Sistema");
        }

        private void Process_Click(object sender, EventArgs e)
        {
            if (!Update.Checked)
                addServicio();
            else
                UpServicio();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            var sercicio = Pro.ConsultServicio(Id_Servicio.Text);

            if (sercicio.User == UserLoginCache.UserId)
            {
                NombreServicio1.Text = sercicio.NombreBrin;
                Description1.Text = sercicio.Description1;

                AreaPro2.Text = sercicio.AreaBusq;
                NombreServicio2.Text = sercicio.NombreBusq;
                Description2.Text = sercicio.Description2;

                ValorPRomedio.Text = sercicio.ValorPromedio.ToString();
            }
            else
                MessageBox.Show("No se puede accesar al Servicio","Gestion de servicios");
        }

        private void LimpiarCasillas()
        {
            Id_Servicio.Text = "";
            NombreServicio1.Text = "";
            Description1.Text = "";
            AreaPro2.SelectedItem = "Selecciona la Carrera: ";
            NombreServicio2.Text = "";
            Description2.Text = "";
            ValorPRomedio.Text = "";
        }
    }
}
