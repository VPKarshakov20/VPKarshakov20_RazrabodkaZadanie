using System.Collections.Generic;

public class CarsRepository
{
    private Dictionary<int, Car> cars = new Dictionary<int, Car>();

    public void Create(Car car)
    {
        cars[car.CarID] = car;
    }

    public Car Read(int carID)
    {
        cars.TryGetValue(carID, out var car);
        return car;
    }

    public void Update(int carID, string brand = null, string model = null, int? year = null, string color = null, string registrationNumber = null, decimal? rentalRate = null, bool? available = null)
    {
        if (cars.TryGetValue(carID, out var car))
        {
            if (!string.IsNullOrEmpty(brand))
                car.Brand = brand;
            if (!string.IsNullOrEmpty(model))
                car.Model = model;
            if (year.HasValue)
                car.Year = year.Value;
            if (!string.IsNullOrEmpty(color))
                car.Color = color;
            if (!string.IsNullOrEmpty(registrationNumber))
                car.RegistrationNumber = registrationNumber;
            if (rentalRate.HasValue)
                car.RentalRate = rentalRate.Value;
            if (available.HasValue)
                car.Available = available.Value;
        }
    }

    public void Delete(int carID)
    {
        cars.Remove(carID);
    }
}
