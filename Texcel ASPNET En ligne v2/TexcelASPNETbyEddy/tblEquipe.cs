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
    
    public partial class tblEquipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEquipe()
        {
            this.tblTests = new HashSet<tblTest>();
            this.tblEmployes = new HashSet<tblEmploye>();
        }
    
        public int idEquipe { get; set; }
        public string nomEquipe { get; set; }
        public int idChefEquipe { get; set; }
        public int idDirecteur { get; set; }
    
        public virtual tblDirecteur tblDirecteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTest> tblTests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmploye> tblEmployes { get; set; }
    }
}
