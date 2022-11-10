using System;
namespace VisitorDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            school.doHealthCheckup();

            Console.Read();
        }
    }
}