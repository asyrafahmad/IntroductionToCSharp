using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//****************************   PART 71 (Code Snippet)  ******************************//
/*
Code snippets are ready-made snippets of code you can quickly insert into your code.To insert code snippets there are several ways
1. Keyboard shortcut: CTRL K + X
2. Right click and select "Insert Snippet...", from the context menu
3. Click on Edit - Intellisense - Insert Snippet
4. Use code snippets short cut.For example to use "for loop" code snippet, type "for" and press TAB key twice

Once a code snippet is inserted, the editable fields are highlighted in yellow, and the first editable field is selected automatically. Upon changing the first editable field, press TAB to move to the next editable field.To come to the previous editable field use SHIFT + TAB.Press ENTER or ESC keys to cancel field editing and return the Code Editor to normal.

Code Snippet Types:
Expansion: These snippets allows the code snippet to be inserted at the cursor.
SurroundsWith: These snippets allows the code snippet to be placed around a selected piece of code.
Refactoring: These snippets are used during code refactoring.

Surround-with code snippets: These snippets surrounds the selected code, with the code snippets code.
1. Select the code to surround, and use keyboard shortcut CTRL K + S
2. Select the code to surround, right click and select "Surround with.." option from the context menu
3. Select the code to surround, then click on Edit menu, select "IntelliSense" and then select the "Surround With" command.

Code snippets can be used with any type of applications that you create with visual studio. For example, you can use them with
1. Console applications
2. ASP.NET web applications
3. ASP.NET MVC applications etc..

Code snippets are available for the following languages.
1. C#
2. Visual Basic
3. XML
4. HTML
5. JScript
6. SQL

Code Snippet Manager can be used to Add or remove code snippets.You can also find the following information about a code snippet.
1. Description
2. Shortcut
3. Snippet Type
4. Author

To access code snippet manager, click on "Tools" and then select "Code Snippet Manager". Code snippets are xml files and have.snippet extension.
*/



//****************************   PART 72 (Dictionary)  ******************************//
/* fastest way to retrieve object
 * 
 * 1. A dictionary is a collection of (key, value) pairs.
 * 2. Dictionary class is present in System.Collections.Generic namespace.
 * 3. When creating a dictionary, we need to specify the type for key and value.
 * 4. Dictionary provides fast lookups for values using keys.
 * 5. Keys in the dictionary must be unique.
 * 
 */

//namespace Demo
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Customer customer1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Salary = 5000
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 110,
//                Name = "Pam",
//                Salary = 6500
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 3500
//            };

//            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
//            dictionaryCustomers.Add(customer1.ID, customer1);
//            dictionaryCustomers.Add(customer2.ID, customer2);
//            dictionaryCustomers.Add(customer3.ID, customer3);

//            // Customer customer119 = dictionaryCustomers[119];
//            // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

//            ////                    OR


//            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
//            //{
//            //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
//            //    Customer cust = customerKeyValuePair.Value;
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//            //    Console.WriteLine("-----------------------------------------------------------------");
//            //}

//            ////                    OR

//            //foreach (var customerKeyValuePair in dictionaryCustomers.Keys)
//            //{
//            //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
//            //    Customer cust = customerKeyValuePair.Value;
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//            //    Console.WriteLine("-----------------------------------------------------------------");
//            //}

//            ////                    OR

//            //foreach (int key in dictionaryCustomers.Keys)
//            //{
//            //    Console.WriteLine(key);
//            //}

//            ////                    OR

//            foreach (Customer cust in dictionaryCustomers.Values)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//                Console.WriteLine("-----------------------------------------------------------------");
//            }


//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }
//}




//****************************   PART 73 (What is dictionary)  ******************************//
/* fastest way to retrieve object
 * 
 * 1. TryGetValue() = to get the value
 * 2. Count()       = count the total object
 * 3. Remove()
 * 4. Clear()
 * 5. Using LINQ extension method with Dictionary
 * 6. Different ways to conert an array into a dictionary
 * 
 */


namespace Demo
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            ////// 1. TryGetValue()
            //Customer cust;      //declare the object as cust
            //if(dictionaryCustomers.TryGetValue(101, out cust))
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("The key is not found");
            //}

            //// 2. Count() 
            //Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));


            //// 3. Remove()
            dictionaryCustomers.Remove(110);

            //// 4. Clear()
            dictionaryCustomers.Remove(110);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
