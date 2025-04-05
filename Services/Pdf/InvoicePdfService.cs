using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakturaAlex.Models;
using PdfSharp;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace FakturaAlex.Services.Pdf
{
    public class InvoicePdfService
    {
        public byte[] ProducePdfInvoice(Invoice invoice)
        {
            string htmlTemplate = File.ReadAllText("Templates/faktura_template.html");

            // Generer HTML for alle fakturalinjer
            var itemRows = new StringBuilder();
            foreach (var item in invoice.Items)
            {
                var total = item.Quantity * item.Price;
                itemRows.AppendLine($@"<tr>
              <td>{item.Code}</td>
              <td>{item.Description}</td>
              <td>{item.Quantity}</td>
              <td>{item.Price:N2}</td>
              <td>{item.Discount}</td>
              <td>{item.Mva}</td>
              <td>{total:N2}</td>
            </tr>");
            }

            string html = htmlTemplate
                .Replace("{{Kundenavn}}", invoice.Customer.Name)
                .Replace("{{Kundeaddresse}}", invoice.Customer.Address)
                .Replace("{{Kundepostnummer}}", invoice.Customer.Zip)
                .Replace("{{Kundepoststed}}", invoice.Customer.City)
                .Replace("{{Kundenr}}", invoice.Customer.CustomerId.ToString())
                .Replace("{{Fakturanr}}", invoice.InvoiceNumber.ToString())
                .Replace("{{Fakturadato}}", invoice.InvoiceDate.ToString("dd.MM.yyyy"))
                .Replace("{{Fakturaforfall}}", invoice.DueDate.ToString("dd.MM.yyyy"))  
                .Replace("{{Kid}}", invoice.Kid)
                .Replace("{{Kontonr}}", invoice.AccountNumber)
                .Replace("{{Kroner}}", invoice.NetTotal.ToString("N0"))
                .Replace("{{Ore}}", "00")
                .Replace("{{MvaKroner}}", invoice.MvaTotal.ToString("N0"))
                .Replace("{{MvaOre}}", "00")
                .Replace("{{TotaltKroner}}", invoice.Total.ToString("N0"))
                .Replace("{{TotaltOre}}", "00")
                .Replace("{{ItemRows}}", itemRows.ToString());

            var document = PdfGenerator.GeneratePdf(html, PageSize.A4);
            using var stream = new MemoryStream();
            document.Save(stream, false);
            return stream.ToArray();
        }
    }

}
