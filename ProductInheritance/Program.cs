using System;
using System.Collections.Generic;

namespace ProductInheritance {
    public class Program {

        static void Main(string[] args) {


            List<Product> salesOrder = new List<Product>();

            Product widget1 = new Widget("W1", 50, "Small", "Red");
            Product widget2 = new Widget("W2", 100, "Medium", "White");
            Product widget3 = new Widget("W3", 200, "Large", "Blue");
            Product service = new Service("SVC", 500, "Premium", 5);

            salesOrder.Add(widget1);
            salesOrder.Add(widget2);
            salesOrder.Add(widget3);
            salesOrder.Add(service);

            decimal salesOrderTotal = 0;

            foreach (Product p in salesOrder) {
                salesOrderTotal += p.Price;

                if (p is Widget) {
                    Widget w = p as Widget;
                    Console.WriteLine($"{w.Code} {w.Price:c} {w.Size} {w.Color}");
                    continue;
                }
                if (p is Service) {
                    Service s = p as Service;
                    Console.WriteLine($"{s.Code} {s.Price:c} {s.ServiceLevel} {s.NumberofYears}");
                    continue;
                }
            }
            Console.WriteLine($"Total sales order is {salesOrderTotal:c}"); 
        }
    }
}
