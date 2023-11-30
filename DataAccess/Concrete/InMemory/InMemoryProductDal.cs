using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        
        List<Car> _cars;

        public InMemoryProductDal() { 
         _cars = new List<Car>
         {
             new Car {Id=679, BrandId=12, ColorId=3, ModelYear=2023, DailyPrice=234.200, Description="renault clio"},
             new Car {Id=579, BrandId=12, ColorId=2, ModelYear=2022, DailyPrice=380.200, Description="renault megane"},
             new Car {Id=479, BrandId=34, ColorId=3, ModelYear=2024, DailyPrice=699.200, Description="bmw z4"},
             new Car {Id=379, BrandId=33, ColorId=1, ModelYear=2024, DailyPrice=900.200, Description="mercedes a180"}
         };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete= null;
            carToDelete = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int BrandId)
        {
            return _cars.Where(c => c.BrandId==BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
