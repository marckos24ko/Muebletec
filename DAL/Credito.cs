//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Credito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Credito()
        {
            this.Recibo = new HashSet<Recibo>();
        }
    
        public long Id { get; set; }
        public decimal Monto { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public int CantidadCuotas { get; set; }
        public decimal MontoCuota { get; set; }
        public string Estado { get; set; }
        public decimal TotalAbonado { get; set; }
        public long ClienteId { get; set; }
        public System.DateTime FechaCancelacion { get; set; }
        public int CodigoCredito { get; set; }
        public Nullable<int> Interes { get; set; }
        public string TipoCredito { get; set; }
        public Nullable<bool> Refinanciado { get; set; }
        public Nullable<bool> Extension { get; set; }
        public Nullable<int> CodigoCreditoBase { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recibo> Recibo { get; set; }
    }
}
