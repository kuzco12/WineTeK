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
    
    public partial class T_EMPLACEMENT_EMP
    {
        public T_EMPLACEMENT_EMP()
        {
            this.T_STOCKAGE_STO = new HashSet<T_STOCKAGE_STO>();
        }
    
        public long EMP_I_ID { get; set; }
        public Nullable<long> LIE_I_ID { get; set; }
        public Nullable<int> EMP_I_POSH { get; set; }
        public Nullable<int> EMP_I_POSV { get; set; }
    
        public virtual T_LIEU_LIE T_LIEU_LIE { get; set; }
        public virtual ICollection<T_STOCKAGE_STO> T_STOCKAGE_STO { get; set; }
    }
}
