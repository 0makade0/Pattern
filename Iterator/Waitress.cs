using System;
using Iterator.Iterator;

namespace Iterator
{
    public class Waitress
    {
        private PancakeMenu _pancakeMenu;
        private DinerMenu _dinerMenu;

        public Waitress(PancakeMenu pancakeMenu, DinerMenu dinerMenu)
        {
            this._pancakeMenu = pancakeMenu;
            this._dinerMenu = dinerMenu;
        }

        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Name} - {menuItem.Price}");
                Console.WriteLine($"{menuItem.Description}");
            }
        }

        public void PrintMenu()
        {
            IIterator<MenuItem> pancakeIterator = _pancakeMenu.CreateIterator();
            IIterator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();
            Console.WriteLine("Menu");
            Console.WriteLine("Pancake house");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\nDinner Menu");
            PrintMenu(dinerIterator);
        }
    }
}