using System;

class Program
{
    //Task 1

    //static void PrintEvenNumbers()

    //{
    //    for (int i = 2; i < 90; i++)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    PrintEvenNumbers();
    //}



    //Task 2
    //static void PirintOddNumbers(int a, int b)
    //{
    //    int min = Math.Min(a, b);
    //    int max = Math.Max(a, b);

    //       for(int i = min + 1; i < max; i++)

    //    {
    //        if (i % 3 == 0)

    //        {
    //            Console.WriteLine(i);
    //            Console.ReadLine();
    //        }
    //    }      

    //}


    //Task 3

    static void EnBoyukReqem(int eded)
    {

        int maxReqem = 0;
        while (eded > 0)
        {
            int qaliq = eded & 10;
            if(qaliq > maxReqem)
            {
                maxReqem = qaliq;
            }
            eded /= 10;
        }
        Console.WriteLine(maxReqem);

    }
     
}






