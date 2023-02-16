using System;
using System.Collections.Generic;

namespace Autoservis
{
    internal class PartWarehouse
    {
        private List<CarDetail> _autoparts = new List<CarDetail>();
        private Random _random = new Random();

        public PartWarehouse()
        {
            for (int i = 0; i < _random.Next(30, 60); i++)
            {
                List<CarDetail> autoparts = new DetailCatalog().GetDetails();

                _autoparts.Add(autoparts[_random.Next(autoparts.Count)]);
            }
        }

        public List<CarDetail> GetDetails()
        {
            return new List<CarDetail>(_autoparts);
        }

        public void ShowInfo()
        {
            foreach (var autopart in _autoparts)
            {
                Console.WriteLine($" Деталь - {autopart.Name} её цена - {autopart.Price}");
            }
        }

        public List<CarDetail> GetAutoParts()
        {
            return _autoparts;
        }

        public void RemoveDetail(CarDetail carDetail)
        {
            _autoparts.Remove(carDetail);
        }
    }
}
