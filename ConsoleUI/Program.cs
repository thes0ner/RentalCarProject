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
            //RentalAddTest();

            RentalDeleteTest();
        }

        private static void RentalDeleteTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental()
            {
                Id= 2,
            };

            //rentalManager.Add(rental);
            Console.WriteLine(rentalManager.Delete(rental).Message);
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental()
            {
                CarId = 7,
                CustomerId = 1,
                RentDate = new DateTime(2022, 12, 1),
                ReturnDate = null
            };

            //rentalManager.Add(rental);
            Console.WriteLine(rentalManager.Add(rental).Message);
        }

        private static UserManager UserAddTest()
        {
            UserManager user = new UserManager(new EfUserDal());
            user.Add(new User { FirstName = "Soner", LastName = "Abduramanov", Email = "soner@outlook.com", Password = "1q2w3e4r5t6y!" });
            return user;
        }

        private static CustomerManager CustomerAddTest()
        {
            CustomerManager customer = new CustomerManager(new EfCustomerDal());
            customer.Add(new Customer { UserId = 1, CompanyName = "Falcon X", Address = "Street1 Skopje", City = "Skopje", Country = "Macedonia" });
            return customer;
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
