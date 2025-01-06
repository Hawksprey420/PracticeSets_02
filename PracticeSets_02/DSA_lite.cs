using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PracticeSets_02
{
    internal class DSA_lite
    {
        public static async Task DSA_lite1()
        {
            const int orderCount = 10000; // Generate 10^4 orders
            var orderQueue = new BlockingCollection<Order>();
            var processingQueue = new BlockingCollection<Order>();

            var log = new List<string>();
            var orders = GenerateTestOrders(orderCount);

            var tasks = new List<Task>
            {
                Task.Run(() => Ordering_Placement(orders, orderQueue, log)),
                Task.Run(() => Processing_Order(orderQueue, processingQueue, log)),
                Task.Run(() => Shipping_Order(processingQueue, log))
            };

            await Task.WhenAll(tasks);

            Console.WriteLine("\nOrder Processing Log:");
            foreach (var entry in log)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
            SaveLogToFile(log, "OrderLog.txt");
        }

        class Order
        {
            public int Customer_OrderId { get; set; }
            public string Customer_Name { get; set; }
            public List<string> Order_Items { get; set; }
            public string Customer_Address { get; set; }
        }

        const int PlacementDelay = 1000;
        const int ProcessingDelay = 2000;
        const int ShippingDelay = 1500;

        static async Task Ordering_Placement(List<Order> orders, BlockingCollection<Order> orderQueue, List<string> log)
        {
            foreach (Order order in orders)
            {
                SimulateDelay("Placing Order", PlacementDelay);
                orderQueue.Add(order);
                lock (log)
                {
                    log.Add($"Order {order.Customer_OrderId}: Placed by {order.Customer_Name}");
                }
            }
            orderQueue.CompleteAdding();
        }

        static async Task Processing_Order(BlockingCollection<Order> orderQueue, BlockingCollection<Order> processingQueue, List<string> log)
        {
            foreach (var order in orderQueue.GetConsumingEnumerable())
            {
                SimulateDelay($"Processing Order {order.Customer_OrderId}", ProcessingDelay);
                lock (log)
                {
                    log.Add($"Order {order.Customer_OrderId}: Processed - Items packed: {string.Join(", ", order.Order_Items)}");
                }
                processingQueue.Add(order);
            }
            processingQueue.CompleteAdding();
        }

        static async Task Shipping_Order(BlockingCollection<Order> processingQueue, List<string> log)
        {
            foreach (var order in processingQueue.GetConsumingEnumerable())
            {

                SimulateDelay($"Shipping Order {order.Customer_OrderId}", ShippingDelay);
                lock (log)
                {
                    log.Add($"Order {order.Customer_OrderId}: Shipped to {order.Customer_Address}");
                }
            }
        }
        static List<string> availableItems = new List<string>
        {
            "Laptop", "Mouse", "Keyboard", "Tablet", "Phone", "Headphones", "Gymrat-Protein", "Lipstick"
        };

        static void SaveLogToFile(List<string> log, string filePath)
        {
            System.IO.File.WriteAllLines(filePath, log);
            Console.WriteLine($"Log saved to {filePath}");
        }

        static List<Order> GenerateTestOrders(int orderCount)
        {
            var orders = new List<Order>();
            var random = new Random();

            for (int i = 0; i < orderCount; i++)
            {
                var itemCount = random.Next(1, 5); // Each order has between 1 and 4 items
                var items = new List<string>();
                for (int j = 0; j < itemCount; j++)
                {
                    items.Add(availableItems[random.Next(availableItems.Count)]);
                }

                orders.Add(new Order
                {
                    Customer_OrderId = i + 1,
                    Customer_Name = $"Customer_{i + 1}",
                    Customer_Address = $"Address_{i + 1}",
                    Order_Items = items
                });
            }

            return orders;
        }

        static void SimulateDelay(string process, int delay)
        {
            Console.Write($"{process}: ");
            int steps = delay / 500;
            for (int i = 0; i < steps; i++) // Update progress every 500ms
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine(" Done!");
        }
    }
}
