//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCANBs.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SituacaoPagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SituacaoPagamento()
        {
            this.Pagamento = new HashSet<Pagamento>();
        }
    
        public short IdSituacaoPagamento { get; set; }
        public string DescricaoSituacaoPagamento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagamento> Pagamento { get; set; }
    }
}
