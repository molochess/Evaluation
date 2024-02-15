using Evaluation.Objects;

namespace Evaluation.Collections;

public class DictionaryTest
{
    private readonly Dictionary<int, Product> productDictionary = new Dictionary<int, Product>();

    public DictionaryTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productDictionary.Add(id, Product.GenerateRandomProduct(id));
        }
    }
}