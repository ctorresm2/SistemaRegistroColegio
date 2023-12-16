using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class Uploadimage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void CargarImagen(PictureBox pictureBox)
        {
            //Estableceder la propiedad de WaitOnLoad a true significa que la imagen se carga de forma sincronica
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes |*.jpeg;*.gif;*.png;*.bmp;*.jpg";
            fd.ShowDialog();

            if (fd.FileName != string.Empty)
            { 
                pictureBox.ImageLocation = fd.FileName;
            }


        }


    }
}
