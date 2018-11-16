using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuRepository
    {
        public List<MenuItem> _menuItemList = new List<MenuItem>();

        public void AddMenuItemToList(MenuItem list)
        {
            _menuItemList.Add(list);
        }
        public List<MenuItem> GetMenuItemList()
        {
            return _menuItemList;
        }
        public void RemoveItemFromMenu(MenuItem removedItem)
        {
            _menuItemList.Remove(removedItem);
        }




    }
}
