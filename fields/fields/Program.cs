using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fields
{
    class FieldExample
    {
        string name = "Eric";
        public const int myInt = 123;
      //  var birthday = new DateTime(1972, 11, 20);
        readonly decimal dollars;
    //    int length = this.name.Length;
        static int count = 0;
   
    
    public FieldExample(decimal dollars)
    {
        Console.WriteLine(this.dollars);
        Console.WriteLine(name);
        this.dollars = dollars;
        Console.WriteLine(FieldExample.count);
        count = count + 1;
   //     Console.WriteLine(this.count);
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var example = new FieldExample(123.45m);
          //  Console.WriteLine(example.name);
          //  Console.WriteLine(FieldExample.count);
            var another = new FieldExample(456.78m);
            Console.WriteLine(FieldExample.myInt);
            Console.WriteLine(Math.PI);
        }


    }

}
