
using System;
////using PATA = ProjectA.teamA;
////using PATB = ProjectA.teamB;
////using ProjectA.teamA;
////using ProjectA.teamB;
//using System.Collections;
//using System.Configuration;


////*************************   PART 18  (Namespaces )  *************************//
////to organize the program

//class Program1
//{
//    public static void Main()
//    {

//        //PATA.ClassA.Print();
//        //PATB.ClassA.Print();
//        //ProjectA.teamA.ClassA.Print();
//        //ProjectA.teamB.ClassA.Print();
//    }

//}

////namespace ProjectA
////{
////    namespace teamA
////    {
////        class ClassA
////        {
////            public static void Print()
////            {
////                Console.WriteLine("Team A  print method");
////            }
////        }
////    }
////}

////namespace ProjectA
////{
////    namespace teamB
////    {
////        class ClassA
////        {
////            public static void Print()
////            {
////                Console.WriteLine("Team B print method");
////            }
////        }
////    }
////}





//*************************   PART 19  (Classes)  *************************//



//class Customer
//{
//    string _firstname;
//    string _lastname;

//    //constructor set as default
//    public Customer() : this("No Firstname Provided", "No Lastname Provided")
//    {

//    }

//    //constructer
//    //no return type & same as class name
//    public Customer(string FirstName, string LastName)
//    {
//        this._firstname = FirstName;
//        this._lastname = LastName;
//    }

//    public void PrintFullName()
//    {
//        Console.WriteLine("Fullname = {0}", this._firstname + " " + this._lastname);
//    }

//    //Destructor
//    // to clean any resources that class was holding
//    ~Customer()
//    {
//        //clean up code
//    }
//}

//class Program2
//{
//    public static void Main()
//    {
//       // Customer C1 = new Customer("Sapura", "Technologies"  );

//        Customer C1 = new Customer();

//        C1.PrintFullName();


//        Customer C2 = new Customer("First","Last");
//        C2.PrintFullName();
//    }
//}


//*************************   PART 20  (Static and Instances)  *************************//
// **Class contain 2 types: static, non-static and instances
// **Static: _PI
// **Intances: _radius 


//class Circle
//{
//    //static
//    float _PI = 3.41F;
//    int _Radius;


//    //constructor
//    public Circle(int Radius)
//    {
//        this._Radius = Radius;
//    }




//    // method or function
//    public float CalculateArea()
//    {
//        return this._PI * this._Radius * this._Radius;
//    }
//}



///* static and instnaces constructor */
//class Circle
//{
//    /*static*/
//    //public static float _PI;        // "public" is to access the PI
//    static float _PI;
//    int _Radius;


//    static Circle()
//    {
//        Console.WriteLine("Static Constructor Called");
//        Circle._PI = 3.14F;
//    }

//    public Circle(int Radius)
//    {
//        Console.WriteLine("Instance  Construtor Called");
//        this._Radius = Radius;
//    }



//    // method or function
//    public float CalculateArea()
//    {
//        return Circle._PI * this._Radius * this._Radius;
//    }
//}

//class Program3
//{
//    public static void Main()
//    {
//        Circle C1 = new Circle(5);
//        float Area1 = C1.CalculateArea();
//        Console.WriteLine("Area 1 = {0}", Area1);

//        Circle C2 = new Circle(6);
//        float Area2 = C2.CalculateArea();
//        Console.WriteLine("Area 2 = {0}", Area2);

//    }
//}



//*************************   PART 21  (Inheritance)  *************************//
/*   
    Inheritance
    1. Is one of the object oriented programming
    2. It allow code reuse
    3. Code reuse can reduce time and errors.

    Inheritance Syntax
    1. DerivedClass inherits from ParentClass
    2. C# supports only single class inheritance.
    3. C# supports multiple interface inheritance.
    4. Child class is a specialization of base class.
    5. Base classes are automatically instantiated before derived classes.
    6. Parent Class constructor executes before Child Class Constructor.

    **inheritance not support multiple class, but it supports multiple interface

    Part A  ------> PartTimeEmployee -------
                                           |
                                           -----------> Employee
                                           |
                    FullTimeEmployee -------
*/



//public class Employee
//{
//    public string Firstname;
//    public string LastName;
//    public string Email;

//    public void PrintFullName()
//    {
//        Console.WriteLine(Firstname + " " + LastName);
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public float YearlySalary;
//}

//public class PartTimeEmployee : Employee
//{
//    public float HourlyRate;
//}

//public class A : PartTimeEmployee
//{

//}

//public class Program4
//{
//    public static void Main()
//    {
//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.Firstname = "Full";
//        FTE.LastName = "Time";
//        FTE.YearlySalary = 500000;
//        FTE.PrintFullName();

//        PartTimeEmployee PTE = new PartTimeEmployee();
//        PTE.Firstname = "Part";
//        PTE.LastName = "Time";
//        PTE.PrintFullName();

//    }
//}



////////////////////////////////////////////////////////////////////////////////////////////////





//public class ParentClass
//{
//    public ParentClass()
//    {
//        Console.WriteLine("ParentClass Constructor called");
//    }

//    public ParentClass(string Message)
//    {
//        Console.WriteLine(Message);
//    }
//}

//public class ChildClass : ParentClass
//{
//    //base is to controll the parent constructor

//    public ChildClass() //: base("Derive class controlling Parent class")
//    {
//        Console.WriteLine("ChildClass Constructor called");
//    }
//}

//public class Program5
//{
//    public static void Main()
//    {
//        ChildClass CC = new ChildClass();
//    }
//}




//*************************   PART 22  (Method hiding)  *************************//
// to display hiding method from child class using 'new' keyword



//public class Employee       // base class or parent class
//{
//    public string FirstName;
//    public string LastName;

//    public void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}

//public class PartTimeEmployee : Employee    //derived class or child class
//{
//    public new void PrintFullName()
//    {
//        base.PrintFullName();                                               // to print from the base class
//        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
//    }

//}

//public class FullTimeEmployee : Employee    //derived class or child class
//{

//}


//public class Program6
//{
//    public static void Main()
//    {
//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.FirstName = "FullTime";
//        FTE.LastName = "Employee";
//        FTE.PrintFullName();

//        PartTimeEmployee PTE = new PartTimeEmployee();      // display child class
//        //Employee PTE = new PartTimeEmployee();            // to display parent class

//        PTE.FirstName = "PartTime";
//        PTE.LastName = "Employee";
//        PTE.PrintFullName();

//        //((Employee)FTE).PrintFullName();                    //another way to call method


//    }
//}




//*************************   PART 23  (Polymorphism)  *************************//
// function :  to invoke derive class method using base class reference variable
// use 'virtual' on base class and 'overrides on child class to override method from the base class


//public class Employee
//{
//    public string FirstName = "FN";
//    public string LastName = "LN";

//    public virtual void PrintFullName()     //set virtual
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}

//public class PartTimeEmployee : Employee
//{
//    public override void PrintFullName()       //override from base
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Part Time");
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public override void PrintFullName()        //override from base
//    {
//        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
//    }

//}
//public class TemporaryEmployee : Employee
//{

//}

//public class Program
//{
//    public static void Main()
//    {
//        Employee[] employees = new Employee[4];     //declare array

//        employees[0] = new Employee();
//        employees[1] = new PartTimeEmployee ();
//        employees[2] = new FullTimeEmployee ();
//        employees[3] = new TemporaryEmployee ();

//        foreach(Employee e in employees)
//        {
//            e.PrintFullName();
//        }



//         
//        
//    }
//}




//*************************   PART 24  (Difference betwwen method overriding and method hiding)  *************************//



//public class BaseClass
//{
//    //virtual (polymorphism)
//    public virtual void Print()
//    {
//        Console.WriteLine("I am the Base Class Print Method");
//    }
//}

//public class DerivedClass : BaseClass
//{
//    ////override (method override)
//    //public override void Print()
//    //{
//    //    Console.WriteLine("I am the Child Class Print Method");
//    //}

//    //new (method hiding)
//    public new void Print()
//    {
//        Console.WriteLine("I am the Child Class Print Method");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        BaseClass B = new DerivedClass();
//        B.Print();

//        DerivedClass D = new DerivedClass();
//        D.Print();
//    }
//}




//*************************   PART 25  (**Method overloading)  *************************//
// method overloading :  base on number of parameter


//public class Program7
//{
//    public static void Main()
//    {
//        Add();
//    }

//    public void Add(int FN, int SN)
//    {
//        Console.WriteLine("Sum - {0}", FN + SN);
//    }

//    public static void Add(float FN, float SN)
//    {
//        Console.WriteLine("Sum - {0}", FN + SN);
//    }

//    public static void Add(int FN, float SN)
//    {
//        Console.WriteLine("Sum - {0}", FN + SN);
//    }
//}




//****************************   PART 26  (Properties)  ******************************//



//public class Student
//{
//    public int ID;
//    public string Name;
//    public int PassMark;
//}

//public class Program
//{
//    public static void Main()
//    {
//            Student C1 = new Student();
//            C1.ID = -101;
//            C1.Name = null;
//            C1.PassMark = 0;

//            Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}",C1.ID, C1.Name, C1.PassMark);   
//    }
//}




///////////////////////////////////////////////////////////////////////////////////////////////
// how to protect class field using public getter and setter methods

//public class Student
//{
//    private int _id;
//    private string _Name;
//    private int _PassMark = 35; //readonly 

//    //readonly
//    public int GetPassMark()
//    {
//        return this._PassMark;
//    }

//    public void SetName(string Name)
//    {
//        if(string.IsNullOrEmpty(Name))
//        {
//            throw new Exception("Name cannot be null of empty");
//        }
//        this._Name = Name;
//    }

//    public string GetName()
//    {
//        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
//    }

//    public void SetId(int Id)
//    {
//        if(Id <= 0)
//        {
//            throw new Exception("Student Id cannot be negative");
//        }
//        this._id = Id;
//    }

//    public int GetId()
//    {
//        return this._id;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Student C1 = new Student();
//        C1.SetId(101);
//        C1.SetName("Asyraf");

//        Console.WriteLine("Student Id = {0}", C1.GetId());
//        Console.WriteLine("Student Name = {0}", C1.GetName());
//        Console.WriteLine("PassMark = {0}", C1.GetPassMark());
//    }
//}


///////////////////////////////////////////////////////////////////////////////////////////
// refactor into simple code


//public class Student
//{
//    private int _id;
//    private string _Name;
//    private int _PassMark = 35; //readonly 


//    public string Email { get; set; }
//    public string City { get; set; }

//    //readonly
//    public int PassMark
//    {
//        get
//        {
//            return this._PassMark;
//        }

//    }


//    public string Name
//    {
//        set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new Exception("Name cannot be null of empty");
//            }
//            this._Name = value;
//        }
//        get
//        {
//            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
//        }
//    }


//    public int Id       //change from SetId
//    {
//        set
//        {
//            if (value <= 0)
//            {
//                throw new Exception("Student Id cannot be negative");
//            }
//            this._id = value;
//        }
//        get{
//            return this._id;
//        }
//    }


//}

//public class Program
//{
//    public static void Main()
//    {
//        Student C1 = new Student();
//        C1.Name = "Asyraf";
//        //C1.PassMark = 34;

//        Console.WriteLine("Student Id = {0}", C1.Id);
//        Console.WriteLine("Student Name = {0}", C1.Name);
//        Console.WriteLine("PassMark = {0}", C1.PassMark);
//    } 
//}



//****************************   PART 27  (Structs)  ******************************//
// just like classes struct can have
//1. Private fields
//2. Public properties
//3. Constructors
//4. Methods



//public struct Customer
//{
//    private int _id;
//    private string _name;

//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }

//    public int Id
//    {
//        get { return this._id; }
//        set { this._id = value; }
//    }

//    public Customer(int Id,  string Name)
//    {
//        this._id = Id;
//        this._name = Name;
//    }

//    public void PrintDetails()
//    {
//        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Customer C1 = new Customer(101, "Mark");
//        C1.PrintDetails();

//        Customer C2 = new Customer();
//        C2.Id = 102;
//        C2.Name = "John";
//        C2.PrintDetails();

//        Customer C3 = new Customer
//        {
//            Id = 103,
//            Name = "Rob"
//        };
//        C3.PrintDetails();
//    }
//  }




//****************************   PART 29  (Difference betwwen classes and structs in C)  ******************************//
/*  - Structs are stored on stack, where as classes are stored on the heap.
    - Value types hold their value in memory where they are declared, but reference types hold a reference to an object in memory
    - Value types are destroyed immediately after the scope is lost , where as for the reference types only the reference variable is destroyed after the scope is lost.
      The object is later destroyed by garbage collector.
    - When you copy a struct into another struct, a new copy of that struct gets created and 
      modifications on one struct will not affect the values contained by other struct.
    - When you copy a class into another class, we only get a copy of the reference variable. 
      Both the reference variables point to the same objecct on the heap. So, operations on one variable will affect the values contained by the other reference variable.

 ** Structs can't have constuctor & desctructors, but classes can have destructors
 ** Structs cannot have explicit paramete less constructo where as a class can.
 ** Structs can'tinherit from another class where as a class can, both structs and classes can inherit from an interface.
 ** 1. A class or a struct cannot inherit from another struct. Struct are sealed types.
 
*/


//public class Customer
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        //int i = 0;

//        //if( i == 10)
//        //{
//        //    int j = 20;
//        //    Customer C1 = new Customer();           // stored in Stack (object reference variable)
//        //    C1.ID = 101;                            // stored in Heap (actual object)
//        //    C1.Name = "Mark";                       // stored in Heap (actual object)
//        //}
//        //Console.WriteLine("Hello");


//    ///////////////////////////////////////////////////////////////////////////////////////////////

//        //int i = 10;
//        //int j = i;
//        //j = j + 1;

//        //Console.WriteLine("i = {0} && j = {1}", i, j);

//        //Customer C1 = new Customer();
//        //C1.ID = 101;
//        //C1.Name = "Mark";

//        //Customer C2 = C1;

//        //C2.Name = "John";

//        //Console.WriteLine("C1.Name = {0} && C2.Name = {1}", C1.Name, C2.Name);  


//    }
//}



/////////////////////////////////////////////////////////////////////////////////////////////

// **when marked class as a sealed, we can't use a base class for other


//public sealed class Customer 
//{
//    public int ID { get; set; }
//    public string Name { get; set; }

//    public Customer()
//    {

//    }
//}

//public class Program 
//{
//    public static void Main()
//    {

//    }
//}




//****************************   PART 30  (Interfaces)  ******************************//
/* 
 * same as classes
 * contain properties,methods, delegates and events
 * contain declarations only, NO implementations
 * CAN'T have public or private (USE VOID ONLY)
 * CAN'T have int,string field 
 * CAN'T can't contain fields
 * Class or Struct can inherit more than 1 interfaces at the same time, but where as, a class can't inherit from more than one class at the same time.
 * Interfaces can inherit from other interfaces
 */


//interface ICustomer1
//{
//    void Print1();
//}

//interface ICustomer2 : ICustomer1
//{
//    void Print2();
//}

// public class Customer : ICustomer2
//{
//    public void Print1()
//    {
//        Console.WriteLine("Print 1");
//    }

//    public void Print2()
//    {
//        Console.WriteLine("Print 2");
//    }
//}


//public class Program 
//{
//    public static void Main()
//    {
//        Customer C1 = new Customer();
//        C1.Print1();
//        C1.Print2();
//    }
//}


//****************************   PART 31  (Explicit interfaces implementation)  ******************************//
/*
 * dont use access modifier. eg: public, private
 */

//interface I1
//{
//    void InterfaceMethod();
//}

//interface I2
//{
//    void InterfaceMethod();
//}

//public class Program : I1, I2
//{
//    //void I1.InterfaceMethod()
//    //{
//    //    Console.WriteLine("I1 Interfaces Method");
//    //}

//    public void InterfaceMethod()
//    {
//        Console.WriteLine("I1 Interfaces Method");
//    }

//    void I2.InterfaceMethod()
//    {
//        Console.WriteLine("I2 Interfaces Method");
//    } 

//    public static void Main()
//    {
//        //// access thru interface  reference variable
//        //Program P = new Program(); 
//        //((I1)P).InterfaceMethod();      // invoked interfaces1 method
//        //((I2)P).InterfaceMethod();      // invoked interfaces2 method


//        ////      OR


//        //// When explicitly implements an interface member
//        //// access thru class reference variable
//        //I1 i1 = new Program();
//        //I2 i2 = new Program();

//        //i1.InterfaceMethod();
//        //i2.InterfaceMethod();


//        ////       OR

//        Program P = new Program();
//        P.InterfaceMethod();
//        ((I2)P).InterfaceMethod();
//    }
//}



//****************************   **PART 32  (Abstract classes)  ******************************//
/*
 * CAN be use as base class for other classes
 * contain abstract members (methods, properties, indexers and events)
 * CAN'T be sealed
 ** to prevent class from being inherited by another class, USE SEALED
 */



//public abstract class Customer
//{
//    // abstract method = can't have imlementation
//    public void Print()
//    {
//        Console.WriteLine("Print");
//    }

//}

//public class Program : Customer
//{
//    //public override void Print()
//    //{
//    //    Console.WriteLine("Print Method");
//    //}

//    public static void Main()
//    {
//        //Program P = new Program();
//        //P.Print();

//        ////        OR

//        Customer C = new Program();
//        C.Print();
//    }
//}




//****************************   PART 33  (Abstract classes VS Interfaces)  ******************************//
/*
 * Abstract class CAN have some members(method)
 * Interfaces CANNOT have some members(method)
 * 
 * Abstract classes CAN have fields
 * Interfaces CANNOT have fields
 * 
 * Abstract class can inherit from another abstract class or another interface
 * Interfaces CAN inherit from another interface only and CANNOT inherit from an abstract class
 * 
 * Abstract class members CAN have access modifiers, and is set as public by default
 * Interfaces members CANNOT have acces modifiers
 * 
 *
 */


//public abstract class Customer
//{
//    public void Print()
//    {
//        Console.WriteLine("Print");
//    }
//}

//public interface ICustomer
//{
//    void Print();

//}

//public class Program
//{
//    public static void Main()
//    {

//    }
//}



//****************************   PART 34  (Problems of multiple classes inheritance)  ******************************//

/*      WHY C# DOESN'T SUPPORT MULTIPLE CLASS INHERITANCE (diamond problem)
 * 
 *   
 *      -----------> class C--------->
 *      |                            |
 *   class D                         ------> class A
 *      |                            | 
 *      -----------> class B --------> 
 *
 * 
 */


//class A
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("A Implementation");
//    }
//}

//class B : A
//{
//    public override void Print()
//    {
//        Console.WriteLine("B Implementaton");
//    }
//}

//class C : A
//{
//    public override void Print()
//    {
//        Console.WriteLine("C Implementaton");
//    }
//}

//class D : B, C
//{
//    public override void Print()
//    {
//        Console.WriteLine("C Implementaton");
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        D d = new D();
//        d.Print();
//    }
//}



//****************************   PART 35  (Multiple class inheritance using interfaces)  ******************************//
/*
 * 
 *                   class A --------> Interface A
 *                                 |  
 *                                 |     
 *                   class AB -----|
 *                                 | 
 *                                 |   
 *                   class B --------> Interface B
 *
 */



//interface IA
//{
//    void AMethod();
//}

//class A :IA
//{
//    public void AMethod()
//    {
//        Console.WriteLine("A");
//    }
//}

//interface IB
//{
//    void BMethod();
//}

//class B : IB
//{
//    public void BMethod()
//    {
//        Console.WriteLine("B");
//    }
//}


//class AB : IA, IB
//{
//    A a = new A();
//    B b = new B();

//    public void AMethod()
//    {
//        a.AMethod();
//    }

//    public void BMethod()
//    {
//        b.BMethod();
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        AB ab = new AB();
//        ab.AMethod();
//        ab.BMethod();
//    }
//}


