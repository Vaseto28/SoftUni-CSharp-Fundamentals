using System;
using System.Linq;
using System.Collections.Generic;

namespace T06.StoreBoxes
{
    class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public Box(string serealNumber, Item item, int quantity)
        {
            this.SerialNumber = serealNumber;
            this.Item = item;
            this.Quantity = quantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceForTheBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string serealNumber = arguments[0];
                int itemQuantity = int.Parse(arguments[2]);
                Item currItem = new Item(arguments[1], decimal.Parse(arguments[3]));
                Box currBox = new Box(serealNumber, currItem, itemQuantity);
                currBox.PriceForTheBox = itemQuantity * currItem.Price;
                boxes.Add(currBox);
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(x => x.PriceForTheBox).ToList();

            for (int i = 0; i < orderedBoxes.Count; i++)
            {
                Console.WriteLine(orderedBoxes[i].SerialNumber);
                Console.WriteLine($"-- {orderedBoxes[i].Item.Name} - ${orderedBoxes[i].Item.Price:f2}: {orderedBoxes[i].Quantity}");
                Console.WriteLine($"-- ${orderedBoxes[i].PriceForTheBox:f2}");
            }
        }
    }
}
