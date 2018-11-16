using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingProgramUI
    {
        OutingRepository _outingRepo = new OutingRepository();
        Outing newOuting = new Outing();
        
        public void RunMenu()
        {
            Outing shinedown = new Outing(OutingType.Concert, 20, "12/12/2012", 30m, 600m);
            _outingRepo.AddOutingList(shinedown);
            Outing garthBrooks = new Outing(OutingType.Concert, 50, "11/11/2011", 40m, 800m);
            _outingRepo.AddOutingList(garthBrooks);

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Enter information:" +
                    "\n1. Add outing to list" +
                    "\n2. See all outing list" +
                    "\n3. See cost for all outings" +
                    "\n4. See cost by outing type"+
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:     //Create new content
                        CreateOutingList();
                        break;

                    case 2:
                        PrintOutingList();
                        break; //Show current list

                    case 3:
                        Console.WriteLine($"The Total Cost is {_outingRepo.CalculateTotalCost()}"); 
                        break; //Show current list

                    case 4:
                        SeeTotalCostByType();
                        break; //Show current list

                    case 5:     //Exit
                        isRunning = false;
                        Console.WriteLine("Thank you come again");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void CreateOutingList()
        {
            Outing newItem = new Outing();
            Console.WriteLine("Enter information:" +
                    "\n1. Golf" +
                    "\n2. Bowling" +
                    "\n3. Amusement Park" +
                    "\n4. Concert" +
                    "\n5. Other");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    newItem.EventType = OutingType.Golf;
                    break;
                case 2:
                    newItem.EventType = OutingType.Bowling;
                    break;
                case 3:
                    newItem.EventType = OutingType.AmusementPark;
                    break;
                case 4:
                    newItem.EventType = OutingType.Concert;
                    break;
                case 5:
                    newItem.EventType = OutingType.Other;
                    break;
                default:
                    Console.WriteLine("Invalid response.");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("\nWhat is total number of people?");
            newItem.NumPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Date?");
            newItem.Date = Console.ReadLine();

            Console.WriteLine("\nWhat is the cost for event?");
            newItem.CostPerPerson = decimal.Parse(Console.ReadLine());
            newItem.TotalEventCost = newItem.NumPeople * newItem.CostPerPerson;
            _outingRepo.AddOutingList(newItem);
        }
        public void PrintOutingList()
        {
            List<Outing> outingList = _outingRepo.GetOutingList();
            Console.WriteLine("Date\t EventType\t NumPeople\t CostPerPerson\t TotalEventCost");
            foreach (Outing outing in outingList)
            {
                Console.WriteLine($"{outing.Date}\t{outing.EventType}\t{outing.NumPeople}\t{outing.CostPerPerson:c}\t{outing.TotalEventCost:c}");
            }
            Console.ReadLine();

        }
        public void SeeTotalCostByType()
        {
            decimal typeTotal = 0;
            Console.WriteLine("Enter information:" +
                "\n1. Golf" +
                "\n2. Bowling" +
                "\n3. Amusement Park" +
                "\n4. Concert" +
                "\n5. Other");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    typeTotal = _outingRepo.CalculateTotalCostByType(OutingType.Golf);
                    break;
                case 2:
                    typeTotal = _outingRepo.CalculateTotalCostByType(OutingType.Bowling);
                    break;
                case 3:
                    typeTotal = _outingRepo.CalculateTotalCostByType(OutingType.AmusementPark);
                    break;
                case 4:
                    typeTotal = _outingRepo.CalculateTotalCostByType(OutingType.Concert);
                    break;
                case 5:
                    typeTotal = _outingRepo.CalculateTotalCostByType(OutingType.Other);
                    break;
                default:
                    Console.WriteLine("Invalid response.");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine($"This is total cost for event type{typeTotal}");
            Console.ReadLine();
        }

    }
}
