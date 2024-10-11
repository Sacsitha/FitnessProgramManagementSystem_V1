using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class IndividualFitnessProgram:FitnessProgram
    {


        public string SubscriptionType { get; set; }
        public string NeedPersonalTrainer{ get; set; }
        public IndividualFitnessProgram():base()
        {
        }

        public IndividualFitnessProgram(string subscriptionType,string needPersonalTrainer, string FitnessProgramId, string Title, string Duration, string Price) : base(FitnessProgramId, Title, Duration, Price)
        {
            SubscriptionType = subscriptionType;
            NeedPersonalTrainer = needPersonalTrainer;
        }
        public void DisplayIndividualFitnessProgramInfo()
        {
            Console.WriteLine($"fitnessProgramId :{GetFitnessProgramId()} \ntitle :{GetTitle()}\nduration :{GetDuration()} \nprice :{GetPrice()}\n SubscriptionType :{SubscriptionType} \n NeedPersonalTrainer :{NeedPersonalTrainer}");
        }
    }
}
