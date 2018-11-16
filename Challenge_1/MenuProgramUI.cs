using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuProgramUI
    {
        MenuRepository _itemRepo = new MenuRepository();
        List<MenuItem> menuItems;
        public void Run()
        {
            menuItems = _itemRepo.GetMenuItemList();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. Create new menu item" +
                    "\n2. Remove menu item" +
                    "\n3. See current list" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:     //Create new content
                        List<string> MenuItem = new List<string>();
                        CreateMenu();
                        break;

                    case 2:
                        RemoveMenuItem();
                        break;

                    case 3:
                        PrintMenuList();
                        break; //Show current list

                    case 4:     //Exit
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
        public void CreateMenu()
        {
            MenuItem newItem = new MenuItem();
            Console.WriteLine("What is the meal number?");
            newItem.MealNumber = Console.ReadLine();

            Console.WriteLine("\nWhat is the meal price?");
            newItem.MealPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the meal name?");
            newItem.MealName = Console.ReadLine();

            Console.WriteLine("\nWhat is the meal description?");
            newItem.MealDescription = Console.ReadLine();

            Console.WriteLine("\nWhat are the meal ingredients?");
            newItem.Ingredients = Console.ReadLine();

            _itemRepo._menuItemList.Add(newItem);
        }

        public void PrintMenuList()
        {
            List<MenuItem> menuItemList = _itemRepo.GetMenuItemList();
            Console.WriteLine("MealNumber\t MealPrice\t MealName\t MealDescription\t Ingredients");
            foreach (MenuItem menuItem in menuItems)
            {
                Console.WriteLine($"{menuItem.MealNumber}\t{menuItem.MealPrice}\t{menuItem.MealName}\t{menuItem.MealDescription}\t{menuItem.Ingredients}");
            }
            Console.ReadLine();

        }

        public void RemoveMenuItem()
        {

            List<MenuItem> itemList = _itemRepo.GetMenuItemList();

            Console.WriteLine("\nPlease type in the menu item, using the meal name, that you would like removed.");
            foreach (MenuItem item in itemList)
            {
                Console.WriteLine($"{item.MealNumber}\t {item.MealName}\t {item.MealDescription}\t{item.Ingredients}\t{item.MealPrice:C:}");

            }
            var removedItem = Console.ReadLine();
            foreach (MenuItem item in itemList)
            {
                if (removedItem == item.MealName)
                {
                    _itemRepo.RemoveItemFromMenu(item);
                    break;
                }

                
            }
        }
    }
}

