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
    
    public partial class Car_Systems
    {
        public Car_Systems()
        {
            this.Car_System_Nodes = new HashSet<Car_System_Nodes>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public bool WasViewed { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Car_System_Nodes> Car_System_Nodes { get; set; }
    }
}
