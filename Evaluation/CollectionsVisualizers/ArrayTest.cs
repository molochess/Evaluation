namespace Evaluation.Collections;

public class ArrayTest
{
    private readonly int[,] numbers = new int[105, 105];
    private string[,] strings = new string[105, 105];
    public DateTime[,] dates = new DateTime[10, 10];
    public ArrayTest()
    {
        for (int i = 0; i < numbers.GetLength(0); i++) 
        {
            for (int j = 0; j < numbers.GetLength(1); j++) 
            {
               
                numbers[i, j] = i + j ;
                strings[i, j] = "abc@#$" + i + j;
            }
        }
        
        for (int i = 0; i < 9; i++) 
        {
            for (int j = 0; j < 9; j++) 
            {
                dates[i,j] = DateTime.Now;
                    
            }
        }
    }
}