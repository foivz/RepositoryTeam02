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
    
    public partial class artikli
    {
        public artikli()
        {
            this.stavke = new HashSet<stavke>();
        }
    
        public int id_artikla { get; set; }
        public Nullable<int> br_serije { get; set; }
        public string naziv { get; set; }
        public Nullable<int> trenutna_kolicina { get; set; }
        public Nullable<float> cijena { get; set; }
        public Nullable<int> frekvencija_izlaska_id_frekvencije { get; set; }
        public Nullable<int> minimalna_kolicina { get; set; }
        public Nullable<int> mjesto_id_mjesta { get; set; }
    
        public virtual mjesto mjesto { get; set; }
        public virtual ICollection<stavke> stavke { get; set; }
    }
}
