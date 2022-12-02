using Core.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarById(int carId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        //DTO'S
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsById(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

    }
}
