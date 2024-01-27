namespace TinasCustomTees
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
            dateTimePicker1 = new DateTimePicker();
            btnCheckout = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            colorComboBox = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(289, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(414, 233);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Small", "Medium", "Large", "XL" });
            comboBox1.Location = new Point(123, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 151);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "Select order date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 148);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Select Size:";
            // 
            // colorComboBox
            // 
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Items.AddRange(new object[] { "Red", "Blue", "Green", "Yellow" });
            colorComboBox.Location = new Point(539, 174);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(121, 23);
            colorComboBox.TabIndex = 5;
            colorComboBox.SelectedIndexChanged += colorComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(540, 152);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Select Color:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(colorComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnCheckout);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnCheckout;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox colorComboBox;
        private Label label3;
    }
}
