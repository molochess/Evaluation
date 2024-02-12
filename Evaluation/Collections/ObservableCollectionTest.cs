using System.Collections.Concurrent;
using System.Collections.ObjectModel;

namespace Evaluation.Collections;

public class ObservableCollectionTest
{
    private readonly ObservableCollection<Product> productConcurrentDictionary 
        = new ObservableCollection<Product>();
    
    public ObservableCollectionTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productConcurrentDictionary.Add(Product.GenerateRandomProduct(id));
        }
    }
}