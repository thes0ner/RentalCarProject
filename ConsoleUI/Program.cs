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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            CarAddTest();


            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"CarId: {item.Id} BrandId: {item.BrandId} ColorId: {item.ColorId} CarName: {item.Description}");
            }


            foreach (var item in brandManager.GetCarsByBrandId(1))
            {
                Console.WriteLine($"BrandId: {item.Id} BrandName: {item.Name}");
            }

            foreach (var item in colorManager.GetCarsByColorId(1))
            {
                Console.WriteLine($"ColorId: {item.Id} ColorName: {item.Name}");
            }


        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 3, Description = "D", ColorId = 1, DailyPrice = 1220, ModelYear = 2008 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }


    }
}
