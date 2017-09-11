namespace B64ToImage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnklblLoadFile = new System.Windows.Forms.LinkLabel();
            this.RtxbxString = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFrom64 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveImageToFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbResourceUrl = new System.Windows.Forms.Label();
            this.tbResourceUrl = new System.Windows.Forms.TextBox();
            this.pictureBoxTo64 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbEncodedString = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPathOfFile = new System.Windows.Forms.TextBox();
            this.lbResourceFile = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_String_ = new System.Windows.Forms.RichTextBox();
            this.button_encode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.button_Decode = new System.Windows.Forms.Button();
            this.richTextBox_Base64 = new System.Windows.Forms.RichTextBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnResourceUrlLoad = new System.Windows.Forms.Button();
            this.btnLoadFromClipboard = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrom64)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTo64)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lnklblLoadFile);
            this.groupBox1.Controls.Add(this.RtxbxString);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(745, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String";
            // 
            // lnklblLoadFile
            // 
            this.lnklblLoadFile.AutoSize = true;
            this.lnklblLoadFile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLoadFile.Location = new System.Drawing.Point(620, 96);
            this.lnklblLoadFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblLoadFile.Name = "lnklblLoadFile";
            this.lnklblLoadFile.Size = new System.Drawing.Size(125, 14);
            this.lnklblLoadFile.TabIndex = 1;
            this.lnklblLoadFile.TabStop = true;
            this.lnklblLoadFile.Text = "Load from Text File";
            this.lnklblLoadFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLoadFile_LinkClicked);
            // 
            // RtxbxString
            // 
            this.RtxbxString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtxbxString.Location = new System.Drawing.Point(8, 24);
            this.RtxbxString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RtxbxString.Name = "RtxbxString";
            this.RtxbxString.Size = new System.Drawing.Size(708, 69);
            this.RtxbxString.TabIndex = 0;
            this.RtxbxString.Text = "";
            this.RtxbxString.TextChanged += new System.EventHandler(this.RtxbxString_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBoxFrom64);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(365, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // pictureBoxFrom64
            // 
            this.pictureBoxFrom64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFrom64.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxFrom64.Location = new System.Drawing.Point(9, 21);
            this.pictureBoxFrom64.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxFrom64.Name = "pictureBoxFrom64";
            this.pictureBoxFrom64.Size = new System.Drawing.Size(348, 215);
            this.pictureBoxFrom64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFrom64.TabIndex = 0;
            this.pictureBoxFrom64.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSaveImageToFile);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(389, 126);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(373, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // btnSaveImageToFile
            // 
            this.btnSaveImageToFile.Location = new System.Drawing.Point(149, 140);
            this.btnSaveImageToFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveImageToFile.Name = "btnSaveImageToFile";
            this.btnSaveImageToFile.Size = new System.Drawing.Size(100, 24);
            this.btnSaveImageToFile.TabIndex = 3;
            this.btnSaveImageToFile.Text = "To FIle";
            this.btnSaveImageToFile.UseVisualStyleBackColor = true;
            this.btnSaveImageToFile.Click += new System.EventHandler(this.btnSaveImageToFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Save";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "StretchImage",
            "AutoSize",
            "CenterImage",
            "Zoom"});
            this.comboBox1.Location = new System.Drawing.Point(131, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 22);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "SizeMode";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 402);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(776, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "64ToImage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.btnLoadFromClipboard);
            this.tabPage2.Controls.Add(this.btnResourceUrlLoad);
            this.tabPage2.Controls.Add(this.lbResourceUrl);
            this.tabPage2.Controls.Add(this.tbResourceUrl);
            this.tabPage2.Controls.Add(this.pictureBoxTo64);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.lbEncodedString);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tbPathOfFile);
            this.tabPage2.Controls.Add(this.lbResourceFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(776, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image2B64";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbResourceUrl
            // 
            this.lbResourceUrl.AutoSize = true;
            this.lbResourceUrl.Location = new System.Drawing.Point(24, 22);
            this.lbResourceUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResourceUrl.Name = "lbResourceUrl";
            this.lbResourceUrl.Size = new System.Drawing.Size(24, 14);
            this.lbResourceUrl.TabIndex = 8;
            this.lbResourceUrl.Text = "Url";
            // 
            // tbResourceUrl
            // 
            this.tbResourceUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResourceUrl.Location = new System.Drawing.Point(80, 19);
            this.tbResourceUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResourceUrl.Name = "tbResourceUrl";
            this.tbResourceUrl.Size = new System.Drawing.Size(540, 22);
            this.tbResourceUrl.TabIndex = 7;
            this.tbResourceUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxTo64
            // 
            this.pictureBoxTo64.Location = new System.Drawing.Point(80, 85);
            this.pictureBoxTo64.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxTo64.Name = "pictureBoxTo64";
            this.pictureBoxTo64.Size = new System.Drawing.Size(239, 93);
            this.pictureBoxTo64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTo64.TabIndex = 6;
            this.pictureBoxTo64.TabStop = false;
            this.pictureBoxTo64.Click += new System.EventHandler(this.pictureBoxTo64_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(640, 356);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 14);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Save To FIle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbEncodedString
            // 
            this.lbEncodedString.AutoSize = true;
            this.lbEncodedString.Location = new System.Drawing.Point(24, 276);
            this.lbEncodedString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEncodedString.Name = "lbEncodedString";
            this.lbEncodedString.Size = new System.Drawing.Size(44, 14);
            this.lbEncodedString.TabIndex = 4;
            this.lbEncodedString.Text = "String";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(80, 202);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(651, 151);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(631, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPathOfFile
            // 
            this.tbPathOfFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPathOfFile.Location = new System.Drawing.Point(80, 47);
            this.tbPathOfFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPathOfFile.Name = "tbPathOfFile";
            this.tbPathOfFile.Size = new System.Drawing.Size(540, 22);
            this.tbPathOfFile.TabIndex = 1;
            this.tbPathOfFile.TextChanged += new System.EventHandler(this.txbxPathOfFile_TextChanged);
            // 
            // lbResourceFile
            // 
            this.lbResourceFile.AutoSize = true;
            this.lbResourceFile.Location = new System.Drawing.Point(24, 50);
            this.lbResourceFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResourceFile.Name = "lbResourceFile";
            this.lbResourceFile.Size = new System.Drawing.Size(28, 14);
            this.lbResourceFile.TabIndex = 0;
            this.lbResourceFile.Text = "File";
            this.lbResourceFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Beige;
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(776, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Text";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.richTextBox_String_);
            this.panel2.Controls.Add(this.button_encode);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Size = new System.Drawing.Size(756, 181);
            this.panel2.TabIndex = 5;
            this.panel2.TabStop = false;
            this.panel2.Text = "Decoded";
            // 
            // richTextBox_String_
            // 
            this.richTextBox_String_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_String_.BackColor = System.Drawing.Color.White;
            this.richTextBox_String_.Location = new System.Drawing.Point(1, 21);
            this.richTextBox_String_.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox_String_.Name = "richTextBox_String_";
            this.richTextBox_String_.Size = new System.Drawing.Size(745, 125);
            this.richTextBox_String_.TabIndex = 0;
            this.richTextBox_String_.Text = "";
            // 
            // button_encode
            // 
            this.button_encode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_encode.Location = new System.Drawing.Point(4, 153);
            this.button_encode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_encode.Name = "button_encode";
            this.button_encode.Size = new System.Drawing.Size(203, 24);
            this.button_encode.TabIndex = 1;
            this.button_encode.Text = "String 2 Base64";
            this.button_encode.UseVisualStyleBackColor = true;
            this.button_encode.Click += new System.EventHandler(this.Encode_str2b64_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_Decode);
            this.panel1.Controls.Add(this.richTextBox_Base64);
            this.panel1.Location = new System.Drawing.Point(9, 210);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Size = new System.Drawing.Size(756, 157);
            this.panel1.TabIndex = 4;
            this.panel1.TabStop = false;
            this.panel1.Text = "Encoded";
            // 
            // button_Decode
            // 
            this.button_Decode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Decode.Location = new System.Drawing.Point(521, 9);
            this.button_Decode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Decode.Name = "button_Decode";
            this.button_Decode.Size = new System.Drawing.Size(227, 24);
            this.button_Decode.TabIndex = 3;
            this.button_Decode.Text = " Base64  to string";
            this.button_Decode.UseVisualStyleBackColor = true;
            this.button_Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // richTextBox_Base64
            // 
            this.richTextBox_Base64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Base64.BackColor = System.Drawing.Color.White;
            this.richTextBox_Base64.Location = new System.Drawing.Point(4, 34);
            this.richTextBox_Base64.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox_Base64.Name = "richTextBox_Base64";
            this.richTextBox_Base64.Size = new System.Drawing.Size(735, 121);
            this.richTextBox_Base64.TabIndex = 2;
            this.richTextBox_Base64.Text = "";
            // 
            // lblNot
            // 
            this.lblNot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(13, 409);
            this.lblNot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(0, 14);
            this.lblNot.TabIndex = 4;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(708, 409);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(45, 14);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Coder";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnResourceUrlLoad
            // 
            this.btnResourceUrlLoad.Location = new System.Drawing.Point(631, 18);
            this.btnResourceUrlLoad.Name = "btnResourceUrlLoad";
            this.btnResourceUrlLoad.Size = new System.Drawing.Size(100, 23);
            this.btnResourceUrlLoad.TabIndex = 9;
            this.btnResourceUrlLoad.Text = "Load";
            this.btnResourceUrlLoad.UseVisualStyleBackColor = true;
            this.btnResourceUrlLoad.Click += new System.EventHandler(this.btnResourceUrlLoad_Click);
            // 
            // btnLoadFromClipboard
            // 
            this.btnLoadFromClipboard.Location = new System.Drawing.Point(634, 81);
            this.btnLoadFromClipboard.Name = "btnLoadFromClipboard";
            this.btnLoadFromClipboard.Size = new System.Drawing.Size(96, 96);
            this.btnLoadFromClipboard.TabIndex = 10;
            this.btnLoadFromClipboard.Text = "Load From Clipboard";
            this.btnLoadFromClipboard.UseVisualStyleBackColor = true;
            this.btnLoadFromClipboard.Click += new System.EventHandler(this.btnLoadFromClipboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(797, 427);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MR Base_64 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrom64)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTo64)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel lnklblLoadFile;
        private System.Windows.Forms.RichTextBox RtxbxString;
        private System.Windows.Forms.PictureBox pictureBoxFrom64;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPathOfFile;
        private System.Windows.Forms.Label lbResourceFile;
        private System.Windows.Forms.Label lbEncodedString;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Button btnSaveImageToFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxTo64;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_Decode;
        private System.Windows.Forms.RichTextBox richTextBox_Base64;
        private System.Windows.Forms.Button button_encode;
        private System.Windows.Forms.RichTextBox richTextBox_String_;
        private System.Windows.Forms.GroupBox panel2;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lbResourceUrl;
        private System.Windows.Forms.TextBox tbResourceUrl;
        private System.Windows.Forms.Button btnResourceUrlLoad;
        private System.Windows.Forms.Button btnLoadFromClipboard;
    }
}

