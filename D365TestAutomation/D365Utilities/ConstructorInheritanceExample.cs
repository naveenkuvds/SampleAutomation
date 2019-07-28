using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities
{

    public class SampleClass
    {
        public void SampleMethod()
        {
            Console.WriteLine("In Sample Method");
        }

        public SampleClass()
        { }
    }
    /// <summary>
    /// This is an example of using a class constructor using this keywork . <see cref="ConstructorInheritanceExample"/> 
    /// </summary>
    public class ConstructorInheritanceExample
    {
        public ConstructorInheritanceExample() : this(new SampleClass())
        { }

        /// <summary>
        /// <paramref name="sc"/>
        /// </summary>
        /// <param name="sc"></param>
        public ConstructorInheritanceExample(SampleClass sc)
        {
            sc.SampleMethod();
        }
    }
}
