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
    
    public partial class korisnik
    {
        public korisnik()
        {
            this.dokument = new HashSet<dokument>();
        }
    
        public int id_korisnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string br_telefona { get; set; }
        public string kor_ime { get; set; }
        public string lozinka { get; set; }
        public string status { get; set; }
        public Nullable<int> tip_korisnika_id_tipa { get; set; }
    
        public virtual ICollection<dokument> dokument { get; set; }
        public virtual tip_korisnika tip_korisnika { get; set; }
    }
}
