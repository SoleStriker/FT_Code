namespace RecentlyVisitedSites
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            linkLabel1 = new LinkLabel();
            toolTip1 = new ToolTip(components);
            groupBox1 = new GroupBox();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(61, 32);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Google.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.MouseHover += linkedLabel1_Hover;
            // 
            // toolTip1
            // 
            toolTip1.Tag = "YO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel3);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Location = new Point(272, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(61, 62);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(51, 15);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "clash.gg";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            linkLabel3.MouseHover += linkedLabel3_Hover;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(61, 47);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(77, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "paycom.com";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            linkLabel2.MouseHover += linkedLabel2_Hover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabel1;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
    }
}
