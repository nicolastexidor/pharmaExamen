using System;

namespace Library
{
    public class ItemDiscount1 : IitemDiscount
    {

        public int AplicarDescuento(Item item, int subTotalAntesDeDescuento)
        {
            return (subTotalAntesDeDescuento * 10) / 100;  
        }
        public bool ChekDiscount(Item item, int subTotalAntesDeDescuento)
        {
            if (item.Cantidad > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}