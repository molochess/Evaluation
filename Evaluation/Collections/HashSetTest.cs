namespace Evaluation.Collections;

public class HashSetTest
{
    private readonly HashSet<Product> productHashSet = new HashSet<Product>();
    
    public HashSetTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productHashSet.Add(Product.GenerateRandomProduct(id));
        }
    }
}