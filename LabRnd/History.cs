//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabRnd
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
    {
        public int id { get; set; }
        public Nullable<int> url_id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> number_rnd { get; set; }
        public Nullable<int> range_min { get; set; }
        public Nullable<int> range_max { get; set; }
        public Nullable<int> result { get; set; }
    
        public virtual Resource Resource { get; set; }
    }
}
