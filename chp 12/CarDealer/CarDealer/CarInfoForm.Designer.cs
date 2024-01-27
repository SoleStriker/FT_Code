namespace CarDealer
{
    partial class CarInfoForm
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
            lblModel = new Label();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(322, 159);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(38, 15);
            lblModel.TabIndex = 0;
            lblModel.Text = "label1";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(268, 262);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(38, 15);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // CarInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfo);
            Controls.Add(lblModel);
            Name = "CarInfoForm";
            Text = "CarInfoForm";
            Load += CarInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModel;
        private Label lblInfo;
    }
}