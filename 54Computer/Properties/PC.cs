//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _54Computer.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class PC
    {
        public int PC_ID { get; set; }
        public string Islemci { get; set; }
        public int RAM { get; set; }
        public int Depolama { get; set; }
    
        public virtual Bilgisayar Bilgisayar { get; set; }
    }
}
