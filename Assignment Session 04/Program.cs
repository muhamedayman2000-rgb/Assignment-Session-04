// See https://aka.ms/new-console-template for more information


internal static class Program
{
    static int calculate(int num1, int num2, char op, int result)
    {
        switch (op)
        {

            case '+':
                result = num1 + num2;
                break;
                case '-':
                result = num1 - num2;
                break;
                default:
                Console.WriteLine("enter valid operation");
                break;
        }
                return result;

    }
    static void SummitionOfDigits(int num)
    {
        int sum = 0;
        int n = num;
        while (num > 0)
        {

            sum += num % 10;

            int remaider = num / 10;
            num= remaider;


        }
        Console.WriteLine($"  The sum of the digits of the number {n} is : {sum} ");
    
    }
    static void ReadArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter element {i + 1} : ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    static void MinMaxArray(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];

        }
        Console.WriteLine($"The maximum element in array : {max}");
        Console.WriteLine($"The minimum element in array : {min}");

    }
    static void Factorial(int num) 
    { 
     for (int i = num-1; i > 0; i--)
        {
            num *= i;
        }
        Console.WriteLine($"The factorial of the number is : {num}");

    }
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static void ChangeValue(int x)
    {
        x = 100;
    }
    static void ChangeValue1(int x)
    {
        x = 100;
    }
    private static void Main(string[] args)
    {
        #region Q3
        //int result = calculate(10, 5, '+', 0);
        // Console.WriteLine( result ); 
        #endregion

        #region Q4
        //SummitionOfDigits(568); 
        #endregion

        #region Q5

        //int num = int .Parse(Console.ReadLine());
        //if(IsPrime(num))
        //    Console.WriteLine("The number is prime");
        //else
        //    Console.WriteLine("The number is not prime"); 
        #endregion

        #region Q6
        //int[] arr = new int[5];
        //ReadArray(arr);
        //MinMaxArray(arr); 
        #endregion

        #region Q7
        //Factorial(5); 
        #endregion


    }
}

