//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FollowLifeAPI.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class IndicatorType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IndicatorType()
        {
            this.Indicator = new HashSet<Indicator>();
        }
    
        public int Id { get; set; }
        public int UnitofMeasurementId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indicator> Indicator { get; set; }
        public virtual UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
