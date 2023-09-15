using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Producto
    {
        public decimal Codigo { get; set; }
        public decimal Cantidad_Producto { get; set; }
        public float Porsentaje_Descuento { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }

        public Producto(decimal codigo, decimal cantidad_Producto, float porsentaje_Descuento, float precio, string descripcion)
        {
            Codigo = codigo;
            this.Cantidad_Producto = cantidad_Producto;
            this.Porsentaje_Descuento = porsentaje_Descuento;
            Precio = precio;
            this.Descripcion = descripcion;
        }
    }
}
