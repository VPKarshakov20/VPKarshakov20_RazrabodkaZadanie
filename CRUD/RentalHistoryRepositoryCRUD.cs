using System;
using System.Collections.Generic;

public class RentalHistoryRepository
{
    private Dictionary<int, RentalHistory> rentalHistories = new Dictionary<int, RentalHistory>();

    public void Create(RentalHistory rentalHistory)
    {
        rentalHistories[rentalHistory.HistoryID] = rentalHistory;
    }

    public RentalHistory Read(int historyID)
    {
        rentalHistories.TryGetValue(historyID, out var rentalHistory);
        return rentalHistory;
    }

    public void Update(int historyID, int? carID = null, int? customerID = null, DateTime? rentalDate = null, DateTime? returnDate = null, decimal? totalAmount = null)
    {
        if (rentalHistories.TryGetValue(historyID, out var rentalHistory))
        {
            if (carID.HasValue)
                rentalHistory.CarID = carID.Value;
            if (customerID.HasValue)
                rentalHistory.CustomerID = customerID.Value;
            if (rentalDate.HasValue)
                rentalHistory.RentalDate = rentalDate.Value;
            if (returnDate.HasValue)
                rentalHistory.ReturnDate = returnDate.Value;
            if (totalAmount.HasValue)
                rentalHistory.TotalAmount = totalAmount.Value;
        }
    }

    public void Delete(int historyID)
    {
        rentalHistories.Remove(historyID);
    }
}
