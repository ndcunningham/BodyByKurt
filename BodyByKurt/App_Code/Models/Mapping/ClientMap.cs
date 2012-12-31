using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BodyByKurt.Models.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => t.Client_Id);

            // Properties
            this.Property(t => t.F_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.L_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .HasMaxLength(10);

            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address2)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Client");
            this.Property(t => t.Client_Id).HasColumnName("Client_Id");
            this.Property(t => t.F_Name).HasColumnName("F_Name");
            this.Property(t => t.L_Name).HasColumnName("L_Name");
            this.Property(t => t.DOB).HasColumnName("DOB");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
