
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
    
public partial class TONKHO_TAHP
{

    public string MA_HANG { get; set; }

    public string MA_KHO_CON { get; set; }

    public int SL_TAHP { get; set; }



    public virtual DM_KHO DM_KHO { get; set; }

    public virtual HH HH { get; set; }

}

}