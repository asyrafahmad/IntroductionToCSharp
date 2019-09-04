using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//****************************   **PART 63  (Partial Methods)  ******************************//
/* 
 * 1. A partial class or a struct can contain partial methods
 * 2. A partial method is created using the partial keyword. 
 * 3. A partial method declaration consists of two parts. 
        i) The definition (only the method signature)
        ii) The implementation. 
        These may be in separate parts of a partial class, or in the same part.
 * 4. The implementation for a partial method is optional. If we don't provide the implementation, the compiler removes the signature and all calls to the method.
 * 5. Partial methods are private by default, and it is a compile time error to include any access modifiers, including private.
 * 6. It is a compile time error, to include declaration and implementation at the same time for a partial method.
 * 7. A partial method return type must be void. Including any other return type is a compile time error.
 * 8. Signature of the partial method declaration, must match with the signature of the implementation.
 * 9. A partial method must be declared within a partial class or partial struct. A non partial class or struct cannot include partial methods.
 * 10. A partial method can be implemented only once. Trying to implement a partial method more than once, raises a compile time error
 * 
 * 
 */


//namespace IntroductionToCSharp
//{
//    public partial class SamplePartialClass
//    {
//        partial void SamplePartialMethod()
//        {
//            Console.WriteLine("SamplePartialMethod Invoked");
//        }
//    }
//}
