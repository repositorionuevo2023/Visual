using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Proveedor
    {
        public string Nombre_Comercial { get; set; }
        public string Dirreccion_Fiscal { get; set; }
        public string Dirreccion_de_Entrega { get; set; }
        public decimal Numero_de_Pedido { get; set; }
        public decimal Fecha { get; set; }
        public float Porsentaje { get; set; }

        public Proveedor(string nombre_Comercial, string dirreccion_Fiscal, string dirreccion_de_Entrega, decimal numero_de_Pedido, decimal fecha, float porsentaje)
        {
            Nombre_Comercial = nombre_Comercial;
            Dirreccion_Fiscal = dirreccion_Fiscal;
            Dirreccion_de_Entrega = dirreccion_de_Entrega;
            Numero_de_Pedido = numero_de_Pedido;
            Fecha = fecha;
            Porsentaje = porsentaje;
        }
    }
}
