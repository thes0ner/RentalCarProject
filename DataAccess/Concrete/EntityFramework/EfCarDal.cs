using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalCarContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = br.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description

                             };
                return result.ToList();
            }


        }


        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = br.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();

            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = br.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();


            }
        }

        public List<CarDetailDto> GetCarDetailsById(int carId)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.Id == carId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = br.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();


            }
        }

    }
}
