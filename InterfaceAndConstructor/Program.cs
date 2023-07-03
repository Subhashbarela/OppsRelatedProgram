using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Default and Para Constructor  \n2: CoprConstructor \n3: Static Constructor");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        ConstructorClass c_One = new ConstructorClass();
                        ConstructorClass c_Two = new ConstructorClass(101, "Sagar");
                        break;
                    }
                case 2:
                    {
                        CopyConstructorP obj1 = new CopyConstructorP(1, "Bridgelabs");
                        obj1.GetData();
                        CopyConstructorP obj2 = new CopyConstructorP(obj1);
                        obj2.GetData();
                        break;
                    }
                case 3:
                    {
                        StaticConstructor std=new StaticConstructor();
                        std.GetDetails();
                        break;
                    }
                case 4:
                    {
                        // PrivateConstructor prt=new PrivateConstructor("subhash","barela"); //in case of parameterize constructor
                       //PrivateConstructor prt1 = new PrivateConstructor(); //in case of non parameterize constructor we cannot create obj
                        PrivateConstructor.a = 10;
                       Console.WriteLine(PrivateConstructor.GetData());
                        break;
                    }
                default:
                    Console.WriteLine("Please insert valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
