using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intuinless1
{
    class Person
    {
        private string _FirstName;

        private string _LastName;

        private int _Age;

        public string FirstName 
        {
            get { return _FirstName; }

            set {  _FirstName = value;  }
        }

        public string LastName 

        {
            get { return _LastName; }
            set { _LastName = value; }
       }

        public int Age
        {
            get { return _Age; }

            set {
                if (value >= 0 )
                {
                    _Age = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public  Person(string firstName , string lastName , int age )
        {
            FirstName = firstName;

            LastName = lastName;

            Age = age;
        }

        public override string ToString()
        {
            return ("Name is: " + FirstName + " " + "\nLastName is: " + LastName + " " + "\nAge is:" + " " + Age);
        }

        public void WriteHello(string someName)
        {
            Console.WriteLine("Hello" + " " + someName);
        }

        public void WriteEtcInfo()
        {
            Console.WriteLine("These info about ur new patient: ");
        }
    }

    public class Program
    {

      static void Main()
        {
          Person person1 = new Person("Petr","loxov",18);
          person1.WriteHello("Jo");
          person1.WriteEtcInfo();
          
          Console.WriteLine(person1);
        }
    }
}
