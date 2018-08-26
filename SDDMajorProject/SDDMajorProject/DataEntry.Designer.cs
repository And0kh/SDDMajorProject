namespace SDDMajorProject
{
    partial class MainForm
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
            this.pnlAthltcs = new System.Windows.Forms.Panel();
            this.lblTm = new System.Windows.Forms.Label();
            this.nmrcUpDnAtmpt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBxAthltcsEvnts = new System.Windows.Forms.ComboBox();
            this.lblEvnt = new System.Windows.Forms.Label();
            this.cmboBxAge = new System.Windows.Forms.ComboBox();
            this.lblSdntAge = new System.Windows.Forms.Label();
            this.txtBxSdntName = new System.Windows.Forms.TextBox();
            this.lblSdntName = new System.Windows.Forms.Label();
            this.pnlEvnt = new System.Windows.Forms.Panel();
            this.btnCnfm = new System.Windows.Forms.Button();
            this.txtBxOthr = new System.Windows.Forms.TextBox();
            this.cmboBxEvnt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSwmng = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboBxSwmDstnc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboBxSwmEvnts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCrsCntry = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AthltcsDistanceUpDn = new System.Windows.Forms.NumericUpDown();
            this.lblDstnc = new System.Windows.Forms.Label();
            this.athltcsTmMUpDn = new System.Windows.Forms.NumericUpDown();
            this.athltcsTmScMilliUpDn = new System.Windows.Forms.NumericUpDown();
            this.pnlAthltcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDnAtmpt)).BeginInit();
            this.pnlEvnt.SuspendLayout();
            this.pnlSwmng.SuspendLayout();
            this.pnlCrsCntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AthltcsDistanceUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athltcsTmMUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athltcsTmScMilliUpDn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAthltcs
            // 
            this.pnlAthltcs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAthltcs.Controls.Add(this.athltcsTmScMilliUpDn);
            this.pnlAthltcs.Controls.Add(this.athltcsTmMUpDn);
            this.pnlAthltcs.Controls.Add(this.lblDstnc);
            this.pnlAthltcs.Controls.Add(this.AthltcsDistanceUpDn);
            this.pnlAthltcs.Controls.Add(this.lblTm);
            this.pnlAthltcs.Controls.Add(this.nmrcUpDnAtmpt);
            this.pnlAthltcs.Controls.Add(this.lblSdntName);
            this.pnlAthltcs.Controls.Add(this.txtBxSdntName);
            this.pnlAthltcs.Controls.Add(this.label1);
            this.pnlAthltcs.Controls.Add(this.lblSdntAge);
            this.pnlAthltcs.Controls.Add(this.cmboBxAthltcsEvnts);
            this.pnlAthltcs.Controls.Add(this.cmboBxAge);
            this.pnlAthltcs.Controls.Add(this.lblEvnt);
            this.pnlAthltcs.Location = new System.Drawing.Point(218, 12);
            this.pnlAthltcs.Name = "pnlAthltcs";
            this.pnlAthltcs.Size = new System.Drawing.Size(280, 194);
            this.pnlAthltcs.TabIndex = 10;
            this.pnlAthltcs.Visible = false;
            // 
            // lblTm
            // 
            this.lblTm.AutoSize = true;
            this.lblTm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTm.Location = new System.Drawing.Point(13, 0);
            this.lblTm.Name = "lblTm";
            this.lblTm.Size = new System.Drawing.Size(59, 25);
            this.lblTm.TabIndex = 18;
            this.lblTm.Text = "Time";
            // 
            // nmrcUpDnAtmpt
            // 
            this.nmrcUpDnAtmpt.Enabled = false;
            this.nmrcUpDnAtmpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcUpDnAtmpt.Location = new System.Drawing.Point(171, 85);
            this.nmrcUpDnAtmpt.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmrcUpDnAtmpt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcUpDnAtmpt.Name = "nmrcUpDnAtmpt";
            this.nmrcUpDnAtmpt.Size = new System.Drawing.Size(80, 26);
            this.nmrcUpDnAtmpt.TabIndex = 17;
            this.nmrcUpDnAtmpt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Attempt";
            // 
            // cmboBxAthltcsEvnts
            // 
            this.cmboBxAthltcsEvnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxAthltcsEvnts.FormattingEnabled = true;
            this.cmboBxAthltcsEvnts.Location = new System.Drawing.Point(80, 27);
            this.cmboBxAthltcsEvnts.Name = "cmboBxAthltcsEvnts";
            this.cmboBxAthltcsEvnts.Size = new System.Drawing.Size(120, 28);
            this.cmboBxAthltcsEvnts.TabIndex = 15;
            this.cmboBxAthltcsEvnts.SelectedIndexChanged += new System.EventHandler(this.TimeOrDistance);
            // 
            // lblEvnt
            // 
            this.lblEvnt.AutoSize = true;
            this.lblEvnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvnt.Location = new System.Drawing.Point(110, 0);
            this.lblEvnt.Name = "lblEvnt";
            this.lblEvnt.Size = new System.Drawing.Size(67, 25);
            this.lblEvnt.TabIndex = 14;
            this.lblEvnt.Text = "Event";
            // 
            // cmboBxAge
            // 
            this.cmboBxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxAge.FormattingEnabled = true;
            this.cmboBxAge.Items.AddRange(new object[] {
            "5-",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18+"});
            this.cmboBxAge.Location = new System.Drawing.Point(196, 156);
            this.cmboBxAge.Name = "cmboBxAge";
            this.cmboBxAge.Size = new System.Drawing.Size(55, 28);
            this.cmboBxAge.TabIndex = 13;
            // 
            // lblSdntAge
            // 
            this.lblSdntAge.AutoSize = true;
            this.lblSdntAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdntAge.Location = new System.Drawing.Point(173, 128);
            this.lblSdntAge.Name = "lblSdntAge";
            this.lblSdntAge.Size = new System.Drawing.Size(111, 25);
            this.lblSdntAge.TabIndex = 12;
            this.lblSdntAge.Text = "Age group";
            // 
            // txtBxSdntName
            // 
            this.txtBxSdntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSdntName.Location = new System.Drawing.Point(3, 156);
            this.txtBxSdntName.Name = "txtBxSdntName";
            this.txtBxSdntName.Size = new System.Drawing.Size(164, 26);
            this.txtBxSdntName.TabIndex = 11;
            // 
            // lblSdntName
            // 
            this.lblSdntName.AutoSize = true;
            this.lblSdntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdntName.Location = new System.Drawing.Point(-2, 128);
            this.lblSdntName.Name = "lblSdntName";
            this.lblSdntName.Size = new System.Drawing.Size(169, 25);
            this.lblSdntName.TabIndex = 10;
            this.lblSdntName.Text = "Name of student";
            // 
            // pnlEvnt
            // 
            this.pnlEvnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEvnt.Controls.Add(this.btnCnfm);
            this.pnlEvnt.Controls.Add(this.txtBxOthr);
            this.pnlEvnt.Controls.Add(this.cmboBxEvnt);
            this.pnlEvnt.Controls.Add(this.label3);
            this.pnlEvnt.Location = new System.Drawing.Point(12, 12);
            this.pnlEvnt.Name = "pnlEvnt";
            this.pnlEvnt.Size = new System.Drawing.Size(200, 194);
            this.pnlEvnt.TabIndex = 11;
            // 
            // btnCnfm
            // 
            this.btnCnfm.Location = new System.Drawing.Point(53, 123);
            this.btnCnfm.Name = "btnCnfm";
            this.btnCnfm.Size = new System.Drawing.Size(90, 23);
            this.btnCnfm.TabIndex = 6;
            this.btnCnfm.Text = "Confirm";
            this.btnCnfm.UseVisualStyleBackColor = true;
            this.btnCnfm.Click += new System.EventHandler(this.btnCnfm_Click);
            // 
            // txtBxOthr
            // 
            this.txtBxOthr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxOthr.Location = new System.Drawing.Point(25, 90);
            this.txtBxOthr.Name = "txtBxOthr";
            this.txtBxOthr.Size = new System.Drawing.Size(155, 26);
            this.txtBxOthr.TabIndex = 5;
            this.txtBxOthr.Visible = false;
            // 
            // cmboBxEvnt
            // 
            this.cmboBxEvnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxEvnt.FormattingEnabled = true;
            this.cmboBxEvnt.Items.AddRange(new object[] {
            "Swimming carnival",
            "Athletics carnival",
            "Cross country"});
            this.cmboBxEvnt.Location = new System.Drawing.Point(25, 50);
            this.cmboBxEvnt.Name = "cmboBxEvnt";
            this.cmboBxEvnt.Size = new System.Drawing.Size(155, 28);
            this.cmboBxEvnt.TabIndex = 4;
            this.cmboBxEvnt.SelectedIndexChanged += new System.EventHandler(this.isOthrSlctd);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Event day";
            // 
            // pnlSwmng
            // 
            this.pnlSwmng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSwmng.Controls.Add(this.textBox2);
            this.pnlSwmng.Controls.Add(this.label6);
            this.pnlSwmng.Controls.Add(this.comboBox1);
            this.pnlSwmng.Controls.Add(this.label7);
            this.pnlSwmng.Controls.Add(this.textBox3);
            this.pnlSwmng.Controls.Add(this.label8);
            this.pnlSwmng.Controls.Add(this.cmboBxSwmDstnc);
            this.pnlSwmng.Controls.Add(this.label5);
            this.pnlSwmng.Controls.Add(this.cmboBxSwmEvnts);
            this.pnlSwmng.Controls.Add(this.label4);
            this.pnlSwmng.Location = new System.Drawing.Point(218, 212);
            this.pnlSwmng.Name = "pnlSwmng";
            this.pnlSwmng.Size = new System.Drawing.Size(280, 194);
            this.pnlSwmng.TabIndex = 12;
            this.pnlSwmng.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Time";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5-",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18+"});
            this.comboBox1.Location = new System.Drawing.Point(196, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Age group";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-2, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name of student";
            // 
            // cmboBxSwmDstnc
            // 
            this.cmboBxSwmDstnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxSwmDstnc.FormattingEnabled = true;
            this.cmboBxSwmDstnc.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "400",
            "800"});
            this.cmboBxSwmDstnc.Location = new System.Drawing.Point(135, 31);
            this.cmboBxSwmDstnc.Name = "cmboBxSwmDstnc";
            this.cmboBxSwmDstnc.Size = new System.Drawing.Size(120, 28);
            this.cmboBxSwmDstnc.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Distance";
            // 
            // cmboBxSwmEvnts
            // 
            this.cmboBxSwmEvnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxSwmEvnts.FormattingEnabled = true;
            this.cmboBxSwmEvnts.Location = new System.Drawing.Point(3, 31);
            this.cmboBxSwmEvnts.Name = "cmboBxSwmEvnts";
            this.cmboBxSwmEvnts.Size = new System.Drawing.Size(120, 28);
            this.cmboBxSwmEvnts.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Event";
            // 
            // pnlCrsCntry
            // 
            this.pnlCrsCntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCrsCntry.Controls.Add(this.textBox4);
            this.pnlCrsCntry.Controls.Add(this.label9);
            this.pnlCrsCntry.Controls.Add(this.comboBox2);
            this.pnlCrsCntry.Controls.Add(this.label10);
            this.pnlCrsCntry.Controls.Add(this.textBox5);
            this.pnlCrsCntry.Controls.Add(this.label11);
            this.pnlCrsCntry.Location = new System.Drawing.Point(511, 12);
            this.pnlCrsCntry.Name = "pnlCrsCntry";
            this.pnlCrsCntry.Size = new System.Drawing.Size(280, 194);
            this.pnlCrsCntry.TabIndex = 13;
            this.pnlCrsCntry.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(5, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 26);
            this.textBox4.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Time";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5-",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18+"});
            this.comboBox2.Location = new System.Drawing.Point(198, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(55, 28);
            this.comboBox2.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Age group";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(5, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 26);
            this.textBox5.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Name of student";
            // 
            // AthltcsDistanceUpDn
            // 
            this.AthltcsDistanceUpDn.DecimalPlaces = 2;
            this.AthltcsDistanceUpDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthltcsDistanceUpDn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.AthltcsDistanceUpDn.Location = new System.Drawing.Point(46, 86);
            this.AthltcsDistanceUpDn.Name = "AthltcsDistanceUpDn";
            this.AthltcsDistanceUpDn.Size = new System.Drawing.Size(80, 26);
            this.AthltcsDistanceUpDn.TabIndex = 20;
            // 
            // lblDstnc
            // 
            this.lblDstnc.AutoSize = true;
            this.lblDstnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDstnc.Location = new System.Drawing.Point(22, 58);
            this.lblDstnc.Name = "lblDstnc";
            this.lblDstnc.Size = new System.Drawing.Size(127, 25);
            this.lblDstnc.TabIndex = 21;
            this.lblDstnc.Text = "Distance(m)";
            // 
            // athltcsTmMUpDn
            // 
            this.athltcsTmMUpDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athltcsTmMUpDn.Location = new System.Drawing.Point(4, 26);
            this.athltcsTmMUpDn.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.athltcsTmMUpDn.Name = "athltcsTmMUpDn";
            this.athltcsTmMUpDn.Size = new System.Drawing.Size(70, 26);
            this.athltcsTmMUpDn.TabIndex = 22;
            // 
            // athltcsTmScMilliUpDn
            // 
            this.athltcsTmScMilliUpDn.DecimalPlaces = 3;
            this.athltcsTmScMilliUpDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athltcsTmScMilliUpDn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.athltcsTmScMilliUpDn.Location = new System.Drawing.Point(4, 54);
            this.athltcsTmScMilliUpDn.Name = "athltcsTmScMilliUpDn";
            this.athltcsTmScMilliUpDn.Size = new System.Drawing.Size(70, 26);
            this.athltcsTmScMilliUpDn.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCrsCntry);
            this.Controls.Add(this.pnlSwmng);
            this.Controls.Add(this.pnlEvnt);
            this.Controls.Add(this.pnlAthltcs);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "MainForm";
            this.Text = "Time sorter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlAthltcs.ResumeLayout(false);
            this.pnlAthltcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDnAtmpt)).EndInit();
            this.pnlEvnt.ResumeLayout(false);
            this.pnlEvnt.PerformLayout();
            this.pnlSwmng.ResumeLayout(false);
            this.pnlSwmng.PerformLayout();
            this.pnlCrsCntry.ResumeLayout(false);
            this.pnlCrsCntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AthltcsDistanceUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athltcsTmMUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athltcsTmScMilliUpDn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAthltcs;
        private System.Windows.Forms.Label lblTm;
        private System.Windows.Forms.NumericUpDown nmrcUpDnAtmpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvnt;
        private System.Windows.Forms.ComboBox cmboBxAge;
        private System.Windows.Forms.Label lblSdntAge;
        private System.Windows.Forms.TextBox txtBxSdntName;
        private System.Windows.Forms.Label lblSdntName;
        private System.Windows.Forms.Panel pnlEvnt;
        private System.Windows.Forms.ComboBox cmboBxEvnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxOthr;
        private System.Windows.Forms.Button btnCnfm;
        public System.Windows.Forms.ComboBox cmboBxAthltcsEvnts;
        private System.Windows.Forms.Panel pnlSwmng;
        public System.Windows.Forms.ComboBox cmboBxSwmDstnc;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmboBxSwmEvnts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlCrsCntry;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown AthltcsDistanceUpDn;
        private System.Windows.Forms.Label lblDstnc;
        private System.Windows.Forms.NumericUpDown athltcsTmScMilliUpDn;
        private System.Windows.Forms.NumericUpDown athltcsTmMUpDn;
    }
}

