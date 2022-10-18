﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else if (car.Description.Length >= 2 && car.DailyPrice <= 0)
                Console.WriteLine("Sorry, Daily Price must be greather than 0, please try again!");
            else if (car.Description.Length < 2 && car.DailyPrice > 0)
                Console.WriteLine("Sorry, Car name must be upper than one character, please try again!");
            else
                Console.WriteLine("Sorry,Car name must be upper than one character and Daily Price must be greather than 0, please try again! ");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return (List<Car>)_carDal.GetAll().Where(c => c.Id == id);
        }
    }
}