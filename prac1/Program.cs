using System;


namespace prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.cla();
            Console.Read();
        }
    }
    public class Class1
    {
        //the purpose of this class is too make calling
        //of the rectangle class recursivly
            public void cla()
            {
                Console.WriteLine("enter width");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter lenght");
                double num2 = Convert.ToDouble(Console.ReadLine());
                rectangle r = new rectangle(num2, num1);
                double are = r.area();
                Console.WriteLine("area of rectangle is = {0} \nwith width = {1} with lenght = {2}"
                    ,are,r.Width,r.Lenght);                     
            }        
    }
    class rectangle
    {
        private double lenght = 1;// variable is encapsulated so only local class members can access
        private double width = 1; //
        public rectangle(double l, double w)// constructor that takes two variables
        {
            if (l>0)//this variable checks if the number is bigger than zero Note 0.1 or 0.0001 accepted
               Lenght = l;
            else
            {//else if the variable is less than zero the function calls Class1 
                Console.WriteLine("please enter a number above 0");
                Class1 c = new Class1();//creates an instance of Class1
                c.cla();//calls the method which in turn calls the rectangle class with our 
                //specfic constructor
            }
            if (w>0)
               Width = w;
            else
            {
                Console.WriteLine("please enter a number above 0");
                Class1 c = new Class1();
                c.cla();
            }
        }
        public double Lenght
        {
            get
            {//calls get of the property inorder to returm/get the value
                return lenght;
            }
            set
            {//calls set that assigns a value to the variable
                if (lenght > 0)
                {
                    lenght = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (width > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("please enter a number above 0");
                    Class1 c = new Class1();
                    c.cla();
                }
            }
        }
        public double area()
        {
            return lenght * width;
        }
    }
}
