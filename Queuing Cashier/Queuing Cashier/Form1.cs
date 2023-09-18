namespace Queuing_Cashier
{
    public partial class frmQueuingForm : Form
    {
        CashierClass cashier;
        public frmQueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }
        private void frmQueuingForm_Load(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindowQueueForm = new CashierWindowQueueForm();
            cashierWindowQueueForm.Show();
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }


    }
}