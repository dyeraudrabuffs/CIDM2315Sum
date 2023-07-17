using System;

public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine("Customer ID: " + cus_id);
        Console.WriteLine("Customer Name: " + cus_name);
        Console.WriteLine("Customer Age: " + cus_age);
        Console.WriteLine();
    }

    public void CompareAge(Customer objCustomer)
    {
        if (cus_age > objCustomer.cus_age)
        {
            Console.WriteLine(cus_name + " is older.");
        }
        else if (cus_age < objCustomer.cus_age)
        {
            Console.WriteLine(objCustomer.cus_name + " is older.");
        }
        else
        {
            Console.WriteLine("Both customers have the same age.");
        }
    }
}