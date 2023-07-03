using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndConstructor
{
    public interface Shape
    {

        void draw();
    }
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class Triangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("drawing Triangle...");
        }
    }

}
