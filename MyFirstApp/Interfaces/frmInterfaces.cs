using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Interfaces
{
    public partial class frmInterfaces : Form
    {
        public frmInterfaces()
        {
            InitializeComponent();
        }

        private void FrmInterfaces_Load(object sender, EventArgs e)
        {
            //Polimorfismo de interfaces
            IVehiculo vehiculo = new Avion();
            vehiculo.Acelerar(59);

        }
    }
}
