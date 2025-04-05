using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakturaAlex.Models;
using FakturaAlex.Services;

namespace FakturaAlex.Views
{
    public partial class CreateNewCustomerForm : Form
    {
        private readonly CustomerService _customerService;

        public CreateNewCustomerForm(CustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void CreateNewCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Opprett
            var customer = new Customer
            {
                Name = kundenavnFelt.Text,
                Address = addresseFelt.Text,
                 Zip = postnrText.Text,
                 OrgNummer  = orgnummerFelt.Text,
                City = poststedText.Text,
                Notes = kundenr.Text,
                Email = epostFelt.Text,
                PhoneNumber = telefonFelt.Text,
            };
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(customer);

            bool isValid = Validator.TryValidateObject(customer, context, validationResults, true);

            if (!isValid)
            {
                var errors = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
                MessageBox.Show("Valideringsfeil:\n" + errors);
                return;
            }
            _customerService.CreateCustomer(customer);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
