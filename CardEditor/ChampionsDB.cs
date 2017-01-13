namespace CardEditor
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChampionsDB : DbContext
    {
        public ChampionsDB()
            : base("name=ChampionsDB")
        {
        }

        public virtual DbSet<CardEffect> CardEffects { get; set; }
        public virtual DbSet<CardEffectsJoin> CardEffectsJoins { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardType> CardTypes { get; set; }
        public virtual DbSet<CardTypesJoin> CardTypesJoins { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<Effect> Effects { get; set; }
        public virtual DbSet<EffectTrigger> EffectTriggers { get; set; }
        public virtual DbSet<Target> Targets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Effect>()
                .Property(e => e.ShortName)
                .IsFixedLength();

            modelBuilder.Entity<Target>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
