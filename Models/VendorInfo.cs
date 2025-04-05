/*
 * FakturaAlex v1.0
 * 
 * File: VendorInfo.cs
 * Author: Alexander Blohmé <alexander@thrino.no>
 * Date: April 5, 2025
 * Description: Vendor info static class
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
    public static class VendorInfo
    {
        public static string CompanyName => "Mitt AS";
        public static string OrgNumber => "999 999 999";

        // Du kan legge til mer her om ønskelig:
        public static string Address => "Fakturaveien 1";
        public static string Zip => "1234";
        public static string City => "OSLO";

        public static string FullAddress =>
            $"{Address}, {Zip} {City}";
    }

}
