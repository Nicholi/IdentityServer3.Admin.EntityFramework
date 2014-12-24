using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Admin.EntityFramework.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://+:9010"))
            {
                Console.WriteLine("Server is running. Press ENTER to stop.");
                Console.ReadLine();
            }
        }
    }
}
