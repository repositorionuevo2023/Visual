using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class DetalleDelPedido
    {
        public float Cantidad_Total
        {
            get
            {
                return (Producto.Precio * (float)Cantidad) - Descuento; 
            }
        }

        public float Descuento { get; set; }

        public decimal Codigo_del_Producto { get; set; }
        public decimal Cantidad { get; set; }
        public string Dirreccion_de_Entrega { get; set; }

        public DetalleDelPedido(decimal codigo_del_Producto, decimal cantidad, string dirreccion_de_Entrega)
        {
            Codigo_del_Producto = codigo_del_Producto;
            Cantidad = cantidad;
            Dirreccion_de_Entrega = dirreccion_de_Entrega;
        }

        public float Precio
        {
            get
            {
                return Producto.Precio;
            }
        }

        public Producto Producto { get; set; }
        public string Producto1
        {
            get
            {

                return Producto.Descripcion; 
            }
        }
            
    }
}
