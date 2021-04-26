using System.IO;
using System;

class C3
{
    public static void sum(double a, double b)
    {
        Console.WriteLine("Sum = " +(a+b));
    
    }
    
    public static void Main()
    {
        
        C3.sum(1.5,2.5);
    }
}

----------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Day_3
{
    class Class2
    {
        void sum()
        {
            Console.WriteLine("Iam empty");
        }
        void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void sum(float a, float b, float c)
        {
            Console.WriteLine(a + b + c);
        }
        void sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main()
        {
            Class2 program1 = new Class2();
            Console.WriteLine("Enter a and b:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            program1.sum(float.Parse(a.ToString()), float.Parse(b.ToString()), float.Parse(c.ToString()));
            program1.sum(a.ToString(), b.ToString());
        }
    }
}


-------------------------------------------------------------------------------------------------------------


using System.IO;
using System;

class C3
{
    int a;
    int b;
    
    C3(int _a, int _b)
    {
        a= _a;
        b= _b;
    }
    
    public static C3 operator*(C3 _obj1, C3 _obj2)
    {
        C3 _obj3= new C3(0,0);
        _obj3.a = _obj1.a * _obj2.a;
        _obj3.b = _obj1.b * _obj2.b;
        return _obj3;
    }
    
    public static void Showvalues(C3 _obj)
    {
        Console.WriteLine("a = "+_obj.a);
        Console.WriteLine("b = "+_obj.b);
    }
    
    public static void Main()
    {
        
        C3 Obj1 = new C3(1,2);
        C3 Obj2 = new C3(1,2);
        C3 Obj3 = new C3(0,0);
        Obj3 = Obj1 * Obj2;
        C3.Showvalues(Obj3);
        Console.ReadLine();
    }
}


---------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    class Shape
    {
        //private members----Abstraction is implemeted here---Data hiding
        double _width;
        double _length;
        //Default Constructor
        public Shape()
        {
            //Default values
            Width = Length = 0.0;
        }
        //Parametrised constructor
        public Shape(double w,double l)
        {
            Width = w;
            Length = l;
        }
        //For Square
        public Shape(double y)
        {
            Width = Length = y;
        }
        //Properties --properties
        public double Width
        {
            get { return _width; }
            set
            {
                _width = value < 0 ? -value:value;
            }
        }
        public double Length
        {
            get { return _length; }
            set
            {
                _length = value < 0 ? -value : value;
            }
        }
        public void DisplayValues()
        {
            Console.WriteLine("Width and Length are "+Width+" and "+Length);
        }
    }
    class Rectange:Shape
    {
        string Style;
        public Rectange()
        {
            Style = "";
        }
        public Rectange(String s,double w,double l):base(w,l)
        {
            Style = s;
        }
        public Rectange(double y):base(y)
        {
            Style = "square";
        }
        public double Area()
        {
            return Width * Length;
        }
        public void DisplayStyle()
        {
            Console.WriteLine("Rectangle is "+Style);
        }
    }
    class ColorRectange:Rectange
    {
        string rcolor;
        public ColorRectange(string c,string s,double w,double l):base(s,w,l)// This base keyword will
            //Rectangle class constructor
        {
            rcolor = c;
        }
        public void DisplayColor()
        {
            Console.WriteLine("Color is "+rcolor);
        }
    }
    class Client
    {
        static void Main()
        {
            ColorRectange r1 = new ColorRectange("blue","Rectangle",2.0,3.0);
            ColorRectange r2 = new ColorRectange("black", "Square", 2.0, 2.0);
            Console.WriteLine("Details of r1: ");
            r1.DisplayStyle();
            r1.DisplayValues();
            r1.DisplayColor();
            Console.WriteLine("Area is : "+r1.Area());

 

            Console.WriteLine("------------------------------------------------------------------");

 

            Console.WriteLine("Details of r2: ");
            r2.DisplayStyle();
            r2.DisplayValues();
            r2.DisplayColor();
            Console.WriteLine("Area is : " + r2.Area());
           
            Console.ReadLine();
        }
    }
}
-----------------------------------------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    interface I1
    {
        void myMethod();
    }
    interface I2
    {
        void myMethod();
    }
    class MultipleInhertance:I1,I2
    {
        void I1.myMethod()
        {
            Console.WriteLine("Hello I am Interface-1 Method");
        }
        void I2.myMethod()
        {
            Console.WriteLine("Hello I am Interface-2 Method");
        }
    }
    public class Client
    {
        public static void Main()
        {
            MultipleInhertance Obj1 = new MultipleInhertance();

 

            I1 Interface1 = Obj1;
            Interface1.myMethod();

 

            //
            I2 Interface2 = Obj1;
            Interface2.myMethod();

 

            Console.ReadLine();
        }
       
    }
}

------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    //static keyword
    //by default thease are selead clasess--cannot inherit and cannot create a object
    static class Class12
    {
        static Class12()
        {
            Console.WriteLine("Hi i am constructor");
        }
        public static string Topic = "Static Class";
        public static void sum()
        {
            Console.WriteLine("Hi ! i am a static function");
        }
    }
    class Client
    {
        public static void Main()
        {
             Class12.sum();
            //Console.WriteLine(Class12.Topic);
            Console.ReadLine();
           
        }
    }
}


------------------------------------------------------------------------------------------



using System.IO;
using System;

class Program
{
    static void Main()
    {
        string s = "It is a bad colour";
        Console.WriteLine("String: " +s);
        string t= "is a";
        Console.WriteLine("Substring: " +t);
        
        if(s.Contains(t))
        {
            Console.WriteLine("Substring " +t+ " is present");
        }
        
        Console.ReadLine();
    }
}


---------------------------------------------------------------------------------------


using System.IO;
using System;

class Program
{
    public static void Main()
	{
	    string str1 ="My name is Simanta Mukherjee";
        char[] arr1;
        int l,i;
        l=0;
        char ch;
        
       
       l=str1.Length;
       arr1 = str1.ToCharArray(0, l);

        Console.WriteLine("After conversion, the string is : ");
        for(i=0; i < l; i++)
         {
          ch=arr1[i];
           if (Char.IsLower(ch))
              Console.Write(Char.ToUpper(ch));
              else
              Console.Write(Char.ToLower(ch));
        }
    Console.ReadLine();    
   }
}


----------------------------------------------------------------------------------------------


