using System.Collections.Generic;

public class CustomersRepository
{
    private Dictionary<int, Customer> customers = new Dictionary<int, Customer>();

    public void Create(Customer customer)
    {
        customers[customer.CustomerID] = customer;
    }

    public Customer Read(int customerID)
    {
        customers.TryGetValue(customerID, out var customer);
        return customer;
    }

    public void Update(int customerID, string firstName = null, string lastName = null, string address = null, string phone = null, string email = null)
    {
        if (customers.TryGetValue(customerID, out var customer))
        {
            if (!string.IsNullOrEmpty(firstName))
                customer.FirstName = firstName;
            if (!string.IsNullOrEmpty(lastName))
                customer.LastName = lastName;
            if (!string.IsNullOrEmpty(address))
                customer.Address = address;
            if (!string.IsNullOrEmpty(phone))
                customer.Phone = phone;
            if (!string.IsNullOrEmpty(email))
                customer.Email = email;
        }
    }

    public void Delete(int customerID)
    {
        customers.Remove(customerID);
    }
}
