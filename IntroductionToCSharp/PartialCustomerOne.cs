using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****************************   PART 61  (Partial Classes)  ******************************//
/* 
 * allow us to split a class into 2 or more files. All these parts are then combined into a single class., when the application is compiled.
 * 'partial' keyword can also be used to split a struct or an interface over two or more files
 * 
 * Advantages of partial classes
 * 1. spreading  a class over separate files allow multiple programmers to work on it simultaneously. (when working on large projects) 
 *
 */

namespace IntroductionToCSharp
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
    }
}
