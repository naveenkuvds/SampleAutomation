using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities.OOP_Practice
{
    public class EncapsulationGetterSetterSamplePerson
    {
        private string firstName;
        public string FirstName {
            get {
                return firstName;
            }
            set
            {
                if (value == null)
                    firstName = "Default";
            }
                 }

        public string lastName{ get; set; }
    }
}
