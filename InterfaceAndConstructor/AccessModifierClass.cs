using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndConstructor
{
    public class AccessModifierClass
    {
        public int id =1;
        public int name;
        private string pass="abc@123";
        protected string cource;
        public void ShowInfo()
        {
            Console.WriteLine("Id is : " + id);           
            Console.WriteLine("Name is : " + name);
            Console.WriteLine("Cource is : " + cource);
        }
        protected void PrintPass()
        {
            Console.WriteLine("your password is : "+ pass);
        }
    }
    public class CourseClass: AccessModifierClass
    {
        public void GetCourseName(string course)
        {
            this.cource = course;
            // PrintPass();  //access Passworld method
        }
        public void Show()
        {
            PrintPass();
        }

    }
}
