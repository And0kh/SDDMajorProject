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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBxEvnts = new System.Windows.Forms.ComboBox();
            this.lblEvnt = new System.Windows.Forms.Label();
            this.cmboBxAge = new System.Windows.Forms.ComboBox();
            this.lblSdntAge = new System.Windows.Forms.Label();
            this.txtBxSdntName = new System.Windows.Forms.TextBox();
            this.lblSdntName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBxOthr = new System.Windows.Forms.TextBox();
            this.cmboBxEvnt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmboBxEvnts);
            this.panel1.Controls.Add(this.lblEvnt);
            this.panel1.Controls.Add(this.cmboBxAge);
            this.panel1.Controls.Add(this.lblSdntAge);
            this.panel1.Controls.Add(this.txtBxSdntName);
            this.panel1.Controls.Add(this.lblSdntName);
            this.panel1.Location = new System.Drawing.Point(218, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 194);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Time/Distance";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(137, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 26);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Attempt";
            // 
            // cmboBxEvnts
            // 
            this.cmboBxEvnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxEvnts.FormattingEnabled = true;
            this.cmboBxEvnts.Items.AddRange(new object[] {
            "Running 100m",
            "Running 200m",
            "Running 400m",
            "Running 800m",
            "Running 1500m",
            "High jump",
            "Long jump",
            "Shot put",
            "Javelin",
            "Discus"});
            this.cmboBxEvnts.Location = new System.Drawing.Point(3, 31);
            this.cmboBxEvnts.Name = "cmboBxEvnts";
            this.cmboBxEvnts.Size = new System.Drawing.Size(120, 28);
            this.cmboBxEvnts.TabIndex = 15;
            // 
            // lblEvnt
            // 
            this.lblEvnt.AutoSize = true;
            this.lblEvnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvnt.Location = new System.Drawing.Point(31, 4);
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
            this.cmboBxAge.Location = new System.Drawing.Point(196, 88);
            this.cmboBxAge.Name = "cmboBxAge";
            this.cmboBxAge.Size = new System.Drawing.Size(55, 28);
            this.cmboBxAge.TabIndex = 13;
            // 
            // lblSdntAge
            // 
            this.lblSdntAge.AutoSize = true;
            this.lblSdntAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdntAge.Location = new System.Drawing.Point(173, 62);
            this.lblSdntAge.Name = "lblSdntAge";
            this.lblSdntAge.Size = new System.Drawing.Size(111, 25);
            this.lblSdntAge.TabIndex = 12;
            this.lblSdntAge.Text = "Age group";
            // 
            // txtBxSdntName
            // 
            this.txtBxSdntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSdntName.Location = new System.Drawing.Point(3, 90);
            this.txtBxSdntName.Name = "txtBxSdntName";
            this.txtBxSdntName.Size = new System.Drawing.Size(164, 26);
            this.txtBxSdntName.TabIndex = 11;
            // 
            // lblSdntName
            // 
            this.lblSdntName.AutoSize = true;
            this.lblSdntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdntName.Location = new System.Drawing.Point(-2, 62);
            this.lblSdntName.Name = "lblSdntName";
            this.lblSdntName.Size = new System.Drawing.Size(169, 25);
            this.lblSdntName.TabIndex = 10;
            this.lblSdntName.Text = "Name of student";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtBxOthr);
            this.panel2.Controls.Add(this.cmboBxEvnt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 194);
            this.panel2.TabIndex = 11;
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
            "Cross country",
            "Other"});
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confrim";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Time sorter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBxEvnts;
        private System.Windows.Forms.Label lblEvnt;
        private System.Windows.Forms.ComboBox cmboBxAge;
        private System.Windows.Forms.Label lblSdntAge;
        private System.Windows.Forms.TextBox txtBxSdntName;
        private System.Windows.Forms.Label lblSdntName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmboBxEvnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxOthr;
        private System.Windows.Forms.Button button1;
    }
}

