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
    
    public partial class Caja
    {
        public int ID_Caja { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan Hora { get; set; }
        public double Monto { get; set; }
        public string Detalle { get; set; }
        public Nullable<int> ID_Pedido { get; set; }
        public int ID_TipoDeMonto { get; set; }
        public int ID_EstadoCaja { get; set; }
        public int ID_Usuario { get; set; }
    
        public virtual EstadoCaja EstadoCaja { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual TipoDeMonto TipoDeMonto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
