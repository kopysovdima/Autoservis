using System;
using System.Collections.Generic;

namespace Autoservis
{
    internal class PartWarehouse
    {
        private static Random _random = new Random();
        private List<CarDetail> _autoparts = new List<CarDetail>();

        public PartWarehouse()
        {
            int maxValueDetails = 50;
            int minValueDetails = 30;

            for (int i = 0; i < _random.Next(minValueDetails, maxValueDetails); i++)
            {
                List<CarDetail> autoparts = new DetailCatalog().GetDetails();

                _autoparts.Add(autoparts[_random.Next(autoparts.Count)]);
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
