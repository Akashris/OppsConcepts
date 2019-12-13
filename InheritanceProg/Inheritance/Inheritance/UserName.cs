using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    public class UserName
    {
        public string Name;
        public void GetName()
        {
            Console.WriteLine("Name: {0}", Name);
        }
    }


    public class Address : UserName
    {
        public string Location;
        public void GetLocation()
        {
            Console.WriteLine("Location: {0}", Location);
        }
    }


    public class UserAge : Address
    {
        public int Age;
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            UserAge obj = new UserAge();
            obj.Name = "Akash Shritharan";
            obj.Location = "Chennai";
            obj.Age = 23;
            obj.GetName();
            obj.GetLocation();
            obj.GetAge();
            Console.ReadLine();
        }
    }
}
