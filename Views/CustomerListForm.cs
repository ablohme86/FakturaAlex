using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakturaAlex.Services;

namespace FakturaAlex.Views
{
    public partial class CustomerListForm : Form
    {
        private readonly CustomerService _customerService;

        public CustomerListForm(CustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;

        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _customerService.GetAllCustomers();

            // Gi kolonner brukervennlige titler
            dataGridView1.Columns["Name"].HeaderText = "Kundenavn";
            dataGridView1.Columns["Address"].HeaderText = "Adresse";
            dataGridView1.Columns["Zip"].HeaderText = "Postnummer";
            dataGridView1.Columns["City"].HeaderText = "Poststed";
            dataGridView1.Columns["PhoneNumber"].HeaderText = "Telefon";
            dataGridView1.Columns["Email"].HeaderText = "E-post";
            dataGridView1.Columns["CustomerId"].HeaderText = "Kundenr";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var customers = _customerService.GetAllCustomers();
            dataGridView1.DataSource = customers;
        }
    }
}
