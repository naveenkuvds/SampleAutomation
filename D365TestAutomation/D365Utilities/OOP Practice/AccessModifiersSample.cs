using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities.OOP_Practice
{
    class AccessModifiersSample
    {
        /// <summary>
        /// A default access modifier of a field in a class is always private and accessible only from within the class
        /// </summary>
        int defaultVariableAccessModifier = 10;

        /// <summary>
        /// fields having internal as access modifiers can be accessed only from project or from that assembly.
        /// </summary>
        internal int internalVariableAccessModifier;

        /// <summary>
        /// fields with protected access modifier can be accessed if ony derived.
        /// </summary>
        protected int protectedVariableAccessModifier;

        /// <summary>
        /// Either internal or protected
        /// </summary>
        protected internal int protectedInternalVariableAccessModifier;


    }
}
