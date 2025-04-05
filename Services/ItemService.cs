/*
 * FakturaAlex v1.0
 * 
 * File: ItemService.cs
 * Author: Alexander Blohmé <alexander@thrino.no>
 * Date: April 5, 2025
 * Description: ItemService class
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
using FakturaAlex.Database;
using FakturaAlex.Models;

namespace FakturaAlex.Services
{
    public class ItemService
    {
        private readonly ApplicationDbContext _context;

        public ItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public Item GetItemById(int id)
        {
            return _context.Items.FirstOrDefault(i => i.ItemId == id);
        }
    }
}
