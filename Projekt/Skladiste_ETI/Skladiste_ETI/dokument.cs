//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skladiste_ETI
{
    using System;
    using System.Collections.Generic;
    
    public partial class dokument
    {
        public dokument()
        {
            this.stavke = new HashSet<stavke>();
        }
    
        public int id_dokumenta { get; set; }
        public int korisnik_id_korisnika { get; set; }
        public int tip_dokumenta_id_tipa { get; set; }
        public int poslovni_partner_id_partnera { get; set; }
        public System.DateTime datum { get; set; }
        public bool status { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        public virtual poslovni_partner poslovni_partner { get; set; }
        public virtual tip_dokumenta tip_dokumenta { get; set; }
        public virtual ICollection<stavke> stavke { get; set; }
    }
}
