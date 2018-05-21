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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblSdntName = new System.Windows.Forms.Label();
            this.txtBxSdntName = new System.Windows.Forms.TextBox();
            this.lblSdntAge = new System.Windows.Forms.Label();
            this.cmboBxAge = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblSdntName
            // 
            this.lblSdntName.AutoSize = true;
            this.lblSdntName.Location = new System.Drawing.Point(13, 13);
            this.lblSdntName.Name = "lblSdntName";
            this.lblSdntName.Size = new System.Drawing.Size(105, 13);
            this.lblSdntName.TabIndex = 0;
            this.lblSdntName.Text = "First name of student";
            // 
            // txtBxSdntName
            // 
            this.txtBxSdntName.Location = new System.Drawing.Point(16, 30);
            this.txtBxSdntName.Name = "txtBxSdntName";
            this.txtBxSdntName.Size = new System.Drawing.Size(100, 20);
            this.txtBxSdntName.TabIndex = 1;
            // 
            // lblSdntAge
            // 
            this.lblSdntAge.AutoSize = true;
            this.lblSdntAge.Location = new System.Drawing.Point(139, 13);
            this.lblSdntAge.Name = "lblSdntAge";
            this.lblSdntAge.Size = new System.Drawing.Size(76, 13);
            this.lblSdntAge.TabIndex = 2;
            this.lblSdntAge.Text = "Age of student";
            // 
            // cmboBxAge
            // 
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
            this.cmboBxAge.Location = new System.Drawing.Point(142, 28);
            this.cmboBxAge.Name = "cmboBxAge";
            this.cmboBxAge.Size = new System.Drawing.Size(121, 21);
            this.cmboBxAge.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmboBxAge);
            this.Controls.Add(this.lblSdntAge);
            this.Controls.Add(this.txtBxSdntName);
            this.Controls.Add(this.lblSdntName);
            this.Name = "MainForm";
            this.Text = "Time sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblSdntName;
        private System.Windows.Forms.TextBox txtBxSdntName;
        private System.Windows.Forms.Label lblSdntAge;
        private System.Windows.Forms.ComboBox cmboBxAge;
    }
}

