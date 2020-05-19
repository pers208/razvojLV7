using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class Cart
    {
        private List<IItem> items;
        public Cart()
        {
            items = new List<IItem>();
        }
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public double Accept(IVisitor visitor)
        {   
            double price = 0;
            foreach(IItem item in items)
            {
                price += item.Accept(visitor);
            }
            return price;
        }
    }
}
