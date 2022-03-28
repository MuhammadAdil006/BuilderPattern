using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BusinessObjects;
namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            Driver d = new DriverBulder { Name="hassan" ,CabId=34};
            Console.WriteLine(d.Name);
        }
    }
}