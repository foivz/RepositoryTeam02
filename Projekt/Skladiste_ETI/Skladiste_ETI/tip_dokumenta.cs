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
    
    public partial class tip_dokumenta
    {
        public tip_dokumenta()
        {
            this.dokument = new HashSet<dokument>();
        }
    
        public int id_tipa { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<dokument> dokument { get; set; }
    }
}
