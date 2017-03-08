using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace R__n_R
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            CurrentTxt.Text = "Buy two, get the second one for half price";
            PromotionTxt.Text = "B608";
        }

        private void MusicBtn_Click(object sender, EventArgs e)
        {
            CurrentTxt.Text = "Get a free MP3 download with purchase of a CD.";
            PromotionTxt.Text = "M608";
        }

        private void PeriodBtn_Click(object sender, EventArgs e)
        {
            CurrentTxt.Text = "Elite members receive 10% off every purchase.";
            PromotionTxt.Text = "P608";
        }

        private void CoffeeBtn_Click(object sender, EventArgs e)
        {
            CurrentTxt.Text = "Celebrate the season with 20% off speciality drinks.";
            PromotionTxt.Text = "C608";
        }

        /// <summary>
        /// print preview form
        /// ref:
        /// https://msdn.microsoft.com/en-us/library/6he9hz8c(v=vs.110).aspx
        /// https://msdn.microsoft.com/en-us/library/aa984360(v=vs.71).aspx
        /// </summary>
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
        int nXDest, int nYDest, int nWidth, int nHeight,
        IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height,
                mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(
                memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                this.ClientRectangle.Height, dc1, 0, 0,
                13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
