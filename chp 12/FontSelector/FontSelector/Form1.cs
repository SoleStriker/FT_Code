using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontStyleList.Items.AddRange(new string[] { "Arial", "Times New Roman", "Courier New", "Verdana" });
            FontStyleList.SelectedIndex = 0;


            FontSizeList.Items.AddRange(new string[] { "12", "16", "20", "24" });
            FontSizeList.SelectedIndex = 0;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFont = FontStyleList.SelectedItem.ToString();
            int selectedSize = Convert.ToInt32(FontSizeList.SelectedItem);

            label1.Font = new Font(selectedFont, selectedSize);
            label1.Text = selectedFont;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
