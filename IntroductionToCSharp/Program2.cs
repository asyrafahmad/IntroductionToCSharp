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
/*      TO TRACK ORIGINAL EXCEPTION 
 *      
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
 *  2. The application should allow the user 
 *  3. If the user is already logged in, and if he opens another browser window and tries to login again
 *      the application should throw an error stating he is already logged in another browser window.
 */


//public class CustomExceptionsDemo  
//{
//    public static void Main()
//    {
//        try
//        {
//            throw new UserAlreadyLoggedInException("User is Logged in - no duplicate session");
//        }
//        catch (UserAlreadyLoggedInException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

//[Serializable]                      // break down the object into packet that can be trace
////can call constructor
//public class UserAlreadyLoggedInException : Exception
//{
//    public UserAlreadyLoggedInException()
//        : base ()
//    {

//    }

//    public UserAlreadyLoggedInException(string message)
//        : base (message)                                    // 'base' invoke from base class
//    {

//    }

//    public UserAlreadyLoggedInException( string message, Exception innerException)
//        : base (message, innerException)
//    {

//    }

//    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
//        : base (info, context)
//    {

//    }
//}




//****************************   PART 43  (Exception handling abuse)  ******************************//
/*
 * 
 */


//public class ExceptionHandlingAbuse
//{
//    public static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Please enter Numerator");
//            int Numerator = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Please enter Denominator");
//            int Denominator = Convert.ToInt32(Console.ReadLine());

//            int Result = Numerator / Denominator;

//            Console.WriteLine("Result = {0}", Result);

//        }
//        catch (FormatException)                 // if the input is not a number
//        {
//            Console.WriteLine("Please enter a number");
//        }
//        catch (OverflowException)               // if the input number is overlflows
//        {
//            Console.WriteLine("Only Numbers between  {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Denominator cannot be zero");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}



//****************************   PART 44  (Exception handling abuse (cont..))  ******************************//
/*
 * BETTER WAY USE USE EXEPTION HANDLING
 *  using Int32.TryParse is better than Convert.Int32
 * 
 */


//public class ExceptionHandlingAbuse
//{
//    public static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Please enter Numerator");
//            int Numerator;
//            bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);       // if input is a not a number return true or false

//            if (IsNumeratorConversionSuccessful)
//            {
//                Console.WriteLine("Please enter Denominator");
//                int Denominator;
//                bool IsDenominatorConversionSuccessfull =  Int32.TryParse(Console.ReadLine(), out Denominator);

//                if (IsDenominatorConversionSuccessfull && Denominator != 0)
//                {
//                    int Result = Numerator / Denominator;

//                    Console.WriteLine("Result = {0}", Result);
//                }
//                else
//                {
//                     if(Denominator == 0)
//                    {
//                        Console.WriteLine("Denominator cannot be zero");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Denominator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
//                    }
//                }                
//            }
//            else
//            {
//                Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}



//****************************   PART 45  (Why Enums)  ******************************//
/*
 * change the integral (int)
 * Strongly typed constants
 * 
 * Advantage:
 * 1. Less readable
 * 2. Maintainable
 */



//public class Enums
//{
//    public static void Main()
//    {
//        Customer[] customers = new Customer[3];

//        customers[0] = new Customer
//        {
//            Name = "Mark",
//            Gender = 1
//        };

//        customers[1] = new Customer
//        {
//            Name = "Asyraf",
//            Gender = 2
//        };

//        customers[2] = new Customer
//        {
//            Name = "Allen",
//            Gender = 0
//        };

//        foreach(Customer customer in customers)
//        {
//            Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
//        }
//    }

//    public static string GetGender(int gender)
//    {
//        switch (gender)
//        {
//            case 0:
//                return "Unknown";
//            case 1:
//                return "Male";
//            case 2:
//                return "Female";
//            default:
//                return "Invalid data detected";
//        }
//    }
//}

//// 0 - Unknown
//// 1 - Male
//// 2 - Female
//public class Customer
//{
//    public string Name { get; set; }
//    public int Gender { get; set; }
//}


/////////////////////////////////////////////////////////////////////////////////////////


//public class Enums
//{
//    public static void Main()
//    {


//        Customer[] customers = new Customer[3];

//        customers[0] = new Customer
//        {
//            Name = "Mark",
//            Gender = Gender.Male
//        };

//        customers[1] = new Customer
//        {
//            Name = "Asyraf",
//            Gender = Gender.Female
//        };

//        customers[2] = new Customer
//        {
//            Name = "Allen",
//            Gender = Gender.Unknown
//        };

//        foreach (Customer customer in customers)
//        {
//            Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
//        }
//    }

//    public static string GetGender(Gender gender)  //1st change
//    {
//        switch (gender)
//        {
//            case Gender.Unknown:                   //2nd change
//                return "Unknown";
//            case Gender.Male:                      //2nd change
//                return "Male";
//            case Gender.Female:                     //2nd change
//                return "Female";
//            default:
//                return "Invalid data detected";
//        }
//    }
//}

//public enum Gender
//{
//    Unknown,
//    Male,
//    Female
//}

//// 0 - Unknown
//// 1 - Male
//// 2 - Female
//public class Customer
//{
//    public string Name { get; set; }
//    public Gender Gender { get; set; }  // 1st change
//}





//****************************   PART 47  (Tutorial Enums)  ******************************//
/* change integral (int) to enum
 * 
 * 1. Enums are enumerations
 * 2. Enums are strongly typed constants. Hence, an explicit cast is needed to convert from enum type to an integral type
 *      and vice versa. Also an enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their
 *      members are the same.
 * 3. the default underlying type of an enum is int
 * 4. The default value for first element is ZERO and gets incremented by 1. START FROM 0,1,2,3,.....
 * 5. It is possible to customize the underlying type and values
 * 6. Enums are value types
 * 7. Enum keyword (all small letters) is used to create enumerations,
 *      where as Enum class, contains static GetValues() and GetNames() method 
 *      which can be used to list Enums underlying type values and Names.
 * 
 */


//public class Enums
//{
//    public static void Main()
//    {


//        Gender gender = (Gender)3;
//        int Num = (int)Gender.Unknown;

//        //typeof
//        short[] Values = (short[])Enum.GetValues(typeof(Gender));

//        foreach (short value in Values)
//        {
//            Console.WriteLine(value);
//        }

//        string[] Names = Enum.GetNames(typeof(Gender));

//        foreach (string Name in Names)
//        {
//            Console.WriteLine(Name);
//        }
//    }
//}

//public enum Gender
//{
//    Unknown = 1,
//    Male = 2,
//    Female = 3
//}




///////////////////////////////////////////////////////////////////////////////////////
///




//public class Enums
//{
//    public static void Main()
//    {
//        Gender gender = (Gender)Season.Winter;
//    }
//}

//public enum Gender
//{
//    Unknown = 1,
//    Male = 2,
//    Female = 3
//}

//public enum Season
//{
//    Winter = 1,
//    Spring = 2,
//    Summer = 3
//}





//****************************   PART 48  (Difference between types and type members)  ******************************//
/*
 * In general:
 *  - CLASSES, STRUCTS, ENUMS, INTERFACES, DELEGATES are called as TYPES
 *  - FIELDS, PROPERTIES, CONSTRUCTORS, METHODS etc, are called as TYPE MEMBERS
 *  - PRIVATE, PROTECTED, INTERNAL, PROTECTED INTERNAL, PUBLIC are called as ACCESS MODIFIERS
 *  
 *  - Type members can have all the access modifiers, where as types can have only 2( internal, publi)of the 5 access modifiers
 *  
 *  #region 
 */


//public class Customer
//{
//    #region Fields
//    private int _id;
//    private string _firstname;
//    private string _lastname;
//    #endregion

//    #region Properties
//    public int id
//    {
//        get { return _id; }
//        set { _id = value; }
//    }

//    public string FirstName
//    {
//        get { return _firstname; }
//        set { _firstname = value; }
//    }

//    public string LastName
//    {
//        get { return _lastname; }
//        set { _lastname = value;  }
//    }
//    #endregion

//    #region Methods
//    public string GetFullName()
//    {
//        return this._firstname = " " + this.LastName; 
//    }
//    #endregion
//}




//****************************   PART 49  (Access Modifiers)  ******************************//
/*
 * 1. Private           - Only with in the containing class
 * 2. Protected         - With in the containing types and the types derived from the containing typef
 * 3. Internal
 * 4. Protected Internal
 * 5. Public            - Anywhere, no restrictions
 * 
 */


//// private and public
//public class Customer
//{
//    private int _id;

//    public int ID
//    {
//        get
//        {
//            return _id;
//        }
//        set
//        {
//            _id = value;
//        }
//    }
//}

//public class MainClass
//{
//    private static void Main()
//    {
//        Customer C1 = new Customer();
//        Console.WriteLine(C1.ID);
//    }
//}



///////////////////////////////////////////////////////////////////////////////////////////



//// protected
//public class Customer
//{
//    protected int ID;
//}

//public class CorporateCustomer : Customer
//{
//    public void PrintID()
//    {
//        CorporateCustomer CC = new CorporateCustomer();
//        CC.ID = 101;       //to call from protected access modifier 

//        /*
//         * base.ID = can also use base keyword
//         * this.ID = can also user this keyword
//         */
//    }
//}

//public class MainClass
//{
//    private static void Main()
//    {
//        Customer C1 = new Customer();
//        Console.WriteLine(C1.ID);


//    }
//}



//****************************   PART 49  (Access Modifiers (cont..)  ******************************//
/*
 * 1. Private           
 * 2. Protected         
 * 3. Internal          - available anywhere with in the containing assembly. It's a compile time error to access, an internal member from outside the containing assembly
 * 4. Protected Internal- can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly
 *                        It is combination of protected and internal.
 * 5. Public            
 * 
 */


