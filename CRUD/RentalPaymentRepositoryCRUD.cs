using System;
using System.Collections.Generic;

public class RentalPaymentsRepository
{
    private Dictionary<int, RentalPayment> rentalPayments = new Dictionary<int, RentalPayment>();

    public void Create(RentalPayment rentalPayment)
    {
        rentalPayments[rentalPayment.PaymentID] = rentalPayment;
    }

    public RentalPayment Read(int paymentID)
    {
        rentalPayments.TryGetValue(paymentID, out var rentalPayment);
        return rentalPayment;
    }

    public void Update(int paymentID, int? rentalID = null, DateTime? paymentDate = null, decimal? amount = null)
    {
        if (rentalPayments.TryGetValue(paymentID, out var rentalPayment))
        {
            if (rentalID.HasValue)
                rentalPayment.RentalID = rentalID.Value;
            if (paymentDate.HasValue)
                rentalPayment.PaymentDate = paymentDate.Value;
            if (amount.HasValue)
                rentalPayment.Amount = amount.Value;
        }
    }

    public void Delete(int paymentID)
    {
        rentalPayments.Remove(paymentID);
    }
}
