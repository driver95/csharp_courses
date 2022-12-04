﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxes = new List<Box>();
            while((input = Console.ReadLine()) != "end")
            {
                string[] boxInfo = input.Split();

                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);

                foreach(var crate in boxes.OrderByDescending(x => x.PricePerBox))
                {
                    Console.WriteLine(box.SerialNumber);
                    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}:{box.Quantity}");
                    Console.WriteLine($"-- {box.PricePerBox:f2}");
                }
            }
        }
    }
    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }
        public string SerialNumber { get; set; }
        public Item Item{ get; set; }
        public int Quantity { get; set; }
        public decimal PricePerBox
        {
            get
            {
                return Quantity * Item.Price;
            }
        } 
    }
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}