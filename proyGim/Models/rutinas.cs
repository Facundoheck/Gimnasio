//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyGim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rutinas
    {
        public int nro_rutina { get; set; }
        public string tipo { get; set; }
        public string ejercicio { get; set; }
        public Nullable<double> peso { get; set; }
        public Nullable<long> tiempo { get; set; }
    
        public virtual socios socios { get; set; }
    }
}
