using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities.OOP_Practice
{
    public class ExtensionMethodsSample
    {
        public void MethodDefinedInClass()
        {
            Console.WriteLine("Method Defined in Class");
        }

        public void SecondMethodDefinedInClass()
        {
            Console.WriteLine("Second Method Defined in Class");
        }
    }


    public static class ExtendedClassInSample {
        public static void ExtMethod(this ExtensionMethodsSample sample)
        {
            Console.WriteLine("In Extended Method");
        }


    }

    public class ExtClass {
        public void Implementation()
        {
            ExtensionMethodsSample sample = new ExtensionMethodsSample();
            sample.ExtMethod();
        }
    }
}
