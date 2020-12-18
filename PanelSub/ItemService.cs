﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentation.PanelSub
{
    public partial class ItemService : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );

        public ItemService(Servicio servicio)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            Item(servicio);
        }

        public void Item(Servicio servicio)
        {
            User.Text = servicio.User;
            Fecha.Text = "Publicado: "+servicio.Fecha;
            Brind.Text = servicio.NombreBrin;
            Busque.Text = servicio.NombreBusq;
            ValorPromedio.Text = "₡ "+ String.Format(CultureInfo.InvariantCulture, "{0:0,0.0}", servicio.ValorPromedio);

            if (servicio.User == UserLoginCache.UserId)
            {
                DeleteService.Visible = true;
            }
        }

        private void v_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
