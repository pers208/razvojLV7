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
        private IVisitor visitor;
        public Cart()
        {
            items = new List<IItem>();
        }
        public void setVisitor(IVisitor visitor)
        {
            this.visitor = visitor;
        }
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public double Accept()
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
