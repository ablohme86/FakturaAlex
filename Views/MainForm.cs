using System.Diagnostics;
using FakturaAlex.Database;
using FakturaAlex.Services;
using FakturaAlex.Views;

namespace FakturaAlex
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void visAlleKunderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerService = new CustomerService(new ApplicationDbContext());
            var customerListForm = new CustomerListForm(customerService)
            {
                MdiParent = this
            };
            customerListForm.Show();
        }

        private void opprettNyKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerService = new CustomerService(new ApplicationDbContext());
            var createNewCustomerForm = new CreateNewCustomerForm(customerService)
            {
                MdiParent = this
            };
            createNewCustomerForm.Show();
        }
    }
}
