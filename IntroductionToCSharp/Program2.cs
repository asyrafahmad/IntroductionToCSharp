using System;


//****************************   **PART 36  (Delegates)  ******************************//
/* 
 * same as class
 * delegates is r
 * 
 */


public delegate void HelloFunctionDelegate(string Message);

class Pragim
{
    public static void Main()
    {
        // A delegate is a type safe function pointer
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from Delegate");

    }

    public static void Hello (string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}

