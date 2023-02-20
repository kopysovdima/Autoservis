﻿using System;

namespace Autoservis
{
    internal class Client
    {
        private int _money;
        private Car _car;
        private static Random _random = new Random();

        public Client(int money, Car car)
        {
            _money = money;
            _car = car;
        }

        public Client()
        {
            int minValueMoney = 300;
            int maxValueMoney = 2000;

            _money = _random.Next(minValueMoney, maxValueMoney);
            _car = new Car();
        }

        public bool PaySuccess(CarDetail carDetail)
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

        public void ShowInfo()
        {
            Console.WriteLine($"У клиента {_money} денег и сломана {_car.BrokenPartName}");
        }
    }
}
