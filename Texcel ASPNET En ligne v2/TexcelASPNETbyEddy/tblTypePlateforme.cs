//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TexcelASPNETbyEddy
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTypePlateforme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTypePlateforme()
        {
            this.tblPlateformes = new HashSet<tblPlateforme>();
        }
    
        public int idTypePlateforme { get; set; }
        public string nomTypePlateforme { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPlateforme> tblPlateformes { get; set; }
    }
}
