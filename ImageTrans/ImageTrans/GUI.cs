using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTrans
{
    public partial class GUI : Form
    {
        private Bitmap image1, image2, image3;
        private Controller ctrl;

        bool image1Displaying;

        public GUI()
        {
            InitializeComponent();
            ctrl = new Controller();

            image1Displaying = true;
        }

        private void menuFileComponentLoad_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "All Files (*.*)|*.*|bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
                dlg.InitialDirectory = Directory.GetCurrentDirectory() + @"\Images\";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    image1 = new Bitmap(dlg.FileName);
                    //image1 = ResizeImage(image1, picOrriginal.Width, picOrriginal.Height);
                    image1 = ctrl.ScaleImage(image1, picOrriginal.Width, picOrriginal.Height);

                    if (image1Displaying)
                        picOrriginal.BackgroundImage = image1;

                    picTransformed.BackgroundImage = null;
                }
            }
        }

        private void menuFileComponentSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.InitialDirectory = Directory.GetCurrentDirectory() + @"\Images\";
            ImageFormat format = ImageFormat.Png;

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                image3.Save(sfd.FileName, format);
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (image1Displaying)
            {
                Bitmap aux = image1;
                image1 = image3;
                image3 = aux;
                picOrriginal.BackgroundImage = image1;
                picTransformed.BackgroundImage = image3;
            }
            else
            {
                Bitmap aux = image2;
                image2 = image3;
                image3 = aux;
                picOrriginal.BackgroundImage = image2;
                picTransformed.BackgroundImage = image3;
            }
        }

        /*///////////////////////////////
                    Lab 1
        ///////////////////////////////*/


        private void menuLaboratory1ComponentGrayScale_Click(object sender, EventArgs e)
        {
            closeAllPanels(true);
            image3 = ctrl.grayScale(image1);
            picTransformed.BackgroundImage = image3;
        }

        /*///////////////////////////////
                    Lab 2
        ///////////////////////////////*/

        private void menuLaboratory2ComponentContrast_Click(object sender, EventArgs e)
        {
            closeAllPanels(false);
            if (!panelContrast.Visible)
            {
                panelContrast.Visible = true;
                lblCurrentPanel.Text = "Contrast";
            }
        }

        private void trackContrast_Scroll(object sender, EventArgs e)
        {
            lblTrackValue.Text = trackContrast.Value.ToString();
            image3 = ctrl.ContrastAdjustment(image1, trackContrast.Value);
            picTransformed.BackgroundImage = image3;
        }

        private void btnCloseContrastPanel_Click(object sender, EventArgs e)
        {
            panelContrast.Visible = false;
            lblCurrentPanel.Text = "None";
        }

        private void menuLaboratory2ComponentNoise_Click(Object sender, EventArgs e)
        {
            closeAllPanels(false);
            if(!panelNoise.Visible)
            {
                panelNoise.Visible = true;
                lblCurrentPanel.Text = "Noise";
            }
        }

        private void trackNoiseA_Scroll(object sender, EventArgs e)
        {
            lblTrackValueA.Text = trackNoiseA.Value.ToString();
            image3 = ctrl.NoiseAdjustment(image1, trackNoiseA.Value,trackNoiseB.Value);
            picTransformed.BackgroundImage = image3;
        }

        private void btnClosePanelNoise_Click(object sender, EventArgs e)
        {
            panelNoise.Visible = false;
            lblCurrentPanel.Text = "None";
        }

        private void trackNoiseB_Scroll(object sender, EventArgs e)
        {
            lblTrackValueB.Text = trackNoiseB.Value.ToString();
            image3 = ctrl.NoiseAdjustment(image1, trackNoiseA.Value, trackNoiseB.Value);
            picTransformed.BackgroundImage = image3;
        }

        private void menuLaboratory2ComponentSubstraction_Click(object sender, EventArgs e)
        {
            closeAllPanels(false);
            if (!panelSubstraction.Visible)
            {
                panelSubstraction.Visible = true;
                lblCurrentPanel.Text = "Substraction";
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (image1Displaying)
            {
                picOrriginal.BackgroundImage = image2;
                image1Displaying = false;
                lblOriginalImage.Text = "Orriginal (2nd)";
            }
            else
            {
                picOrriginal.BackgroundImage = image1;
                image1Displaying = true;
                lblOriginalImage.Text = "Orriginal";
            }
        }

        private void btnClosePanelSubstraction_Click(object sender, EventArgs e)
        {
            panelSubstraction.Visible = false;
            lblCurrentPanel.Text = "None";
        }

        private void btnLoadSecondOrriginalImage_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "All Files (*.*)|*.*|bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
                dlg.InitialDirectory = Directory.GetCurrentDirectory() + @"\Resources\";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    image2 = new Bitmap(dlg.FileName);
                    //image1 = ResizeImage(image1, picOrriginal.Width, picOrriginal.Height);
                    image2 = ctrl.ScaleImage(image2, picOrriginal.Width, picOrriginal.Height);

                    if (!image1Displaying)
                        picOrriginal.BackgroundImage = image2;
                }
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            image3 = ctrl.Substraction(image1, image2);
            picTransformed.BackgroundImage = image3;
        }

        private void menuLaboratory2ComponentHistograms_Click(object sender, EventArgs e)
        {
            closeAllPanels(true);
            image3 = ctrl.Histograms(image1);
            picTransformed.BackgroundImage = image3;
        }

        /*///////////////////////////////
                    Lab 3
        ///////////////////////////////*/

        private void menuLaboratory3ComponentDirectionalFiltering_Click(object sender, EventArgs e)
        {
            closeAllPanels(true);
            image3 = ctrl.DirectionalFiltering(image1);
            picTransformed.BackgroundImage = image3;
        }

        private void menuLaboratory3ComponentOutlineEnhancement_Click(object sender, EventArgs e)
        {
            closeAllPanels(true);
            image3 = ctrl.OutlineEnhancement(image1);
            picTransformed.BackgroundImage = image3;
        }

        private void menuLaboratory3ComponentContrastReversing_Click(object sender, EventArgs e)
        {
            closeAllPanels(true);
            image3 = ctrl.ContrastReversing(image1);
            picTransformed.BackgroundImage = image3;
        }

        private void menuLaboratory3ComponentBiomedicalImageEnhancement_Click(object sender, EventArgs e)
        {
            closeAllPanels(false);
            if (!panelBio.Visible)
            {
                panelBio.Visible = true;
                lblCurrentPanel.Text = "Biomedical Image Enhancement";
            }
        }

        private void btnBioApply_Click(object sender, EventArgs e)
        {
            List<List<int>> mask = new List<List<int>>() { new List<int>() { Int32.Parse(txtBioMask00.Text),Int32.Parse(txtBioMask01.Text),Int32.Parse(txtBioMask02.Text)},
                                                           new List<int>() { Int32.Parse(txtBioMask10.Text),Int32.Parse(txtBioMask11.Text),Int32.Parse(txtBioMask12.Text) },
                                                           new List<int>() { Int32.Parse(txtBioMask20.Text),Int32.Parse(txtBioMask21.Text),Int32.Parse(txtBioMask22.Text)} };

            image3 = ctrl.BiomedicalImageEnhancement(image1, mask);
            picTransformed.BackgroundImage = image3;
        }

        private void btnClosePanelBio_Click(object sender, EventArgs e)
        {
            panelBio.Visible = false;
            lblCurrentPanel.Text = "None";
        }

        /*///////////////////////////////
                    Lab 4
        ///////////////////////////////*/

        private void menuLaboratory4ComponentOutline_Click(object sender, EventArgs e)
        {
            closeAllPanels(true);
            image3 = ctrl.Outline(image1);
            picTransformed.BackgroundImage = image3;
        }










        private void closeAllPanels(bool modifyTitle)
        {
            if(modifyTitle)
                lblCurrentPanel.Text = "None";
            panelContrast.Visible = false;
            panelNoise.Visible = false;
            panelSubstraction.Visible = false;
            panelBio.Visible = false;
        }
    }
}
