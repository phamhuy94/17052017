
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
    
public partial class NH_CHUYEN_TIEN_NOI_BO
{

    public string SO_CHUNG_TU { get; set; }

    public System.DateTime NGAY_CHUNG_TU { get; set; }

    public System.DateTime NGAY_HACH_TOAN { get; set; }

    public string TAI_KHOAN_DI { get; set; }

    public string TAI_KHOAN_DEN { get; set; }

    public string LY_DO_CHUYEN { get; set; }

    public string LOAI_TIEN { get; set; }

    public decimal TY_GIA { get; set; }

    public string TK_NO { get; set; }

    public string TK_CO { get; set; }

    public decimal SO_TIEN { get; set; }

    public decimal QUY_DOI { get; set; }

    public string TRUC_THUOC { get; set; }

    public string NGUOI_LAP_PHIEU { get; set; }



    public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }

    public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }

    public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN { get; set; }

    public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN1 { get; set; }

    public virtual DM_TK_NGAN_HANG_NOI_BO DM_TK_NGAN_HANG_NOI_BO { get; set; }

    public virtual DM_TK_NGAN_HANG_NOI_BO DM_TK_NGAN_HANG_NOI_BO1 { get; set; }

}

}
