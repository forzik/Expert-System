//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ES_Problems_With_Car
{
    using System;
    using System.Collections.Generic;
    
    public partial class Defect_Reasons
    {
        public Defect_Reasons()
        {
            this.Car_Defects = new HashSet<Car_Defects>();
            this.Defect_Reasons1 = new HashSet<Defect_Reasons>();
        }
    
        public int ID { get; set; }
        public int NodeID { get; set; }
        public Nullable<int> DiagnosisID { get; set; }
        public Nullable<int> PreviousReasonsID { get; set; }
        public string Label { get; set; }
        public bool IsSelected { get; set; }
        public bool WasViewed { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Car_Defects> Car_Defects { get; set; }
        public virtual Car_System_Nodes Car_System_Nodes { get; set; }
        public virtual Reasons_Diagnosis Reasons_Diagnosis { get; set; }
        public virtual ICollection<Defect_Reasons> Defect_Reasons1 { get; set; }
        public virtual Defect_Reasons Defect_Reasons2 { get; set; }
    }
}
