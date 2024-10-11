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
        public List<FitnessProgram> FitnessProgramList=new List<FitnessProgram>();

        public void CreateFitnessProgram (FitnessProgram fitnessProgram)
        {
            FitnessProgramList.Add(fitnessProgram);
            Console.WriteLine("Program Added successfully");
        }
        public void ReadFitnessPrograms()
        {
            foreach (var item in FitnessProgramList)
            {
                item.ToString();//or the other code
                Console.WriteLine($"fitnessProgramId :{item.GetFitnessProgramId()} \ntitle :{item.GetTitle()}\nduration :{item.GetDuration()} \nprice :{item.GetPrice()}");
            }
        }
        public void UpdateFitnessProgram(FitnessProgram fitnessProgram)
        {
            var UpdateProgram=FitnessProgramList.SingleOrDefault(i=>i.GetFitnessProgramId()== fitnessProgram.GetFitnessProgramId());
            if (UpdateProgram ==null)
            {
                Console.WriteLine("Program not founded");
            }
            else
            {
                FitnessProgramList.Remove(UpdateProgram);
                FitnessProgramList.Add(fitnessProgram );
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

    }
}
