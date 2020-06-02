using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml;
using System.Data.Common;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);

            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
