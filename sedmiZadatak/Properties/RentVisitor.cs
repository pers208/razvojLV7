using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class RentVisitor:IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        private const double BookTax = 0.15;
        public double Visit(DVD DVDItem)
        {   if (DVDItem.Type == DVDType.SOFTWARE) return DVDItem.Price * (1 + DVDTax);
            return DVDItem.Price * (0.1 + DVDTax);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (0.1 + VHSTax);
        }

        public double Visit(Book BookItem)
        {
            return BookItem.Price * (0.1 + BookTax);
        }
    }
}
