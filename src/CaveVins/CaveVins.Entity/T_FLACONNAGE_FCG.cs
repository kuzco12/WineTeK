//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaveVins.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_FLACONNAGE_FCG
    {
        public T_FLACONNAGE_FCG()
        {
            this.T_BOUTEILLE_BTL = new HashSet<T_BOUTEILLE_BTL>();
        }
    
        public int FCG_I_ID { get; set; }
        public string FCG_S_NOM { get; set; }
        public int FCG_R_CONTENANCE { get; set; }
    
        public virtual ICollection<T_BOUTEILLE_BTL> T_BOUTEILLE_BTL { get; set; }
    }
}
