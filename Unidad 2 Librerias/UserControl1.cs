using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unidad_2_Librerias
{
    public partial class UserCtrl: UserControl
    {
        //variables
        private string directorio = "";
        private int dimension;
        private int separacion;
        private int borde = 7;
        
        //coleccion de imagenes
        //declaracion de la lista tipo imagen 
        private List   <Imagen> imagenes = new List<Imagen>();

        //PROPIEDADES
        //directorio de las imagenes
        public string Directorio {
            get { return directorio; }
            set { directorio = value;
                UpdateControl();
            }
        }

        //dimensiones de las imagenes
        public int Dimension {
            get { return dimension; }
            set { UpdateControl(); 
            }
        }

        //SEPARACION
        public int Sepracion { 
            get { return separacion; }
            set { separacion = value;
                UpdateControl();
            }
        }

        public UserCtrl()
        {
            InitializeComponent();
        }

        private void getImagenes() {

            if (directorio.Length !=0) 
            { 
                imagenes.Clear();
                DirectoryInfo dire = new DirectoryInfo(directorio);
                foreach (FileInfo file in dire.GetFiles("*.jpg"))
                {
                    imagenes.Add(new Imagen(Bitmap.FromFile(File.FullName), File.Fullname));
                }
            }
        }

        private void UpdateControl()
        {
            foreach(Control ctrl in UserCtrl.Controls )
        }

        //clase que se usara en la lista, conetiene las caracteristicas del objeto
        internal class Imagen
        {
            //creacion de objeto de la clase

            public Imagen img{get; set; }
            public string FullName{ get; set; }

            public Imagen(Imagen img, string fileName )
            {
                this.img = img;
                fileName = fileName;
            }


        }

        private void UserCtrl_Load(object sender, EventArgs e)
        {

        }
    }
}
