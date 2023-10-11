using System;
using System.Collections.Generic;

namespace lab06
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
            if (item == null)
            {
                throw new CustomException("Невозможно добавить null-элемент");
            }

            if (SportEquipment.Contains(item))
            {
                throw new NotFoundException($"Элемент {item} уже существует");
            }

            if (Budget > item.EquipmentInfo.Price)
            {
                SportEquipment.Add(item);
                Budget -= item.EquipmentInfo.Price;
            }
            else
            {
                throw new CustomException("Не удалось добавить снаряд: Превышение допустимого бюджета");
            }
        }

        public void Remove(T item) 
        {
            if (item == null)
            {
                throw new CustomException("Невозможно удалить null-элемент");
            }

            if (!SportEquipment.Contains(item))
            {
                throw new NotFoundException($"Элемент {item} не найден в списке снарядов");
            }

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
