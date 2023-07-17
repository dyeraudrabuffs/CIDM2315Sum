public class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);

        Console.WriteLine("");
        
        c1.PrintCusInfo();
        c2.PrintCusInfo();

        c1.ChangeID(220);
        c2.ChangeID(221);

        Console.WriteLine("Updated:");
        Console.WriteLine("");
        c1.PrintCusInfo();
        c2.PrintCusInfo();

      
        Console.WriteLine("");
        c1.CompareAge(c2);
    }
}       //code would not run as I had it. Asked GPT to fix errors. Added: this.cus_id = cus_id;
        //this.cus_name = cus_name;
        //this.cus_age = cus_age; to customer class