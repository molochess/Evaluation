using System.Collections.Concurrent;

namespace Evaluation.Collections;

public class ConcurrentDictionaryTest
{
    private readonly ConcurrentDictionary<int, Product> productConcurrentDictionary 
        = new ConcurrentDictionary<int, Product>();
    
    public ConcurrentDictionaryTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productConcurrentDictionary.TryAdd(id, Product.GenerateRandomProduct(id));
        }
    }
}