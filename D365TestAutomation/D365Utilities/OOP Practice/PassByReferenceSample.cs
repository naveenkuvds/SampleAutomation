using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
///     
/// </summary>
namespace D365Utilities.OOP_Practice
{
    class PassByReferenceSample
    {
        public static void Change(string str)
        {
            str = "Changed";
        }

        public static void ChangeByRef(ref string str)
        {
            str = "Changed";
        }

        public PassByReferenceSample()
        {
            string str = "In main method string";
            Console.WriteLine(str);
            Change(str);
            Console.WriteLine(str);
            ChangeByRef(ref str);
            Console.WriteLine(str);
        }
    }
}
