//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoptifySystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vet_Appointment_Line
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vet_Appointment_Line()
        {
            this.Capture_Medical_Card = new HashSet<Capture_Medical_Card>();
        }
    
        public int Vet_Appoint_Line_ID { get; set; }
        public Nullable<int> Vet_Appoint_Line_Status { get; set; }
        public Nullable<int> Animal_ID { get; set; }
        public Nullable<int> Vet_Appointment_ID { get; set; }
    
        public virtual Animal Animal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Capture_Medical_Card> Capture_Medical_Card { get; set; }
        public virtual Vet_Appointment Vet_Appointment { get; set; }
    }
}
