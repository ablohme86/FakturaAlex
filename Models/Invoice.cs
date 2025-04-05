/*
 * FakturaAlex v1.0
 * 
 * File: Invoice.cs
 * Author: Alexander Blohmé <alexander@thrino.no>
 * Date: April 5, 2025
 * Description: Invoice entity class
 * 
 *
 * FakturaAlex is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * FakturaAlex is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with FakturaAlex. If not, see <https://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaAlex.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public Customer Customer { get; set; }
        public List<Item> Items { get; set; }
        public string Kid { get; set; }
        public string AccountNumber { get; set; }
        public decimal NetTotal => Items.Sum(i => i.Quantity * i.Price);
        public decimal MvaTotal => 0; // enkel versjon
        public decimal Total => NetTotal + MvaTotal;
    }
}
