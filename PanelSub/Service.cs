using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain.Process;

namespace Presentation.PanelSub
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();

            var Iteam = new Process().Servicios();

            foreach(Servicio servicio in Iteam)
            {
               if(servicio.User != UserLoginCache.UserId)
                    flowLayoutPanel1.Controls.Add(new ItemService(servicio));
            }  
        }
    }
}
