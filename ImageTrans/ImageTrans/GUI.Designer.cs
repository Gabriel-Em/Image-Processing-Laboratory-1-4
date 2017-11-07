namespace ImageTrans
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileComponentLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileComponentSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory1ComponentGrayScale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory2ComponentContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory2ComponentNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory2ComponentSubstraction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory2ComponentHistograms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory3ComponentDirectionalFiltering = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory3ComponentOutlineEnhancement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory3ComponentContrastReversing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory3ComponentBiomedicalImageEnhancement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory4ComponentOutline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratory5 = new System.Windows.Forms.ToolStripMenuItem();
            this.picOrriginal = new System.Windows.Forms.PictureBox();
            this.lblOriginalImage = new System.Windows.Forms.Label();
            this.lblTransformedImage = new System.Windows.Forms.Label();
            this.picTransformed = new System.Windows.Forms.PictureBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.panelContrast = new System.Windows.Forms.Panel();
            this.btnCloseContrastPanel = new System.Windows.Forms.Button();
            this.lblTrackValue = new System.Windows.Forms.Label();
            this.lblTrackContrastCurrentValue = new System.Windows.Forms.Label();
            this.lblTrackContrast9 = new System.Windows.Forms.Label();
            this.lblTrackContrast8 = new System.Windows.Forms.Label();
            this.lblTrackContrast7 = new System.Windows.Forms.Label();
            this.lblTrackContrast6 = new System.Windows.Forms.Label();
            this.lblTrackContrast5 = new System.Windows.Forms.Label();
            this.lblTrackContrast4 = new System.Windows.Forms.Label();
            this.lblTrackContrast3 = new System.Windows.Forms.Label();
            this.lblTrackContrast2 = new System.Windows.Forms.Label();
            this.lblTrackContrast10 = new System.Windows.Forms.Label();
            this.lblTrackContrast0 = new System.Windows.Forms.Label();
            this.lblTrackContrast1 = new System.Windows.Forms.Label();
            this.trackContrast = new System.Windows.Forms.TrackBar();
            this.lblCurrentPanelTitle = new System.Windows.Forms.Label();
            this.lblCurrentPanel = new System.Windows.Forms.Label();
            this.picMainMenuBorder = new System.Windows.Forms.PictureBox();
            this.panelNoise = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTrackValueB = new System.Windows.Forms.Label();
            this.lblTrackNoiseCurrentValueB = new System.Windows.Forms.Label();
            this.trackNoiseB = new System.Windows.Forms.TrackBar();
            this.btnClosePanelNoise = new System.Windows.Forms.Button();
            this.lblTrackValueA = new System.Windows.Forms.Label();
            this.lblTrackNoiseCurrentValueA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackNoiseA = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panelSubstraction = new System.Windows.Forms.Panel();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnLoadSecondOriginalImage = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnClosePanelSubstraction = new System.Windows.Forms.Button();
            this.panelBio = new System.Windows.Forms.Panel();
            this.btnBioApply = new System.Windows.Forms.Button();
            this.txtBioMask22 = new System.Windows.Forms.TextBox();
            this.txtBioMask21 = new System.Windows.Forms.TextBox();
            this.txtBioMask20 = new System.Windows.Forms.TextBox();
            this.txtBioMask12 = new System.Windows.Forms.TextBox();
            this.txtBioMask11 = new System.Windows.Forms.TextBox();
            this.txtBioMask10 = new System.Windows.Forms.TextBox();
            this.txtBioMask02 = new System.Windows.Forms.TextBox();
            this.txtBioMask01 = new System.Windows.Forms.TextBox();
            this.txtBioMask00 = new System.Windows.Forms.TextBox();
            this.btnClosePanelBio = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransformed)).BeginInit();
            this.panelContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuBorder)).BeginInit();
            this.panelNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackNoiseB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNoiseA)).BeginInit();
            this.panelSubstraction.SuspendLayout();
            this.panelBio.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuLaboratory1,
            this.menuLaboratory2,
            this.menuLaboratory3,
            this.menuLaboratory4,
            this.menuLaboratory5});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1234, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileComponentLoad,
            this.menuFileComponentSave});
            this.menuFile.ForeColor = System.Drawing.Color.Black;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(42, 21);
            this.menuFile.Text = "File";
            // 
            // menuFileComponentLoad
            // 
            this.menuFileComponentLoad.Name = "menuFileComponentLoad";
            this.menuFileComponentLoad.Size = new System.Drawing.Size(106, 22);
            this.menuFileComponentLoad.Text = "Load";
            this.menuFileComponentLoad.Click += new System.EventHandler(this.menuFileComponentLoad_Click);
            // 
            // menuFileComponentSave
            // 
            this.menuFileComponentSave.Name = "menuFileComponentSave";
            this.menuFileComponentSave.Size = new System.Drawing.Size(106, 22);
            this.menuFileComponentSave.Text = "Save";
            this.menuFileComponentSave.Click += new System.EventHandler(this.menuFileComponentSave_Click);
            // 
            // menuLaboratory1
            // 
            this.menuLaboratory1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLaboratory1ComponentGrayScale});
            this.menuLaboratory1.ForeColor = System.Drawing.Color.Black;
            this.menuLaboratory1.Name = "menuLaboratory1";
            this.menuLaboratory1.Size = new System.Drawing.Size(99, 21);
            this.menuLaboratory1.Text = "Laboratory 1";
            // 
            // menuLaboratory1ComponentGrayScale
            // 
            this.menuLaboratory1ComponentGrayScale.Name = "menuLaboratory1ComponentGrayScale";
            this.menuLaboratory1ComponentGrayScale.Size = new System.Drawing.Size(135, 22);
            this.menuLaboratory1ComponentGrayScale.Text = "GrayScale";
            this.menuLaboratory1ComponentGrayScale.Click += new System.EventHandler(this.menuLaboratory1ComponentGrayScale_Click);
            // 
            // menuLaboratory2
            // 
            this.menuLaboratory2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLaboratory2ComponentContrast,
            this.menuLaboratory2ComponentNoise,
            this.menuLaboratory2ComponentSubstraction,
            this.menuLaboratory2ComponentHistograms});
            this.menuLaboratory2.Name = "menuLaboratory2";
            this.menuLaboratory2.Size = new System.Drawing.Size(99, 21);
            this.menuLaboratory2.Text = "Laboratory 2";
            // 
            // menuLaboratory2ComponentContrast
            // 
            this.menuLaboratory2ComponentContrast.Name = "menuLaboratory2ComponentContrast";
            this.menuLaboratory2ComponentContrast.Size = new System.Drawing.Size(153, 22);
            this.menuLaboratory2ComponentContrast.Text = "Contrast";
            this.menuLaboratory2ComponentContrast.Click += new System.EventHandler(this.menuLaboratory2ComponentContrast_Click);
            // 
            // menuLaboratory2ComponentNoise
            // 
            this.menuLaboratory2ComponentNoise.Name = "menuLaboratory2ComponentNoise";
            this.menuLaboratory2ComponentNoise.Size = new System.Drawing.Size(153, 22);
            this.menuLaboratory2ComponentNoise.Text = "Noise";
            this.menuLaboratory2ComponentNoise.Click += new System.EventHandler(this.menuLaboratory2ComponentNoise_Click);
            // 
            // menuLaboratory2ComponentSubstraction
            // 
            this.menuLaboratory2ComponentSubstraction.Name = "menuLaboratory2ComponentSubstraction";
            this.menuLaboratory2ComponentSubstraction.Size = new System.Drawing.Size(153, 22);
            this.menuLaboratory2ComponentSubstraction.Text = "Substraction";
            this.menuLaboratory2ComponentSubstraction.Click += new System.EventHandler(this.menuLaboratory2ComponentSubstraction_Click);
            // 
            // menuLaboratory2ComponentHistograms
            // 
            this.menuLaboratory2ComponentHistograms.Name = "menuLaboratory2ComponentHistograms";
            this.menuLaboratory2ComponentHistograms.Size = new System.Drawing.Size(153, 22);
            this.menuLaboratory2ComponentHistograms.Text = "Histograms";
            this.menuLaboratory2ComponentHistograms.Click += new System.EventHandler(this.menuLaboratory2ComponentHistograms_Click);
            // 
            // menuLaboratory3
            // 
            this.menuLaboratory3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLaboratory3ComponentDirectionalFiltering,
            this.menuLaboratory3ComponentOutlineEnhancement,
            this.menuLaboratory3ComponentContrastReversing,
            this.menuLaboratory3ComponentBiomedicalImageEnhancement});
            this.menuLaboratory3.Name = "menuLaboratory3";
            this.menuLaboratory3.Size = new System.Drawing.Size(99, 21);
            this.menuLaboratory3.Text = "Laboratory 3";
            // 
            // menuLaboratory3ComponentDirectionalFiltering
            // 
            this.menuLaboratory3ComponentDirectionalFiltering.Name = "menuLaboratory3ComponentDirectionalFiltering";
            this.menuLaboratory3ComponentDirectionalFiltering.Size = new System.Drawing.Size(273, 22);
            this.menuLaboratory3ComponentDirectionalFiltering.Text = "Directional Filtering";
            this.menuLaboratory3ComponentDirectionalFiltering.Click += new System.EventHandler(this.menuLaboratory3ComponentDirectionalFiltering_Click);
            // 
            // menuLaboratory3ComponentOutlineEnhancement
            // 
            this.menuLaboratory3ComponentOutlineEnhancement.Name = "menuLaboratory3ComponentOutlineEnhancement";
            this.menuLaboratory3ComponentOutlineEnhancement.Size = new System.Drawing.Size(273, 22);
            this.menuLaboratory3ComponentOutlineEnhancement.Text = "Outline Enhancement";
            this.menuLaboratory3ComponentOutlineEnhancement.Click += new System.EventHandler(this.menuLaboratory3ComponentOutlineEnhancement_Click);
            // 
            // menuLaboratory3ComponentContrastReversing
            // 
            this.menuLaboratory3ComponentContrastReversing.Name = "menuLaboratory3ComponentContrastReversing";
            this.menuLaboratory3ComponentContrastReversing.Size = new System.Drawing.Size(273, 22);
            this.menuLaboratory3ComponentContrastReversing.Text = "Contrast Reversing ";
            this.menuLaboratory3ComponentContrastReversing.Click += new System.EventHandler(this.menuLaboratory3ComponentContrastReversing_Click);
            // 
            // menuLaboratory3ComponentBiomedicalImageEnhancement
            // 
            this.menuLaboratory3ComponentBiomedicalImageEnhancement.Name = "menuLaboratory3ComponentBiomedicalImageEnhancement";
            this.menuLaboratory3ComponentBiomedicalImageEnhancement.Size = new System.Drawing.Size(273, 22);
            this.menuLaboratory3ComponentBiomedicalImageEnhancement.Text = "Biomedical Image Enhancement";
            this.menuLaboratory3ComponentBiomedicalImageEnhancement.Click += new System.EventHandler(this.menuLaboratory3ComponentBiomedicalImageEnhancement_Click);
            // 
            // menuLaboratory4
            // 
            this.menuLaboratory4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLaboratory4ComponentOutline});
            this.menuLaboratory4.Name = "menuLaboratory4";
            this.menuLaboratory4.Size = new System.Drawing.Size(99, 21);
            this.menuLaboratory4.Text = "Laboratory 4";
            // 
            // menuLaboratory4ComponentOutline
            // 
            this.menuLaboratory4ComponentOutline.Name = "menuLaboratory4ComponentOutline";
            this.menuLaboratory4ComponentOutline.Size = new System.Drawing.Size(122, 22);
            this.menuLaboratory4ComponentOutline.Text = "Outline";
            this.menuLaboratory4ComponentOutline.Click += new System.EventHandler(this.menuLaboratory4ComponentOutline_Click);
            // 
            // menuLaboratory5
            // 
            this.menuLaboratory5.Name = "menuLaboratory5";
            this.menuLaboratory5.Size = new System.Drawing.Size(99, 21);
            this.menuLaboratory5.Text = "Laboratory 5";
            // 
            // picOrriginal
            // 
            this.picOrriginal.BackColor = System.Drawing.Color.LightGray;
            this.picOrriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picOrriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOrriginal.Location = new System.Drawing.Point(12, 62);
            this.picOrriginal.Name = "picOrriginal";
            this.picOrriginal.Size = new System.Drawing.Size(600, 337);
            this.picOrriginal.TabIndex = 1;
            this.picOrriginal.TabStop = false;
            // 
            // lblOriginalImage
            // 
            this.lblOriginalImage.AutoSize = true;
            this.lblOriginalImage.BackColor = System.Drawing.Color.Transparent;
            this.lblOriginalImage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalImage.ForeColor = System.Drawing.Color.Black;
            this.lblOriginalImage.Location = new System.Drawing.Point(257, 29);
            this.lblOriginalImage.Name = "lblOriginalImage";
            this.lblOriginalImage.Size = new System.Drawing.Size(92, 30);
            this.lblOriginalImage.TabIndex = 3;
            this.lblOriginalImage.Text = "Original";
            // 
            // lblTransformedImage
            // 
            this.lblTransformedImage.AutoSize = true;
            this.lblTransformedImage.BackColor = System.Drawing.Color.Transparent;
            this.lblTransformedImage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransformedImage.ForeColor = System.Drawing.Color.Black;
            this.lblTransformedImage.Location = new System.Drawing.Point(867, 29);
            this.lblTransformedImage.Name = "lblTransformedImage";
            this.lblTransformedImage.Size = new System.Drawing.Size(136, 30);
            this.lblTransformedImage.TabIndex = 4;
            this.lblTransformedImage.Text = "Transformed";
            // 
            // picTransformed
            // 
            this.picTransformed.BackColor = System.Drawing.Color.LightGray;
            this.picTransformed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTransformed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTransformed.Location = new System.Drawing.Point(622, 62);
            this.picTransformed.Name = "picTransformed";
            this.picTransformed.Size = new System.Drawing.Size(600, 337);
            this.picTransformed.TabIndex = 5;
            this.picTransformed.TabStop = false;
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.Transparent;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwap.Location = new System.Drawing.Point(1090, 402);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(132, 37);
            this.btnSwap.TabIndex = 6;
            this.btnSwap.Text = "-> Swap <-";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // panelContrast
            // 
            this.panelContrast.BackColor = System.Drawing.Color.Navy;
            this.panelContrast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContrast.Controls.Add(this.btnCloseContrastPanel);
            this.panelContrast.Controls.Add(this.lblTrackValue);
            this.panelContrast.Controls.Add(this.lblTrackContrastCurrentValue);
            this.panelContrast.Controls.Add(this.lblTrackContrast9);
            this.panelContrast.Controls.Add(this.lblTrackContrast8);
            this.panelContrast.Controls.Add(this.lblTrackContrast7);
            this.panelContrast.Controls.Add(this.lblTrackContrast6);
            this.panelContrast.Controls.Add(this.lblTrackContrast5);
            this.panelContrast.Controls.Add(this.lblTrackContrast4);
            this.panelContrast.Controls.Add(this.lblTrackContrast3);
            this.panelContrast.Controls.Add(this.lblTrackContrast2);
            this.panelContrast.Controls.Add(this.lblTrackContrast10);
            this.panelContrast.Controls.Add(this.lblTrackContrast0);
            this.panelContrast.Controls.Add(this.lblTrackContrast1);
            this.panelContrast.Controls.Add(this.trackContrast);
            this.panelContrast.Location = new System.Drawing.Point(12, 426);
            this.panelContrast.Name = "panelContrast";
            this.panelContrast.Size = new System.Drawing.Size(300, 87);
            this.panelContrast.TabIndex = 7;
            this.panelContrast.Visible = false;
            // 
            // btnCloseContrastPanel
            // 
            this.btnCloseContrastPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseContrastPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseContrastPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseContrastPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseContrastPanel.Location = new System.Drawing.Point(201, 60);
            this.btnCloseContrastPanel.Name = "btnCloseContrastPanel";
            this.btnCloseContrastPanel.Size = new System.Drawing.Size(93, 21);
            this.btnCloseContrastPanel.TabIndex = 24;
            this.btnCloseContrastPanel.Text = "Close Panel";
            this.btnCloseContrastPanel.UseVisualStyleBackColor = false;
            this.btnCloseContrastPanel.Click += new System.EventHandler(this.btnCloseContrastPanel_Click);
            // 
            // lblTrackValue
            // 
            this.lblTrackValue.AutoSize = true;
            this.lblTrackValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackValue.Location = new System.Drawing.Point(104, 61);
            this.lblTrackValue.Name = "lblTrackValue";
            this.lblTrackValue.Size = new System.Drawing.Size(15, 17);
            this.lblTrackValue.TabIndex = 20;
            this.lblTrackValue.Text = "0";
            // 
            // lblTrackContrastCurrentValue
            // 
            this.lblTrackContrastCurrentValue.AutoSize = true;
            this.lblTrackContrastCurrentValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrastCurrentValue.Location = new System.Drawing.Point(9, 60);
            this.lblTrackContrastCurrentValue.Name = "lblTrackContrastCurrentValue";
            this.lblTrackContrastCurrentValue.Size = new System.Drawing.Size(95, 17);
            this.lblTrackContrastCurrentValue.TabIndex = 19;
            this.lblTrackContrastCurrentValue.Text = "Current value:";
            // 
            // lblTrackContrast9
            // 
            this.lblTrackContrast9.AutoSize = true;
            this.lblTrackContrast9.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast9.Location = new System.Drawing.Point(246, 28);
            this.lblTrackContrast9.Name = "lblTrackContrast9";
            this.lblTrackContrast9.Size = new System.Drawing.Size(22, 17);
            this.lblTrackContrast9.TabIndex = 18;
            this.lblTrackContrast9.Text = "80";
            // 
            // lblTrackContrast8
            // 
            this.lblTrackContrast8.AutoSize = true;
            this.lblTrackContrast8.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast8.Location = new System.Drawing.Point(220, 28);
            this.lblTrackContrast8.Name = "lblTrackContrast8";
            this.lblTrackContrast8.Size = new System.Drawing.Size(22, 17);
            this.lblTrackContrast8.TabIndex = 17;
            this.lblTrackContrast8.Text = "60";
            // 
            // lblTrackContrast7
            // 
            this.lblTrackContrast7.AutoSize = true;
            this.lblTrackContrast7.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast7.Location = new System.Drawing.Point(193, 28);
            this.lblTrackContrast7.Name = "lblTrackContrast7";
            this.lblTrackContrast7.Size = new System.Drawing.Size(22, 17);
            this.lblTrackContrast7.TabIndex = 16;
            this.lblTrackContrast7.Text = "40";
            // 
            // lblTrackContrast6
            // 
            this.lblTrackContrast6.AutoSize = true;
            this.lblTrackContrast6.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast6.Location = new System.Drawing.Point(166, 28);
            this.lblTrackContrast6.Name = "lblTrackContrast6";
            this.lblTrackContrast6.Size = new System.Drawing.Size(22, 17);
            this.lblTrackContrast6.TabIndex = 15;
            this.lblTrackContrast6.Text = "20";
            // 
            // lblTrackContrast5
            // 
            this.lblTrackContrast5.AutoSize = true;
            this.lblTrackContrast5.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast5.Location = new System.Drawing.Point(144, 28);
            this.lblTrackContrast5.Name = "lblTrackContrast5";
            this.lblTrackContrast5.Size = new System.Drawing.Size(15, 17);
            this.lblTrackContrast5.TabIndex = 14;
            this.lblTrackContrast5.Text = "0";
            // 
            // lblTrackContrast4
            // 
            this.lblTrackContrast4.AutoSize = true;
            this.lblTrackContrast4.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast4.Location = new System.Drawing.Point(108, 28);
            this.lblTrackContrast4.Name = "lblTrackContrast4";
            this.lblTrackContrast4.Size = new System.Drawing.Size(27, 17);
            this.lblTrackContrast4.TabIndex = 13;
            this.lblTrackContrast4.Text = "-20";
            // 
            // lblTrackContrast3
            // 
            this.lblTrackContrast3.AutoSize = true;
            this.lblTrackContrast3.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast3.Location = new System.Drawing.Point(81, 28);
            this.lblTrackContrast3.Name = "lblTrackContrast3";
            this.lblTrackContrast3.Size = new System.Drawing.Size(27, 17);
            this.lblTrackContrast3.TabIndex = 12;
            this.lblTrackContrast3.Text = "-40";
            // 
            // lblTrackContrast2
            // 
            this.lblTrackContrast2.AutoSize = true;
            this.lblTrackContrast2.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast2.Location = new System.Drawing.Point(54, 28);
            this.lblTrackContrast2.Name = "lblTrackContrast2";
            this.lblTrackContrast2.Size = new System.Drawing.Size(27, 17);
            this.lblTrackContrast2.TabIndex = 11;
            this.lblTrackContrast2.Text = "-60";
            // 
            // lblTrackContrast10
            // 
            this.lblTrackContrast10.AutoSize = true;
            this.lblTrackContrast10.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast10.Location = new System.Drawing.Point(269, 28);
            this.lblTrackContrast10.Name = "lblTrackContrast10";
            this.lblTrackContrast10.Size = new System.Drawing.Size(29, 17);
            this.lblTrackContrast10.TabIndex = 9;
            this.lblTrackContrast10.Text = "100";
            // 
            // lblTrackContrast0
            // 
            this.lblTrackContrast0.AutoSize = true;
            this.lblTrackContrast0.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast0.Location = new System.Drawing.Point(-3, 28);
            this.lblTrackContrast0.Name = "lblTrackContrast0";
            this.lblTrackContrast0.Size = new System.Drawing.Size(34, 17);
            this.lblTrackContrast0.TabIndex = 8;
            this.lblTrackContrast0.Text = "-100";
            // 
            // lblTrackContrast1
            // 
            this.lblTrackContrast1.AutoSize = true;
            this.lblTrackContrast1.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackContrast1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackContrast1.Location = new System.Drawing.Point(28, 28);
            this.lblTrackContrast1.Name = "lblTrackContrast1";
            this.lblTrackContrast1.Size = new System.Drawing.Size(27, 17);
            this.lblTrackContrast1.TabIndex = 10;
            this.lblTrackContrast1.Text = "-80";
            // 
            // trackContrast
            // 
            this.trackContrast.BackColor = System.Drawing.Color.Navy;
            this.trackContrast.Location = new System.Drawing.Point(3, 3);
            this.trackContrast.Maximum = 100;
            this.trackContrast.Minimum = -100;
            this.trackContrast.Name = "trackContrast";
            this.trackContrast.Size = new System.Drawing.Size(294, 45);
            this.trackContrast.TabIndex = 0;
            this.trackContrast.TickFrequency = 20;
            this.trackContrast.Scroll += new System.EventHandler(this.trackContrast_Scroll);
            // 
            // lblCurrentPanelTitle
            // 
            this.lblCurrentPanelTitle.AutoSize = true;
            this.lblCurrentPanelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPanelTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPanelTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentPanelTitle.Location = new System.Drawing.Point(13, 402);
            this.lblCurrentPanelTitle.Name = "lblCurrentPanelTitle";
            this.lblCurrentPanelTitle.Size = new System.Drawing.Size(96, 17);
            this.lblCurrentPanelTitle.TabIndex = 21;
            this.lblCurrentPanelTitle.Text = "Current panel:";
            // 
            // lblCurrentPanel
            // 
            this.lblCurrentPanel.AutoSize = true;
            this.lblCurrentPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPanel.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentPanel.Location = new System.Drawing.Point(110, 402);
            this.lblCurrentPanel.Name = "lblCurrentPanel";
            this.lblCurrentPanel.Size = new System.Drawing.Size(41, 17);
            this.lblCurrentPanel.TabIndex = 22;
            this.lblCurrentPanel.Text = "None";
            // 
            // picMainMenuBorder
            // 
            this.picMainMenuBorder.BackColor = System.Drawing.Color.Black;
            this.picMainMenuBorder.Location = new System.Drawing.Point(0, 22);
            this.picMainMenuBorder.Name = "picMainMenuBorder";
            this.picMainMenuBorder.Size = new System.Drawing.Size(1250, 5);
            this.picMainMenuBorder.TabIndex = 23;
            this.picMainMenuBorder.TabStop = false;
            // 
            // panelNoise
            // 
            this.panelNoise.BackColor = System.Drawing.Color.Navy;
            this.panelNoise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoise.Controls.Add(this.label1);
            this.panelNoise.Controls.Add(this.label2);
            this.panelNoise.Controls.Add(this.label3);
            this.panelNoise.Controls.Add(this.label4);
            this.panelNoise.Controls.Add(this.label5);
            this.panelNoise.Controls.Add(this.label6);
            this.panelNoise.Controls.Add(this.lblTrackValueB);
            this.panelNoise.Controls.Add(this.lblTrackNoiseCurrentValueB);
            this.panelNoise.Controls.Add(this.trackNoiseB);
            this.panelNoise.Controls.Add(this.btnClosePanelNoise);
            this.panelNoise.Controls.Add(this.lblTrackValueA);
            this.panelNoise.Controls.Add(this.lblTrackNoiseCurrentValueA);
            this.panelNoise.Controls.Add(this.label7);
            this.panelNoise.Controls.Add(this.label8);
            this.panelNoise.Controls.Add(this.label9);
            this.panelNoise.Controls.Add(this.label10);
            this.panelNoise.Controls.Add(this.label12);
            this.panelNoise.Controls.Add(this.label13);
            this.panelNoise.Controls.Add(this.trackNoiseA);
            this.panelNoise.Controls.Add(this.label28);
            this.panelNoise.Controls.Add(this.label27);
            this.panelNoise.Location = new System.Drawing.Point(12, 426);
            this.panelNoise.Name = "panelNoise";
            this.panelNoise.Size = new System.Drawing.Size(659, 87);
            this.panelNoise.TabIndex = 25;
            this.panelNoise.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "255";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "204";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "153";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "102";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "51";
            // 
            // lblTrackValueB
            // 
            this.lblTrackValueB.AutoSize = true;
            this.lblTrackValueB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackValueB.Location = new System.Drawing.Point(427, 61);
            this.lblTrackValueB.Name = "lblTrackValueB";
            this.lblTrackValueB.Size = new System.Drawing.Size(15, 17);
            this.lblTrackValueB.TabIndex = 38;
            this.lblTrackValueB.Text = "0";
            // 
            // lblTrackNoiseCurrentValueB
            // 
            this.lblTrackNoiseCurrentValueB.AutoSize = true;
            this.lblTrackNoiseCurrentValueB.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackNoiseCurrentValueB.Location = new System.Drawing.Point(332, 60);
            this.lblTrackNoiseCurrentValueB.Name = "lblTrackNoiseCurrentValueB";
            this.lblTrackNoiseCurrentValueB.Size = new System.Drawing.Size(95, 17);
            this.lblTrackNoiseCurrentValueB.TabIndex = 37;
            this.lblTrackNoiseCurrentValueB.Text = "Current value:";
            // 
            // trackNoiseB
            // 
            this.trackNoiseB.BackColor = System.Drawing.Color.Navy;
            this.trackNoiseB.Location = new System.Drawing.Point(359, 3);
            this.trackNoiseB.Maximum = 255;
            this.trackNoiseB.Name = "trackNoiseB";
            this.trackNoiseB.Size = new System.Drawing.Size(294, 45);
            this.trackNoiseB.TabIndex = 25;
            this.trackNoiseB.TickFrequency = 51;
            this.trackNoiseB.Scroll += new System.EventHandler(this.trackNoiseB_Scroll);
            // 
            // btnClosePanelNoise
            // 
            this.btnClosePanelNoise.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePanelNoise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePanelNoise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePanelNoise.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanelNoise.Location = new System.Drawing.Point(560, 60);
            this.btnClosePanelNoise.Name = "btnClosePanelNoise";
            this.btnClosePanelNoise.Size = new System.Drawing.Size(93, 21);
            this.btnClosePanelNoise.TabIndex = 24;
            this.btnClosePanelNoise.Text = "Close Panel";
            this.btnClosePanelNoise.UseVisualStyleBackColor = false;
            this.btnClosePanelNoise.Click += new System.EventHandler(this.btnClosePanelNoise_Click);
            // 
            // lblTrackValueA
            // 
            this.lblTrackValueA.AutoSize = true;
            this.lblTrackValueA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackValueA.Location = new System.Drawing.Point(102, 62);
            this.lblTrackValueA.Name = "lblTrackValueA";
            this.lblTrackValueA.Size = new System.Drawing.Size(15, 17);
            this.lblTrackValueA.TabIndex = 20;
            this.lblTrackValueA.Text = "0";
            // 
            // lblTrackNoiseCurrentValueA
            // 
            this.lblTrackNoiseCurrentValueA.AutoSize = true;
            this.lblTrackNoiseCurrentValueA.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackNoiseCurrentValueA.Location = new System.Drawing.Point(7, 61);
            this.lblTrackNoiseCurrentValueA.Name = "lblTrackNoiseCurrentValueA";
            this.lblTrackNoiseCurrentValueA.Size = new System.Drawing.Size(95, 17);
            this.lblTrackNoiseCurrentValueA.TabIndex = 19;
            this.lblTrackNoiseCurrentValueA.Text = "Current value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "204";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(192, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "153";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(140, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "102";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(88, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "51";
            // 
            // trackNoiseA
            // 
            this.trackNoiseA.BackColor = System.Drawing.Color.Navy;
            this.trackNoiseA.Location = new System.Drawing.Point(32, 4);
            this.trackNoiseA.Maximum = 255;
            this.trackNoiseA.Name = "trackNoiseA";
            this.trackNoiseA.Size = new System.Drawing.Size(294, 45);
            this.trackNoiseA.TabIndex = 0;
            this.trackNoiseA.TickFrequency = 51;
            this.trackNoiseA.Scroll += new System.EventHandler(this.trackNoiseA_Scroll);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(337, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 17);
            this.label28.TabIndex = 40;
            this.label28.Text = "B = ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(7, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 17);
            this.label27.TabIndex = 39;
            this.label27.Text = "A = ";
            // 
            // panelSubstraction
            // 
            this.panelSubstraction.BackColor = System.Drawing.Color.Navy;
            this.panelSubstraction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubstraction.Controls.Add(this.btnSubstract);
            this.panelSubstraction.Controls.Add(this.btnLoadSecondOriginalImage);
            this.panelSubstraction.Controls.Add(this.btnSwitch);
            this.panelSubstraction.Controls.Add(this.btnClosePanelSubstraction);
            this.panelSubstraction.Location = new System.Drawing.Point(12, 426);
            this.panelSubstraction.Name = "panelSubstraction";
            this.panelSubstraction.Size = new System.Drawing.Size(282, 87);
            this.panelSubstraction.TabIndex = 47;
            this.panelSubstraction.Visible = false;
            // 
            // btnSubstract
            // 
            this.btnSubstract.BackColor = System.Drawing.Color.Transparent;
            this.btnSubstract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubstract.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.Location = new System.Drawing.Point(137, 8);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(134, 31);
            this.btnSubstract.TabIndex = 27;
            this.btnSubstract.Text = "Substract";
            this.btnSubstract.UseVisualStyleBackColor = false;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnLoadSecondOriginalImage
            // 
            this.btnLoadSecondOriginalImage.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadSecondOriginalImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadSecondOriginalImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSecondOriginalImage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSecondOriginalImage.Location = new System.Drawing.Point(9, 45);
            this.btnLoadSecondOriginalImage.Name = "btnLoadSecondOriginalImage";
            this.btnLoadSecondOriginalImage.Size = new System.Drawing.Size(172, 31);
            this.btnLoadSecondOriginalImage.TabIndex = 26;
            this.btnLoadSecondOriginalImage.Text = "Load second Original Image";
            this.btnLoadSecondOriginalImage.UseVisualStyleBackColor = false;
            this.btnLoadSecondOriginalImage.Click += new System.EventHandler(this.btnLoadSecondOrriginalImage_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwitch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(9, 8);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(122, 31);
            this.btnSwitch.TabIndex = 25;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnClosePanelSubstraction
            // 
            this.btnClosePanelSubstraction.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePanelSubstraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePanelSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePanelSubstraction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanelSubstraction.Location = new System.Drawing.Point(187, 45);
            this.btnClosePanelSubstraction.Name = "btnClosePanelSubstraction";
            this.btnClosePanelSubstraction.Size = new System.Drawing.Size(84, 31);
            this.btnClosePanelSubstraction.TabIndex = 24;
            this.btnClosePanelSubstraction.Text = "Close Panel";
            this.btnClosePanelSubstraction.UseVisualStyleBackColor = false;
            this.btnClosePanelSubstraction.Click += new System.EventHandler(this.btnClosePanelSubstraction_Click);
            // 
            // panelBio
            // 
            this.panelBio.BackColor = System.Drawing.Color.Navy;
            this.panelBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBio.Controls.Add(this.btnBioApply);
            this.panelBio.Controls.Add(this.txtBioMask22);
            this.panelBio.Controls.Add(this.txtBioMask21);
            this.panelBio.Controls.Add(this.txtBioMask20);
            this.panelBio.Controls.Add(this.txtBioMask12);
            this.panelBio.Controls.Add(this.txtBioMask11);
            this.panelBio.Controls.Add(this.txtBioMask10);
            this.panelBio.Controls.Add(this.txtBioMask02);
            this.panelBio.Controls.Add(this.txtBioMask01);
            this.panelBio.Controls.Add(this.txtBioMask00);
            this.panelBio.Controls.Add(this.btnClosePanelBio);
            this.panelBio.Location = new System.Drawing.Point(12, 426);
            this.panelBio.Name = "panelBio";
            this.panelBio.Size = new System.Drawing.Size(182, 87);
            this.panelBio.TabIndex = 48;
            this.panelBio.Visible = false;
            // 
            // btnBioApply
            // 
            this.btnBioApply.BackColor = System.Drawing.Color.Transparent;
            this.btnBioApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBioApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBioApply.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBioApply.Location = new System.Drawing.Point(88, 9);
            this.btnBioApply.Name = "btnBioApply";
            this.btnBioApply.Size = new System.Drawing.Size(84, 31);
            this.btnBioApply.TabIndex = 34;
            this.btnBioApply.Text = "Apply";
            this.btnBioApply.UseVisualStyleBackColor = false;
            this.btnBioApply.Click += new System.EventHandler(this.btnBioApply_Click);
            // 
            // txtBioMask22
            // 
            this.txtBioMask22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask22.Location = new System.Drawing.Point(60, 58);
            this.txtBioMask22.Name = "txtBioMask22";
            this.txtBioMask22.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask22.TabIndex = 33;
            this.txtBioMask22.Text = "0";
            // 
            // txtBioMask21
            // 
            this.txtBioMask21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask21.Location = new System.Drawing.Point(32, 58);
            this.txtBioMask21.Name = "txtBioMask21";
            this.txtBioMask21.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask21.TabIndex = 32;
            this.txtBioMask21.Text = "0";
            // 
            // txtBioMask20
            // 
            this.txtBioMask20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask20.Location = new System.Drawing.Point(4, 58);
            this.txtBioMask20.Name = "txtBioMask20";
            this.txtBioMask20.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask20.TabIndex = 31;
            this.txtBioMask20.Text = "0";
            // 
            // txtBioMask12
            // 
            this.txtBioMask12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask12.Location = new System.Drawing.Point(60, 31);
            this.txtBioMask12.Name = "txtBioMask12";
            this.txtBioMask12.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask12.TabIndex = 30;
            this.txtBioMask12.Text = "0";
            // 
            // txtBioMask11
            // 
            this.txtBioMask11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask11.Location = new System.Drawing.Point(32, 31);
            this.txtBioMask11.Name = "txtBioMask11";
            this.txtBioMask11.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask11.TabIndex = 29;
            this.txtBioMask11.Text = "0";
            // 
            // txtBioMask10
            // 
            this.txtBioMask10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask10.Location = new System.Drawing.Point(4, 31);
            this.txtBioMask10.Name = "txtBioMask10";
            this.txtBioMask10.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask10.TabIndex = 28;
            this.txtBioMask10.Text = "0";
            // 
            // txtBioMask02
            // 
            this.txtBioMask02.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask02.Location = new System.Drawing.Point(60, 2);
            this.txtBioMask02.Name = "txtBioMask02";
            this.txtBioMask02.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask02.TabIndex = 27;
            this.txtBioMask02.Text = "0";
            // 
            // txtBioMask01
            // 
            this.txtBioMask01.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask01.Location = new System.Drawing.Point(32, 2);
            this.txtBioMask01.Name = "txtBioMask01";
            this.txtBioMask01.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask01.TabIndex = 26;
            this.txtBioMask01.Text = "0";
            // 
            // txtBioMask00
            // 
            this.txtBioMask00.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBioMask00.Location = new System.Drawing.Point(4, 2);
            this.txtBioMask00.Name = "txtBioMask00";
            this.txtBioMask00.Size = new System.Drawing.Size(22, 23);
            this.txtBioMask00.TabIndex = 25;
            this.txtBioMask00.Text = "0";
            // 
            // btnClosePanelBio
            // 
            this.btnClosePanelBio.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePanelBio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePanelBio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePanelBio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanelBio.Location = new System.Drawing.Point(88, 47);
            this.btnClosePanelBio.Name = "btnClosePanelBio";
            this.btnClosePanelBio.Size = new System.Drawing.Size(84, 31);
            this.btnClosePanelBio.TabIndex = 24;
            this.btnClosePanelBio.Text = "Close Panel";
            this.btnClosePanelBio.UseVisualStyleBackColor = false;
            this.btnClosePanelBio.Click += new System.EventHandler(this.btnClosePanelBio_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::ImageTrans.Properties.Resources.blue_wallpaper_7;
            this.ClientSize = new System.Drawing.Size(1234, 525);
            this.Controls.Add(this.panelBio);
            this.Controls.Add(this.panelSubstraction);
            this.Controls.Add(this.panelNoise);
            this.Controls.Add(this.lblCurrentPanel);
            this.Controls.Add(this.lblCurrentPanelTitle);
            this.Controls.Add(this.panelContrast);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.picTransformed);
            this.Controls.Add(this.picOrriginal);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.lblOriginalImage);
            this.Controls.Add(this.lblTransformedImage);
            this.Controls.Add(this.picMainMenuBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Transformation";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransformed)).EndInit();
            this.panelContrast.ResumeLayout(false);
            this.panelContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuBorder)).EndInit();
            this.panelNoise.ResumeLayout(false);
            this.panelNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackNoiseB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNoiseA)).EndInit();
            this.panelSubstraction.ResumeLayout(false);
            this.panelBio.ResumeLayout(false);
            this.panelBio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileComponentLoad;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory1;
        private System.Windows.Forms.PictureBox picOrriginal;
        private System.Windows.Forms.Label lblOriginalImage;
        private System.Windows.Forms.Label lblTransformedImage;
        private System.Windows.Forms.PictureBox picTransformed;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory1ComponentGrayScale;
        private System.Windows.Forms.ToolStripMenuItem menuFileComponentSave;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Panel panelContrast;
        private System.Windows.Forms.Label lblTrackValue;
        private System.Windows.Forms.Label lblTrackContrastCurrentValue;
        private System.Windows.Forms.Label lblTrackContrast9;
        private System.Windows.Forms.Label lblTrackContrast8;
        private System.Windows.Forms.Label lblTrackContrast7;
        private System.Windows.Forms.Label lblTrackContrast6;
        private System.Windows.Forms.Label lblTrackContrast5;
        private System.Windows.Forms.Label lblTrackContrast4;
        private System.Windows.Forms.Label lblTrackContrast3;
        private System.Windows.Forms.Label lblTrackContrast2;
        private System.Windows.Forms.Label lblTrackContrast10;
        private System.Windows.Forms.Label lblTrackContrast0;
        private System.Windows.Forms.Label lblTrackContrast1;
        private System.Windows.Forms.TrackBar trackContrast;
        private System.Windows.Forms.Label lblCurrentPanelTitle;
        private System.Windows.Forms.Label lblCurrentPanel;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory2;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory3;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory4;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory5;
        private System.Windows.Forms.PictureBox picMainMenuBorder;
        private System.Windows.Forms.Button btnCloseContrastPanel;
        private System.Windows.Forms.Panel panelNoise;
        private System.Windows.Forms.Label lblTrackValueB;
        private System.Windows.Forms.Label lblTrackNoiseCurrentValueB;
        private System.Windows.Forms.TrackBar trackNoiseB;
        private System.Windows.Forms.Button btnClosePanelNoise;
        private System.Windows.Forms.Label lblTrackValueA;
        private System.Windows.Forms.Label lblTrackNoiseCurrentValueA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackNoiseA;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelSubstraction;
        private System.Windows.Forms.Button btnClosePanelSubstraction;
        private System.Windows.Forms.Button btnLoadSecondOriginalImage;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Panel panelBio;
        private System.Windows.Forms.Button btnBioApply;
        private System.Windows.Forms.TextBox txtBioMask22;
        private System.Windows.Forms.TextBox txtBioMask21;
        private System.Windows.Forms.TextBox txtBioMask20;
        private System.Windows.Forms.TextBox txtBioMask12;
        private System.Windows.Forms.TextBox txtBioMask11;
        private System.Windows.Forms.TextBox txtBioMask10;
        private System.Windows.Forms.TextBox txtBioMask02;
        private System.Windows.Forms.TextBox txtBioMask01;
        private System.Windows.Forms.TextBox txtBioMask00;
        private System.Windows.Forms.Button btnClosePanelBio;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory2ComponentContrast;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory2ComponentNoise;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory2ComponentSubstraction;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory2ComponentHistograms;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory3ComponentDirectionalFiltering;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory3ComponentOutlineEnhancement;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory3ComponentContrastReversing;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory3ComponentBiomedicalImageEnhancement;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratory4ComponentOutline;
    }
}

