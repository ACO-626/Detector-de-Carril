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

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Cvb;
using System.Runtime.InteropServices;


namespace Detector_de_Carril
{
    public partial class FormPrincipal : Form
    {
        Graphics papel;
        Pen pluma = new Pen(Color.DarkGreen);

        #region Variables golobales
        Image<Bgr, byte> imgOriginal;
        //Image<Bgr, byte> imgArea;
        Image<Bgr, byte> imgRepresent;
        Image<Hls, byte> imgArea;
        Image<Hls, byte> imgAreaAux;
        
        //Video
        VideoCapture video;
        bool pausa = false;
        int tiempo = 60;
        Image<Bgr, byte> frame;

        Point[] Trapecio = new Point[4];
        Point[] Cuadro = new Point[4];

        IInputArray Cuadrado;
        

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

        #region Reiniciar
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
        #endregion

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
        #endregion

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
        #endregion

        #region DetectarPara3
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
        #endregion

        #region Visualizar
        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            Visualizar();
        }

        private void Visualizar()
        {

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgArea.Convert<Gray, byte>(), contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < contours.Size; i++)
            {
                var area = CvInvoke.ContourArea(contours[i]);
                if (area > (double)numericUArea.Value)
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
        #endregion

        #region HLS

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelLuz.Text = "Max Light: " + trackLuz.Value.ToString();
        }

        private void trackHue_ValueChanged(object sender, EventArgs e)
        {
            labelHue.Text = trackHue.Value.ToString();
        }
        #endregion

        #region Canny
        private void btnCanny3_Click(object sender, EventArgs e)
        {
            imgArea = new Image<Hls, byte>(imgOriginal.Width, imgOriginal.Height);
            imgAreaAux = imgOriginal.Convert<Hls, byte>();
           
            for (int i = imgOriginal.Height - 1; i > imgOriginal.Height * 2 / 3; i--)
            {
                //For de los espacios 
                for (int j = 0; j < imgOriginal.Width - 2 * (imgOriginal.Height - i); j++)
                {
                    
                        imgArea[i, j + (imgOriginal.Height - i)] = imgAreaAux[i, j + (imgOriginal.Height - i)];
                }
            }
            Image<Gray, byte> imgGray = imgArea.Convert<Gray, byte>();
            imgGray = imgGray.Canny((Double)numericL1.Value,(Double)numericU1.Value);
            imgArea = imgGray.Convert<Hls, byte>();
            pictureArea.Image = imgArea.ToBitmap();

        }




        private void btnCanny2_Click(object sender, EventArgs e)
        {
            imgArea = new Image<Hls, byte>(imgOriginal.Width, imgOriginal.Height);

            for (int i = (imgOriginal.Height * 2) / 3; i < imgOriginal.Height; i++)
            {
                for (int j = 0; j < imgOriginal.Width; j++)
                {
                    //imgArea[i-imgArea.Height*2, j] = imgOriginal[i, j];
                    imgRepresent[i, j] = imgOriginal[i, j];
                }
            }
            Image<Gray, byte> imgGray = imgRepresent.Convert<Gray, byte>();
            imgGray = imgGray.Canny((Double)numericL1.Value, (Double)numericU1.Value);
            imgArea = imgGray.Convert<Hls, byte>();
            pictureArea.Image = imgArea.ToBitmap();
        }
        #endregion

        #region VideoPlay
        private async void btnPlay_Click(object sender, EventArgs e)
        {
            pausa = false;
            if(video==null)
            {
                Importar();
            }
            try
            {
                while(!pausa)
                {
                    Mat mFrame1 = new Mat();
                    video.Retrieve(mFrame1);
                    video.Grab();
                    frame = mFrame1.ToImage<Bgr, byte>();
                    if (!mFrame1.IsEmpty)
                    {
                        pictureOriginal.Image = frame.ToBitmap();
                        await Task.Delay(1000 / tiempo);

                    }
                    else
                    {
                        video.Stop();
                        break;
                    }
                }
            }catch(Exception)
            {

            }
        }
        #endregion

        #region Importar Video

        private void ImportacionVideo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                video = new VideoCapture(ofd.FileName);
                Mat matriz = new Mat();
                video.Read(matriz);
                Image<Bgr, byte> img = matriz.ToImage<Bgr, byte>();
                //img = img.Resize(pictureOriginal.Width, pictureOriginal.Height, Emgu.CV.CvEnum.Inter.Linear);
                imgArea = img.Convert<Hls, byte>(); 
                pictureOriginal.Image = matriz.Bitmap;

                

                



            }
        }


        private void btnImportarVideo_Click(object sender, EventArgs e)
        {
            ImportacionVideo();
        }
        #endregion


        #region fps
        private void trackBarTime_ValueChanged(object sender, EventArgs e)
        {
            labelFps.Text = trackBarTime.Value.ToString();
            tiempo = trackBarTime.Value;
        }
        #endregion

        #region AcotarVideo
        private void DetectarCaminoenVideo(Image<Bgr,byte> imgFrame)
        {
           
            imgAreaAux = imgFrame.Convert<Hls, byte>();
            imgArea = new Image<Hls, byte>(imgFrame.Width,imgFrame.Height);

            for (int i = imgFrame.Height - 1; i > imgFrame.Height * 2 / 3; i--)
            {                
                for (int j = 0; j < imgFrame.Width - 2 * (imgFrame.Height - i); j++)
                {
                    if ((imgAreaAux[i, j + (imgFrame.Height - i)].Hue < trackHue.Value && imgAreaAux[i, j + (imgFrame.Height - i)].Hue > 14) || imgAreaAux[i, j + (imgFrame.Height - i)].Lightness > trackLuz.Value)
                        imgArea[i, j + (imgFrame.Height - i)] = imgAreaAux[i, j + (imgFrame.Height - i)];
                }
            }




            //HomographyMatrix mywarpmat = CameraCalibration.GetPerspectiveTransform(srcs, dsts);
            //Image<Bgr, byte> newImage = image.WarpPerspective(mywarpmat, Emgu.CV.CvEnum.INTER.CV_INTER_NN, Emgu.CV.CvEnum.WARP.CV_WARP_FILL_OUTLIERS, new Bgr(0, 0, 0));
            //var cuadradoArray = new[] { Cuadro[0], Cuadro[1], Cuadro[2], Cuadro[3] };
            //var trapecioArray = new[] { Cuadro[0], Cuadro[1], Cuadro[2], Cuadro[3] };
            //var matrix = CvInvoke.GetPerspectiveTransform(,);

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgArea.Convert<Gray, byte>(), contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < contours.Size; i++)
            {
                var area = CvInvoke.ContourArea(contours[i]);
                if (area > (double)numericUArea.Value)
                {
                    CvInvoke.DrawContours(imgFrame, contours, i, new MCvScalar(255, 0, 255), 10);                    
                }
            }
            pictureOriginal.Image = imgFrame.ToBitmap();

        }
        #endregion

        #region btnPlayDetectVideo
        private async void btnPlayDetect_Click(object sender, EventArgs e)
        {

            pausa = false;
            if (video == null)
            {
                ImportacionVideo();
            }
            try
            {
                while (!pausa)
                {
                    Mat mFrame1 = new Mat();
                    video.Retrieve(mFrame1);
                    video.Grab();
                    frame = mFrame1.ToImage<Bgr, byte>();
                    if (!mFrame1.IsEmpty)
                    {
                        //pictureOriginal.Image = frame.ToBitmap();
                        DetectarCaminoenVideo(frame);
                        await Task.Delay(1000 / tiempo);

                    }
                    else
                    {
                        video.Stop();
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Pausa
        private void btnPausa_Click(object sender, EventArgs e)
        {
            pausa = true;
        }
        #endregion

        private void btnTransformar_Click(object sender, EventArgs e)
        {
            Transformar();
        }

        private void Transformar()
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

            imgRepresent = imgRepresent.Resize(pictureArea.Width, pictureArea.Height, Emgu.CV.CvEnum.Inter.Lanczos4);
            //pictureArea.Image = imgRepresent.ToBitmap();


            PointF[] dstCuadro = new PointF[]
            {
                new Point(0, 0),
                new Point(imgRepresent.Width,0),
                new Point(0,imgRepresent.Height),
                new Point(pictureArea.Width,pictureArea.Height )

              };
            PointF[] srcTrapecio = new PointF[]
            {
                new Point((23*imgRepresent.Height/40),(2 * imgRepresent.Height/3)),
                new Point((imgRepresent.Width - 23*imgRepresent.Height/40),(2 * imgRepresent.Height/3)),
                new Point(0,imgRepresent.Height),
                new Point(pictureArea.Width,pictureArea.Height)
              };



            PointF[] srcs = new PointF[4];
            srcs[0] = new Point(0, 0);
            srcs[1] = new Point(0, imgRepresent.Width);
            srcs[2] = new Point(imgRepresent.Height, 0);
            srcs[3] = new Point(imgRepresent.Height, imgRepresent.Width);


            PointF[] dsts = new PointF[4];
            dsts[0] = new Point((2 / 3) * imgRepresent.Height, (1 / 3) * imgRepresent.Height);
            dsts[1] = new Point(0, imgRepresent.Width);
            dsts[2] = new Point(imgRepresent.Height, 0);
            dsts[3] = new Point(imgRepresent.Height, imgRepresent.Width);

            Mat srcImg;
            srcImg = imgRepresent.Mat;
            Mat dstImag = new Mat();
            Mat homo;



            //homo = CvInvoke.GetAffineTransform(srcTrapecio, dstCuadro);
            homo = CvInvoke.FindHomography(srcTrapecio, dstCuadro,HomographyMethod.Default);
            //CvInvoke.WarpAffine(srcImg, dstImag, homo, new System.Drawing.Size(pictureArea.Width,pictureArea.Height),Inter.Nearest, Warp.InverseMap, BorderType.Replicate);
            CvInvoke.WarpPerspective(imgRepresent,dstImag,homo,imgRepresent.Size);
            pictureArea.Image = (dstImag.ToImage<Bgr, byte>()).ToBitmap();
            //pictureOriginal.Image = (homo.ToImage<Bgr, byte>().ToBitmap());


            papel = pictureArea.CreateGraphics();
            pluma.Width = 5;

            //papel.DrawRectangle(pluma, 0, 0, 5, 5);
            //papel.DrawRectangle(pluma, imgRepresent.Width - 5, 0, 5, 5);
            //papel.DrawRectangle(pluma, 0, imgRepresent.Height - 5, 5, 5);
            //papel.DrawRectangle(pluma, pictureArea.Width - 5, pictureArea.Height - 5, 5, 5);

            //pluma.Color = Color.Red;
            //papel.DrawRectangle(pluma, ((imgRepresent.Height / 3)), (2 * imgRepresent.Height / 3), 5, 5);
            //papel.DrawRectangle(pluma, (imgRepresent.Width - imgRepresent.Height / 3), (2 * imgRepresent.Height / 3), 5, 5);
        }
    }
}
