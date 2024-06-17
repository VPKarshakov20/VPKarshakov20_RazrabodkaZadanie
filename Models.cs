public class RentalHistory
{
    public int HistoryID { get; set; }
    public int CarID { get; set; }
    public int CustomerID { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public decimal TotalAmount { get; set; }

    public RentalHistory(int historyID, int carID, int customerID, DateTime rentalDate, DateTime returnDate, decimal totalAmount)
    {
        HistoryID = historyID;
        CarID = carID;
        CustomerID = customerID;
        RentalDate = rentalDate;
        ReturnDate = returnDate;
        TotalAmount = totalAmount;
    }
}

public class Rental
{
    public int RentalID { get; set; }
    public int CarID { get; set; }
    public int CustomerID { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public decimal TotalAmount { get; set; }

    public Rental(int rentalID, int carID, int customerID, DateTime rentalDate, DateTime returnDate, decimal totalAmount)
    {
        RentalID = rentalID;
        CarID = carID;
        CustomerID = customerID;
        RentalDate = rentalDate;
        ReturnDate = returnDate;
        TotalAmount = totalAmount;
    }
}

public class Car
{
    public int CarID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string RegistrationNumber { get; set; }
    public decimal RentalRate { get; set; }
    public bool Available { get; set; }

    public Car(int carID, string brand, string model, int year, string color, string registrationNumber, decimal rentalRate, bool available)
    {
        CarID = carID;
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        RegistrationNumber = registrationNumber;
        RentalRate = rentalRate;
        Available = available;
    }
}

public class Customer
{
    public int CustomerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Customer(int customerID, string firstName, string lastName, string address, string phone, string email)
    {
        CustomerID = customerID;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Phone = phone;
        Email = email;
    }
}

public class RentalPayment
{
    public int PaymentID { get; set; }
    public int RentalID { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }

    public RentalPayment(int paymentID, int rentalID, DateTime paymentDate, decimal amount)
    {
        PaymentID = paymentID;
        RentalID = rentalID;
        PaymentDate = paymentDate;
        Amount = amount;
    }
}
