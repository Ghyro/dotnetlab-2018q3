using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Context;
using DAL.Entities;

namespace Example
{
    public class SomeService
    {
        public void PrintItems()
        {
            using (var _context = new AppDbContext())
            {
                var items = _context.Items.ToList();

                var customers = _context.Customers.Include("Order.OrderItems").ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"Orders for customer {customer.Id} - {customer.Name}:");

                    foreach (var order in customer.Order)
                    {
                        Console.WriteLine($"Id: {order.Id}");

                        foreach (var orderItem in order.OrderItems)
                        {
                            var item = items.Single(i => i.Id == orderItem.ItemId);

                            Console.WriteLine($"{item.Id} - {item.Description} - ${item.Price} - {orderItem.Quantity}$");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}