using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTrans
{
    class Transformari
    {
        public Bitmap ScaleImage(Bitmap image, int maxWidth, int maxHeight)  // resize keeping proportions
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public Bitmap ResizeImage(Image image, int width, int height) // resize without keeping proportions
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public Bitmap grayScale(Bitmap image) // transforms an image into grayScale
        {
            Bitmap grayScaleImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color oc = image.GetPixel(i, j);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color tc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    grayScaleImage.SetPixel(i, j, tc);
                }
            }
            return grayScaleImage;
        }

        public Bitmap SetContrast(Bitmap OriginalImage, float Value)
        {
            Bitmap NewBitmap = new Bitmap(OriginalImage.Width, OriginalImage.Height);

            Value = (100.0f + Value) / 100.0f;
            Value *= Value;

            for (int x = 0; x < NewBitmap.Width; ++x)
            {
                for (int y = 0; y < NewBitmap.Height; ++y)
                {
                    Color Pixel = OriginalImage.GetPixel(x, y);
                    float Red = Pixel.R / 255.0f;
                    float Green = Pixel.G / 255.0f;
                    float Blue = Pixel.B / 255.0f;
                    Red = (((Red - 0.5f) * Value) + 0.5f) * 255.0f;
                    Green = (((Green - 0.5f) * Value) + 0.5f) * 255.0f;
                    Blue = (((Blue - 0.5f) * Value) + 0.5f) * 255.0f;

                    Red = Red > 255 ? 255 : Red;
                    Green = Green > 255 ? 255 : Green;
                    Blue = Blue > 255 ? 255 : Blue;
                    Red = Red < 0 ? 0 : Red;
                    Green = Green < 0 ? 0 : Green;
                    Blue = Blue < 0 ? 0 : Blue;

                    NewBitmap.SetPixel(x, y, Color.FromArgb(Pixel.A, (int)Red, (int)Green, (int)Blue));
                }
            }

            return NewBitmap;
        }

        public Bitmap Noise(Bitmap image,int a_,int b_)
        {
            Bitmap noiseImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color oc = image.GetPixel(i, j);
                    double r, g, b;

                    if (oc.R <= a_)
                        r = 0;
                    else
                        if (oc.R > a_ && oc.R <= b_)
                        r = (oc.R - a_) / (b_ - a_) * 255;
                    else
                        r = 255;

                    if (oc.G <= a_)
                        g = 0;
                    else
                        if (oc.G > a_ && oc.G <= b_)
                        g = (oc.G - a_) / (b_ - a_) * 255;
                    else
                        g = 255;

                    if (oc.B <= a_)
                        b = 0;
                    else
                        if (oc.B > a_ && oc.B <= b_)
                        b = (oc.B - a_) / (b_ - a_) * 255;
                    else
                        b = 255;

                    r = r > 255 ? 255 : r;
                    g = g > 255 ? 255 : g;
                    b = b > 255 ? 255 : b;
                    r = r < 0 ? 0 : r;
                    g = g < 0 ? 0 : g;
                    b = b < 0 ? 0 : b;

                    Color tc = Color.FromArgb(oc.A, (int)r, (int)g, (int)b);
                    noiseImage.SetPixel(i, j, tc);
                }
            }
            return noiseImage;
        }

        public Bitmap Substraction(Bitmap image1, Bitmap image2)
        {
            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color oc1 = image1.GetPixel(i, j);
                    Color oc2 = image2.GetPixel(i, j);

                    if (oc1 == oc2)
                    {
                        Color tc = Color.FromArgb(oc1.A, 255, 255, 255);
                        image3.SetPixel(i, j, tc);
                    }
                    else
                    {
                        Color tc = Color.FromArgb(oc1.A, oc1.R, oc1.G, oc1.B);
                        image3.SetPixel(i, j, tc);
                    }
                }
            }

            return image3;
        }

        public Bitmap Histogram(Bitmap image)
        {
            Bitmap returnImage = new Bitmap(image.Width, image.Height);

            List<int> r = new List<int>();
            List<int> g = new List<int>();
            List<int> b = new List<int>();

            List<int> newR = new List<int>(255);
            List<int> newG = new List<int>(255);
            List<int> newB = new List<int>(255);

            for (int i = 0;i<=255;i++)
            {
                r.Add(0);
                g.Add(0);
                b.Add(0);
                newR.Add(0);
                newG.Add(0);
                newB.Add(0);
            }

            int nrT = 0;

            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    Color oc = image.GetPixel(i, j);
                    r[oc.R]++;
                    g[oc.G]++;
                    b[oc.B]++;
                    nrT++;
                }

            float nrr, nrg, nrb;
            nrr = 0;
            nrg = 0;
            nrb = 0;

            for (int i = 0; i <= 255; i++)
            {
                nrr += r[i];
                nrg += g[i];
                nrb += b[i];

                newR[i] = (int)(nrr / nrT * 255);
                newG[i] = (int)(nrg / nrT * 255);
                newB[i] = (int)(nrb / nrT * 255);
            }

            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    Color oc = image.GetPixel(i, j);
                    Color tc = Color.FromArgb(oc.A, newR[oc.R], newG[oc.G], newB[oc.B]);
                    returnImage.SetPixel(i, j, tc);
                }

            return returnImage;
        }

        public Bitmap DirectionalFiltering(Bitmap image)
        {
            Bitmap returnImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    if (i > 2 && j < image.Height - 3)
                    {
                        int vr, vg, vb;

                        Tuple<int, int, int> t = med(image, i, j);
                        vr = t.Item1;
                        vg = t.Item2;
                        vb = t.Item3;

                        returnImage.SetPixel(i, j, Color.FromArgb(vr, vg, vb));
                    }
                    else
                    {
                        Color oc = image.GetPixel(i, j);
                        returnImage.SetPixel(i, j, oc);
                    }

            return returnImage;
        }

        private Tuple<int, int, int> med(Bitmap image, int i_, int j_)
        {
            int sr, sg, sb;

            sr = 0;
            sg = 0;
            sb = 0;

            for (int i = -2; i <= 0; i++)
                for (int j = 2; j >= -i; j--)
                {
                    sr += image.GetPixel(i_ + i, j_ + j).R;
                    sg += image.GetPixel(i_ + i, j_ + j).G;
                    sb += image.GetPixel(i_ + i, j_ + j).B;
                }
            return new Tuple<int, int, int>(sr / 6, sg / 6, sb / 6);
        }

        public Bitmap OutlineEnhancement(Bitmap image)
        {
            Bitmap returnImage = new Bitmap(image.Width, image.Height);

            float l = 5.5f;

            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    if (i > 0 && j > 0 && i <image.Width -1 && j < image.Height -1)
                    {
                        int fr, fg, fb, r, g, b;

                        Color oc0 = image.GetPixel(i, j);
                        Color oc1 = image.GetPixel(i - 1, j);
                        Color oc2 = image.GetPixel(i + 1, j);
                        Color oc3 = image.GetPixel(i, j - 1);
                        Color oc4 = image.GetPixel(i, j + 1);

                        fr = (oc1.R + oc2.R + oc3.R + oc4.R) / 4;
                        fg = (oc1.G + oc2.G + oc3.G + oc4.G) / 4;
                        fb = (oc1.B + oc2.B + oc3.B + oc4.B) / 4;

                        r = oc0.R + (int)(l * (oc0.R - fr));
                        g = oc0.G + (int)(l * (oc0.G - fg));
                        b = oc0.B + (int)(l * (oc0.B - fb));

                        r = r > 255 ? 255 : r;
                        g = g > 255 ? 255 : g;
                        b = b > 255 ? 255 : b;
                        r = r < 0 ? 0 : r;
                        g = g < 0 ? 0 : g;
                        b = b < 0 ? 0 : b;

                        returnImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                    else
                    {
                        Color oc = image.GetPixel(i, j);
                        returnImage.SetPixel(i, j, oc);
                    }

            return returnImage;
        }

        public Bitmap ContrastReversing(Bitmap image)
        {
            Bitmap returnImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    if (i > 0 && j > 0 && i < image.Width - 1 && j < image.Height - 1)
                    {
                        int mr, mg, mb, dr, dg, db, vr, vg, vb;

                        Tuple<int, int, int> t = medM(image, i, j);
                        mr = t.Item1;
                        mg = t.Item2;
                        mb = t.Item3;

                        t = medD(image, i, j);
                        dr = t.Item1;
                        dg = t.Item2;
                        db = t.Item3;

                        if (dr != 0)
                            vr = mr / dr;
                        else
                            vr = 0;

                        if (dg != 0)
                            vg = mg / dg;
                        else
                            vg = 0;

                        if (db != 0)
                            vb = mb / db;
                        else
                            vb = 0;
                        returnImage.SetPixel(i, j, Color.FromArgb(vr, vg, vb));
                    }
                    else
                    {
                        Color oc = image.GetPixel(i, j);
                        returnImage.SetPixel(i, j, oc);
                    }

            return returnImage;
        }

        private Tuple<int,int,int> medM(Bitmap image, int i_, int j_)
        {
            int sr, sg, sb;

            sr = 0;
            sg = 0;
            sb = 0;

            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                    {
                        sr += image.GetPixel(i_ + i, j_ + j).R;
                        sg += image.GetPixel(i_ + i, j_ + j).G;
                        sb += image.GetPixel(i_ + i, j_ + j).B;
                    }
            return new Tuple<int, int, int>(sr/9, sg/9, sb/9);
        }

        private Tuple<int, int, int> medD(Bitmap image, int i_, int j_)
        {
            double sr, sg, sb;

            sr = 0;
            sg = 0;
            sb = 0;

            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                {
                    sr += Math.Pow((double)(image.GetPixel(i_ + i, j_ + j).R - image.GetPixel(i_, j_).R), 2);
                    sg += Math.Pow((double)(image.GetPixel(i_ + i, j_ + j).G - image.GetPixel(i_, j_).G), 2);
                    sb += Math.Pow((double)(image.GetPixel(i_ + i, j_ + j).B - image.GetPixel(i_, j_).B), 2);
                }
            return new Tuple<int, int, int>((int)(Math.Sqrt(sr / 9)), (int)Math.Sqrt(sg / 9), (int)Math.Sqrt(sb / 9));
        }

        public Bitmap BiomedicalImageEnhancement(Bitmap image, List<List<int>> mask)
        {
            Bitmap returnImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    if (i > 0 && j > 0 && i < image.Width - 1 && j < image.Height - 1)
                    {
                        Color oc;

                        List<List<int>> maskR = new List<List<int>>() { new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 0 } };
                        List<List<int>> maskG = new List<List<int>>() { new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 0 } };
                        List<List<int>> maskB = new List<List<int>>() { new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 0 } };

                        oc = image.GetPixel(i - 1, j - 1);
                        maskR[0][0] = oc.R * mask[0][0];
                        maskG[0][0] = oc.G * mask[0][0];
                        maskB[0][0] = oc.B * mask[0][0];

                        oc = image.GetPixel(i - 1, j);
                        maskR[0][1] = oc.R * mask[0][1];
                        maskG[0][1] = oc.G * mask[0][1];
                        maskB[0][1] = oc.B * mask[0][1];

                        oc = image.GetPixel(i - 1, j + 1);
                        maskR[0][2] = oc.R * mask[0][2];
                        maskG[0][2] = oc.G * mask[0][2];
                        maskB[0][2] = oc.B * mask[0][2];

                        oc = image.GetPixel(i, j - 1);
                        maskR[1][0] = oc.R * mask[1][0];
                        maskG[1][0] = oc.G * mask[1][0];
                        maskB[1][0] = oc.B * mask[1][0];

                        oc = image.GetPixel(i, j);
                        maskR[1][1] = oc.R * mask[1][1];
                        maskG[1][1] = oc.G * mask[1][1];
                        maskB[1][1] = oc.B * mask[1][1];

                        oc = image.GetPixel(i, j + 1);
                        maskR[1][2] = oc.R * mask[1][2];
                        maskG[1][2] = oc.G * mask[1][2];
                        maskB[1][2] = oc.B * mask[1][2];

                        oc = image.GetPixel(i + 1, j - 1);
                        maskR[2][0] = oc.R * mask[2][0];
                        maskG[2][0] = oc.G * mask[2][0];
                        maskB[2][0] = oc.B * mask[2][0];

                        oc = image.GetPixel(i + 1, j);
                        maskR[2][1] = oc.R * mask[2][1];
                        maskG[2][1] = oc.G * mask[2][1];
                        maskB[2][1] = oc.B * mask[2][1];

                        oc = image.GetPixel(i + 1, j + 1);
                        maskR[2][2] = oc.R * mask[2][2];
                        maskG[2][2] = oc.G * mask[2][2];
                        maskB[2][2] = oc.B * mask[2][2];

                        returnImage.SetPixel(i, j, Color.FromArgb(sumOfMask(maskR), sumOfMask(maskG), sumOfMask(maskB)));
                    }
                    else
                    {
                        Color oc = image.GetPixel(i, j);
                        returnImage.SetPixel(i, j, oc);
                    }
                }

            return returnImage;
        }

        private int sumOfMask(List<List<int>> mask)
        {
            int sum = 0;
            for (int i = 0; i < mask.Count; i++)
                for (int j = 0; j < mask[i].Count; j++)
                    sum += mask[i][j];

            if (sum > 255)
                return 255;
            if (sum < 0)
                return 0;
            return sum;
        }

        public Bitmap getOutline(Bitmap image)
        {
            Bitmap returnImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    if (i > 0 && j > 0 && i < image.Width - 1 && j < image.Height - 1)
                    {
                        Color oc = image.GetPixel(i, j);

                        if (average(oc) >=250)
                        {
                            int nb = 0;

                            if (average(image.GetPixel(i - 1, j - 1)) < 250)
                                nb++;
                            if (average(image.GetPixel(i - 1, j)) < 250)
                                nb++;
                            if (average(image.GetPixel(i - 1, j + 1)) < 250)
                                nb++;
                            if (average(image.GetPixel(i, j - 1)) < 250)
                                nb++;
                            if (average(image.GetPixel(i - 1, j + 1)) < 250)
                                nb++;
                            if (average(image.GetPixel(i + 1, j - 1)) < 250)
                                nb++;
                            if (average(image.GetPixel(i + 1, j)) < 250)
                                nb++;
                            if (average(image.GetPixel(i + 1, j + 1)) < 250)
                                nb++;

                            if (nb > 1)
                                returnImage.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                            else
                                returnImage.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        }
                        else
                            returnImage.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        Color oc = image.GetPixel(i, j);

                        if (average(oc) >= 250)
                            returnImage.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        else
                            returnImage.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }

            return returnImage;
        }

        private int average(Color c)
        {
            return (c.R + c.G + c.B) / 3;
        }
    }
}
