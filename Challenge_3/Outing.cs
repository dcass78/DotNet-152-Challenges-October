using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum OutingType { Golf = 1, Bowling, AmusementPark, Concert, Other }
    public class Outing
    {
        public OutingType EventType { get; set; }
        public int NumPeople { get; set; }
        public string Date { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalEventCost { get; set; }

        public Outing(OutingType eventType, int numPeople, string date, decimal costPerPerson, decimal totalEventCost)
        {
            EventType = eventType;
            NumPeople = numPeople;
            Date = date;
            CostPerPerson = costPerPerson;
            TotalEventCost = totalEventCost;
        }
        public Outing()
        {

        }









    }
}
