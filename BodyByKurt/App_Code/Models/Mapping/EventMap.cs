using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BodyByKurt.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Event_Name, t.Date_Time });

            // Properties
            this.Property(t => t.Event_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Place)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dec)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Event");
            this.Property(t => t.Event_Name).HasColumnName("Event_Name");
            this.Property(t => t.Date_Time).HasColumnName("Date_Time");
            this.Property(t => t.Place).HasColumnName("Place");
            this.Property(t => t.Dec).HasColumnName("Dec");
        }
    }
}
