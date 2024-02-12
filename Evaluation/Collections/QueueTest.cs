namespace Evaluation.Collections;

public class QueueTest
{
    private readonly Queue<Product> productQueue = new Queue<Product>();
    
    public QueueTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productQueue.Enqueue(Product.GenerateRandomProduct(id));
        }
    }
}