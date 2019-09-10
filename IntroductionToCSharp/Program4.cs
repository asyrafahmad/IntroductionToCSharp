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



//            //////////////// change here

//            ////// 1. TryGetValue()
//            //Customer cust;      //declare the object as cust
//            //if(dictionaryCustomers.TryGetValue(101, out cust))
//            //{
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("The key is not found");
//            //}



//            //// 2. Count() 
//            //Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));



//            //// 3. Remove()
//            //dictionaryCustomers.Remove(110);



//            //// 4. Clear() is to remove all in dictionary
//            //dictionaryCustomers.Clear();



//            //// 6.  Different ways to conert an array into a dictionary

//            //// to convert array into dictionary
//            //Customer[] customers = new Customer[3];
//            //customers[0] = customer1; 
//            //customers[1] = customer2;
//            //customers[2] = customer3;

//            ////to id and object itself
//            //Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

//            //foreach(KeyValuePair<int, Customer> kvp in dict)
//            //{
//            //    Console.WriteLine("Key = {0}", kvp.Key);
//            //    Customer cust = kvp.Value;
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//            //}

//            ////        OR

//            // to convert a list of customer to dictionary 
//            List<Customer> customers = new List<Customer>();
//            customers.Add(customer1);
//            customers.Add(customer2);
//            customers.Add(customer3);

//            //to id and object itself
//            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

//            foreach (KeyValuePair<int, Customer> kvp in dict)
//            {
//                Console.WriteLine("Key = {0}", kvp.Key);
//                Customer cust = kvp.Value;
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
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





//****************************   PART 74 (List collection class)  ******************************//
/*
 * List is one of the generic collection classes present in System.Collections.Generic namespcae.
   There are several generic collection classes in System.Collections.Generic namespace as listed below.
 * 1. Dictionary - Discussed in Parts 72 & 73
 * 2. List
 * 3. Stack
 * 4. Queue etc

 * A List class can be used to create a collection of any type. For example, we can create a list of Integers, Strings and even complex types. 
   The objects stored in the list can be accessed by index. Unlike arrays, lists can grow in size automatically. This class also provides methods to search, sort, and manipulate lists.
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

//            //ARRAY
//            //Customer[] customers = new Customer[2];
//            //customers[0] = customer1;
//            //customers[1] = customer2;
//            //customers[2] = customer3;

//            ////    OR

//            //LIST
//            List<Customer> customers = new List<Customer>(2);
//            customers.Add(customer1);
//            customers.Add(customer2);
//            customers.Add(customer3);


//            ////to display 1 row only
//            //Customer c = customers[0];
//            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

//            ////to display all row
//            //foreach (Customer c in customers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
//            //}

//            //to display all how many we want
//            //for (int i=0; i <= customers.Count; i++)
//            //{
//            //    Customer c = customers[i];
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
//            //}




//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }

//    public class SavingsCustomer : Customer
//    {

//    }
//}


/// ////////////////////////////////////////////////////////////////////////////////////////////////////////


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

//            //ARRAY
//            //Customer[] customers = new Customer[2];
//            //customers[0] = customer1;
//            //customers[1] = customer2;
//            //customers[2] = customer3;

//            ////    OR

//            //LIST
//            List<Customer> customers = new List<Customer>(2);
//            customers.Add(customer1);
//            customers.Add(customer2);
//            customers.Add(customer3);
//            // push 3 position 1
//            //0 is array positiom 
//            //customer3 is value position
//            customers.Insert(0, customer3);

//            //foreach (Customer c in customers)
//            //{
//            //    Console.WriteLine(c.ID);
//            //}

//            //1st parameter = output is 0 because it gets the location of index array
//            //2nd parameter = inital position to start searching from
//            //3rd parameter = number of items to look (last position)
//            Console.WriteLine(customers.IndexOf(customer3, 1, 3));

//        }    
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }

//    public class SavingsCustomer : Customer
//    {

//    }
//}


//****************************   **PART 75 (List collection class (cont..))  ******************************//
/*
In this video, will discuss
 * 1. Contains() function - Use this function to check if an item exists in the list. This method returns true if the items exists, else false.
 * 2. Exists() function - Use this function, to check if an item exists in the list based on a condition. This method returns true if the items exists, else false.
 * 3. Find() function - This method searches for an element that matches the conditions defined by the specified lambda expression and returns the first matching item from the list.
 * 4. FindLast() function - This method searches for an element that matches the conditions defined by the specified lambda expression and returns the Last matching item from the list.
 * 5. FindAll() function - This method returns all the items from the list that match the conditions specified by the lambda expression.
 * 6. FindIndex() function - This method returns the index of the first item, that matches the condition specified by the lambda expression. There are 2 other overloads of this method which allows us to specify the range of elements to search, with in the list.
 * 7. FindLastIndex() function - This method returns the index of the last item, that matches the condition specified by the lambda expression. There are 2 other overloads of this method which allows us to specify the range of elements to search, with in the list.
 * 8. Convert an array to a List - Use ToList() method
 * 9. Convert a list to an array - Use ToArray() method
 * 10. Convert a List to a Dictionary - Use ToDictionary() method
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

//            List<Customer> listCustomers = new List<Customer>(2);
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            ////1. Contain() function
//            //if (listCustomers.Contains(customer3))
//            //{
//            //    Console.WriteLine("Customer3 object exists in the list");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Customer3 object doeas not exist in the list");
//            //}


//            ////2. Exists() function
//            //if (listCustomers.Exists(cust => cust.Name.StartsWith("P")))
//            //{
//            //    Console.WriteLine("Customer3 object exists in the list");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Customer3 object doeas not exist in the list");
//            //}

//            ////    OR
//            //if (listCustomers.Exists(cust => cust.Name.StartsWith("P")))
//            //{
//            //    Console.WriteLine("Customer3 object exists in the list");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Customer3 object doeas not exist in the list");
//            //}


//            ////3. Find() function
//            //Customer c = listCustomers.Find(cust => cust.Salary > 5000);
//            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);


//            ////4. FindAll() function
//            //List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 4500);
//            //foreach(Customer c in customers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary); 
//            //}


//            ////5. FindIndex() function
//            //int index = listCustomers.FindIndex(cust => cust.Salary > 4500);
//            //Console.WriteLine("index = " + index);


//            //// 6. FindLastIndex() function
//            //int index = listCustomers.FindLastIndex(cust => cust.Salary > 4500);
//            //Console.WriteLine("index = " + index);


//            //// 7. Convert an array to a List ( ToList() function )
//            Customer[] customerArray = new Customer[3];
//            customerArray[0] = customer1;
//            customerArray[1] = customer2;
//            customerArray[2] = customer3;

//            List<Customer> listCustomers = customerArray.ToList();

//            foreach(Customer c in listCustomers)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary {2}", c.ID, c.Name, c.Salary)
//            }



//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }

//    public class SavingsCustomer : Customer
//    {

//    }
//}


///////////////////////////////////////////////////////////////////////////////////////////////


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


//            //// 7. Convert an array to a List ( ToList() function )
//            //Customer[] customerArray = new Customer[3];
//            //customerArray[0] = customer1;
//            //customerArray[1] = customer2;
//            //customerArray[2] = customer3;

//            //List<Customer> listCustomers = customerArray.ToList();

//            //foreach (Customer c in listCustomers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary {2}", c.ID, c.Name, c.Salary);
//            //}


//            //// 8. Convert a list to an array ( ToArray() function )
//            //List<Customer> listCustomers = new List<Customer>();
//            //listCustomers.Add(customer1);
//            //listCustomers.Add(customer2);
//            //listCustomers.Add(customer3);

//            //listCustomers.ToArray();

//            //foreach (Customer c in listCustomers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary {2}", c.ID, c.Name, c.Salary);
//            //}


//            // 8. Convert a list to a Dictionary ( ToArray() function )
//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            Dictionary<int, Customer> dictionary = listCustomers.ToDictionary(x => x.ID);

//            foreach (KeyValuePair<int, Customer> kvp in dictionary)
//            {
//                Console.WriteLine("Key = " + kvp.Key);
//                Customer c = kvp.Value;
//                Console.WriteLine("ID = {0}, name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
//            }

//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }

//    public class SavingsCustomer : Customer
//    {

//    }
//}



//****************************   PART 76 (Generic list class and ranges)  ******************************//
/*
 * AddRange() - Add() method allows you to add one item at a time to the end of the list, 
 *              where as AddRange() allows you to add another list of items, to the end of the list.
 * GetRange() - Using an item index, we can retrieve only one item at a time from the list, if you want to get a list of items from the list, 
 *              then use GetRange() function. This function expects 2 parameters, i.e the start index in the list and the number of elements to return.
 * InsertRange() - Insert() method allows you to insert a single item into the list at a specificed index, 
 *                  where as InsertRange() allows you, to insert another list of items to your list at the specified index.
 * RemoveRange() - Remove() function removes only the first matching item from the list. RemoveAt() function, 
 *                  removes the item at the specified index in the list. RemoveAll() function removes all the items that matches the specified condition. 
 *                  RemoveRange() method removes a range of elements from the list. This function expects 2 parameters, i.e the start index in the list and the number of elements to remove. 
 *                  If you want to remove all the elements from the list without specifying any 
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
//                Salary = 5000,
//                Type = "CooperateCustomer"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 110,
//                Name = "Pam",
//                Salary = 6500,
//                Type = "CooperateCustomer"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 3500,
//                Type = "RetailCustomer"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 150,
//                Name = "Abu",
//                Salary = 8000,
//                Type = "RetailCustomer"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 800,
//                Name = "Ali",
//                Salary = 7000,
//                Type = "RetailCustomer"
//            };


//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);


//            List<Customer> listCorporateCustomers = new List<Customer>();
//            listCorporateCustomers.Add(customer4);
//            listCorporateCustomers.Add(customer5);

//            //// 1. AddRange() - add another list of items, to the end of the list
//            //listCustomers.AddRange(listCorporateCustomers);

//            //foreach(Customer c in listCustomers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name= {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
//            //}


//            //// 2. GetRange() - want to get a list of items from the list
//            //listCustomers.AddRange(listCorporateCustomers);

//            //List<Customer> customers = listCustomers.GetRange(3, 2);

//            //foreach(Customer c in customers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name= {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
//            //}


//            //// 3. InsertRange() - insert another list of items to listat the specified index
//            //listCustomers.InsertRange(3, listCorporateCustomers);

//            //foreach (Customer c in listCustomers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name= {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
//            //}


//            //// 4. Remove() - removes only the first matching item from the list 
//            //listCustomers.InsertRange(3, listCorporateCustomers);

//            //listCustomers.Remove(customer1);

//            //foreach (Customer c in listCustomers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name= {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
//            //}


//            //// 5. RemoveAt() - 
//            //listCustomers.InsertRange(3, listCorporateCustomers);

//            //listCustomers.RemoveAt(3);

//            //foreach (Customer c in listCustomers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name= {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
//            //}


//            //// 6. RemoveAll() - 
//            //listCustomers.InsertRange(3, listCorporateCustomers);

//            //listCustomers.RemoveAll (x => x.Type == "CooperateCustomer");

//            //foreach (Customer c in listCustomers)
//            //{
//            //    Console.WriteLine("ID = {0}, Name= {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
//            //}


//            // 4. RemoveRange() - 
//            listCustomers.InsertRange(3, listCorporateCustomers);

//            listCustomers.RemoveRange (0, 3);

//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine("ID = {0}, Name= {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
//            }

//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public string Type { get; set; }
//    }  
//}



//****************************   PART 77 (Sort a list of simple types)  ******************************//
/*
 * Sorting a list of simple types like int, string, char etc, is straight forward. 
 * Just invoke the sort() method on the list instance and the data will be automatically sorted in ascending order.
 * List[int] numbers = new List[int] { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
 * numbers.Sort();
 * 
 * If you want the data to be retrieved in descending order, use Reverse() method on the list instance.
 * numbers.Reverse();
 * 
 * However, when you do the same thing on a complex type like Customer, we get a runtime invalid operation exception - Failed to compare 2 elements in the array. 
 * This because, .NET runtime does not know, how to sort complex types. 
 * We have to tell the way we want data to be sorted in the list by implementing IComparable interface. We will discuss this in a later video session.
 * 
 * So, the next obvious question - How is the sort functionality working for simple types like int, string, char etc?
 * That is because these types (int, string, decimal, char etc) have implemented IComparable interface already.
 */


//namespace Demo
//{
//    class Program
//    {
//        public static void Main()
//        {
//            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

//            Console.WriteLine("Numbers before sorting");
//            foreach(int number in numbers)
//            {
//                Console.WriteLine(number);
//            }

//            numbers.Sort();

//            Console.WriteLine("Numbers after sorting");
//            foreach (int number in numbers)
//            {
//                Console.WriteLine(number);
//            }

//            numbers.Reverse();
//            Console.WriteLine("Numbers in descending order");
//            foreach (int number in numbers)
//            {
//                Console.WriteLine(number);
//            }

//            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
//            Console.WriteLine("Alphabets before sorting");
//            foreach (string alphabet in alphabets)
//            {
//                Console.WriteLine(alphabet);
//            }

//            alphabets.Sort();
//            Console.WriteLine("Alphabets after sorting");
//            foreach (string alphabet in alphabets)
//            {
//                Console.WriteLine(alphabet);
//            }

//            alphabets.Reverse();
//            Console.WriteLine("Alphabets in descending order");
//            foreach (string alphabet in alphabets)
//            {
//                Console.WriteLine(alphabet);
//            }



//            Customer customer1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Salary = 5000,
//                Type = "CooperateCustomer"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 110,
//                Name = "Pam",
//                Salary = 6500,
//                Type = "CooperateCustomer"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 3500,
//                Type = "RetailCustomer"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 150,
//                Name = "Abu",
//                Salary = 8000,
//                Type = "RetailCustomer"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 800,
//                Name = "Ali",
//                Salary = 7000,
//                Type = "RetailCustomer"
//            };


//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);


//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public string Type { get; set; }
//    }
//}



//****************************   PART 78 (Sort a list of complex types)  ******************************//
/*
 * To sort a list of complex types without using LINQ, the complex type has to implement IComparable interface
 * and provide implementation for CompareTo() method.
 * 
 * CompareTo() method returns an integer and the mening of the return value is shown below
 * 
 * RETURN VALUE is :
 * Greater than ZERO    - the current instance is greater than the object being compared with.
 * Less than ZERO       - the current instance is less than the object being compared with.
 * is ZERO              - the current instance is equal to the objecct being compared with.
 * 
 * Alternatively you can als invoke CompareTo() method. Salary property of the Customer object is int.
 * CompareTo() method is already implemented on integer type, so we can invoke this method and return it's value.
 */

////OLD VERSION COMPARISON
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
//                Salary = 5000,
//                Type = "CooperateCustomer"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 110,
//                Name = "Pam",
//                Salary = 6500,
//                Type = "CooperateCustomer"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 3500,
//                Type = "RetailCustomer"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 150,
//                Name = "Abu",
//                Salary = 8000,
//                Type = "RetailCustomer"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 800,
//                Name = "Ali",
//                Salary = 7000,
//                Type = "RetailCustomer"
//            };


//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            Console.WriteLine("Before Sorting");
//            foreach(Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Salary);
//            }

//            listCustomers.Sort();
//            listCustomers.Reverse();
//            Console.WriteLine("After Sorting");

//            foreach(Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Salary);
//            }


//        }
//    }

//    public class Customer : IComparable<Customer>
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public string Type { get; set; }

//        public int CompareTo(Customer other)
//        {
//            // old version of comparison
//                if (this.Salary > other.Salary)
//                    return 1;
//                else if (this.Salary < other.Salary)
//                    return -1;
//                else
//                    return 0;

//        }
//    }
//}


////////////////////////////////////////////////////////////////////////////////////////////////////////////


//OLD VERSION COMPARISON
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
//                Salary = 5000,
//                Type = "CooperateCustomer"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 110,
//                Name = "Pam",
//                Salary = 6500,
//                Type = "CooperateCustomer"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 3500,
//                Type = "RetailCustomer"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 150,
//                Name = "Abu",
//                Salary = 8000,
//                Type = "RetailCustomer"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 800,
//                Name = "Ali",
//                Salary = 7000,
//                Type = "RetailCustomer"
//            };


//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            //before sorting
//            Console.WriteLine("Before Sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Salary);
//            }

//            //after sorting (Descending)
//            listCustomers.Sort();
//            listCustomers.Reverse();
//            Console.WriteLine("After Sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Salary);
//            }

//            //after sorting by name 
//            SortByName sortByName = new SortByName();
//            listCustomers.Sort(sortByName);
//            Console.WriteLine("Sorting by Name");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Name);
//            }   
//        }
//    }

//    public class SortByName : IComparer<Customer>
//    {
//        public int Compare(Customer x, Customer y)
//        {
//            return x.Name.CompareTo(y.Name);
//        }
//    }

//    public class Customer : IComparable<Customer>
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public string Type { get; set; }

//        public int CompareTo(Customer other)
//        {

//            ////new version of comparison
//            return this.Salary.CompareTo(other.Salary);
//        }
//    }
//}



//****************************   PART 79 (Sort a list of complex types using Comparison Delegates)  ******************************//
/*
 * One of the overloads of the Sort() method in List class expects Comparison delegate to be passed as an argument. Let us understand using this overloaded version.
 * public void Sort(Comparison[T] comparison)
 * 
 * Approach 1:
 * Step 1: Create a function whose signature matches the signature of System.Comparison delegate. This is the method where we need to write the logic to compare 2 customer objects.
 * private static int CompareCustomers(Customer c1, Customer c2)
 * {
 *     return c1.ID.CompareTo(c2.ID);
 * }
 * 
 * Step 2: Create an instance of System.Comparison delegate, and then pass the name of the function created in Step1 as the argument. 
 * So, at this point "Comparison" delegate is pointing to our function that contains the logic to compare 2 customer objects.
 * Comparison[Customer] customerComparer = new Comparison[Customer](CompareCustomers);
 * 
 * Step 3: Pass the delegate instance as an argument, to Sort() function.
 * listCutomers.Sort(customerComparer);
 * 
 * At this point, listCutomers should be sorted using the logic defined in CompareCustomers() function. 
 * 
 * Approach 2:
 * In Approcah1 this is what we have done
 * 1. Created a private function that contains the logic to compare customers
 * 2. Created an instance of Comparison delegate, and then passed the name of the private function to the delegate.
 * 3. Finally passed the delegate instance to the Sort() method.
 * 
 * Do we really have to follow all these steps. Isn't there any other way? The above code can be simplified using delegate keyword as shown below.
 * listCutomers.Sort(delegate(Customer c1, Customer c2) 
   { 
       return (c1.ID.CompareTo(c2.ID)); 
   });
   
 * Approach 3: The code in Approach 2, can be further simplified using lambda expression as shown below.
 * listCutomers.Sort((x, y) =] x.ID.CompareTo(y.ID));
 * 
 * Please make sure to replace [ with LESSTHAN and ] with GREATERTHAN symbol.
 */


////Approach 1
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
//                Salary = 5000,
//                Type = "CooperateCustomer"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 130,
//                Name = "Pam",
//                Salary = 6500,
//                Type = "CooperateCustomer"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 3500,
//                Type = "RetailCustomer"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 150,
//                Name = "Abu",
//                Salary = 8000,
//                Type = "RetailCustomer"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 800,
//                Name = "Ali",
//                Salary = 7000,
//                Type = "RetailCustomer"
//            };


//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            //delegates is to pointing to the function
//            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareComparison);

//            Console.WriteLine("Before Sorting");
//            foreach(Customer c in listCustomers)
//            {
//                Console.WriteLine(c.ID);
//            }

//            listCustomers.Sort(customerComparer);

//            Console.WriteLine("After Sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.ID);
//            }
//        }

//        private static int CompareComparison(Customer x, Customer y)
//        {
//            return x.ID.CompareTo(y.ID);
//        }
//    }


//    public class Customer  
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public string Type { get; set; }

//    }
//}


////Approach 2
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
//                Salary = 5000,
//                Type = "CooperateCustomer"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 130,
//                Name = "Pam",
//                Salary = 6500,
//                Type = "CooperateCustomer"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 3500,
//                Type = "RetailCustomer"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 150,
//                Name = "Abu",
//                Salary = 8000,
//                Type = "RetailCustomer"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 800,
//                Name = "Ali",
//                Salary = 7000,
//                Type = "RetailCustomer"
//            };


//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);


//            Console.WriteLine("Before Sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.ID);
//            }

//            ////complicated code
//            //listCustomers.Sort(delegate(Customer c1, Customer c2) 
//            //{
//            //    return c1.ID.CompareTo(c2.ID);
//            //});

//            ////    OR

//            //// simplest code
//            listCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

//            Console.WriteLine("After Sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.ID);
//            }
//        }

//        private static int CompareComparison(Customer x, Customer y)
//        {
//            return x.ID.CompareTo(y.ID);
//        }
//    }


//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public string Type { get; set; }

//    }
//}




