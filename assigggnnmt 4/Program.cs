using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace assigggnnmt_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Download file");
            Download();
            Console.ReadLine();

        }
        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete ");
            });
        }
    }
}

       