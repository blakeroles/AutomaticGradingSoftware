using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGradingSoftware
{
    class Document
    {
        public String filePathOriginal { get; set; }
        public String filePathProcessed { get; set; }
        public Bitmap bmpOriginal { get; set; }
        public Bitmap bmpProcessed { get; set; }
        public Boolean isMasterDocument { get; set; }
        public String documentOwner { get; set; }
        public double grade { get; set; }
        public Color[,] matrixOriginal { get; set; }
        public Color[,] matrixProcessed { get; set; }

        public Document(String filePathOriginal, String filePathProcessed, Boolean isMasterDocument, String documentOwner)
        {
            this.bmpOriginal = new Bitmap(filePathOriginal);
            this.bmpProcessed = null;
            this.isMasterDocument = isMasterDocument;
            this.documentOwner = documentOwner;
            this.filePathProcessed = filePathProcessed;
            this.filePathOriginal = filePathOriginal;
            this.grade = 0.0;

        }

        public void convertBitmapToMatrix()
        {

            matrixOriginal = new Color[bmpOriginal.Height, bmpOriginal.Width];
            for (int i = 0; i <= this.bmpOriginal.Height - 1; i++)
            {
                for (int j = 0; j <= this.bmpOriginal.Width - 1; j++)
                {
                    Console.WriteLine("i = " + i + ", j = " + j);
                    matrixOriginal[i, j] = bmpOriginal.GetPixel(j, i);

                }
            }



        }

        public void convertMatrixToMatrix()
        {
            // For now, just directly copy matrixOriginal to matrixProcessed
            matrixProcessed = matrixOriginal;

            // Test: Convert all black pixels to white pixels
            for (int i = 0; i < matrixProcessed.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrixProcessed.GetLength(1) - 1; j++)
                {
                    if (matrixOriginal[i, j].R == 1 && matrixOriginal[i, j].G == 1 && matrixOriginal[i, j].B == 1)
                    {
                        matrixProcessed[i, j] = Color.FromArgb(255, 255, 255);
                    }
                }
            }

        }

        public void convertMatrixToBitmap()
        {
            bmpProcessed = new Bitmap(bmpOriginal.Width, bmpOriginal.Height);
            for (int i = 0; i < this.bmpOriginal.Height - 1; i++)
            {
                for (int j = 0; j < this.bmpOriginal.Width - 1; j++)
                {
                    Console.WriteLine("i = " + i + ", j = " + j);
                    this.bmpProcessed.SetPixel(j, i, this.matrixProcessed[i, j]);


                }
            }
        }

        public void saveBitmapToFile()
        {
            this.bmpProcessed.Save(this.filePathProcessed, ImageFormat.Bmp);
        }


    }
}
