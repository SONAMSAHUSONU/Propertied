using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertied
{
    class Program
    {
 //propertied:- propertied provied public get and set method, throuhgh properties we can access and read the value of private field. 
 //properties:-Properties are the special type of class members that provides a flexible mechanism to read, write,
 //or compute the value of a private field.
 //Properties can be used as if they are public data members, but they are actually special methods called accessors. 
 //This enables data to be accessed easily and helps to promote the flexibility and safety of methods. 
 //Encapsulation and hiding of information can also be achieved using properties.
 //It uses pre-defined methods which are “get” and “set” methods which help to access and modify the properties.
 // Accessors: The block of “set” and “get” is known as “Accessors”. It is very essential to restrict the accessibility of property.There are two type of accessors i.e.get accessors and set accessors.There are different types of properties based on the “get” and “set” accessors:


               //Read and Write Properties: When property contains both get and set methods.
//Read-Only Properties: When property contains only get method.
//Write Only Properties: When property contains only set method.
//Auto Implemented Properties: When there is no additional logic in the property accessors

        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Name = "Sonam";// here we can set
            Console.WriteLine(c1.Name);// here we can get the value
            Console.ReadLine();
        }
    }
    public class Customer
    {
        private string name;//field
        private int customerid;

        public string Name//properties:-are usefull the for set or get the value of the private variable with the help of propeties as we can't( compuet)get the private variable from outsied of cLASS    as we can't get the of outsied the class
        {
            get { return name; }
            set { name = value; }
        }
    }
    public class Order
    {
        public int OrderDate { get; }
        public int OrderId { get; set; }// it will provied the securites of the data 
        public int OrderProduct { get; set; }//properties
    }
}
