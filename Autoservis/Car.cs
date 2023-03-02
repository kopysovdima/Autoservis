using System;
using System.Collections.Generic;

namespace Autoservis
{
    internal class Car
    {
        private static Random _random = new Random();
        private CarDetail _brokenPart;
        private List<CarDetail> _carDetails;

        public Car()
        {
            _carDetails = new DetailCatalog().GetDetails();
            _brokenPart = _carDetails[_random.Next(_carDetails.Count)];
        }

        public string BrokenPartName => _brokenPart.Name;
        public int BrokenPartPrice => _brokenPart.Price;
        public CarDetail BrokenPartDetail => _brokenPart;

    }
}
