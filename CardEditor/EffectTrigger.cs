namespace CardEditor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EffectTrigger
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FireWhen { get; set; }

        [Required]
        [StringLength(50)]
        public string FireText { get; set; }
    }
}
