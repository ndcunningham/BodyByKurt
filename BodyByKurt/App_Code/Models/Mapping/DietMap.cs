using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BodyByKurt.Models.Mapping
{
    public class DietMap : EntityTypeConfiguration<Diet>
    {
        public DietMap()
        {
            // Primary Key
            this.HasKey(t => t.Diet_Id);

            // Properties
            this.Property(t => t.Diet_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Food)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Diet");
            this.Property(t => t.Diet_Id).HasColumnName("Diet_Id");
            this.Property(t => t.Food).HasColumnName("Food");
            this.Property(t => t.Date_Time).HasColumnName("Date_Time");
            this.Property(t => t.Client_Id).HasColumnName("Client_Id");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.Diets)
                .HasForeignKey(d => d.Client_Id);

        }
    }
}
