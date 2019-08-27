using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;


//****************************   **PART 36,37,38  (Delegates)  ******************************//
/* (to pass a  method as a parameter to another method
 * similar to a class. 
 * -> we can create an instance of it. Thus, we pass in the function name as a parameter to the delegate constructor
 *    and it is to this function the delegate will point to.
 *    
 * delegates is a type safe function pointer. It holds a reference(pointer) to a fucntion.
 * 
 * 
 * -- delegate syntax look very much similar to a method with a delegate keyword
 */

////part 36





//public delegate void HelloFunctionDelegate(string Message);

//class Pragim
//{
//    public static void Main()
//    {
//        // A delegate is a type safe function pointer
//        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
//        del("Hello from Delegate");
//    }

//    public static void Hello (string strMessage)
//    {
//        Console.WriteLine(strMessage);
//    }
//}



///////////////////////////////////////////////////////////////////////////////////////////////////
////part 37



/* WITHOUT DELEGATE */


//class Pragim
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { ID = 101, Name = "Asyraf", Salary = 5000, Experience = 5 });
//        empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
//        empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
//        empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

//        Employee.PromoteEmployee(empList);
//    }
//}


//class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void PromoteEmployee(List<Employee> employeeList)
//    {
//        foreach (Employee employee in employeeList)
//        {
//            if (employee.Experience >= 5)
//            {
//                Console.WriteLine(employee.Name + "promoted");
//            }
//        }
//    }
//}




//// part 38


/* WITH DELEGATE */
//1. create delegate
//2. create logic method
//3. instance of delegate (pass the name of function)



//class Pragim
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { ID = 101, Name = "Asyraf", Salary = 5000, Experience = 5 });
//        empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
//        empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
//        empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

//        //constructor of delegate (3. instance if delegate)
//        IsPromotable isPromotable = new IsPromotable(Promote);

//        Employee.PromoteEmployee(empList, isPromotable);
//    }

//    // (2. logic method)
//    public static bool Promote(Employee emp)
//    {
//        if(emp.Experience >= 5)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

//// (1. delegate)
//delegate bool IsPromotable(Employee empl);

//class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
//    {
//        foreach (Employee employee in employeeList)
//        {
//            if (IsEligibleToPromote(employee))
//            {
//                Console.WriteLine(employee.Name + " promoted");
//            }
//        }
//    }
//}




/////////////////////////////////////////////////////////////////////////////////////
/* another way (simplest way) */



//class Pragim
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { ID = 101, Name = "Asyraf", Salary = 5000, Experience = 5 });
//        empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
//        empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
//        empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

//        // inline
//        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
//    }

//}


//delegate bool IsPromotable(Employee empl);

//class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
//    {
//        foreach (Employee employee in employeeList)
//        {
//            if (IsEligibleToPromote(employee))
//            {
//                Console.WriteLine(employee.Name + " promoted");
//            }
//        }
//    }
//}







//****************************   PART 40  (Exception handling)  ******************************//
/*
 * exception is an unforeseen error that occurs when a program is running.
 * 
 * 
 * eg:  1. trying to read from a file that doew not exist, throws FileNotFoundException
 *      2. trying to read from a database table that does not exist, throws a SqlException
 * 
 * Message: Gets a message that describes the current exception
 * StackTrace: Provides the call stack to the line number in the method where the exception occurred
 *
 * 
 * DISADVANTAGE:
 * 1. Doesn't make any sense for end user
 * 2. can be used for hacker
 * 
 * 
 * NOTE:
 * 1. try = the code that can possibly cause an exception will be the block
 * 2. catch = handles of exception
 * 3. finally = clean and free resources that the class was holding onto during the program
 *     execution. Finally block is optional.
 */



//using System.IO;

// class ExceptionHandling
//{
//    public static void Main()
//    {
//        StreamReader streamReader = null;
//        try
//        {
//            streamReader = new StreamReader(@"D:\Sapura\Introduction_To_CSharp\Note.txt");
//            Console.WriteLine(streamReader.ReadToEnd());     

//        }
//        //catch(Exception ex)
//        catch(FileNotFoundException ex)
//        {
//            //Log the details to the DB
//            Console.WriteLine("Please check if the file {0} exists", ex.FileName);      // give specific message what is the error
//            Console.WriteLine(ex.Message);      // give specific message what is the error
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine(ex.StackTrace);   // which line is throwing that exception
//        }   
//        catch(Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        finally         // to execute the rest of code within try..catch 
//        {
//            if(streamReader != null)
//            {
//                streamReader.Close();
//            }
//            Console.WriteLine("Finally Block");
//        }
//    }     
//}



//****************************   *PART 41  (Inner Exception)  ******************************//
/*
 *  The InnerException property returns the Exception instance that caused the current exception
 *  
 *  To retain the original exception pass it as a parameter to the constructor of the current exception
 *  
 *  Always check if inner exception is not null before accessing any property of the inner exception object, elsem you may get Null Reference Exception
 *  
 *  To get the type of InnerException use GetType() method
 *  
 */


//class InnerException
//{
//    public static void Main()
//    {
//        try
//        {

//            try
//            {
//                Console.WriteLine("Enter First Number");
//                int FN = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter Second Number");
//                int SN = Convert.ToInt32(Console.ReadLine());

//                int Result = FN / SN;

//                Console.WriteLine("Result = {0}", Result);
//            }
//            catch (Exception ex)
//            {
//                //to write the exception error into the log.txt
//                string filePath = @"D:\Sapura\Introduction_To_CSharp\Log.txt";

//                if (File.Exists(filePath))                          //if file is exist
//                {
//                    StreamWriter sw = new StreamWriter(filePath);   //to create the file   
//                    sw.Write(ex.GetType().FullName);
//                    sw.WriteLine();                                 // new line
//                    sw.Write(ex.Message);                           // to write the exception message
//                    sw.Close();                                     // close streamwriter
//                    Console.WriteLine("There is a Problem, Please try later");
//                }
//                else
//                {
//                    throw new FileNotFoundException(filePath + " is not present", ex);
//                }
//            }

//        }
//        catch(Exception exception)
//        {
//            Console.WriteLine("Current exception = {0}", exception.GetType().Name);

//            if(exception.InnerException != null)
//            {
//                Console.WriteLine("Inner exception = {0}", exception.InnerException.GetType().Name);
//            }
//        }
//    }
//}




//****************************   **PART 42  (Custom Exception)  ******************************//
/*
 * 
 * Case study:
 *  1. i have an asp.net web application
 *  2. The applicaiton should allow the user 
 *  3. If the user is already logged in, and if he opens another browser window and tries to login again
 *      the application should throw an error stating he is already logged in another browser window.
 */


public class CustomExceptionsDemo
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User is Logged in - no duplicate session");
        }
        catch (UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException()
        : base ()
    {

    }

    public UserAlreadyLoggedInException(string message)
        : base (message)
    {

    }

    public UserAlreadyLoggedInException( string message, Exception innerException)
        : base (message, innerException)
    {
         
    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
        : base (info, context)
    {

    }
}

