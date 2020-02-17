using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.matrixOriginal = new Color[bmpOriginal.Height, bmpOriginal.Width];
            this.matrixProcessed = null;
            this.isMasterDocument = isMasterDocument;
            this.documentOwner = documentOwner;
            this.filePathProcessed = filePathProcessed;
            this.filePathOriginal = filePathOriginal;
            this.grade = 0.0;

        }

        public void convertBitmapToMatrix()
        {
            
        }

        public void convertMatrixToMatrix()
        {
            // For now, just directly copy matrixOriginal to matrixProcessed
            this.matrixProcessed = this.matrixOriginal;

        }

        public void convertMatrixToBitmap()
        {

        }

        public void saveBitmapToFile()
        {

        }


    }
}
