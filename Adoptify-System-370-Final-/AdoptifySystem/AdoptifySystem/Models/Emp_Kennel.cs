
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
    
public partial class Emp_Kennel
{

    public int Emp_Kennel_ID { get; set; }

    public Nullable<int> Emp_ID { get; set; }

    public Nullable<int> Kennel_ID { get; set; }



    public virtual Employee Employee { get; set; }

    public virtual Kennel Kennel { get; set; }

}

}
