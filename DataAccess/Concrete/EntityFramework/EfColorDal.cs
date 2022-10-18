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
    public class EfColorDal : IColorDal
    {
        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();

            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);

            }
        }

        public void Add(Color entity)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var addedEntity = context.Entry(entity); //TrackingData.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Color entity)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var updatedEntity = context.Entry(entity); //TrackingData.
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var deletedEntity = context.Entry(entity); //TrackingData.
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
