//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_De_Cafeteria
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProveedoresProducto
    {
        public int Id { get; set; }
        public Nullable<int> ProveedorId { get; set; }
        public Nullable<int> ProductoId { get; set; }
    
        public virtual Proveedore Proveedore { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
