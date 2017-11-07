using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTrans
{
    class Controller
    {
        Transformari transformari;

        public Controller()
        {
            transformari = new Transformari();
        }

        public Bitmap grayScale(Bitmap image)
        {
            return transformari.grayScale(image);
        }

        public Bitmap ScaleImage(Bitmap image, int maxWidth, int maxHeight)
        {
            return transformari.ScaleImage(image, maxWidth, maxHeight);
        }

        public Bitmap ContrastAdjustment(Bitmap image, int contrast)
        {
            return transformari.SetContrast(image, contrast);
        }

        public Bitmap NoiseAdjustment(Bitmap image, int a,int b)
        {
            return transformari.Noise(image, a, b);
        }

        public Bitmap Substraction(Bitmap image1, Bitmap image2)
        {
            return transformari.Substraction(image1, image2);
        }

        public Bitmap Histograms(Bitmap image)
        {
            return transformari.Histogram(image);
        }

        public Bitmap DirectionalFiltering(Bitmap image)
        {
            return transformari.DirectionalFiltering(image);
        }

        public Bitmap OutlineEnhancement(Bitmap image)
        {
            return transformari.OutlineEnhancement(image);
        }

        public Bitmap ContrastReversing(Bitmap image)
        {
            return transformari.ContrastReversing(image);
        }

        public Bitmap BiomedicalImageEnhancement(Bitmap image, List<List<int>> mask)
        {
            return transformari.BiomedicalImageEnhancement(image, mask);
        }

        public Bitmap Outline(Bitmap image)
        {
            return transformari.getOutline(image);
        }
    }
}

