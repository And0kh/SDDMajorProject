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
            this.lblSdntName = new System.Windows.Forms.Label();
            this.txtBxSdntName = new System.Windows.Forms.TextBox();
            this.lblSdntAge = new System.Windows.Forms.Label();
            this.cmboBxAge = new System.Windows.Forms.ComboBox();
            this.lblEvnt = new System.Windows.Forms.Label();
            this.cmboBxEvnts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSdntName
            // 
            this.lblSdntName.AutoSize = true;
            this.lblSdntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdntName.Location = new System.Drawing.Point(17, 83);
            this.lblSdntName.Name = "lblSdntName";
            this.lblSdntName.Size = new System.Drawing.Size(169, 25);
            this.lblSdntName.TabIndex = 0;
            this.lblSdntName.Text = "Name of student";
            // 
            // txtBxSdntName
            // 
            this.txtBxSdntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSdntName.Location = new System.Drawing.Point(22, 111);
            this.txtBxSdntName.Name = "txtBxSdntName";
            this.txtBxSdntName.Size = new System.Drawing.Size(164, 26);
            this.txtBxSdntName.TabIndex = 1;
            // 
            // lblSdntAge
            // 
            this.lblSdntAge.AutoSize = true;
            this.lblSdntAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdntAge.Location = new System.Drawing.Point(192, 83);
            this.lblSdntAge.Name = "lblSdntAge";
            this.lblSdntAge.Size = new System.Drawing.Size(111, 25);
            this.lblSdntAge.TabIndex = 2;
            this.lblSdntAge.Text = "Age group";
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
            this.cmboBxAge.Location = new System.Drawing.Point(220, 109);
            this.cmboBxAge.Name = "cmboBxAge";
            this.cmboBxAge.Size = new System.Drawing.Size(55, 28);
            this.cmboBxAge.TabIndex = 3;
            // 
            // lblEvnt
            // 
            this.lblEvnt.AutoSize = true;
            this.lblEvnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvnt.Location = new System.Drawing.Point(50, 25);
            this.lblEvnt.Name = "lblEvnt";
            this.lblEvnt.Size = new System.Drawing.Size(67, 25);
            this.lblEvnt.TabIndex = 4;
            this.lblEvnt.Text = "Event";
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
            this.cmboBxEvnts.Location = new System.Drawing.Point(22, 52);
            this.cmboBxEvnts.Name = "cmboBxEvnts";
            this.cmboBxEvnts.Size = new System.Drawing.Size(120, 28);
            this.cmboBxEvnts.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Attempt";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(156, 53);
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
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time/Distance";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboBxEvnts);
            this.Controls.Add(this.lblEvnt);
            this.Controls.Add(this.cmboBxAge);
            this.Controls.Add(this.lblSdntAge);
            this.Controls.Add(this.txtBxSdntName);
            this.Controls.Add(this.lblSdntName);
            this.Name = "MainForm";
            this.Text = "Time sorter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSdntName;
        private System.Windows.Forms.TextBox txtBxSdntName;
        private System.Windows.Forms.Label lblSdntAge;
        private System.Windows.Forms.ComboBox cmboBxAge;
        private System.Windows.Forms.Label lblEvnt;
        private System.Windows.Forms.ComboBox cmboBxEvnts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}

