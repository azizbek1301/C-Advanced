
#region Collections

//Dictionary<string,string> weekdays=new Dictionary<string,string>();

//weekdays.Add("Uzbekistan", "Tashkent");
//weekdays.Add("Rjussia", "Moskow");
//weekdays.Add("Usa", "Washington");

//Console.WriteLine(weekdays["Usa"]);

//Stack<int> numbers = new Stack<int>();

//numbers.Push(1);
//numbers.Push(12);
//numbers.Push(15);

//foreach (var num in numbers)
//{
//    Console.WriteLine(num + " ");
//}

//static void PrintValuesOfStack()
//{

//}

#endregion

#region Delegatlar


//static int Add(int a, int b) => a + b;



//Do add = Add;
//public delegate int Do(int a, int b);

class Program
{
    
    static void Main(string[] args)
    {

        Func<string,int, char ,bool> check = (s,i,c) => s[i]==c;
        

        Action<string> print = (s)=> Console.WriteLine(s);


        print(check("Azizbek", 2, 'i').ToString());
    }

    static void ConvertAll(int[] ar,Action<int> action)
    {
        foreach(var number in ar)
        {
            action(number);
        }
    }

    
  
}







#endregion
