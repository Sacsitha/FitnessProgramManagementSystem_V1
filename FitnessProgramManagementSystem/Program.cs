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
            //var FitnessProgram1 = new FitnessProgram("FIT_001", "Beginners YOGA ", "3 months ", "10.00 ");
            //Console.WriteLine(FitnessProgram1);
            Menu();
        }

        public static void Menu()
        {

            bool status=true;
            FitnessProgramManager fitnessProgramManager = new FitnessProgramManager();
            while(status)
            {
                Console.WriteLine("FitnessProgram Management System:");
                Console.WriteLine("1. Add a FitnessProgram");
                Console.WriteLine("2. View All FitnessPrograms");
                Console.WriteLine("3. Update a FitnessProgram");
                Console.WriteLine("4. Delete a FitnessProgram");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");
                string option = Console.ReadLine();
                switch (option)
                {

                    case "1":
                        fitnessProgramManager.CreateFitnessProgram(ProgramObject());
                        break;
                    case "2":
                        fitnessProgramManager.ReadFitnessPrograms();
                        break;
                    case "3":
                        fitnessProgramManager.UpdateFitnessProgram(ProgramObject());
                        break;
                    case "4":
                        fitnessProgramManager.DeleteFitnessProgram(GetId());
                        break;
                    case "5":
                        status = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;                       
                }
            }
        }
        public static FitnessProgram ProgramObject()
        {
            Console.WriteLine("fitnessProgramId :");
            string id = Console.ReadLine();
            Console.WriteLine("fitnessProgram Title :");
            string Title = Console.ReadLine();
            Console.WriteLine("fitnessProgram Duration :");
            string Duration = Console.ReadLine();
            Console.WriteLine("fitnessProgram Price :");
            string Price = Console.ReadLine();
            FitnessProgram fitnessProgram=new FitnessProgram(id,Title,Duration, Price);
            return fitnessProgram;
        }
        public static string GetId()
        {
            Console.WriteLine("fitnessProgramId :");
            string id = Console.ReadLine();

            return id;
        }

    }
}
