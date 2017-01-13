namespace CardEditor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CardEffect
    {
        public int Id { get; set; }

        [Required]
        public string EffectText { get; set; }

        public int Target { get; set; }

        public int EffectTrigger { get; set; }

        public int FireCondition { get; set; }

        public int ConditionValue { get; set; }

        public int TriggerTarget { get; set; }

        [Required]
        [StringLength(20)]
        public string Value { get; set; }

        [Required]
        [StringLength(20)]
        public string Cost { get; set; }

        public int Duration { get; set; }

        public int Effect { get; set; }
    }
}
