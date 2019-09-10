using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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


//****************************   PART 84(Real time example of queue collection class)   ******************************//
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
namespace WebFormsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Queue<int> queueTokens = new Queue<int>();
            Session["TokenQueue"] = queueTokens;
        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " customers before you in the queue";

            if(Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }

            int nextTokenNumberTobeIssued = (int)Session["LastTokenNumberIssued"] + 1;
            Session["LastTokenNumberIssued"] = nextTokenNumberTobeIssued;
            tokenQueue.Enqueue(nextTokenNumberTobeIssued);

            AddTokensToListBox(tokenQueue);
        }

        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        private void ServerNextCustomer(TextBox textbox, int counterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count == 0)
            {
                textbox.Text = " No customers in the Queue";
            }
            else
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                textbox.Text = tokenNumberToBeServed.ToString();
                txtDisplay.Text = "Token Number: " + tokenNumberToBeServed.ToString(); +"Please go to counter 1" + counterNumber.ToString();
                AddTokensToListBox(tokenQueue);
            }
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter3, 3);
        }
    }
}
