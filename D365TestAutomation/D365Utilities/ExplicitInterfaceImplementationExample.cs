using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities
{
    public interface ISomeInterface
    {
        void MethodA();
        void MethodB();
    }

    class ExplicitInterfaceImplementationExample : ISomeInterface
    {
        public void MethodA()
        {
            ISomeInterface me = (ISomeInterface)this;
            me.MethodB();
        }

        void ISomeInterface.MethodB()
        {
            throw new NotImplementedException();
        }

    }

    public class SomeInterfaceImplementationClass
    {
        public void MethodFirst()
        {
            ExplicitInterfaceImplementationExample eiis = new ExplicitInterfaceImplementationExample();
            eiis.MethodA();

            ISomeInterface isi = new ExplicitInterfaceImplementationExample();
            isi.MethodA();
            isi.MethodB();

        }
    }
}
