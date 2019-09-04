//using System;



   // ***************** PART 1 & 2   *************************//

//class Program
//{

//    static void Main1()
//    {
//        Console.WriteLine("Welcome to C# Training 1");
//    }

//    static void Main()
//    {
//        Console.WriteLine("Welcome to C# Training");
//        Main1();


//        Console.WriteLine("Please enter your firstname");
//        string FirstName = Console.ReadLine();

//        Console.WriteLine("Please enter your lastname");
//        string LastName = Console.ReadLine();

//        Console.WriteLine("Hello {0} {1}", FirstName, LastName);   // Place holder syntax - Most Preferred
//        Console.WriteLine("Hello " + FirstName);                   // Concatenation
//    }




//    //*****************   PART 3 (Built In-Types)  *************************//

//    //static void Main()
//    //{
//    //    int i = 0;

//    //    Console.WriteLine("Min = {0} " + int.MinValue); 
//    //    Console.WriteLine("Max = {1} " + int.MaxValue);


//    //    double d = 123.22242433;

//    //    Console.WriteLine(d);
//    //}




//    //*****************   PART 4 (String type in C#)   *************************//

//    //static void Main()
//    //{
//    //    string Name     = "\"Asyraf\"\n\"Ahmad\"";
//    //    string Location = "C:\\Asyraf\\Ahmad\\CShrapFolder";

//    //    Console.WriteLine(Name);
//    //    Console.WriteLine(Location);
//    //}



//    //*****************   PART 5  (Common Operator) *************************//

//    //static void Main()
//    //{
//    //    int Number = 10;
//    //    int AnotherNumber = 20;

//    //    bool IsNumber10 = Number == 10 ? true: false ;


//    //    int Numerator = 10;
//    //    int Denominator = 2;

//    //    int Result = Numerator / Denominator;

//    //    if(Number == 10 && AnotherNumber == 20)
//    //    {
//    //        Console.WriteLine("Hello");
//    //        Console.WriteLine("Answer = " + Result);
//    //    }

//    //    if(Number == 10)
//    //    {
//    //        IsNumber10 = false;
//    //    }

//    //    Console.WriteLine("Number == 10 is{0}", IsNumber10);
//    //}



//    //*****************   PART 6  (Nullable) *************************//

//    //static void Main()
//    //{
//    //    //string Name = null;

//    //    //int i = null;           // "int" can't be null (non-nullable)
//    //   // int? p = null;

//    //    bool? AreYouMajor = true;

//    //    if(AreYouMajor  == true)
//    //    {
//    //        Console.WriteLine("User is major");
//    //    }
//    //    else if(!AreYouMajor.Value) // same like (AreYouMajor == false)
//    //    {
//    //        Console.WriteLine("User is not Major");
//    //    }
//    //    else
//    //    {
//    //        Console.WriteLine("Null");
//    //    }

//    //    /////////////////////////////////////////////////////////////////////////////////////////////////////////////


//    //    int? TicketsOnSale = null;                  //change value

//    //    int AvailableTickets = TicketsOnSale ?? 0 ; // if value is null then output is 0

//    //    if(TicketsOnSale == null)
//    //    {
//    //        AvailableTickets = 0;
//    //    }
//    //    else
//    //    {
//    //        AvailableTickets = (int)TicketsOnSale;
//    //    }


//    //    Console.WriteLine("Available Tickets = {0}", AvailableTickets);
//    //}



//    //*****************   PART 7  (DataTypes Conversion) *************************//

//    //static void Main()
//    //{ 
//    //    float i = 123.45F;

//    //    //int d = i;        // (implicit conversion)
//    //    int f = (int) i;    // (explicit conversion) to change float value to int value
//    //    int g = Convert.ToInt32(i);

//    //    Console.WriteLine(f);


//    //    /////////////////////////////////////////////////////////////////////////////////////////////

//    //    string strNumber = "100";       //valid input
//    //    //string strNumber = "100GT";   //invalid input


//    //    int Result = 0;

//    //    int k = int.Parse(strNumber);       // Parse() throw exception if it cannot parse the value
//    //    Console.WriteLine(k);


//    //    bool IsConversionSuccesfull = int.TryParse(strNumber, out Result);  // TryParse() returns a bool indication wheter it succeeded or failed

//    //    if (IsConversionSuccesfull)
//    //    {
//    //        Console.WriteLine(Result);
//    //    }
//    //    else
//    //    {
//    //        Console.WriteLine("Result enter a value");
//    //    }
//    //}




//    //*************************   PART 8  (Array) unsolved *************************//

//    //static void Main()
//    //{
//    //    int[] EventNumbers = new int[3];

//    //    EventNumbers[0] = 0;
//    //    EventNumbers[1] = 2;
//    //    EventNumbers[2] = 4;
//    //    EventNumbers[3] = 6;

//    //    Console.WriteLine(EventNumbers[10]);
//    //}



//    //*************************   PART 9  (Comments)  *************************//


//    //      single line comments
//    /*      multiple line comments  */
//    ///     XML documentation comments



//    //*************************   PART 10  (if statements)  *************************//

//    //static void Main()
//    //{
//    //    Console.WriteLine("Please enter a number");

//    //    int UserNumber = int.Parse(Console.ReadLine());

//    //    if(UserNumber == 1)
//    //    {
//    //        Console.WriteLine("Your number is one");
//    //    }

//    //    else if (UserNumber == 2)
//    //    {
//    //        Console.WriteLine("Your number is two");
//    //    }

//    //    else if (UserNumber == 3)
//    //    {
//    //        Console.WriteLine("Your number is three");
//    //    }
//    //    else if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
//    //    {
//    //        Console.WriteLine("Your number is not between 1 and 3");
//    //    }


//    //    ////////////////////////////////////////////////////////////////////// 


//    //    if(UserNumber == 10 || UserNumber == 20)
//    //    {
//    //        Console.WriteLine("Your Number is 10 or 20");
//    //    }
//    //    else
//    //    {
//    //        Console.WriteLine("");
//    //    }

//    //}


//    //*************************   PART 11  (switch statements)  *************************//

//    //static void Main()
//    //{
//    //    Console.WriteLine("Please enter your number");

//    //    int UserNumber = int.Parse(Console.ReadLine());


//    //    //if statement
//    //    if(UserNumber == 10)
//    //    {
//    //        Console.WriteLine("Your number is 10");
//    //    }
//    //    else if (UserNumber == 20)
//    //    {
//    //        Console.WriteLine("Your number is 20");
//    //    }
//    //    else if (UserNumber == 30)
//    //    {
//    //        Console.WriteLine("Your number is 30");
//    //    }
//    //    else 
//    //    {
//    //        Console.WriteLine("Your number is not 10, 20 & 30");
//    //    }


//    //    ////////////////////////////////////////////////////////////////////////////////////////


//    //    //switch statement
//    //    switch (UserNumber)
//    //    {
//    //        case 10:
//    //            Console.WriteLine("Your number is 10");
//    //            break;
//    //        case 20:
//    //            Console.WriteLine("Your number is 20");
//    //            break;
//    //        case 30:
//    //            Console.WriteLine("Your number is 30");
//    //            break;
//    //        default:
//    //            Console.WriteLine("Your number is not 10, 20 & 30");
//    //            break;
//    //     }



//    ////////////////////////////////////////////////////////////////////////////////////////


//    //    static void Main()
//    //    {
//    //        int TotalCoffeeCost = 0;

//    //        Start: 
//    //        Console.WriteLine("Please select your coffee size : 1 - Small, 2 - Medium, 3 - Large");

//    //        int UserChoice = int.Parse(Console.ReadLine());

//    //        switch (UserChoice)
//    //        {
//    //            case 1:
//    //                TotalCoffeeCost += 1;
//    //                break;
//    //            case 2:
//    //                TotalCoffeeCost += 2;
//    //                break;
//    //            case 3:
//    //                TotalCoffeeCost += 3;
//    //                break;
//    //            default:
//    //                Console.WriteLine("Your choice {0} is invalid. Please try again... ");
//    //                goto Decide;
//    //        }

//    //        Decide:
//    //        Console.WriteLine("\nDo you want to buy another coffee? \n yes \n no ");
//    //        string UserDecision = Console.ReadLine();

//    //        switch (UserDecision.ToUpper())     // ToUpper = change into uppercase
//    //        {
//    //            case "YES":
//    //                goto Start;
//    //            case "NO":
//    //                break;
//    //            default:
//    //                Console.WriteLine("Your choice {0} is invalid. Please try again..", UserDecision);
//    //                goto Decide;
//    //        }

//    //        Console.WriteLine("Thank you for shopping with us");
//    //        Console.WriteLine("Total Amount  = {0}", TotalCoffeeCost);

//    //    }
//    //}




//    //*************************   PART 12  (loop statements -  do & do..while..)  *************************//




//    //static void Main()
//    //{
//    //    string UserChoice = string.Empty;

//    //    do
//    //    {


//    //        Console.WriteLine("Please enter your target?");

//    //        int UserTarget = int.Parse(Console.ReadLine());
//    //        int Start = 0;

//    //        while (Start <= UserTarget)
//    //        {
//    //            Console.WriteLine(Start + " ");
//    //            Start = Start + 2;
//    //        }

//    //        do
//    //        {
//    //            Console.WriteLine("Do you want to continue = Yes or No ?");
//    //            UserChoice = Console.ReadLine().ToUpper();

//    //            if (UserChoice != "YES" && UserChoice != "NO")
//    //            {
//    //                Console.WriteLine("Invalid choice, please say Yes or No");
//    //            }
//    //        }while (UserChoice != "YES" && UserChoice != "NO");

//    //    }while (UserChoice == "YES");


//    //}



//    //*************************   PART 15  (loop statements - for & foreach)  *************************//


//    //static void Main()
//    //{
//    //int[] Numbers = new int[3];

//    //Numbers[0] = 101;
//    //Numbers[1] = 102;
//    //Numbers[2] = 103;

//    //foreach(int k in Numbers)
//    //{
//    //    Console.WriteLine(k);
//    //}

//    //for(int j = 0; j < Numbers.Length; j++)
//    //{
//    //    Console.WriteLine(Numbers[j]);
//    //}

//    //int i = 0;
//    //while(i < Numbers.Length)
//    //{
//    //    Console.WriteLine(Numbers[i]);
//    //    i++;
//    //}


//    //////////////////////////////////////////////////////////////////////////////
//    ///


//    //for(int i = 1; i <=20; i++)
//    //{
//    //    if (i % 2 == 1)
//    //        continue;

//    //    Console.WriteLine(i);
//    //}

//    //}


//    //*************************   PART 16  (Methods)  *************************//



//    ////public = access modifier   
//    //public static void Main()
//    //{
//    //    //Program p = new Program();        //if instance method
//    //    //p.EvenNumbers();

//    //    Program.EvenNumbers(30);              //if static method

//    //    Program P = new Program();
//    //    int Sum = P.Add(10, 20);

//    //    Console.WriteLine("Sum = {0}", Sum);
//    //}

//    //public int Add(int FN, int SN)
//    //{
//    //    return FN + SN;
//    //}

//    //public static void EvenNumbers(int Target)
//    //{
//    //    int Start = 0;

//    //    while(Start <= Target)
//    //    {
//    //        Console.WriteLine(Start);
//    //        Start = Start + 2;
//    //    }
//    //}


//    //*************************   PART 17  (Different types of method parameters)  *************************//
//    //4 types of method parameters
//    //   value parameters
//    //   reference parameters
//    //   out parameters
//    //   parameter arrays


//    //public static void Main()
//    //{
//    //    int i = 0;

//    //    SimpleMethod(ref i);

//    //    Console.WriteLine(i);

//    //}

//    //// ref =  value is refer to that parameter
//    //public static void SimpleMethod(ref int j)
//    //{
//    //    j = 101;
//    //}


//    /////////////////////////////////////////////////////////////////////////////////////////////

//    //// out parameters (to return more than 1 value in method/function)
//    //public static void Main()
//    //{
//    //    int Total = 0;
//    //    int Product = 0;
//    //    Calculate(10, 20, out Total, out Product);

//    //    Console.WriteLine("Sum =  {0} && Product = {1}", Total, Product);
//    //}

//    //public static void Calculate(int FN, int SN, out int Sum, out int Product)
//    //{
//    //    Sum =  FN + SN;
//    //    Product = FN * SN;
//    //}


//    /////////////////////////////////////////////////////////////////////////////////////////////

//    //// parameters array

//    //public static void Main()
//    //{
//    //    int[] Numbers = new int[3];

//    //    Numbers[0] = 101;
//    //    Numbers[1] = 102;
//    //    Numbers[2] = 103;

//    //    //ParamsMethod();
//    //    ParamsMethod(Numbers);
//    //    //ParamsMethod(1, 2, 3, 4, 5);
//    //}

//    ////parameter(params) array should be last
//    ////parameter(params) cant't be more than one
//    //public static void ParamsMethod(params int[] Numbers)
//    //{
//    //    Console.WriteLine("There are {0} elements", Numbers.Length);

//    //    foreach (int i in Numbers)
//    //    {
//    //        Console.WriteLine(i);
//    //    }

//    //}


//}
