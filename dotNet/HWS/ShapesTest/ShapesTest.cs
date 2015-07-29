using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ShapesTest {
    class ShapesTest {
        static void Main(string[] args) {
            Square x = new Square(5);
            Circle c = new Circle(3.5);
            Triangle t = new Triangle(3, 4, 5);
            Rectangle r = new Rectangle(5, 2.5);

            //make list
            List<IShape> shapes = new List<IShape>();
            shapes.Add(x);
            shapes.Add(c);
            shapes.Add(t);
            shapes.Add(r);

            //print out
            foreach (IShape shape in shapes) {

                Console.WriteLine(shape);

            }
            Console.ReadLine();
        }
    }
}
