using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities
{
    class PracticeClasses
    {
    }
    // Example of an Interface with some properties
    public interface IExcelOpen
    {
        string SomeProperty { get; set; }
        string SomeOtherProperty { get; set; }
    }

    public interface IExcelSheet
    {
        string SheetName(string sheetName);
    }


    public class ExcelSheetImplementation : IExcelSheet
    {
        string ab = "ab";
        public string SheetName(string sheetName)
        {
            return sheetName;
        }

        string IExcelSheet.SheetName(string sheetName)
        {
            return "ab";
        }
    }

    public class ExcelOpenClass : IExcelOpen
    {
        public string SomeProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }        
        public string SomeOtherProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

       
    }

    public interface IExplicitlyImplementingMembersEx
    {
        void MethodA();
        void MethodB();
    }

    public class SomeClass : IExplicitlyImplementingMembersEx
    {
        public void MethodA()
        {
            IExplicitlyImplementingMembersEx exMember = (IExplicitlyImplementingMembersEx)this;
            exMember.MethodB();
        }

        void IExplicitlyImplementingMembersEx.MethodB()
        {
            throw new NotImplementedException();
        }
    }

    public class SomeClassImplementation
    {
        public void MethodA() { 
        SomeClass someclass = new SomeClass();
            someclass.MethodA();
                }
    }

    public class StaticImplementationInSameClassDemo {
        static int staticVariable = 10;
        int nonStaticVariable = 100;
        void MethodCallingStaticMemberfromNonStaticMethod()
        {
            Console.WriteLine("The number to be printed : " + staticVariable);
            StaticImplementationInSameClassDemo.StaticMethod();
            Console.WriteLine("Some Message to be printed : " + nonStaticVariable.ToString());
        }

        static void StaticMethod()
        {
            // Console.WriteLine("Some Message to be printed : " + nonStaticVariable.ToString());

            Console.WriteLine("The number to be printed : " + staticVariable.ToString());
        }

    }
    /// <summary>
    /// Some class for Interface implementation
    /// </summary>
    /// <remarks>
    /// Sample for Interface implementation and using properties and methods
    /// </remarks>
    public class SomeClassForInterfaceExatraction : ISomeClassForInterfaceExatraction
    {
        public int MyProperty { get; set; }
        public void SomeMethod1()
        { }

        public string SomeMethod2()
        { return "ab"; }
    }

}
