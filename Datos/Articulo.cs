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
    
    public partial class Articulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulo()
        {
            this.Detalle = new HashSet<Detalle>();
        }
    
        public int ID_Articulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<double> Precio { get; set; }
        public int ID_EstadoArticulo { get; set; }
        public int ID_CategoriaArticulo { get; set; }
        public Nullable<double> PrecioDelivery { get; set; }
    
        public virtual CategoriaArticulo CategoriaArticulo { get; set; }
        public virtual EstadoArticulo EstadoArticulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}
