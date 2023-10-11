using System;
using System.Collections.Generic;

namespace lab05
{
    internal class GymContainer<T> where T : Inventory.Inventory
    {
        public List<T> SportEquipment { get; private set; }

        public double Budget { get; set; }

        public GymContainer(double budget) 
        { 
            SportEquipment = new List<T>();
            Budget = budget;
        }
        
        public void Add(T item) 
        {
            if (Budget > item.EquipmentInfo.Price)
            {
                SportEquipment.Add(item);
                Budget -= item.EquipmentInfo.Price;
            }
            else
            {
                Console.WriteLine($"Не хватает бюджета! {item}");
            }
        }

        public void Remove(T item) 
        { 
            SportEquipment.Remove(item);
        }
        
        public void ShowInventory()
        {
            foreach (T item in SportEquipment)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
