using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramManager
    {
        public List<IndividualFitnessProgram> FitnessProgramList = new List<IndividualFitnessProgram>();

        public void CreateFitnessProgram(IndividualFitnessProgram fitnessProgram)
        {
            //decimal price = ValidatePrice(fitnessProgram.GetPrice());
            //fitnessProgram.SetPrice(price.ToString());
            FitnessProgramList.Add(fitnessProgram);
            Console.WriteLine("Program Added successfully");
        }
        public void ReadFitnessPrograms()
        {
            foreach (var item in FitnessProgramList)
            {
                item.ToString();//or the other code
                Console.WriteLine($"fitnessProgramId :{item.GetFitnessProgramId()} \ntitle :{item.GetTitle()}\nduration :{item.GetDuration()} \nprice :{item.GetPrice()} \nSubscriptionType :{item.SubscriptionType} \n NeedPersonalTrainer :{item.NeedPersonalTrainer}");
            }
        }
        public void UpdateFitnessProgram(IndividualFitnessProgram fitnessProgram)
        {
            var UpdateProgram = FitnessProgramList.SingleOrDefault(i => i.GetFitnessProgramId() == fitnessProgram.GetFitnessProgramId());
            if (UpdateProgram == null)
            {
                Console.WriteLine("Program not founded");
            }
            else
            {
                FitnessProgramList.Remove(UpdateProgram);
                FitnessProgramList.Add(fitnessProgram);
                Console.WriteLine("Program Udated Successfully");
            }
        }
        public void DeleteFitnessProgram(string id)
        {
            var DeleteProgram = FitnessProgramList.SingleOrDefault(i => i.GetFitnessProgramId() == id);
            if (DeleteProgram == null)
            {
                Console.WriteLine("Program not founded");
            }
            else
            {
                FitnessProgramList.Remove(DeleteProgram);
                Console.WriteLine("Program deleted Successfully");
            }
        }
        public decimal ValidatePrice(string price)
        {
            decimal priceDecimal = decimal.Parse(price);
            while (true)
            {
                if (priceDecimal > 0)
                {
                    return priceDecimal;
                }
                else
                {
                    Console.WriteLine("Invalid price\n Please try again");
                    priceDecimal = decimal.Parse(Console.ReadLine());
                }
            }
        }
    }
}
