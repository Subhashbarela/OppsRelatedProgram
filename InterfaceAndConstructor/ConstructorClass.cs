using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndConstructor
{
    public class ConstructorClass
    {
        public int s_id;
        public string s_name;
        public ConstructorClass()
        {
            Console.WriteLine("Default Constructor");
        }
        public ConstructorClass(int s_id, string s_name)
        {
            this.s_id = s_id;
            this.s_name = s_name;
            Console.WriteLine("Id : " + s_id);
            Console.WriteLine("Name : " + s_name);

        }
    }
    public class CopyConstructorP
    {
        //copy constructor is use to copy one object to anothe object
        public int c_id;
        public string c_name;
        public CopyConstructorP(int age, string name)
        {
            this.c_id = age;
            this.c_name = name;
            Console.WriteLine("Copy Constructor Invoke...!");
        }
        public void GetData()
        {           
            Console.WriteLine("the College Id is: " + c_id);
            Console.WriteLine("the College Name is: " + c_name);
        }
        // this is copy constructor take parameter as current class type
        public CopyConstructorP(CopyConstructorP e)
        {
            this.c_id = e.c_id;
            this.c_name = e.c_name;
        }
    }
    //static constructor is use to initialize static variable of class and to perform a particular action only once.
    //it called only once,no matter how many object we create.
    public class StaticConstructor  //:  PrivateConstructor
    {
        public static string PersonName;
        public static int PersonAge;

        // in which we cannot take any param and does not use any access modifier
        static StaticConstructor()
        {
            PersonName = "subhash";
            PersonAge = 25;
            Console.WriteLine("Static constructor invoke !!");
        }       
        public void GetDetails()
        {

            Console.WriteLine("Person name:" + PersonName);
            Console.WriteLine("Person age:" + PersonAge);

        }

    }
    public class PrivateConstructor
    {
        //it used to give restriction that no anyone create object of this class in case of default constructor
        //it is used when we provide all member as static in a class
        // it give restriction that no anyone inherite this class
       // public string name;
       // public string fname;


        public static int a;
        //  when we create paramiterise constructor then we can create object of this class 
        //public PrivateConstructor(string name, string fname)
        //{
        //    this.name = name;
        //    this.fname = fname;
        //}

        private PrivateConstructor()
        {

        }
        public static int GetData()
        {
            return a += 1;
        }
    }
}
