//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClienteXPedido
    {
        public int ID_ClienteXPedido { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_EstadoClienteXPedido { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual EstadoClienteXPedido EstadoClienteXPedido { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
