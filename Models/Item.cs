/*
 * FakturaAlex v1.0
 * 
 * File: Item.cs
 * Author: Alexander Blohmé <alexander@thrino.no>
 * Date: April 5, 2025
 * Description: Item entity class
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
    public class Item
    {
        public int ItemId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Discount { get; set; }
        public string Mva { get; set; }
    }
}
