
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AdoptifySystem.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Foster_Care_Parent
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Foster_Care_Parent()
    {

        this.Foster_Care = new HashSet<Foster_Care>();

    }


    public int Foster_Parent_ID { get; set; }

    public string Foster_Parent_Name { get; set; }

    public string Foster_Parent_Surname { get; set; }

    public string Foster_Parent_Address { get; set; }

    public string Foster_Parent_CellNumber { get; set; }

    public string Foster_Parent_WorkNumber { get; set; }

    public string Foster_Parent_Email { get; set; }

    public Nullable<int> Foster_Parent_IDNumber { get; set; }

    public Nullable<System.DateTime> Foster_Parent_Last_Modified { get; set; }

    public Nullable<int> Num_In_Household { get; set; }

    public string Type_Of_Housing { get; set; }

    public string Ownership_Housing { get; set; }

    public Nullable<int> Hours_Left_Alone { get; set; }

    public Nullable<int> Adopter_ID { get; set; }



    public virtual Adopter Adopter { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Foster_Care> Foster_Care { get; set; }

}

}
