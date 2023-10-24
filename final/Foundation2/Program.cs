class Program
{
    public static void Main()
    {
        Random random = new Random();
        
        int firstProductIndex = random.Next(Product.Products.Count);
        int secondProductIndex = random.Next(Product.Products.Count);

        int firstCustomerIndex = random.Next(Product.Products.Count);
        int secondCustomerIndex = random.Next(Product.Products.Count);

        Console.Clear();
        Console.WriteLine($"Total Price: ${Order.TotalCost(firstProductIndex, secondProductIndex)}");
        Console.WriteLine($"First product: {Product.Products[firstCustomerIndex][0]}, " + $"{Product.Products[firstCustomerIndex][1]}, " + $"Quantity: {Product.Products[firstCustomerIndex][2]}");
        Console.WriteLine($"Second product: {Product.Products[secondCustomerIndex][0]}, " + $"{Product.Products[secondCustomerIndex][1]}, " + $"Quantity: {Product.Products[secondCustomerIndex][2]}");
        Console.WriteLine($"\nName: {Customer.Name}\n" + $"Address: {Customer.Address.FullAddress}");
        Console.WriteLine("\n(Refresh to get a different order)\n");
    }
}

class Order
{
    private static List<List<string>> products = Product.Products;
    
    public static int TotalCost(int First, int Second)
    {
        int total = Convert.ToInt32(products[First][2]) * Convert.ToInt32(products[First][3])
            + Convert.ToInt32(Product.Products
            [Second][2]) * Convert.ToInt32(products[Second][3]);

        if (Customer.USQuery())
        {
            return total + 5;
        }
        else
        {
            return total + 35;
        }
    }

    public static string ProductInfo(int First, int Second)
    {
        string allInfo = $"{products[First][0]}|" + $"{products[First][1]}\n" +
            $"{products[Second][0]}|" + $"{products[Second][1]}";

        return allInfo;
    }


    public static string CustomerInfo(int First, int Second)
    {
        string customerInfo = $"Name:{Customer.Name}|" + $"Address: {Customer.Address.FullAddress}";

        return customerInfo;
    }
}

class Product
{
    // Define and initialize the products list
    private static List<List<string>> products = new List<List<string>>()
    {
        new List<string> { "Carrots", "ID:1", "3", "7" },
        new List<string> { "Lemons", "ID:2", "4", "10" },
        new List<string> { "Cakes", "ID:3", "15", "4" }
    };

    public static List<List<string>> Products
    {
        get
        {
            return products;
        }
    }
}

class Customer
{
    private static readonly string _name = "Bartholomew";

    public static string Name
    {
        get
        {
            return _name;
        }
    }

    public static bool USQuery()
    {
        return Address.USQuery();
    }

    public class Address
    {
        private static string _address = "221 Baker Street, Westminster, UK";

        public static string FullAddress
        {
            get
            {
                return _address;
            }
        }

        public static bool USQuery()
        {
            if (_address.ToLower().Contains("us"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string AllFields()
        {
            if (USQuery())
            {
                return $"{_address} \nLives in the US: false";
            }
            else
            {
                return $"{_address} \nLives in the US: false";
            }
        }
    }
}
