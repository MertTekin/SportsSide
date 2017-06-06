//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FACILITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACILITY()
        {
            this.FACILITY_PICTURES = new HashSet<FACILITY_PICTURES>();
            this.RESERVATIONs = new HashSet<RESERVATION>();
            this.SUBSCRIBERs = new HashSet<SUBSCRIBER>();
        }

        public int FACILITY_ID { get; set; }
        public int USER_ID { get; set; }
        [Required(ErrorMessage = "L�tfen tesis turu seciniz.")]
        public int FACILITY_TYPE { get; set; }
        [Required(ErrorMessage = "L�tfen ilce seciniz.")]
        public int DISTRICT_ID { get; set; }
        [Required(ErrorMessage = "L�tfen tesis adi giriniz.")]
        [StringLength(100, ErrorMessage = "Tesis adi uzunlugu maksimum 100 karakter olabilir.")]
        public string FACILITY_NAME { get; set; }
        [Required(ErrorMessage = "L�tfen tesis kapasitesi giriniz.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Tesis kapasitesi minimum 1 olabilir.")]
        public int FACILITY_CAPACITY { get; set; }
        public string FACILITY_ADDRESS { get; set; }
        [Required(ErrorMessage = "L�tfen rezervasyon fiyati giriniz.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Rezervasyon fiyati minimum 1 TL olabilir.")]
        public int FACILITY_PRICE { get; set; }
        public string FACILITY_CONTENT { get; set; }

        public virtual DISTRICT DISTRICT { get; set; }
        public virtual FACILITY_TYPE FACILITY_TYPE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACILITY_PICTURES> FACILITY_PICTURES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATIONs { get; set; }
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBSCRIBER> SUBSCRIBERs { get; set; }
    }
}