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
    
    public partial class MesaXReserva
    {
        public int ID_MesaXReserva { get; set; }
        public int ID_Mesa { get; set; }
        public int ID_Reserva { get; set; }
    
        public virtual Mesa Mesa { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
