//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Неодобренные_заявки
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Неодобренные_заявки()
        {
            this.Одобренные_заявки = new HashSet<Одобренные_заявки>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_Активности { get; set; }
        public Nullable<int> id_Модератора { get; set; }
    
        public virtual Активности Активности { get; set; }
        public virtual Модераторы Модераторы { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Одобренные_заявки> Одобренные_заявки { get; set; }
    }
}
