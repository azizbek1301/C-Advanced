

int[] numbers = new int[] { 1, 4, 5, 6, 7, 6, 9, 4, 6, 6, 6, 5, 6 };

Console.WriteLine(Sum(numbers));

static int Sum(params int[] sonlarRoyxati)
{
    int sum = 0;
    foreach (var item in sonlarRoyxati)
    {
        sum += item;
    }
    return sum;
}


//if (args[0]=="Salom")
//    Console.WriteLine("Salom dunyo");
//else if (args[0]=="5")
//{

//}