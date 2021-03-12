using System;
using System.Collections.Generic;

//Ya que la clase carrito es la experta en la informacion tanto de los items que se quieren ordenar como de el precio de los mismos, esta es la encargada de 
//calcular el precio total con su descuento especifico y tambien de iniciar el proceso de checkout ya que tiene toda la informacion necesaria para hacerlo
//
//Esta clase tambien cumple con el principio de inversion de dependencias al estar compuesta por ICarritoDisocunt, de esta forma permitiendo agregar nuevos descuentos
//sin la necesidad de depender de una clase nueva de descuento
//
//Por ultimo el metodo TotalCompra() utiliza el patron Creator por razon de que usa de forma muy cercana estos descuentos
namespace Library
{
    public class Carrito
    {
        public List<Item> Items = new List<Item>();
        private List<ICarritoDiscount> Discounts = new List<ICarritoDiscount>();
        public Carrito(Cliente cliente1)
        {
            this.Cliente1 = cliente1;
        }
        public Cliente Cliente1{get;}
        
        public void AddItem(Item item, Catalogo catalogo)
        {
            if(catalogo.CantidadDeProducto(item.Producto) >= item.Cantidad)
            {
                int i = 0;
                Items.Add(item);
                while (i <= item.Cantidad)
                {
                    catalogo.RemoveProduct(item.Producto);
                    i += 1;
                }  
            }
            else
            {
                throw new NullReferenceException(message: "Ese producto no esta disponible debido a que no hay más disponibles");
            }
        }
        public void RemoveItem(Item item, Catalogo catalogo)
        {
            if (Items.Contains(item))
            {
                int i = 0;
                this.Items.Remove(item);
                while (i <= item.Cantidad)
                {
                    catalogo.AddProduct(item.Producto);
                    i += 1;
                }  
            }
            else
            {
                throw new NullReferenceException(message: "No se encuentra este item en el carrito");
            }
        }
        public double PesoTotal()
        {
            double peso = 0;
            foreach (Item item in Items)
            {
                peso += item.Producto.Peso * item.Cantidad;
            }
            return peso;
        }
        public double TotalCompraAntesDeDescuento()
        {
            double cant = 0;
            foreach (Item item in Items)
            {
                cant += item.SubTotal();
            } 
            return cant + Cliente1.Envio.CostoTotal(this.PesoTotal());
        }
        public double TotalCompra()
        {
            Discounts.Add(new CarritoDiscount1());
            Discounts.Add(new CarritoDiscount2());

            foreach(ICarritoDiscount discount in Discounts)
            {
                if (discount.CheckDiscount(this, Cliente1.Envio))
                {
                    return discount.AplicarDescuento(this, Cliente1.Envio);
                }
            }

            return TotalCompraAntesDeDescuento();
        }
        public string CarritoDetails()
        {
            string result = "";
            int prodNum = 1;
            foreach (Item item in this.Items)
            {
                result += $"Producto {prodNum}+\n----------+\n" + item.Detalles();
                prodNum += 1;
            }
            return result;
        }

        public Orden InitiateCheckout()
        {
            Orden ordenAEnviar = new Orden(this.Cliente1, this.Items);
            ordenAEnviar.Subscribe(Cliente1.Envio);
            ordenAEnviar.PlaceOrder();
            return ordenAEnviar;
        }
    }
}
