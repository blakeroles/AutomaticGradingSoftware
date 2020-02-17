using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticGradingSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Testing the Document class
            String fileName = "test2_venus";
            String fileOriginal = @"C:\Users\blake\Git Repositories\AutomaticGradingSoftware\AutomaticGradingSoftware\AutomaticGradingSoftware\TestImages\" + fileName + ".bmp";
            String fileProcessed = @"C:\Users\blake\Git Repositories\AutomaticGradingSoftware\AutomaticGradingSoftware\AutomaticGradingSoftware\TestImages\Processed\" + fileName + "_processed.bmp";

            Document testDoc = new Document(fileOriginal, fileProcessed, true, "Blake");

            testDoc.convertBitmapToMatrix();
            testDoc.convertMatrixToMatrix();
            testDoc.convertMatrixToBitmap();
            testDoc.saveBitmapToFile();
        }
    }
}
