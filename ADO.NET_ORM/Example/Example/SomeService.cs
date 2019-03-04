using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Context;
using DAL.Entities;

namespace Example
{
    public class SomeService
    {
        public void DoSmth()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.ToList();

                this.PrintItems(items.ToList());
            }
        }

        private void PrintItems(List<Item> items)
        {
            Console.WriteLine($"Items count: {items.Count}");

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} - {item.Description} - {item.Price}");
            }
        }
    }
}