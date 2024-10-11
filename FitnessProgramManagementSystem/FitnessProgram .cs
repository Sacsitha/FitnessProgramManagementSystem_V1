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
        public static int TotalFitnessPrograms { get; set; }

        public FitnessProgram(string FitnessProgramId, string Title, string Duration, string Price)
        {
            fitnessProgramId = FitnessProgramId;
            title = Title;
            duration = Duration;
            price = Price;
            TotalFitnessPrograms++;
        }
        

        public FitnessProgram()
        {
            TotalFitnessPrograms++;
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
        public string SetPrice(string price) => this.price = price;
        public override string ToString()
        {
            return $"fitnessProgramId :{fitnessProgramId} \ntitle :{title}\nduration :{duration} \nprice :{price}";
        }
        public virtual string DisplayFitnessProgramInfo()
        {
            return $"fitnessProgramId :{fitnessProgramId} \ntitle :{title}\nduration :{duration} \nprice :{price}";
        }
    }

}
