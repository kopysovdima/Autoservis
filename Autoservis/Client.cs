using System;

namespace Autoservis
{
    internal class Client
    {
        private static Random _random = new Random();
        private int _money;
        private Car _car;

        public Client()
        {
            int minValueMoney = 300;
            int maxValueMoney = 2000;

            _money = _random.Next(minValueMoney, maxValueMoney);
            _car = new Car();
        }

        public bool TryPay(CarDetail carDetail)
        {
            if (carDetail.Price <= _money)
            {
                _money = _money - carDetail.Price;
                return true;
            }

            return false;
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
