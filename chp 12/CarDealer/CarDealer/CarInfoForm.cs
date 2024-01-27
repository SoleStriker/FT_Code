using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class CarInfoForm : Form
    {
        public CarInfoForm(string selectedModel)
        {
            InitializeComponent();
            DisplayCarDetails(selectedModel);
        }
        private void DisplayCarDetails(string selectedModel)
        {
            switch (selectedModel)
            {
                case "Ford F150":
                    lblInfo.Text = "Year: 2023, 4 door, v8, 4x4";
                    break;
                case "Chevy Cruze":
                    lblInfo.Text = "Year 2016, 4 door, Inline 4";
                    break;
                case "Subaru BRZ":
                    lblInfo.Text = "Year 2023, 2 Door, V8 Engine";
                    break;
                case "Hyundai Gen":
                    lblInfo.Text = "Year 2013, 4 door, v6 Engine";
                    break;
            }
                
            lblModel.Text = selectedModel;
        }

        private void CarInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
