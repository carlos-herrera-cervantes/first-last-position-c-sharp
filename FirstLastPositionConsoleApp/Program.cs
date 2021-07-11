using System;
using FirstLastPositionDomain.Models;

namespace FirstLastPositionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new [] { 5, 7, 7, 8, 8, 10 };
            var target = 7;
            var result = SuperArray.SearchRange(nums, target);

            result.ForEach(item => Console.Write($"{item}, "));
        }
    }
}
