using System;

namespace Library
{
    public class HigienePersonal: ICategoria
    {
        public HigienePersonal()
        {
            this.CategoryID = 1;
            this.Name = "Higiene Personal";
            this.Description = "Productos de higiene personal";
            this.Discount = 0;
        }
        public int CategoryID{get;} 
        public string Name{get;} 
        public string Description{get;}
        public int Discount{get;}

    }
}