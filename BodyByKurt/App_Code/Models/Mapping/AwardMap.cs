using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using BodyByKurt.Models;

namespace BodyByKurt.Models.Mapping
{
    public class AwardMap : EntityTypeConfiguration<Award>
    {
        public AwardMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Award_Name, t.Award_Date, t.Client_Id });

            // Properties
            this.Property(t => t.Award_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Client_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Award");
            this.Property(t => t.Award_Name).HasColumnName("Award_Name");
            this.Property(t => t.Award_Date).HasColumnName("Award_Date");
            this.Property(t => t.Client_Id).HasColumnName("Client_Id");
        }
    }
}
