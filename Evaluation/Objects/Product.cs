namespace Evaluation.Objects;
public class Product : IComparable<Product>
{
    public int Id { get; set; }
    public string Name { get; set; }
    private double Price { get; set; }
    public static string Category { get; set; }
    private static int QuantityInStock { get; set; }

    public Product(int id, string name, double price, string category, int quantityInStock)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
        QuantityInStock = quantityInStock;
    }

    public static Product GenerateRandomProduct(int id)
    {
        Random random = new Random();
        string[] categories = new string[] { "Electronics", "Clothing", "Groceries", "Books", "Home & Garden" };
        string name = $"Product {id}";
        double price = Math.Round(random.NextDouble() * 100 + 1, 2);
        string category = categories[random.Next(categories.Length)];
        int quantityInStock = random.Next(1, 51);

        return new Product(id, name, price, category, quantityInStock);
    }

    public int CompareTo(Product other)
    {
        return this.Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        return $"Product ID: {Id}, Name: {Name}, Price: ${Price}, Category: {Category}, Quantity in Stock: {QuantityInStock}";
    }
}