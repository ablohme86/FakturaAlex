/*
 * FakturaAlex v1.0
 * 
 * File: Customer.cs
 * Author: Alexander Blohmé <alexander@thrino.no>
 * Date: April 5, 2025
 * Description: Customer entity class
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaAlex.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Address { get; set; }
        [Required] public string Zip { get; set; }
        [Required] public string OrgNummer { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required] public string City { get; set; }
        public string Notes { get; set; }
    }
}
