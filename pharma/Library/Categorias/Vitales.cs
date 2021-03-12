using System;

namespace Library
{
    public class Vitales: ICategoria
    {
        public Vitales()
        {
            this.CategoryID = 1;
            this.Name = "Vitales";
            this.Description = "Productos vitales para una persona";
            this.Discount = 5;
        }
        public int CategoryID{get;} 
        public string Name{get;} 
        public string Description{get;}
        public int Discount{get;}

    }
}