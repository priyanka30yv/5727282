namespace ADOWinApps
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
            this.label1 = new System.Windows.Forms.Label();
            this.PartNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.textvoterid = new System.Windows.Forms.TextBox();
            this.textpartnumber = new System.Windows.Forms.TextBox();
            this.textpartname = new System.Windows.Forms.TextBox();
            this.textserialnumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "voterId";
            // 
            // PartNo
            // 
            this.PartNo.AutoSize = true;
            this.PartNo.Location = new System.Drawing.Point(82, 135);
            this.PartNo.Name = "PartNo";
            this.PartNo.Size = new System.Drawing.Size(95, 20);
            this.PartNo.TabIndex = 1;
            this.PartNo.Text = "part number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "part name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "serial number";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(372, 387);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(52, 20);
            this.lblAns.TabIndex = 5;
            this.lblAns.Text = "lblAns";
            // 
            // textvoterid
            // 
            this.textvoterid.Location = new System.Drawing.Point(302, 77);
            this.textvoterid.Name = "textvoterid";
            this.textvoterid.Size = new System.Drawing.Size(100, 26);
            this.textvoterid.TabIndex = 6;
            // 
            // textpartnumber
            // 
            this.textpartnumber.Location = new System.Drawing.Point(302, 129);
            this.textpartnumber.Name = "textpartnumber";
            this.textpartnumber.Size = new System.Drawing.Size(100, 26);
            this.textpartnumber.TabIndex = 7;
            // 
            // textpartname
            // 
            this.textpartname.Location = new System.Drawing.Point(302, 186);
            this.textpartname.Name = "textpartname";
            this.textpartname.Size = new System.Drawing.Size(100, 26);
            this.textpartname.TabIndex = 8;
            // 
            // textserialnumber
            // 
            this.textserialnumber.Location = new System.Drawing.Point(302, 240);
            this.textserialnumber.Name = "textserialnumber";
            this.textserialnumber.Size = new System.Drawing.Size(100, 26);
            this.textserialnumber.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textserialnumber);
            this.Controls.Add(this.textpartname);
            this.Controls.Add(this.textpartnumber);
            this.Controls.Add(this.textvoterid);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PartNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PartNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.TextBox textvoterid;
        private System.Windows.Forms.TextBox textpartnumber;
        private System.Windows.Forms.TextBox textpartname;
        private System.Windows.Forms.TextBox textserialnumber;
        private System.Windows.Forms.Button button1;
    }
}

