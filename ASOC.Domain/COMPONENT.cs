//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASOC.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPONENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPONENT()
        {
            this.CURRENT_STATUS = new HashSet<CURRENT_STATUS>();
        }
    
        public Nullable<decimal> ID_SERIES { get; set; }
        public Nullable<decimal> ID_MODEL { get; set; }
        public Nullable<decimal> ID_TYPE { get; set; }
        public string NAME { get; set; }
        public Nullable<System.DateTime> DATE_ADD { get; set; }
        public string PARTNUMBER { get; set; }
        public decimal ID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
    
        public virtual MODEL MODEL { get; set; }
        public virtual TYPE TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURRENT_STATUS> CURRENT_STATUS { get; set; }
    }
}
