namespace Phone_Ordering_System
{
    public partial class frmPhoneOrdering : Form
    {
        public frmPhoneOrdering()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal bluePhonePrice = 20000m;
            const decimal pinkPhonePrice = 22000m;
            const decimal taxRate = 0.16m;

            int blueQuantity = (int)nudBlueQuantity.Value;
            int pinkQuantity = (int)nudPinkQuantity.Value;

            decimal subtotal = (blueQuantity * bluePhonePrice) +
                               (pinkQuantity * pinkPhonePrice);

            decimal salesTax = subtotal * taxRate;
            decimal totalAmount = subtotal + salesTax;

            lblSubtotalValue.Text = subtotal.ToString("N2");
            lblTaxValue.Text = salesTax.ToString("N2");
            lblTotalValue.Text = totalAmount.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nudBlueQuantity.Value = 0;
            nudPinkQuantity.Value = 0;

            lblSubtotalValue.Text = "0.00";
            lblTaxValue.Text = "0.00";
            lblTotalValue.Text = "0.00";

            nudBlueQuantity.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudBlueQuantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
