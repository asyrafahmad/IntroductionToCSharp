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



//****************************   PART 55  (Late binding using reflection)  ******************************//
/*
 * 
 */

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("Pragim.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo GetFullNameMethod = customerType.GetMethod("GetFullname");

            string[] parameters = new string[2];
            parameters[0] = "Pragim";
            parameters[1] = "Technologies";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("FullName = {0}", fullName);

        //    Customer C1 = new Customer();
        //    string fullName = C1.GetFullName("Pragim", "Tech");
        //    Console.WriteLine("Full Name = {0}", fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}