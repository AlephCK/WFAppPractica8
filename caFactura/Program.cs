using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFactura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            Console.ReadKey();

            var p = new Process();
            string filename = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, args[0] + ".jpg");
            p.StartInfo = new ProcessStartInfo(filename)
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
