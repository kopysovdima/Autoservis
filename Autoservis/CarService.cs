using System;
using System.Collections.Generic;

namespace Autoservis
{
    internal class CarService
    {
        private Random _random = new Random();
        private int _money = 0;
        private Queue<Client> _clientsQueue = new Queue<Client>();
        private PartWarehouse _partWarehouse = new PartWarehouse();

        public CarService()
        {
            CreateClientsQueue();
        }

        public void CreateClientsQueue()
        {
            for (int i = 0; i < _random.Next(7, 15); i++)
            {
                _clientsQueue.Enqueue(new Client());
            }
        }

        public void Work()
        {

            while (_clientsQueue.Count > 0)
            {
                Client client = _clientsQueue.Dequeue();
                CarDetail brokenDetail = client.GetCar().BrokenPartDetail;

                for (int i = 0; i < _partWarehouse.GetAutoParts().Count; i++)
                {
                    if (brokenDetail.Name.Equals(_partWarehouse.GetAutoParts()[i].Name))
                    {
                        if (client.PaySuccess(_partWarehouse.GetAutoParts()[i]))
                        {
                            int repairPrice = _partWarehouse.GetAutoParts()[i].Price / 10 * 2;
                            _money += _partWarehouse.GetAutoParts()[i].Price + repairPrice;
                            _partWarehouse.RemoveDetail(_partWarehouse.GetAutoParts()[i]);

                            Console.WriteLine($"Баланс Сервиса {_money}, клиент купил {client.GetCar().BrokenPartName} стоимостью {client.GetCar().BrokenPartPrice}, Стоимость работ {repairPrice}");
                        }
                        else
                        {
                            Console.WriteLine("не хватило денег у клиента");
                        }
                    }
                }
            }
        }
    }
}