
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ERP.Web.Models.Database
{

using System;
    using System.Collections.Generic;
    
public partial class CCTC_PHONG_BAN
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CCTC_PHONG_BAN()
    {

        this.CCTC_NHAN_VIEN = new HashSet<CCTC_NHAN_VIEN>();

        this.HT_NHIEM_VU_PHONG_BAN = new HashSet<HT_NHIEM_VU_PHONG_BAN>();

        this.MENU_USER = new HashSet<MENU_USER>();

        this.NH_CT_NTTK = new HashSet<NH_CT_NTTK>();

        this.NH_CT_UNC = new HashSet<NH_CT_UNC>();

        this.HT_THONG_BAO_MARKETING = new HashSet<HT_THONG_BAO_MARKETING>();

    }


    public string MA_PHONG_BAN { get; set; }

    public string TEN_PHONG_BAN { get; set; }

    public string SDT { get; set; }

    public string MA_CONG_TY { get; set; }

    public string GHI_CHU { get; set; }



    public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CCTC_NHAN_VIEN> CCTC_NHAN_VIEN { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HT_NHIEM_VU_PHONG_BAN> HT_NHIEM_VU_PHONG_BAN { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MENU_USER> MENU_USER { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<NH_CT_NTTK> NH_CT_NTTK { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<NH_CT_UNC> NH_CT_UNC { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HT_THONG_BAO_MARKETING> HT_THONG_BAO_MARKETING { get; set; }

}

}
