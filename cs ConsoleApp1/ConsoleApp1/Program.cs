


class Consoleinit
{
    //  return type name

   
   
    /// <summary>
    ///  
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {

        double avg(int x, int y)
        {

            double average = ((x + y) / 2.0);
            return average;

        }

        int num1, num2,sum;
 
        string str1;
        Console.WriteLine("Welcome to MS539");
        Console.Write("please enter a string");
        str1 = Console.ReadLine();
        Console.WriteLine("the string you entere is " + str1);

        Console.WriteLine("Please enter a number");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine(" you entered number " + num1);

        Console.WriteLine("Please enter a number");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(" you entered number " + num2);
        sum = num1 + num2;


        if (num1 == num2)
        {
            Console.WriteLine(" num1 = num2");
        }
        else if (sum >13)
        {
            Console.WriteLine(" Sum is BIG");
        }
        else
        {
            Console.WriteLine(" sum is less than 13 and #s are not equal ");
           
        }
        Console.WriteLine("sum = " + sum + "num = " + num1);
        double result = avg(num1, num2);
        Console.WriteLine("average = " + result);

    }
}



