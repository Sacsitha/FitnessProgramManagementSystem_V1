using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class GroupFitnessProgram:FitnessProgram
    {
        public string Schedule {  get; set; }   
        public string GroupCapacity { get; set; }
        public GroupFitnessProgram() : base()
        {
        }

        public GroupFitnessProgram(string schedule, string groupCapacity, string FitnessProgramId, string Title, string Duration, string Price) : base(FitnessProgramId, Title, Duration, Price)
        {
            Schedule = schedule;
            GroupCapacity = groupCapacity;
        }
        public void DisplayGroupFitnessProgramInfo()
        {
            Console.WriteLine($"fitnessProgramId :{GetFitnessProgramId()} \ntitle :{GetTitle()}\nduration :{GetDuration()} \nprice :{GetPrice()}\n Schedule :{Schedule} \n GroupCapacity :{GroupCapacity}");
        }
    }
 
}
