
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
    
public partial class Animal
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Animal()
    {

        this.Adoptions = new HashSet<Adoption>();

        this.Animal_Kennel_History = new HashSet<Animal_Kennel_History>();

        this.CrossBreeds = new HashSet<CrossBreed>();

        this.Foster_Care = new HashSet<Foster_Care>();

        this.Microchips = new HashSet<Microchip>();

        this.Vet_Appointment_Line = new HashSet<Vet_Appointment_Line>();

    }


    public int Animal_ID { get; set; }

    public string Animal_Image { get; set; }

    public string Animal_Name { get; set; }

    public string Animal_Description { get; set; }

    public string Animal_Gender { get; set; }

    public Nullable<int> Animal_Age { get; set; }

    public Nullable<bool> Animal_Sterilization { get; set; }

    public Nullable<bool> Animal_Castration { get; set; }

    public string Animal_Size { get; set; }

    public Nullable<System.DateTime> Animal_Entry_Date { get; set; }

    public string Animal_Coat { get; set; }

    public Nullable<int> Animal_Status_ID { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Adoption> Adoptions { get; set; }

    public virtual Animal_Status Animal_Status { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Animal_Kennel_History> Animal_Kennel_History { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CrossBreed> CrossBreeds { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Foster_Care> Foster_Care { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Microchip> Microchips { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Vet_Appointment_Line> Vet_Appointment_Line { get; set; }

}

}
