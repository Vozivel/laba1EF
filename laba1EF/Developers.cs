//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laba1EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Developers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Developers()
        {
            this.Games = new HashSet<Games>();
        }
    
        public int ID_Developer { get; set; }
        public string Studio_Name { get; set; }
        public Nullable<int> Studio_Age { get; set; }
        public string Studio_Owner { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Games> Games { private get; set; }
    }
}
