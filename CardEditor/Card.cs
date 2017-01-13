namespace CardEditor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Card
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string FlavorText { get; set; }

        [Required]
        [StringLength(20)]
        public string Cost { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int? CardLevel { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public string Notes { get; set; }

        public int Speed { get; set; }

        public int Reach { get; set; }

        [StringLength(20)]
        public string Version { get; set; }
    }
}
