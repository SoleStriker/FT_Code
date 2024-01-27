
namespace CarDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            if (CarModelsList.SelectedItem == null)
            {
                MessageBox.Show("Please select a car model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string selectedModel = CarModelsList.SelectedItem.ToString();
            CarInfoForm carInfoForm = new CarInfoForm(selectedModel);
            carInfoForm.ShowDialog();
        }
    }
}
