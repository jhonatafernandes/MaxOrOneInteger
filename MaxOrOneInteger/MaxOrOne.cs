using System.Collections.Generic;
using System.Linq;

namespace MaxOrOneInteger
{
    public static class MaxOrOne
    {
        public static int AddLinesByQuantity(this int number, int quantity, int otherQuantity)
        {
            var quantities = new List<int>{quantity, otherQuantity};
            
            var quantitiesReturn = quantities.Max();

            return quantitiesReturn > 0 ? quantitiesReturn : 1;
        }
    }
}
