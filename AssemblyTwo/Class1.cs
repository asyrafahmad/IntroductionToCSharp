using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
//namespace AssemblyTwo
//{
//    public class AssemblyTwoClassI
//    {
//        public void Print()
//        {
//            AssemblyOneClassI A1 = new AssemblyOneClassI();  //instances to object from assembly 1  
//            A1.ID = 101;                                     // but can't get the value from assembly 1 (error)
//        }
//    }
//}



/// ///////////////////////////////////////////////////////////////////////////////////



//using AssemblyOne;  //call assembly 1   (internal)


////protected internal (add invoker to base class and 'base' keyword)
//namespace AssemblyTwo
//{
//    public class AssemblyTwoClassI : AssemblyOneClassI
//    {
//        public void Print()
//        {
//            AssemblyOneClassI A1 = new AssemblyOneClassI();  // instances as object from assembly 1  
//            base.ID = 101;

//            AssemblyOneClassI A2 = new AssemblyOneClassI();  // instances as object from assembly 1  
//            base.ID = 101;                                     // but can't get the value from assembly 1 (error)
//        }
//    }
//}





//****************************   PART 51  (Access Modifiers for Types)  ******************************//

//using AssemblyOne;

//namespace AssemblyTwo
//{
//    public class AssemblyTwoClass
//    {
//        public void Test()
//        {
//            AssemblyOneClass instance = new AssemblyOneClass();                             // but can't get the value from assembly 1 (error)
//            instance.Print(); 
//        }
//    }
//}



//****************************   PART 52  (Access Modifiers for Types)  ******************************//

//using AssemblyOne;

//namespace AssemblyTwo
//{
//    public class AssemblyTwoClass
//    {
//        public void Test()
//        {
//            AssemblyOneClass instance = new AssemblyOneClass();                             // but can't get the value from assembly 1 (error)
//            instance.Print(); 
//        }
//    }
//}