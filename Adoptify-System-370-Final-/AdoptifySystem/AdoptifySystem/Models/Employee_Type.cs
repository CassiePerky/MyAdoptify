
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
    
public partial class Employee_Type
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Employee_Type()
    {

        this.Employees = new HashSet<Employee>();

    }


    public int Emp_Type_ID { get; set; }

    public string Emp_Type_Name { get; set; }

    public string Emp_Type_Description { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Employee> Employees { get; set; }

}

}
