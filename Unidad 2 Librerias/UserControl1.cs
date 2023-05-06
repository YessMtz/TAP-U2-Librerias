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
        private List   <ImagenNombre> imagenes = new List<ImagenNombre>();

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
                    imagenes.Add(new ImagenNombre(Bitmap.FromFile(file.FullName), file.FullName));
                }
            }
        }

        private void UpdateControl()
        {
            panel1.SuspendLayout();
            foreach (Control ctrl in panel1.Controls) { ctrl.Dispose(); }
            panel1.Controls.Clear();
            int col = borde, fila = borde;
            panel1.ResumeLayout();

            foreach (ImagenNombre img in imagenes)
            {
                PictureBox pic = new PictureBox();
                pic.Image = img.Imagen;
                pic.Tag = img.fileName;
                pic.Size = new Point(dimension, dimension);
                pic.Location = new Point(col, fila);
                panel1.Controls.Add(pic);
                col += dimension + separacion;
                if ((col + dimension + separacion + borde) > this.Width)
                    {
                    col = borde;
                    fila += dimension + separacion;
                    }
               
            }

             panel1.ResumeLayout();
        }

        public void refresh()
        {
            getImagenes();
            UpdateControl();

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            UpdateControl();
            base.OnSizeChanged(e);

        }

        //clase que se usara en la lista, conetiene las caracteristicas del objeto
        internal class ImagenNombre
        {
            //creacion de objeto de la clase

           
            public ImagenNombre Imagen{get; set; }
            public string FileName{ get; set; }

            public ImagenNombre(ImagenNombre img, string fileName )
            {
                Imagen = img; 
                FileName = fileName;
            }


        }

        private void UserCtrl_Load(object sender, EventArgs e)
        {

        }
    }
}
