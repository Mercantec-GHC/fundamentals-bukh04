public class Chapter1
{
    string name = "Bob";
    int notifications = 3;
    double temp = 34.4;

    public void Print()
    {
        Console.WriteLine($"Hello, {name}! You have {notifications} messages in your inbox. The temperature is {temp} Celsius.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Chapter1 chapter1 = new Chapter1();
        chapter1.Print();

        string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        var orders = orderIDs.Where(x => x.Contains("B"));

        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }

        foreach (var order in orderIDs)
        {
            if (order.Contains("B"))
                Console.WriteLine(order);
        }

        foreach (string orderID in orderIDs)
        {
            if (orderID.StartsWith("B"))
            {
                Console.WriteLine(orderID);
            }
        }
        Console.WriteLine(Sale.GetDiscount());

        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{i} - FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} - Fizz");
            }
            else
            {
                Console.WriteLine($"{i} - Buzz");
            }
        }

        Console.WriteLine(Cases.GetProduct());

    }

    private static class Sale
    {
        public static int GetDiscount()
        {
            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50;
            return discount;
        }
    }

    private static class Cases
    {
        public static string GetProduct()
        {
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])

            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])

            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])

            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }
    
            var result = $"Product: {size} {color} {type}";
            return result;
        }
    }

}
