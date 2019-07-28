using System;
using System.Collections.Generic;
using System.Text;
using D365Utilities;
using D365Utilities.OOP_Practice;

namespace ProCSharp7Practice.Encapsulation
{
    
        public static class ExtendedMethodClass
        {
#pragma warning disable IDE0060 // Remove unused parameter
        public static void MethodExtendedInClass(this ExtensionMethodsSample classInstance)

        {
            Console.WriteLine("in Extended Method");
            }
        }
    
}
