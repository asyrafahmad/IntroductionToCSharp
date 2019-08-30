using System;
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



////internal
//namespace AssemblyOne
//{
//    public class AssemblyOneClassI
//    {
//        internal int ID = 101;
//    } 

//    public class AssemblyOneClassII
//    {
//        public void SampleMethod()
//        {
//            AssemblyOneClassI A1 = new AssemblyOneClassI();
//            Console.WriteLine(A1.ID);
//        }
//    }
//}



/// ////////////////////////////////////////////////////////////////////////////////////////////////////


////protected internal
//namespace AssemblyOne
//{
//    public class AssemblyOneClassI
//    {
//        protected internal int ID = 101;
//    } 

//    public class AssemblyOneClassII
//    {
//        public void SampleMethod()
//        {
//            AssemblyOneClassI A1 = new AssemblyOneClassI();
//            Console.WriteLine(A1.ID);
//        }
//    }
//}



//****************************   PART 51  (Access Modifiers for Types)  ******************************//


//namespace AssemblyOne
//{
//    internal class AssemblyOneClass
//    {
//        public void Print()
//        {
//            Console.WriteLine("Hello");
//        }
//    }
//}


//****************************   PART 52  (Attributes)  ******************************//


//namespace AssemblyOne
//{
//    internal class AssemblyOneClass
//    {
//        public void Print()
//        {
//            Console.WriteLine("Hello");
//        }
//    }
//}