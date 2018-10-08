namespace Assign1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            Players = new HashSet<Player>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int teamID { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(50)]
        public string teamName { get; set; }

        [Required]
        [StringLength(50)]
        public string stadium { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Players { get; set; }
    }
}