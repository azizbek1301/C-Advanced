

public class Program
{
    

    static void Main(string[] args)
    {
        
        Func<int, int, int> func = new Func<int, int, int>(Add);


    }

   

    static int Add(int a, int b)
    {
        return a + b ;
    }

    static int Subtract(int a,int b)
    { 
        return a - b;
    }
}