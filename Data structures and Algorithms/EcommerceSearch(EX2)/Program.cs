using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    static int LinearSearch(Product[] products, int key)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].ProductId == key)
                return i;
        }
        return -1;
    }

    static int BinarySearch(Product[] products, int key)
    {
        int low = 0, high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (products[mid].ProductId == key)
                return mid;
            else if (products[mid].ProductId < key)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Phone","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Bag","Fashion")
        };

        int key = 104;

        int linear = LinearSearch(products, key);
        Console.WriteLine("Linear Search Index: " + linear);

        int binary = BinarySearch(products, key);
        Console.WriteLine("Binary Search Index: " + binary);
    }
}