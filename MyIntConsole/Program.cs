using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBigInteger;
namespace MyIntConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInt mint;
            Int64 numLong;
            Int64 nlong = 123;
            mint = new MyInt("123");
            numLong = mint.toLong();
            Console.WriteLine(string.Format("{0} - {1}"), nlong, numLong);
        }
    }
}
