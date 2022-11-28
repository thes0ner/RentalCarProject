using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager details = new CarManager(new EfCarDal());
            
            //DTO's
            var brandId = details.GetCarDetailsByBrandId(2);
            var colorId = details.GetCarsByColorId(1);
            var id = details.GetCarDetailsById(5);


            Console.WriteLine("#########DTO'S BRAND-TABLE#########\n");
            foreach (var car in brandId.Data)
            {
                Console.WriteLine($"Id: {car.Id}\nBrand: {car.BrandName}\nColor:{car.ColorName}\nDaily Price:{car.DailyPrice}\nDescription: {car.Description}");
            }

            Console.WriteLine("\n#########DTO'S CAR-TABLE#########\n");
            foreach (var car in id.Data)
            {
                Console.WriteLine($"Id: {car.Id}\nBrand: {car.BrandName}\nColor:{car.ColorName}\nDaily Price:{car.DailyPrice}\nDescription: {car.Description}");
            }
        }



    }
}
