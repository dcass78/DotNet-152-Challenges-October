using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
         List<Outing> _outingList = new List<Outing>();

        public void AddOutingList(Outing list)
        {
            _outingList.Add(list);
        }
        public  List<Outing> GetOutingList()
        {
            return _outingList;
        }
        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (Outing o in _outingList)
            {
                total += o.TotalEventCost;
            }
            return total;
        }
        public decimal CalculateTotalCostByType(OutingType type)
        {
            decimal typeTotal = 0;
            foreach (Outing t in _outingList)
            {
                if (type == t.EventType)
                {
                    typeTotal += t.TotalEventCost;
                }
                
            }
            return typeTotal;
        }





    }
}
