using System.Collections.Generic;

namespace Autoservis
{
    internal class DetailCatalog
    {
        private List<CarDetail> _detailCatalog = new List<CarDetail>();

        public DetailCatalog()
        {
            _detailCatalog.Add(new CarDetail("Стекло", 50));
            _detailCatalog.Add(new CarDetail("Дверь", 150));
            _detailCatalog.Add(new CarDetail("Бампер", 75));
            _detailCatalog.Add(new CarDetail("Двигатель", 1000));
            _detailCatalog.Add(new CarDetail("Каробка передач", 750));
            _detailCatalog.Add(new CarDetail("Фара", 300));
            _detailCatalog.Add(new CarDetail("Богажник", 100));
        }

        public List<CarDetail> GetDetails()
        {
            return new List<CarDetail>(_detailCatalog);
        }
    }
}
