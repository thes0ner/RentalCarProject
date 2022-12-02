using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager details = new CarManager(new EfCarDal());
            UserManager user = new UserManager(new EfUserDal());

            ////DTO's
            //var brandId = details.GetCarDetailsByBrandId(2);
            //var colorId = details.GetCarsByColorId(1);
            //var id = details.GetCarDetailsById(5);


            //Console.WriteLine("#########DTO'S BRAND-TABLE#########\n");
            //foreach (var car in brandId.Data)
            //{
            //    Console.WriteLine($"Id: {car.Id}\nBrand: {car.BrandName}\nColor:{car.ColorName}\nDaily Price:{car.DailyPrice}\nDescription: {car.Description}");
            //}

            //Console.WriteLine("\n#########DTO'S CAR-TABLE#########\n");
            //foreach (var car in id.Data)
            //{
            //    Console.WriteLine($"Id: {car.Id}\nBrand: {car.BrandName}\nColor:{car.ColorName}\nDaily Price:{car.DailyPrice}\nDescription: {car.Description}");
            //}

            //var result = details.GetCarById(5);

            //if (result.Success)
            //{
            //    Console.WriteLine(result.Data.DailyPrice);
            //}

            //foreach (var item in details.GetCarById(5))
            //{
            //    Console.WriteLine($"{item.}");
            //}

            var result1 = user.GetUsersById(1);
            if (result1.Success)
            {
                Console.WriteLine(result1.Data.FirstName);
            }




        }



    }
}
