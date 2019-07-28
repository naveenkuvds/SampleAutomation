using System;
using System.Collections.Generic;
using System.Text;

namespace ProCSharp7Practice.Encapsulation
{
    class CarSample
    {
        /// <summary>
        /// class members are private by default and needs to made public in order to access them from other classes
        /// Also class members define the state of the class instance.
        /// Field data should seldom be defined as public, to preserve the integrity of the class state data, it is far better design to define data as private.
        /// </summary>
        public string carName;
        public int currentSpeed;

        /// <summary>
        /// Class members define the behavior of the class. 
        /// </summary>
        public void PrintState() => Console.WriteLine("Current Speed of the {0} car is {1} km/hr.",carName,currentSpeed);
        public void SpeedUp(int delta) => currentSpeed += delta;
    }

    public class SampleDefaultConstructor
    {
        public SampleDefaultConstructor()
        {

        }
    }

    public class ThisKeywordSample
    {
        private string name;

        public ThisKeywordSample(string name)
        {
            this.name = name;
        }
    }

    public class WithoutConstructorChainingMotoCycleSample
    {
        public string driverName;
        public int driverIntensity;

        public WithoutConstructorChainingMotoCycleSample()
        {

        }

        //Redundant code
        public WithoutConstructorChainingMotoCycleSample(int intensity)
        {
            if (intensity>10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        public WithoutConstructorChainingMotoCycleSample(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }

    public class WithConstructorChainingMotoCycleSample
    {
        public string driverName;
        public int driverIntensity;

        public WithConstructorChainingMotoCycleSample()
        {
            Console.WriteLine("In default ctor");
        }

        public WithConstructorChainingMotoCycleSample(int intensity) : this(intensity, "") {
            Console.WriteLine("In int ctor");
        }

        public WithConstructorChainingMotoCycleSample(string name) : this(0, name) { Console.WriteLine("In string ctor"); }

        public WithConstructorChainingMotoCycleSample(int intensity,string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
            Console.WriteLine("In Master ctor");
        }
        
    }

    public class SampleClassWithOptionalArgs
    {
        public string driverName;
        public int driverIntensity;
        public SampleClassWithOptionalArgs(int driverIntensity=0,string driverName="")
        {
            if (driverIntensity>10)
            {
               driverIntensity=10;
            }
            this.driverIntensity = driverIntensity;
            this.driverName = driverName;
        }
    }

    public class SampleStaticDataField
    {
        //Instance-Level data
        public double currentBalance;

        //Class level data
        public static double simpleIntRate = 0.4;

        public void SavingsAccount(double currentBalance)
        {
            this.currentBalance = currentBalance;
        }
    }

    public class SampleGetterSetterMethods
    {
        private string MyProperty { get; set; }
    }
}
