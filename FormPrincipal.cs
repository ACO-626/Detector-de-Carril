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
        //Image<Bgr, byte> imgArea;
        Image<Bgr, byte> imgRepresent;
        Image<Hls, byte> imgArea;
        Image<Hls, byte> imgAreaAux;
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
            if (pictureOriginal.Image != null)
            {
                pictureOriginal.Image.Dispose();
                pictureOriginal.Image = null;
                if (pictureArea.Image != null)
                {
                    pictureArea.Image.Dispose();
                    pictureArea.Image = null;
                }

            } else
            {
                MessageBox.Show("Cuando no se muestran imagenes previamente cargadas el programa está listo para funcionar", "Reiniciado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #region BotonesAcotar
        private void btnAcotar_Click(object sender, EventArgs e)
        {
            if (imgOriginal != null)
            {
                Acotar1();
            } else
            {
                Importar();
                if (imgOriginal != null)
                    Acotar1();

            }
        }
        private void btnAcotar2_Click(object sender, EventArgs e)
        {
            if (imgOriginal != null)
            {
                Acotar2();
            } else
            {
                Importar();
                if (imgOriginal != null)
                    Acotar2();
            }
        }
        #endregion
        private void btnAcotar3_Click(object sender, EventArgs e)
        {
            if (imgOriginal != null)
            {
                Acotar3();
            }
            else
            {
                Importar();
                if (imgOriginal != null)
                    Acotar3();
            }
        }

        #region Metodos de acotar
        private void Acotar1()
        {
            imgRepresent = new Image<Bgr, byte>(imgOriginal.Width, imgOriginal.Height);
            //imgArea = new Image<Bgr, byte>(imgOriginal.Width, imgOriginal.Height / 2);
            for (int i = imgOriginal.Height / 2; i < imgOriginal.Height; i++)
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

            for (int i = (imgOriginal.Height * 2) / 3; i < imgOriginal.Height; i++)
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


        private void Acotar3()
        {
            imgRepresent = new Image<Bgr, byte>(imgOriginal.Width, imgOriginal.Height);
            for (int i = imgOriginal.Height - 1; i > imgOriginal.Height * 2 / 3; i--)
            {
                //For de los espacios 
                for (int j = 0; j < imgOriginal.Width - 2 * (imgOriginal.Height - i); j++)
                {
                    imgRepresent[i, j + (imgOriginal.Height - i)] = imgOriginal[i, j + (imgOriginal.Height - i)];
                }
            }
            pictureArea.Image = imgRepresent.ToBitmap();
        }

        private void btnDetectar_Click(object sender, EventArgs e)
        {
            if (imgOriginal != null)
            {
                DetectaPara3();
            } else
            {
                Importar();
                DetectaPara3();
            }
        }


        private void DetectaPara3()
        {
            //imgArea = imgRepresent.Convert<Hls, byte>();
            imgArea = new Image<Hls, byte>(imgOriginal.Width, imgOriginal.Height);
            imgAreaAux = imgOriginal.Convert<Hls, byte>();
            for (int i = imgOriginal.Height - 1; i > imgOriginal.Height * 2 / 3; i--)
            {
                //For de los espacios 
                for (int j = 0; j < imgOriginal.Width - 2 * (imgOriginal.Height - i); j++)
                {
                    if ((imgAreaAux[i, j + (imgOriginal.Height - i)].Hue < trackHue.Value && imgAreaAux[i, j + (imgOriginal.Height - i)].Hue >14) || imgAreaAux[i, j + (imgOriginal.Height - i)].Lightness>trackLuz.Value)
                    imgArea[i, j + (imgOriginal.Height - i)] = imgAreaAux[i, j + (imgOriginal.Height - i)];
                }
            }
            pictureArea.Image = imgArea.ToBitmap();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgArea.Convert<Gray,byte>(), contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < contours.Size; i++)
            {
                var area = CvInvoke.ContourArea(contours[i]);
                if (area > 50)
                {
                    CvInvoke.DrawContours(imgOriginal, contours, i, new MCvScalar(255, 0, 255), 10);
                    //RotatedRect box = CvInvoke.MinAreaRect(contours[i]);
                    //Rectangle caja = CvInvoke.BoundingRectangle(contours[i]);
                    //CvInvoke.Rectangle(imgOriginal, caja, new MCvScalar(0, 0, 255), 2);
                    //CvInvoke.DrawContours(imgOriginal, contours[i], 1, new MCvScalar(0, 255, 255));
                }


            }
            pictureOriginal.Image = imgOriginal.ToBitmap();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelLuz.Text = "Max Light: " + trackLuz.Value.ToString();
        }

        private void trackHue_ValueChanged(object sender, EventArgs e)
        {
            labelHue.Text = trackHue.Value.ToString();
        }
    }
}
//int j=imgOriginal.Height;i<j;j--
//(2 / 3) * imgOriginal.Height