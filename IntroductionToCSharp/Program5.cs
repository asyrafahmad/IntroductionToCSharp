using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;


//****************************   PART 80 (Some usefull methods of List collection class)  ******************************//
/*
 * In this video, we will discuss the following methods
 * 1. TrueForAll() - Returns true or false depending on whether if every element in the list matches the conditions defined by the specified predicate.
 * 2. AsReadOnly() - Returns a read-only wrapper for the current collection. Use this method, if you don't want the client code to modify the collection i.e add or remove any elements from the collection.
 * The ReadOnlyCollection will not have methods to add or remove items from the collection. You can only read items from this collection.
 * 3. TrimExcess() - Sets the capacity to the actual number of elements in the List, if that number is less than a threshold value. 

According to MSDN: 
This method can be used to minimize a collection's memory overhead if no new elements will be added to the collection.
The cost of reallocating and copying a large List[T] can be considerable, however, so the TrimExcess method does nothing if the list is at more than 90 percent of capacity. 
This avoids incurring a large reallocation cost for a relatively small gain. The current threshold is 90 percent, but this could change in the future.
 */



//namespace Demo
//{
//    class Program5
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

//            List<Customer> listCustomers = new List<Customer>(4);
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            //// 1. TrueForAll()
//            ////to check that the list have got a salary greater than five thousand
//            //Console.WriteLine("are all salaries greater than 5000 = " + listCustomers.TrueForAll(x => x.Salary > 1000));


//            // 2. AsReadOnly
//            // dont want client to modify the collection (add or remove the list of collection)
//            ReadOnlyCollection<Customer> readOnlyCustomers = listCustomers.AsReadOnly();
//            // to count how much elements in the list of collection
//            Console.WriteLine("Items = " + readOnlyCustomers.Count);
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


//namespace Demo
//{
//    class Program5
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

//            List<Customer> listCustomers = new List<Customer>(100);
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            Console.WriteLine("Capacity before trimming = " + listCustomers.Capacity);
//            // to set the capacity to the actual number of elements
//            listCustomers.TrimExcess();
//            Console.WriteLine("Capacity after trimming = " + listCustomers.Capacity);   
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


//****************************   **PART 81 (When to use a dicstionsary over list)UNIFINISHED   ******************************//
/* DICTIONARY IS BETTER THAN LIST in term of performance
 * Find() method of the List class loops thru each object in the list until a match is found. 
 * So, if you want to lookup a value using a key dictionary is better for performance over list. 
 * So, use dictionary when you know the collection will be primarily used for lookups
 */


//// USING LIST
//namespace Demo
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
//            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
//            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington DC" };
//            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
//            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

//            List<Country> listCountries = new List<Country>();
//            listCountries.Add(country1);
//            listCountries.Add(country2);
//            listCountries.Add(country3);
//            listCountries.Add(country4);
//            listCountries.Add(country5);

//            string strUserChoice = string.Empty;

//            do
//            {
//                Console.WriteLine("Please enter country code");
//                string strCountryCode = Console.ReadLine().ToUpper();

//                Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

//                if (resultCountry == null)
//                {
//                    Console.WriteLine("Country code not valid");
//                }
//                else
//                {
//                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
//                }

//                do
//                {
//                    Console.WriteLine("Do you want to continue? YES or NO");
//                    strUserChoice = Console.ReadLine().ToUpper();
//                } while (strUserChoice != "NO" && strUserChoice != "YES");

//            } while (strUserChoice == "YES");
//        }
//    }

//    public class Country
//    {
//        public string Name { get; set; }
//        public string Code { get; set; }
//        public string Capital { get; set; }
//    }
//}



//// USING DICTIONARY
//namespace Demo
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
//            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
//            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington DC" };
//            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
//            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };


//            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
//            dictionaryCountries.Add(country1.Code, country1);
//            dictionaryCountries.Add(country2.Code, country2);
//            dictionaryCountries.Add(country3.Code, country3);
//            dictionaryCountries.Add(country4.Code, country4);
//            dictionaryCountries.Add(country5.Code, country5);

//            string strUserChoice = string.Empty;

//            do
//            {
//                Console.WriteLine("Please enter country code");
//                string strCountryCode = Console.ReadLine().ToUpper();

//                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] :  null;

//                if (resultCountry == null)
//                {
//                    Console.WriteLine("Country code not valid");
//                }
//                else
//                {
//                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
//                }

//                do
//                {
//                    Console.WriteLine("Do you want to continue? YES or NO");
//                    strUserChoice = Console.ReadLine().ToUpper();
//                } while (strUserChoice != "NO" && strUserChoice != "YES");

//            } while (strUserChoice == "YES");
//        }
//    }

//    public class Country
//    {
//        public string Name { get; set; }
//        public string Code { get; set; }
//        public string Capital { get; set; }
//    }
//}



//****************************   PART 82 (Generic queue collection class)   ******************************//
/* FIFO - FIRST ITEM WILL BE ADDED, FIRST ITEM WILL BE REMOVE
 * 
 * Queue is a generic FIFO (First In First Out) collection class that is present in System.Collections.Generic namespace. 
 * The Queue collection class is analogous to a queue at the ATM machine to withdraw money. 
 * The order in which people queue up, will be the order in which they will be able to get out of the queue and withdraw money from the ATM. 
 * The Queue collection class operates in a similar fashion. 
 * The first item to be added (enqueued) to the queue, will be the first item to be removed (dequeued) from the Queue.
 * 
 * 
 * To add items to the end of the queue, use Enqueue() method.
 * 
 * To remove an item that is present at the beginning of the queue, use Dequeue() method.
 * 
 * A foreach loop iterates thru the items in the queue, but will not remove them from the queue.
 * 
 * To check if an item, exists in the queue, use Contains() method.
 * 
 * What is the difference between Dequeue() and Peek() methods?
 * Dequeue() method removes and returns the item at the beginning of the queue, where as Peek() returns the item at the beginning of the queue, without removing it.
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


//            Queue<Customer> queueCustomers = new Queue<Customer>();
//            queueCustomers.Enqueue(customer1);
//            queueCustomers.Enqueue(customer2);
//            queueCustomers.Enqueue(customer3);
//            queueCustomers.Enqueue(customer4);
//            queueCustomers.Enqueue(customer5);


//            ////item present at the beginning of the queue will be remove from the queue adn then returned
//            //Customer c1 = queueCustomers.Dequeue();
//            //Console.WriteLine(c1.ID + " - " + c1.Name);
//            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

//            //// OR

//            ////item present at the beginning of the queue will be remove from the queue adn then returned
//            //Customer c1 = queueCustomers.Dequeue();
//            //Console.WriteLine(c1.ID + " - " + c1.Name);
//            //Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);

//            //Customer c2 = queueCustomers.Dequeue();
//            //Console.WriteLine(c2.ID + " - " + c2.Name);
//            //Console.WriteLine("Total left in the Queue = " + queueCustomers.Count);

//            //Customer c3 = queueCustomers.Dequeue();
//            //Console.WriteLine(c3.ID + " - " + c3.Name);
//            //Console.WriteLine("Total left in the Queue = " + queueCustomers.Count);

//            //Customer c4 = queueCustomers.Dequeue();
//            //Console.WriteLine(c4.ID + " - " + c4.Name);
//            //Console.WriteLine("Total left in the Queue = " + queueCustomers.Count);

//            //Customer c5 = queueCustomers.Dequeue();
//            //Console.WriteLine(c5.ID + " - " + c5.Name);
//            //Console.WriteLine("Total left in the Queue = " + queueCustomers.Count);


//            ////In simplest form to display the elements of the list
//            //foreach (Customer c in queueCustomers)
//            //{
//            //    Console.WriteLine(c.ID + " - " + c.Name);
//            //    Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);
//            //}


//            //// to printout the first item that is present at the queue
//            //Customer c = queueCustomers.Peek();
//            //Console.WriteLine(c.ID + " - " + c.Name);
//            //Console.WriteLine("Total left in the Queue = " + queueCustomers.Count);

//            ////Contains will return true of false
//            if (queueCustomers.Contains(customer1))
//            {
//                Console.WriteLine("customer1 exists");
//            }
//            else
//            {
//                Console.WriteLine("customer1 does not exits");
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



//****************************   PART 83 (Generic stack collection class)   ******************************//
/* LIFO - LAST ITEM WILL BE ADDED, FIRST ITEM WILL BE REMOVE
 * 
 * Stack is a generic LIFO (Last In First Out) collection class that is present in System.Collections.Generic namespace. 
 * The Stack collection class is analogous to a stack of plates. If you want to add a new plate to the stack of plates, you place it on top of all the already existing plates.
 * If you want to remove a plate from the stack, you will first remove the one that you have last added. The stack collection class also operates in a similar fashion. 
 * The last item to be added (pushed) to the stack, will be the first item to be removed (popped) from the stack.
 * 
 * To insert an item at the top of the stack, use Push() method.
 * 
 * To remove and return the item that is present at the top of the stack, use Pop() method.
 * 
 * A foreach loop iterates thru the items in the stack, but will not remove them from the stack. The items from the stack are retrieved in LIFO (Last In First Out), order. The last element added to the Stack is the first one to be removed.
 * 
 * To check if an item exists in the stack, use Contains() method.
 * 
 * What is the difference between Pop() and Peek() methods.
 * Pop() method removes and returns the item at the top of the stack, where as Peek() returns the item at the top of the stack, without removing it.
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


//            Stack<Customer> stackCustomers = new Stack<Customer>();
//            stackCustomers.Push(customer1);
//            stackCustomers.Push(customer2);
//            stackCustomers.Push(customer3);
//            stackCustomers.Push(customer4);
//            stackCustomers.Push(customer5);


//            //Customer c1 = stackCustomers.Pop();
//            //Console.WriteLine(c1.ID + " - " + c1.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c2 = stackCustomers.Pop();
//            //Console.WriteLine(c2.ID + " - " + c2.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c3 = stackCustomers.Pop();
//            //Console.WriteLine(c3.ID + " - " + c3.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c4 = stackCustomers.Pop();
//            //Console.WriteLine(c4.ID + " - " + c4.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c5 = stackCustomers.Pop();
//            //Console.WriteLine(c5.ID + " - " + c5.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);


//            //foreach (Customer c1 in stackCustomers)
//            //{
//            //    Console.WriteLine(c1.ID + " - " + c1.Name);
//            //    Console.WriteLine("Items left in the stack = " + stackCustomers.Count);
//            //}

//            // to return item that present at the top of the stack without removing it
//            Customer c1 = stackCustomers.Peek();
//            Console.WriteLine(c1.ID + " - " + c1.Name);
//            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //stackCustomers.Contains(customer1);
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


//****************************   **PART 84(Real time example of queue collection class)   ******************************//
/*
 * 
 */



////WebForm1.aspx
//<html>
//    <head>

//<title>
//</title>

//    </head>

//<body>
//<form id="form1" runat="server">
//    <table style="font-family:Arial; border: 1px solid black; text-align: center">

//    <tr>
//    <td>
//    <b> Counter 1</b>
//    </td>
//    <td>
//    </td>
//    <td>
//     <b> Counter 2</b>
//    </td>
//    <td>
//    </td>
//    <td>
//     <b> Counter 3</b>
//    </td>
//    </tr>

//    <tr>
//    <td>
//     <asp:TextBox ID="txtCounter1" runat="server" BackColor="#000099" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox> 
//    </td>
//    <td>
//    </td>
//    <td>
//     <asp:TextBox ID= "txtCounter2" runat="server" BackColor="#000099" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox> 
//    </td>
//    <td>
//    </td>
//    <td>
//      <asp:TextBox ID="txtCounter2" runat="server" BackColor="#000099" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox> 
//    </td>
//    </tr>

//    <tr>
//    <td>
//     <asp:Button ID="btnCounter1" runat="server" Text="Button" Width="150px" />
//     </td>
//    <td>
//    </td>
//    <td>
//    <asp:Button ID="btnCounter1" runat="server" Text="Button" Width="150px"/>
//    </td>
//    <td>
//    </td>
//    <td>
//    <asp:Button ID="btnCounter1" runat="server" Text="Button" Width="150px"/>
//    </td>
//    </tr>
//    <tr>
//    <td colspan="5">
//    <asp:TextBox ID="txtDisplay" runat="server" BackColor="#003300" Font-Size="Large" ForeColor="White" Width="500px"></asp:TextBox>
//    </td> 
//    </tr>
//    <tr>
//    <td colspan="5">
//    <asp:ListBox Font-Size="Large" ID="listTokens" runte="server"></asp:ListBox>
//    </td>
//    </tr>
//    <tr>
//    <td colspan="5">
//    <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" />
//    </td>
//    </tr>

//    <tr>
//    <td colspan="5">
//    <asp:Label ID="lblStatus" runat="server" ></asp:Label>
//    </td>
//    </tr>
//</body>


//    </body>
//</html>


//WebForm1.aspx.cs file
//namespace WebFormsDemo
//{
//    public partial class WebForm1 : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            Queue<int> queueTokens = new Queue<int>();
//            Session["TokenQueue"] = queueTokens;
//        }

//        protected void btnPrintToken_Click(object sender, EventArgs e)
//        {
//            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
//            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " customers before you in the queue";

//            if(Session["LastTokenNumberIssued"] == null)
//            {
//                Session["LastTokenNumberIssued"] = 0;
//            }

//            int nextTokenNumberTobeIssued = (int)Session["LastTokenNumberIssued"] + 1;
//            Session["LastTokenNumberIssued"] = nextTokenNumberTobeIssued;
//            tokenQueue.Enqueue(nextTokenNumberTobeIssued);

//            AddTokensToListBox(tokenQueue);
//        }

//        private void AddTokensToListBox(Queue<int> tokenQueue)
//        {
//            listTokens.Items.Clear();
//            foreach (int token in tokenQueue)
//            {
//                listTokens.Items.Add(token.ToString());
//            }
//        }

//        private void ServerNextCustomer(TextBox textbox, int counterNumber)
//        {
//            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
//            if (tokenQueue.Count == 0)
//            {
//                textbox.Text = " No customers in the Queue";
//            }
//            else
//            {
//                int tokenNumberToBeServed = tokenQueue.Dequeue();
//                textbox.Text = tokenNumberToBeServed.ToString();
//                txtDisplay.Text = "Token Number: " + tokenNumberToBeServed.ToString(); +"Please go to counter 1" + counterNumber.ToString();
//                AddTokensToListBox(tokenQueue);
//            }
//        }

//        protected void btnCounter1_Click(object sender, EventArgs e)
//        {
//            ServerNextCustomer(txtCounter1, 1);
//        }

//        protected void btnCounter2_Click(object sender, EventArgs e)
//        {
//            ServerNextCustomer(txtCounter2, 2);
//        }

//        protected void btnCounter3_Click(object sender, EventArgs e)
//        {
//            ServerNextCustomer(txtCounter3, 3);
//        }
//    }
//}



//****************************   **PART 85 (Real time example of stack collection class)unfinished   ******************************//


//namespace WebFormsDemo
//{
//    public class BasePage : System.Web.UI.Page
//    {
//        protected override void OnLoad(EventArgs e)
//        {
//            if (Session["URLStack"] == null)
//            {
//                Stack<string> urlStack = new Stack<string>();
//                Session["URLStack"] = urlStack;
//            }

//            if (Request.UrlReferrer != null && !this.Page.IsPostBack && Session["BackButtonClicked"] == null)
//            {
//                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
//                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
//            }

//            if (Session["BackButtonClicked"] != null)
//            {
//                Session["BackButtonClicked"] = null
//            }
//        }
//    }
//}



//******************************  PART 85 (Multithreading)  *****************************//
/*
 * 1. Process - Process is what the operating system uses to facilitate the execution of a program by providing the resources required. Each process has a unique process Id associated with it. You can view the process within which a program is being executed using windows task manager.
 * 2. Thread - Thread is a light weight process. A process has at least one thread which is commonly called as main thread which actually executes the application code. A single process can have multiple threads.
 * 
 * Please Note: All the threading related classes are present in System.Threading namespace.

 */


//namespace ThreadingExample
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
//        {
//            btnTimeConsumingWork.Enabled = false;
//            btnPrintNumbers.Enabled = false;

//            DoTimeConsumingWork();

//            btnTimeConsumingWork.Enabled = true;
//            btnPrintNumbers.Enabled = true;
//        }

//        private void DoTimeConsumingWork()
//        {
//            // Make the thread sleep, to introduce artifical latency
//            Thread.Sleep(5000);
//        }

//        private void btnPrintNumbers_Click(object sender, EventArgs e)
//        {
//            for (int i = 1; i[= 10; i++)
//            {
//                listBoxNumbers.Items.Add(i);
//            }
//        }
//    }
//}


/*
1. At this point if we run the program, one thread is automatically created. This thread is called as the Main thread or UI thread. This is the thread that is responsible for doing all the work. 
2. Now when you click "Do Time Consuming Work", the first 2 lines of code to disable the button is executed.As a result both the buttons are disabled. 
3. DoTimeConsumingWork() method is called next, and at this point the application is unresponsive as it is waiting for the method to complete. Note that the buttons are still disabled and you cannot click on any of them.
4. Finally, once the DoTimeConsumingWork() method completes the buttons are enabled and the application is responsive.

Now change the code in btnTimeConsumingWork_Click() event handler method as shown below.

*/


//private void btnTimeConsumingWork_Click(object sender, EventArgs e)
//{
//    btnTimeConsumingWork.Enabled = false;
//    btnPrintNumbers.Enabled = false;

//    // Create another THREAD to offload the work of executing the time consuming method to it. 
//    // As a result the UI thread, is free to execute the rest of the code and our application is more responsive. 
//    Thread backGroundThread = new Thread(DoTimeConsumingWork);
//    backGroundThread.Start();
//    //DoTimeConsumingWork();

//    btnTimeConsumingWork.Enabled = true;
//    btnPrintNumbers.Enabled = true;
//}



//******************************  PART 86 (Advantages adn disadvantages of multithreading)  *****************************//
/*
 * Advantages of multithreading:
 * 1. To maintain a responsive user interface
 * 2. To make efficient use of processor time while waiting for I/O operations to complete.
 * 3. To split large, CPU-bound tasks to be processed simultaneously on a machine that has multiple CPUs/cores.
 * 
 * Disadvantages of multithreading:
 * 1. On a single-core/processor machine threading can affect performance negatively as there is overhead involved with context-switching.
 *  eg: context-switching - switch from the first thread to the second thread    
 * 2. Have to write more lines of code to accomplish the same task.
 * 3. Multithreaded applications are difficult to write, understand, debug and maintain.
 * 
 */



//******************************  PART 87 (ThreadStart Delegate)  *****************************//
/*
 * Why a delegate need to be passed as a parameter to the Thread class constructor?
 * The purpose of creating a Thread is to execute a function. A delegate is a type safe function pointer, meaning it points to a function that the thread has to execute.
 * In short, all threads require an entry point to start execution. Any thread you create will need an explicitly defined entry point i.e a pointer to the function where they should begin execution.
 * So threads always require a delegate.

 * 
 */



//using System.Threading;
//using System.Threading.Tasks;


//class Program
//{
//    public static void Main()
//    {
//        //// To create the thread
//        //Thread T1 = new Thread(Number.PrintNumbers);

//        //// ThreadStart =  is a delegates (cant have parameters)
//        //// delegates - C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime. Delegates are especially used for implementing events and the call-back methods.
//        //Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
//        //T1.Start();

//        ////        OR

//        ////create delegate using delegates keyword
//        //Thread T1 = new Thread(delegate () { Number.PrintNumbers(); });

//        ////        OR

//        ////create delegates using lambda expression
//        //Thread T1 = new Thread(() => Number.PrintNumbers());

//        ////        OR

//        ////Thread function need not be a static function always. It can also be a non-static function. In case of non-static function we have to create an instance of the class. An example is shown below.
//        //Number number = new Number();
//        //Thread T1 = new Thread(number.PrintNumbers);
//        //T1.Start();
//    }
//}

//class Number
//{
//    public static void PrintNumbers()
//    {
//        for(int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


//******************************  PART 89 (ParameterizedThreadStart delegate)  *****************************//
/* NOT USING TYPE SAFETY FEATURE OF C#
 * 
 * Use ParameterizedThreadStart delegate to pass data to the thread function
 * 
 * When to use ParameterizedThreadStart over ThreadStart delegate?
 * Use ParameterizedThreadStart delegate if you have some data to pass to the Thread function, otherwise jus use ThreadStart delegate.
 * 
 * Please note: Using ParameterizedThreadStart delegate and Thread.Start(Object) method to pass data to the Thread function is not type safe as they operate on object datatype and any type of data can be passed. 
 * If you try to change the data type of the target parameter of PrintNumbers() function from object to int, 
 * a compiler error will be raised as the signature of PrintNumbers() function does not match with the signature of ParameterizedThreadStart delegate.
 */


//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadStartDelegateExample
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Console.WriteLine("Please enter the target number");
//            object target = Console.ReadLine();

//            //    //Thread function need not be a static function always. It can also be a non-static function. In case of non-static function we have to create an instance of the class. An example is shown below.
//            //    Number number = new Number();
//            //    ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
//            //    Thread T1 = new Thread(parameterizedThreadStart);
//            //    T1.Start(target);

//            ////        OR


//            Number number = new Number();
//            Thread T1 = new Thread(number.PrintNumbers);
//            T1.Start(target);

//        }
//    }
//}

//class Number
//{
//    public void PrintNumbers(object target)
//    {
//        int number = 0;
//        // to convert object target parameter into integer
//        if(int.TryParse(target.ToString(), out number))
//        {
//            for (int i = 1; i <= number; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }

//    }
//}



//******************************  PART 90 (Passing data to the Thread function in a type safe manner)  *****************************//
/* THIS METHOD USING TYPE SAFE FEATURE OF C#
 * 
 *To pass data to the Thread function in a type safe manner, encapsulate the thread function and the data it needs in a helper class and use the ThreadStart delegate to execute the thread function.  
 */


//using System.Threading;
//using System.Threading.Tasks;

//namespace ThreadStartDelegateExample
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Console.WriteLine("Please enter the target number");
//            int target = Convert.ToInt32(Console.ReadLine());

//            Number number = new Number(target);

//            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
//            T1.Start();

//        }
//    }
//}

//class Number
//{
//    private int _target;

//    public Number(int target)
//    {
//        this._target = target;
//    }

//    public void PrintNumbers()
//    {

//            for (int i = 1; i <= _target; i++)
//            {
//                Console.WriteLine(i);
//            }

//    }
//}



//******************************  **PART 91 (Retrieving data from Thread function callback method)  *****************************//
/*
 * 
 */


//using System.Threading;
//using System.Threading.Tasks;
//using ThreadStartDelegateExample;

//namespace ThreadStartDelegateExample
//{
//    public delegate void SumOfNumbersCallback(int SumOfNumbers);

//    class Program
//    {
//        public static void PrintSum(int sum)
//        {
//            Console.WriteLine("Sum of numbers = " + sum);
//        }

//        public static void Main()
//        {
//            Console.WriteLine("Please enter the target number");
//            int target = Convert.ToInt32(Console.ReadLine());

//            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);

//            Number number = new Number(target, callback);
//            Thread T1 = new Thread(new ThreadStart(number.PrintSumOfNumbers));
//            T1.Start();

//        }
//    }
//}

//class Number
//{
//    private int _target;
//    SumOfNumbersCallback _callBackMethod;

//    public Number(int target, SumOfNumbersCallback callBackMethod)
//    {
//        this._target = target;
//        this._callBackMethod = callBackMethod;
//    }

//    public void PrintSumOfNumbers()
//    {
//        int sum = 0;

//        for (int i = 1; i <= _target; i++)
//        {
//            sum = sum + i;
//        }

//        if(_callBackMethod != null) _callBackMethod(sum);

//    }
//}



//******************************  **PART92 (Significance of Thread Join and Thread IsAlive functions)  *****************************//
/*
 * Join blocks the current thread and makes it wait until the thread on which Join method is invoked to complete. 
 * Join method also has a overload where we can specify the timeout. 
 * If we don't specify the timeout the calling thread waits indefinitely, until the thread on which Join() is invoked completes. 
 * This overloaded Join(int millisecondsTimeout) method returns boolean. 
 * True if the thread has terminated otherwise false. 
 * 
 * Join is particularly useful when we need to wait and collect result from a thread execution or if we need to do some cleanup after the thread has completed.
 * 
 * IsAlive returns boolean. True if the thread is still executing otherwise false.
 */



//using System.Threading;

//namespace ThreadingExample
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Console.WriteLine("Main Started");
//            Thread T1 = new Thread(Program.Thread1Function);
//            T1.Start();

//            Thread T2 = new Thread(Program.Thread2Function);
//            T2.Start();

//            if (T1.Join(1000))
//            {
//                Console.WriteLine("Thread1Function Completed");
//            }
//            else
//            {
//                Console.WriteLine("Thread1Function has not completed in 1 second");
//            }

//            T2.Join();
//            Console.WriteLine("Thread2Function Completed");

//            for( int i = 1; i <= 10; i++)
//            {
//                // IsAlive returns boolean
//                if (T1.IsAlive)
//                {
//                    Console.WriteLine("Thread1Function is still doing it's work");
//                    Thread.Sleep(500);
//                }
//                else
//                {
//                    Console.WriteLine("Thread1Function Completed");
//                    break;
//                }
//            }

//            Console.WriteLine("Main Completed");


//        }

//        public static void Thread1Function()
//        {
//            Console.WriteLine("Thread1Function Started");
//            Thread.Sleep(5000);
//            Console.WriteLine("Thread1Function is about to return");
//        }

//        public static void Thread2Function()
//        {
//            Console.WriteLine("Thread2Function Started");
//        }
//    }
//}



//******************************  PART93 (Protecting shared resources fro concurrent access in multithreading)  *****************************//
/*
 *  Which option is better?
 *  From a performance perspective using Interlocked class is better over using locking. Locking locks out all the other threads except a single thread to read and increment the Total variable.
 *  This will ensure that the Total variable is updated safely. The downside is that since all the other threads are locked out, there is a performance hit.
 *  
 *  The Interlocked class can be used with addition/subtraction (increment, decrement, add, etc.) on and int or long field. 
 *  The Interlocked class has methods for incrementing, decrementing, adding, and reading variables atomically.
 * 
 */

//class Program
//{
//    static int Total = 0;

//    public static void Main()
//    {
//        Stopwatch stopwatch = new Stopwatch();

//        Thread T1 = new Thread(Program.AddOneMillion);
//        Thread T2 = new Thread(Program.AddOneMillion);
//        Thread T3 = new Thread(Program.AddOneMillion);

//        T1.Start();
//        T2.Start();
//        T3.Start();

//        T1.Join();
//        T2.Join();
//        T3.Join();
//        Console.WriteLine("Total = " + Total);
//    }

//    public static void AddOneMillion()
//    {
//        for (int i = 1; i<= 1000000; i++)
//        {
//            Total++;
//        }
//    }
//}


////////////////////////////////////////////////////////////////////////////////////////////////////

////to lock
//class Program
//{
//    static int Total = 0;

//    public static void Main()
//    {
//        Stopwatch stopwatch = new Stopwatch();

//        Thread T1 = new Thread(Program.AddOneMillion);
//        Thread T2 = new Thread(Program.AddOneMillion);
//        Thread T3 = new Thread(Program.AddOneMillion);

//        T1.Start();
//        T2.Start();
//        T3.Start();

//        T1.Join();
//        T2.Join();
//        T3.Join();
//        Console.WriteLine("Total = " + Total);

//      
//    }


//    public static void AddOneMillion()
//    {
//        for (int i = 1; i <= 1000000; i++)
//        {
//            // use interlocked function to 
//            Interlocked.Increment(ref Total);
//        }
//    }
//}


/////////////////////////////////////////////////////////////////////////////////////////////////

////          OR

//class Program
//{
//    static int Total = 0;

//    public static void Main()
//    {
//        Stopwatch stopwatch = new Stopwatch();

//        Thread T1 = new Thread(Program.AddOneMillion);
//        Thread T2 = new Thread(Program.AddOneMillion);
//        Thread T3 = new Thread(Program.AddOneMillion);

//        T1.Start();
//        T2.Start();
//        T3.Start();

//        T1.Join();
//        T2.Join();
//        T3.Join();
//        Console.WriteLine("Total = " + Total);


//    }


//    public static void AddOneMillion()
//    {
//        for (int i = 1; i <= 1000000; i++)
//        {
//            lock (_lock)
//            {
//                Total++;
//            }
//        }
//    }
//}


//******************************  PART 94 (Difference between Monitor and Lock)  *****************************//
/*
 * Both Monitor class and lock provides a mechanism that synchronizes access to objects. 
 * Lock is the shortcut for Monitor.Enter with try and finally
 * 
 * 
 * So, in short, lock is a shortcut and it's the option for the basic usage. 
 * If you need more control to implement advanced multithreading solutions using TryEnter() Wait(), Pulse(), & PulseAll() methods, 
 * then the Montior class is your option.
 */



//class Program
//{
//    static int Total = 0;

//    public static void Main()
//    {
//        Stopwatch stopwatch = new Stopwatch();

//        Thread T1 = new Thread(Program.AddOneMillion);
//        Thread T2 = new Thread(Program.AddOneMillion);
//        Thread T3 = new Thread(Program.AddOneMillion);

//        T1.Start();
//        T2.Start();
//        T3.Start();

//        T1.Join();
//        T2.Join();
//        T3.Join();
//        Console.WriteLine("Total = " + Total);


//    }

//    static object _lock = new object();

//    public static void AddOneMillion()
//    {
//        for (int i = 1; i <= 1000000; i++)
//        {
//            Monitor.Enter(_lock);
//            try
//            {
//                Total++;
//            }
//            finally
//            {
//                Monitor.Exit(_lock);
//            }
//        }
//    }
//}




//******************************  PART 95 (Deadlock in multihreaded program)  *****************************//
/* TO CHECK THE DEADLOCK OCCURED
 * 
 */


//public class Account
//{
//    double _balance;
//    int _id;

//    public Account(int id, double balance)
//    {
//        this._id = id;
//        this._balance = balance;
//    }

//    public int ID
//    {
//        get
//        {
//            return _id;
//        }
//    }

//    public void Withdraw(double amount)
//    {
//        _balance -= amount;
//    }

//    public void Deposit(double amount)
//    {
//        _balance += amount;
//    }
//}

    
//public class AccountManager
//{
//    Account _fromAccount;
//    Account _toAccount;
//    double _amountToTransfer;

//    public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
//    {
//        this._fromAccount = fromAccount;
//        this._toAccount = toAccount;
//        this._amountToTransfer= amountToTransfer;
//    }

//    public void Transfer()
//    {
//        //
//        Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());

//        lock (_fromAccount)
//        {
//            //
//            Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.ID.ToString());
//            Console.WriteLine(Thread.CurrentThread.Name + " suspended  for 1 second");

//            Thread.Sleep(1000);
//            //
//            Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + _toAccount.ID.ToString());
//            lock (_toAccount)
//            {
//                Console.WriteLine("This code will not be executed");
//                _fromAccount.Withdraw(_amountToTransfer);
//                _toAccount.Deposit(_amountToTransfer);
//            } 
//        }
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Main Started");
//        Account accountA = new Account(101, 5000);
//        Account accountB = new Account(102, 3000);

//        AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
//        Thread T1 = new Thread(accountManagerA.Transfer);
//        T1.Name = "T1";

//        AccountManager accountManagerB = new AccountManager(accountA, accountB, 2000);
//        Thread T2 = new Thread(accountManagerA.Transfer);
//        T2.Name = "T2";

//        T1.Start();
//        T2.Start();

//        T1.Join();
//        T2.Join();
//        Console.WriteLine("Main Completed");
//    }
//}