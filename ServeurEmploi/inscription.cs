//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServeurEmploi
{
    using System;
    using System.Collections.Generic;
    
    public partial class inscription
    {
        public int id_module { get; set; }
        public int id_etudiant { get; set; }
        public int groupe { get; set; }
        public int section { get; set; }
    
        public virtual module module { get; set; }
        public virtual utilisateur utilisateur { get; set; }
    }
}