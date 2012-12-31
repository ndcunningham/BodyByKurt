using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BodyByKurt.Models.Mapping
{
    public class TipMap : EntityTypeConfiguration<Tip>
    {
        public TipMap()
        {
            // Primary Key
            this.HasKey(t => t.Tip_Id);

            // Properties
            this.Property(t => t.Tip_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tip_Desc)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tip");
            this.Property(t => t.Tip_Id).HasColumnName("Tip_Id");
            this.Property(t => t.Tip_Name).HasColumnName("Tip_Name");
            this.Property(t => t.Tip_Desc).HasColumnName("Tip_Desc");
        }
    }
}
