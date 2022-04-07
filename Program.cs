using System;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            
            Console.WriteLine("Minimum #1: {0}", number.FindingMinimum(3, 1));
            Console.WriteLine("Minimum #2: {0}", number.FindingMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.FindingMaximum(3, 1));
            Console.WriteLine("Maximum #2: {0}", number.FindingMaximum(3, 2, 4));

            Console.Readkey();
        }
    }
}