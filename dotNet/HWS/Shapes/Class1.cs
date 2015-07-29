using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    
    public interface IShape//basic shape
    {
        double Area { get;}
        double Perimeter { get;}
        int Sides { get; }
        
        string ToString();
    }
    // square class
    public class Square : Rectangle {
        
        
        public Square(double side):base(side,side) {
            
        }

        public override string ToString() {
            return String.Format("Shape = square, sides: {0} each side = {1} perimeter = {2} and area = {3}",this.Sides,this.length, this.Perimeter,this.Area);
        }
   
    }

    //Circle class 
    public class Circle : IShape {
       
        public double Circumference { get;}
        public double Radius { get;}
        public int Sides { get;}

        public double Perimeter { get; }

        public double Area { get; }


        public Circle(double radius) {
            this.Radius = radius;
            this.Circumference = findCircumference(this.Radius);
            this.Area = findArea(radius);
            this.Sides = 1;
        }

         private double findCircumference(double radius) {
            return (Math.PI * 2 * radius);
        }

        private double findArea(double radius) {
            return (Math.PI * (radius * radius));
        }

        public override string ToString() {
            return String.Format("shape = circle, sides: {0} ,radius = {1} , circumference = {2} and area = {3}", this.Sides, this.Radius, this.Circumference, this.Area);
        }

        public double getArea() {
            return this.Area;
        }

        public double getPerimeter() {
            return this.Perimeter;
        }
    }
    // Triangle class with constr. and get methods
    public class Triangle : IShape {
        
        public int Sides { get;}

        public double SideA { get ;}

        public double SideB { get;}

        public double SideC { get;}

        public double Perimeter { get;}

        public double Area { get; }

       

        public Triangle(double sideA, double sideB, double sideC) {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Perimeter = (sideA + sideB + sideC);
            this.Area = (findArea(this.SideA, this.SideB, this.SideC));
            this.Sides = 3;
        }

        public double findArea(double a, double b, double c) {
            double s = ((a + b + c) / 2);
            
            double temp = (s * (s - a) * (s - b) * (s - c));
            
            return (Math.Sqrt(temp));
        }

        public override string ToString() {
            return String.Format("shape = triangle, sides: {0}, side a = {1}, side b = {2}, side c = {3}, perimeter = {4} and area = {5}", this.Sides, this.SideA,this.SideB,this.SideC,this.Perimeter, this.Area);
        }

        public double getArea() {
            return this.Area;
        }

        public double getPerimeter() {
            return this.Perimeter;
        }
    }

    //Rectangle class
    public class Rectangle:IShape{

        public double length{ get;}
        public double height { get;}

        public double Perimeter { get; }

        public double Area { get; }

        public int Sides { get; }

       
        public Rectangle(double height, double length) {
            this.length = length;
            this.height = height;
            this.Area = this.length * this.height;
            this.Perimeter = (2 * this.length) + (2 * this.height);
            this.Sides = 4;
        }

        public override string ToString() {
            return String.Format("shape = rectangle, sides: {0}, length = {1}, height = {2},perimeter = {3} and area = {4}", this.Sides, this.length, this.height,this.Perimeter, this.Area);
        }

        public double getArea() {
            return this.Area;
        }

        public double getPerimeter() {
            return this.Perimeter;
        }
    }

    
}
