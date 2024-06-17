using System;
using System.Collections.Generic;

public class RentalsRepository
{
    private Dictionary<int, Rental> rentals = new Dictionary<int, Rental>();

    public void Create(Rental rental)
    {
        rentals[rental.RentalID] = rental;
    }

    public Rental Read(int rentalID)
    {
        rentals.TryGetValue(rentalID, out var rental);
        return rental;
    }

    public void Update(int rentalID, int? carID = null, int? customerID = null, DateTime? rentalDate = null, DateTime? returnDate = null, decimal? totalAmount = null)
    {
        if (rentals.TryGetValue(rentalID, out var rental))
        {
            if (carID.HasValue)
                rental.CarID = carID.Value;
            if (customerID.HasValue)
                rental.CustomerID = customerID.Value;
            if (rentalDate.HasValue)
                rental.RentalDate = rentalDate.Value;
            if (returnDate.HasValue)
                rental.ReturnDate = returnDate.Value;
            if (totalAmount.HasValue)
                rental.TotalAmount = totalAmount.Value;
        }
    }

    public void Delete(int rentalID)
    {
        rentals.Remove(rentalID);
    }
}
