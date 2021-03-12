using System;

namespace Library
{
    public class ItemDiscount3 : IitemDiscount
    {

        public int AplicarDescuento(Item item, int subTotalAntesDeDescuento)
        {
            return (subTotalAntesDeDescuento * 15) / 100;
        }

        public bool ChekDiscount(Item item, int subTotalAntesDeDescuento)
        {
            if (item.Marca == "AXE")
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