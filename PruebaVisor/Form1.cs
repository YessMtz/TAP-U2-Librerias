using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaVisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            userCtrl1.ImagenSeleccionada +=
                new Unidad_2_Librerias.UserCtrl.ImagenSeleccionadaDelegate(visor_ImagenSeleccionada);
                
        }

        private void visor_ImagenSeleccionada(object sender, Unidad_2_Librerias.ImagenSelecionadaArg e)
        {
            MessageBox.Show("La ruta de acceso de la imagen seleccionada es la siguiente " + e.FileName);

        }

        private void userCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}
