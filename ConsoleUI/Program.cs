using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            var carDetails = carManager.GetCarDetails();
            var res = carManager.GetAll().

            if (carDetails.Success == true)
            {
                foreach (var carDetail in carDetails.Data)
                {
                    Console.WriteLine($"{carDetail.Id}  {carDetail.BrandName}  {carDetail.ColorName}");
                }
            }
            else
            {
                Console.WriteLine(carDetails.Message);
            }

        }

        private static void CarUpdateTest()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.Update(new Car { Id = 6, BrandId = 1, ColorId = 2, DailyPrice = 200, Description = "Merco", ModelYear = 2008 });
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 4 });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 3, Description = "DODGE1", ColorId = 1, DailyPrice = 2000, ModelYear = 2022 });

        }


    }
}
