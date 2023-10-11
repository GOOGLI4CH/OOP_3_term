using System.Collections.Generic;
using System.Linq;

namespace lab06
{
    internal class GymController<T> where T : Inventory.Inventory
    {
        private GymContainer<T> _container;

        public GymController(GymContainer<T> container)
        {
            if (container == null)
            {
                throw new CustomException("null не может выступать в качестве контейнера");
            }

            _container = container;
        }

        public void SortInventoryByPrice()
        {
            _container.SportEquipment.Sort(
                (item1, item2) => item1.EquipmentInfo.Price.CompareTo(item2.EquipmentInfo.Price)
                );
        }

        public List<T> FindItemsInPriceRange(double minPrice, double maxPrice)
        {
            return _container.SportEquipment.Where(
                item => item.EquipmentInfo.Price >= minPrice && item.EquipmentInfo.Price <= maxPrice
                ).ToList();
        }
    }
}
