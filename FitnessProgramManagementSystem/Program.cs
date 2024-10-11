using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FitnessProgram1 = new FitnessProgram("FIT_001", "Beginners YOGA ", "3 months ", "10.00 ");
            Console.WriteLine(FitnessProgram1);
            Console.ReadLine();
        }
    }
}
