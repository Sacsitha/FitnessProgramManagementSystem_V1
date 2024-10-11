using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {

        private string fitnessProgramId { get; set; }
        private string title { get; set; }
        private string duration { get; set; }
        private string price { get; set; }

        public FitnessProgram(string FitnessProgramId, string Title, string Duration, string Price)
        {
            fitnessProgramId = FitnessProgramId;
            title = Title;
            duration = Duration;
            price = Price;
        }
        

        public FitnessProgram()
        {
        }

        public string GetFitnessProgramId()
        {
            return fitnessProgramId;
        }
        public string GetTitle()
        {
            return title;
        }
        public string GetDuration()
        {
            return duration;
        }
        public string GetPrice()
        {
            return price;
        }
        public override string ToString()
        {
            return $"fitnessProgramId :{fitnessProgramId} \ntitle :{title}\nduration :{duration} \nprice :{price}";
        }
    }

}
