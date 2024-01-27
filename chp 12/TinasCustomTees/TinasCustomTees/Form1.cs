namespace TinasCustomTees
{
    public partial class Form1 : Form
    {
        private string[] sizes = { "Small", "Medium", "Large", "XL" };
        private string[] colors = { "Blue", "Red", "Green", "Yellow" };
        private decimal[] prices = { 12.99m, 17.99m, 21.99m, 24.99m };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBackGroundColor(object sender, EventArgs e)
        {
            switch (colorComboBox.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Red;
                    break;
                case 1:
                    this.BackColor = Color.Blue;
                    break;
                case 2:
                    this.BackColor = Color.Green;
                    break;
                case 3:
                    this.BackColor = Color.Yellow;
                    break;
            }
        }

        private void DisplayShippingInfo(object sender, EventArgs e) 
        { 
            
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            UpdateBackGroundColor(sender, e);
        }
    }
}
