using System;
using System.Reflection;


//****************************   PART 52  (Attributes)  ******************************//
/* 
 *  to add declarative information 
 *  is a class that inherits from System.Attribute base class
 * 
 * 
 *  Obsolete    - Marks types and type members outdated
 *  WebMethod   - To expose a method as an XML Web service method
 *  Serializable- Indicates that a class can be serialized
 */



//using System.Collections.Generic;

//public class MainClass
//{
//    private static void Main()
//    {

//        //Calculator.Add(10, 20);           //OBSOLETE

//        Calculator.Add(new List<int>() { 10, 20, 30 });

//    }
//}

//public class Calculator
//{
//    [ObsoleteAttribute("Use Add (List<int> Numbers) Method", true)]  // to generate compiler warnings and error out of date notification
//    public static int Add(int FirstNumber, int SecondNumber)
//    {
//        return FirstNumber + SecondNumber;
//    }


//    // List<int> Numbers = to add more integer input in a list
//    public static int Add(List<int> Numbers)
//    {
//        int Sum = 0;
//        foreach (int Number in Numbers)
//        {
//            Sum = Sum + Number;
//        }

//        return Sum;
//    }
//}


//****************************   **PART 53  (Reflection)  ******************************//
/* 'type' keyword to display all the properties detail
 * 
 * - the ability of inspection an assemblies' metadata at runtime. 
 * - it is used to find all types in an assembly and /or dynamically invoker methods in an assembly.
 * 
 * Uses of reflection:
 * 1. When drag and drop a button on a win forms or an asp.net application. The properties window uses reflection to show
 *      all the properties of the Button class. So, reflection is extensively used by IDE or a UI designers.
 * 
 * 2. Late binding can be achieved by using reflection. Can use reflection to dynamically create an instance f a type, about which we don't have any information at complie time.
 *      So, reflection enables us to use code that is not available at compile time.
 *      ( at runtime dynamically) 
 *      
 * 3. Consider an example where we have two alternate implementatons of an interface. We want to allow the user to pick one or the other using a config file. 
 *      With reflection, we can simply read the name of the class whose implementaion we want to use from the config file, and instantiate an instance of that class. 
 *      This is another example for late binding using reflection.
 */



//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {


//            //Type T = Type.GetType("Pragim.Customer");

//            Type T = typeof(Customer);
//            Console.WriteLine("Full Name = {0}", T.FullName);
//            Console.WriteLine("Just the Name = {0}", T.Name);
//            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
//            Console.WriteLine();

//            Console.WriteLine("Properties in Customers");
//            PropertyInfo[] properties = T.GetProperties();
//            foreach(PropertyInfo property in properties)
//            {
//                Console.WriteLine(property.PropertyType.Name + " " + property.Name); 
//            }

//            Console.WriteLine();
//            Console.WriteLine("Methods in Customer class");
//            MethodInfo[] methods = T.GetMethods();
//            foreach(MethodInfo method in methods)
//            {
//                Console.WriteLine(method.ReturnType.Name + " " + method.Name); 
//            }

//            Console.WriteLine();
//            Console.WriteLine("Constructor in Customer class");
//            ConstructorInfo[] constructors = T.GetConstructors();
//            foreach(ConstructorInfo constructor in constructors)
//            {
//                Console.WriteLine(constructor.ToString.Name + " " + constructor.Name); 
//            }



//        }
//    }

//    public class Customer
//    {

//        public int Id { get; set; }
//        public string Name { get; set; }

//        public Customer( int ID, string Name) //constructor
//        {
//            this.Id = ID;
//            this.Name = Name;
//        }

//        public Customer()                      //constructor
//        {
//            this.Id = -1;
//            this.Name = string.Empty;
//        }

//        public void PrintID()
//        {
//            Console.WriteLine("ID = {0}", this.Id);
//        }

//        public void PrintName()
//        {
//            Console.WriteLine("Name= {0}", this.Name);
//        }
//    }
//}




//****************************   **PART 54  (Reflection Example)  ******************************//
/* THESE ARE USING WEBFORM
 * 
 */

//using System.Windows.Forms;
//using System.Reflection;

//namespace ReflectionDemo
//{
//    public partial class Reflection : Form
//    {
//        public Reflection()
//        {
//            InitializeComponent();
//        }

//        private void btnDiscoverTypeInformation_Clink(object sender, EventArgs e)
//        {
//            string TypeName = txtTypeName.Text;
//            Type T = Type.GetType(TypeName);



//            1stMethods.Items.Clear();
//            1stProperties.Items.Clear();
//            1stConstructors.Items.Clear();


//            MethodInfo[] methods = T.GetMethods();
//            foreach (MethodInfo method in methods)
//            {
//                1stProperties.Items.Add(method.ReturnType.Name + " " + property.Name);
//            }

//            PropertyInfo[] properties= T.GetProperties();
//            foreach (PropertyInfo property in properties)
//            {
//                1stProperties.Items.Add(property.PropertyType + " " + property.Name);
//            }

//            ConstructorInfo[] Cconstructors = T.GetConstructors();
//            foreach (ConstructorInfo constructor in constructors)
//            {
//                1stConstructors.Items.Add(constructor.ToString);
//            }
//        }
//    }
//}



//****************************   **PART 55  (Late binding using reflection)  ******************************//
/*
 * late binding is much better than early binding 
 * 
 * BUT in time purposes, early binding is better than late binding.
 * 
 * 
 * early binding 
 * - can know misspelling missmatches or type missmatches
 * 
 * late bnding
 * - doesn't know the missmatches until we run the application
 * 
 * Differences
 * 1. Early binding can flag errors at compile time. With late binding there is risk of run time exceptions
 * 2. Early binding is much better for performance and should always be preferred over late binding. 
 *      Use late binding only when working with an objects that are not available at compile time.  
 */

//namespace Pragim  //assembly
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            /* Late binding */
//            Assembly executingAssembly = Assembly.GetExecutingAssembly();

//            Type customerType = executingAssembly.GetType("Pragim.Customer");

//            object customerInstance = Activator.CreateInstance(customerType);

//            MethodInfo GetFullNameMethod = customerType.GetMethod("GetFullnames");

//            string[] parameters = new string[2];
//            parameters[0] = "Pragim";
//            parameters[1] = "Technologies";

//            string fullName = (string)GetFullNameMethod.Invoke(customerInstance, parameters);
//            Console.WriteLine("FullName = {0}", fullName);



//        //    /* Early binding */
//        //    Customer C1 = new Customer();
//        //    string fullName = C1.GetFullName("Pragim", "Tech");
//        //    Console.WriteLine("Full Name = {0}", fullName);
//        }
//    }

//    public class Customer
//    {
//        public string GetFullName(string FirstName, string LastName)
//        {
//            return FirstName + " " + LastName;
//        }
//    }
//}



//****************************   PART 56  (Generics in C#)  ******************************//
/*
 * - Introduced in C# 2.0. Generics allow us to design classes and methods decoupled from the data types.
 * - are extensively used by collection classes available in System.Collection.Generic namespace
 * - on
 * 
 */


//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            bool Equal = Calculator.AreEqual(1, 1);

//            if(Equal)
//            {
//                Console.WriteLine("Equal");
//            }
//            else
//            {
//                Console.WriteLine("Not Equal");
//            }
//        }
//    }

//    public class Calculator
//    {
//        public static bool AreEqual(int Value1, int Value2)
//        {
//            return Value1 == Value2;
//        }
//    }
//}


/////////////////////////////////////////////////////////////////////////////////
///


//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            bool Equal = Calculator.AreEqual("A", "B");

//            if (Equal)
//            {
//                Console.WriteLine("Equal");
//            }
//            else
//            {
//                Console.WriteLine("Not Equal");
//            }
//        }
//    }

//    public class Calculator
//    {
//        //to string
//           //change int to object
//        public static bool AreEqual(object Value1, object Value2)
//        {
//            return Value1 == Value2;
//        }
//    }
//}



/////////////////////////////////////////////////////////////////////////////////



//// using generics
//// make our code independent
//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            // add string/int
//            bool Equal = Calculator.AreEqual<int>(1, 1);

//            if (Equal)
//            {
//                Console.WriteLine("Equal");
//            }
//            else
//            {
//                Console.WriteLine("Not Equal");
//            }
//        }
//    }

//    //make class generics
//    public class Calculator<T> 
//    public class Calculator 
//    {
//        // add T
//        // T is a string/int
//        public static bool AreEqual<T>( T Value1, T Value2)
//        {
//            //comparison
//            return Value1.Equals(Value2);
//        }
//    }
//}


/* OR   */


//// using generics at class
//// make our code independent
//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            // add string/int
//            bool Equal = Calculator<int>.AreEqual(1, 1);

//            if (Equal)
//            {
//                Console.WriteLine("Equal");
//            }
//            else
//            {
//                Console.WriteLine("Not Equal");
//            }
//        }
//    }

//    //make class generics
//    public class Calculator<T>
//      {
//        // add T
//        // T is a string/int
//        public static bool AreEqual<T>(T Value1, T Value2)
//        {
//            //comparison
//            return Value1.Equals(Value2);
//        }
//    }
//}



//****************************   PART 57  (Why should override ToString())  ******************************//
/*
 * 
 * 
 */

//namespace Pargim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            int Number = 10;
//            Console.WriteLine(Number.ToString());

//            Customer C1 = new Customer();
//            C1.FirstName = "Asyraf";
//            C1.LastName = "Ahmad";

//            //Console.WriteLine(C1.ToString());
//            //      OR
//            Console.WriteLine(Convert.ToString(C1));
//        }
//    }

//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        //override method
//        public override string ToString()
//        {
//            return this.LastName + ", " + this.FirstName;
//        }
//    }
//}




//****************************   PART 58  (Why should override Equals Method)  ******************************//
/*
 * 
 * 
 */

//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            //int i = 10;
//            //int j = 10;

//            Direction direction1 = Direction.East;
//            Direction direction2 = Direction.West;


//            Console.WriteLine(direction1 == direction2);
//            Console.WriteLine(direction1.Equals(direction2)); 
//        }
//    }

//    public enum Direction
//    {
//        East = 1,
//        West = 2,
//        North = 3, 
//        South = 4 
//    }
//}



/////////////////////////////////////////////////////////////////////////////////////


//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            //ANSWER : TRUE
//            Customer C1 = new Customer();
//            C1.FirstName = "Asyraf";
//            C1.LastName = "Ahmad";

//            Customer C2 = C1;

//            Console.WriteLine(C1 == C2);
//            Console.WriteLine(C1.Equals(C2));

//            ///////////////////////////////

//            ////ANSWER : FALSE
//            //Customer C1 = new Customer();
//            //C1.FirstName = "Asyraf";
//            //C1.LastName = "Ahmad";

//            //Customer C2 = new Customer();
//            //C2.FirstName = "Asyraf";
//            //C2.LastName = "Ahmad";


//            //Console.WriteLine(C1 == C2);        //reference equality
//            //Console.WriteLine(C1.Equals(C2));   //value equality

//        }
//    }

//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public override bool Equals(object obj)
//        {
//            if(obj == null)
//            {
//                return false;
//            }

//            if (!(obj is Customer))
//            {
//                return false; 
//            }

//            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
//        }

//        public override int GetHashCode()
//        {
//            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
//        }
//    }
//}



//****************************   PART 59  (Difference between Convert.ToString() and ToString())  ******************************//
/*
 * Convert.ToString() handles NULL
 * ToString() doesn't and throws a NULL Reference exception
 * 
 */


//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            Customer C1 = null;
//            string str = C1.ToString();
//            //          OR
//            //string str = Convert.ToString(C1);
//            Console.WriteLine(str);
//        }
//    }

//    public class Customer
//    {
//        public string Name { get; set; }
//    }
//}



//****************************   PART 60  (Difference between String and StringBuilder)  ******************************//
/*
 * StringBuilder is better than String, its good for performance
 * 
 * 
 * System.String is immutable (unchanging over time or unable to changed)
 * - used a lot of memory
 * 
 * StringBuilder is mutable (liable to change)
 * - used less memory
 * 
 */

//using System.Text;

//namespace Pragim
//{
//    public class MainClass
//    {
//        public static void Main()
//        {
//            ////using String
//            //string userString = "C#";
//            //userString += "Video";
//            //userString += "Tutorial";
//            //userString += "for";
//            //userString += "Beginner";
//            //Console.WriteLine(userString);


//            ////        OR          ////


//            ////using String
//            //string userString = string.Empty;
//            //for(int i = 1; i <= 10000; i++)
//            //{
//            //    userString += i.ToString() + " ";
//            //}
//            //Console.WriteLine(userString);


//            ////        OR          ////


//            // using StringBuilder
//            StringBuilder userString = new StringBuilder("C#");
//            userString.Append("Video");
//            userString.Append("Tutorial");
//            userString.Append("Tutorial");
//            userString.Append("Beginner");
//            Console.WriteLine(userString.ToString());
//        }
//    }
//}