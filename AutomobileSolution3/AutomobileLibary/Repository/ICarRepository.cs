﻿using System.Collections;
using AutomobileLibary.DataAccess;
namespace AutomobileLibary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);
    }
}