﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var addedEntity = context.Entry(entity); //TrackingData.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var deletedEntity = context.Entry(entity); //TrackingData.
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Car entity)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var updatedEntity = context.Entry(entity); //TrackingData.
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                return filter == null 
                    ? context.Set<Car>().ToList() 
                    : context.Set<Car>().Where(filter).ToList(); 
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
                    
                    
            }
        }
    }
}
