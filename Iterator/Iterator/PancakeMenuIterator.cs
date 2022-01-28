using System.Collections.Generic;

namespace Iterator.Iterator
{
    public class PancakeMenuIterator : IIterator<MenuItem>
    {
        private List<MenuItem> menuItems;
        private int position = 0;
        public PancakeMenuIterator(List<MenuItem> list)
        {
            this.menuItems = list;
        }
        public bool HasNext()
        {
            if (position >= menuItems.Count || menuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public MenuItem Next()
        {
            var menuItem = menuItems[position];
            position++;
            return menuItem;
        }
    }
}