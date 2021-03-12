using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace Library
{
    public class ExcelSaver : ISaver 
    {
        public ExcelSaver(){}
        public void Exportar(Orden orden)
        {
            ArrayList myAL =  new ArrayList();
            myAL.Add($"Info de CLiente: {orden.Client.ClientName}, {orden.Client.Direccion}, {orden.Client.Pago.PagoInfo()}");
            myAL.Add(" Nombre producto " + "," + " ID de Producto " + "," + " Costo Unitario "+ "," + " Cantidad ");
            foreach (Item item in orden.ItemsToOrder)
            {
                myAL.Add(item.Detalles());
            }
            myAL.ToArray(typeof(string));

            using (StreamWriter outputFile = new StreamWriter($"{orden.OrdenID} {orden.FechaCreacion}.csv"))
            {
                foreach (string line in myAL)
                {
                    outputFile.WriteLine(line);
                }
            }
        }
    }
}