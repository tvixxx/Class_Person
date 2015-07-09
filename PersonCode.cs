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

        public string FirstName 

        {
            get { return _FirstName; }

            set { value = _FirstName; }
        }

        public string LastName

        {
            get { return _LastName; }
            set { value = _LastName; }

        }
        public  Person(string firstName , string lastName )
        {
            FirstName = firstName;

            LastName = lastName;
        }

        //public void ShowFullInfoAboutThisPerson()
       // {
         //   Console.WriteLine("Name is: " + FirstName + " " + "LastName is: " + LastName);
       // }

        public override string ToString()
        {
            return ("Name is: " + FirstName + " " + "LastName is: " + LastName);
        }
    }

    public class Program
    {

      static void Main()
        {
          Person person1 = new Person("Petr","loxov");
         
          
          

          //person1.ShowFullInfoAboutThisPerson();
            
            
          Console.WriteLine(person1);
        }
    }
}
