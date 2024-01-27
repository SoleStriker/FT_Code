namespace CarDealer
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
            CarModelsList = new ListBox();
            btnMoreInfo = new Button();
            SuspendLayout();
            // 
            // CarModelsList
            // 
            CarModelsList.FormattingEnabled = true;
            CarModelsList.ItemHeight = 15;
            CarModelsList.Items.AddRange(new object[] { "Ford F150", "Chevy Cruze", "Subaru BRZ", "Hyundai Gen" });
            CarModelsList.Location = new Point(248, 119);
            CarModelsList.Name = "CarModelsList";
            CarModelsList.Size = new Size(120, 94);
            CarModelsList.TabIndex = 0;
            // 
            // btnMoreInfo
            // 
            btnMoreInfo.Location = new Point(293, 219);
            btnMoreInfo.Name = "btnMoreInfo";
            btnMoreInfo.Size = new Size(75, 23);
            btnMoreInfo.TabIndex = 1;
            btnMoreInfo.Text = "More Info";
            btnMoreInfo.UseVisualStyleBackColor = true;
            btnMoreInfo.Click += btnMoreInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMoreInfo);
            Controls.Add(CarModelsList);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox CarModelsList;
        private Button btnMoreInfo;
    }
}
