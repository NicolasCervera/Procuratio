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
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.Caja = new HashSet<Caja>();
            this.Detalle = new HashSet<Detalle>();
            this.PedidoXMesa = new HashSet<PedidoXMesa>();
            this.ClienteXPedido = new HashSet<ClienteXPedido>();
        }
    
        public int ID_Pedido { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan Hora { get; set; }
        public int CantidadPersonas { get; set; }
        public Nullable<double> TotalPedido { get; set; }
        public int ID_EstadoPedido { get; set; }
        public int ID_Cliente { get; set; }
        public Nullable<int> ID_Reserva { get; set; }
        public int ID_Chef { get; set; }
        public string Nota { get; set; }
        public Nullable<System.DateTime> TiempoEspera { get; set; }
        public Nullable<int> ID_Delivery { get; set; }
        public Nullable<int> ID_Mozo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Caja { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Delivery Delivery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle> Detalle { get; set; }
        public virtual EstadoPedido EstadoPedido { get; set; }
        public virtual Reserva Reserva { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoXMesa> PedidoXMesa { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteXPedido> ClienteXPedido { get; set; }
    }
}