using System;

namespace Library
{
    public class ItemDiscount2 : IitemDiscount
    { 

        public int AplicarDescuento(Item item, int subTotalAntesDeDescuento)
        {
            return (subTotalAntesDeDescuento * 5) / 100;   
        }

        public bool ChekDiscount(Item item, int subTotalAntesDeDescuento)
        {
            if (item.CostoUnitario > 150)
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