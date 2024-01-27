using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class Form1 : Form
    {

        private const decimal ItemPrice = 1.99m;
        public Form1()
        {
            InitializeComponent();

            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotal(listBox1, label1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTotal(ListBox listBox, Label label1)
        {
            decimal total = 0;
            foreach(var selectedItem in listBox.SelectedItems)
            {
                total += ItemPrice;
            }

            label1.Text = total.ToString("C");
        }
    }
}
