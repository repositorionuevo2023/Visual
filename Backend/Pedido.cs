using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Pedido
    {
        public decimal Codigo_del_Producto { get; set; }
        public decimal Cantidad_Pedidos { get; set; }
        public decimal Numero_de_Orden { get; set; }
        public string Dirreccion_de_Entrega { get; set; }

        public Pedido(string dirreccion_de_Entrega, decimal codigo_del_Producto, decimal cantidad, decimal numero_de_Orden)
        {
            Dirreccion_de_Entrega = dirreccion_de_Entrega;
            Codigo_del_Producto = codigo_del_Producto;
            Cantidad_Pedidos = cantidad;
            Numero_de_Orden = numero_de_Orden;

        }
    }
}
