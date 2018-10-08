namespace Assign1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int playerID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Points Per Game (PPG)")]
        public decimal pointsPerGame { get; set; }

        public int teamID { get; set; }

        public virtual Team Team { get; set; }
    }
}
