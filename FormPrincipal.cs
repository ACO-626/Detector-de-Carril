using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Emgu CV 3.3
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Detector_de_Carril
{
    public partial class FormPrincipal : Form
    {


        #region Variables golobales
        Image<Bgr, byte> imgOriginal;
        Image<Bgr, byte> imgArea;
        Image<Bgr, byte> imgRepresent;
        #endregion

        #region Inicialización
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Importar
        private void btnImportar_Click(object sender, EventArgs e)
        {
            Importar();   
        }


        private void Importar()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgOriginal = new Image<Bgr, byte>(ofd.FileName);
                    pictureOriginal.Image = imgOriginal.ToBitmap();
                    
                }
                if (imgOriginal != null)
                    Acotar1();
            }
            catch (Exception)
            {
                MessageBox.Show("Extensión inválida, solo puede cargar imagenes", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion



        private void btnReiniciar_Click(object sender, EventArgs e)
        {
           if(pictureOriginal.Image!=null)
            {
                pictureOriginal.Image.Dispose();
                pictureOriginal.Image = null;
                if (pictureArea.Image != null)
                {
                    pictureArea.Image.Dispose();
                    pictureArea.Image = null;
                }                    

            }else
            {
                MessageBox.Show("Cuando no se muestran imagenes previamente cargadas el programa está listo para funcionar","Reiniciado ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        #region BotonesAcotar
        private void btnAcotar_Click(object sender, EventArgs e)
        {
            if(imgOriginal!=null)
            {
                Acotar1();
            }else
            {
                Importar();
                if (imgOriginal != null)
                    Acotar1();
      
            }
        }
        private void btnAcotar2_Click(object sender, EventArgs e)
        {
            if(imgOriginal != null)
            {
                Acotar2();
            }else
            {
                Importar();
                if (imgOriginal != null)
                    Acotar2();
            }
        }
        #endregion

        #region Metodos de acotar
        private void Acotar1()
        {
            imgRepresent = new Image<Bgr, byte>(imgOriginal.Width,imgOriginal.Height); 
            //imgArea = new Image<Bgr, byte>(imgOriginal.Width, imgOriginal.Height / 2);
            for (int i = imgOriginal.Height/2; i < imgOriginal.Height; i++)
            {
                for (int j = 0; j < imgOriginal.Width; j++)
                {
                    //imgArea[i - imgArea.Height, j] = imgOriginal[i, j];
                    imgRepresent[i, j] = imgOriginal[i, j];
                }
            }
            //imgArea.Resize(pictureOriginal.Width, pictureOriginal.Height / 2, Emgu.CV.CvEnum.Inter.Linear);
            pictureArea.Image = imgRepresent.ToBitmap();
        }


        private void Acotar2()
        {
            //imgArea = new Image<Bgr, byte>(imgOriginal.Width, imgOriginal.Height / 3);
            imgRepresent = new Image<Bgr, byte>(imgOriginal.Width, imgOriginal.Height);

            for (int i = (imgOriginal.Height*2)/3; i < imgOriginal.Height; i++)
            {
                for (int j = 0; j < imgOriginal.Width; j++)
                {
                    //imgArea[i-imgArea.Height*2, j] = imgOriginal[i, j];
                    imgRepresent[i, j] = imgOriginal[i, j];
                }
            }
            //imgArea.Resize(pictureOriginal.Width, pictureOriginal.Height / 2, Emgu.CV.CvEnum.Inter.Linear);
            pictureArea.Image = imgRepresent.ToBitmap();
        }
        #endregion

    }
}
