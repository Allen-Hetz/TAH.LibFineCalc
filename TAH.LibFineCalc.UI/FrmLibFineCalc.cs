namespace TAH.LibFineCalc.UI
{
    public partial class FrmLibFineCalc : Form
    {
        public FrmLibFineCalc()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears all input fields
            txtOverdueBooks.Text = "";
            txtDaysOverdue.Text = "";
            lblTotalFine.Text = "";
        }

        private void btnCalcFine_Click(object sender, EventArgs e)
        {
            if (txtDaysOverdue.Text == "" || txtOverdueBooks.Text == "")
            {
                MessageBox.Show("Please enter values for both fields.");
                return;
            }
            if (!int.TryParse(txtOverdueBooks.Text, out int overdueBooks) || !int.TryParse(txtDaysOverdue.Text, out int daysOverdue))
            {
                MessageBox.Show("Please enter valid integers for both fields.");
                return;
            }

            float FineAmount = daysOverdue * (overdueBooks * 0.05f);

            lblTotalFine.Text = $"Total Fine: {FineAmount:C2}";
        }
    }
}
