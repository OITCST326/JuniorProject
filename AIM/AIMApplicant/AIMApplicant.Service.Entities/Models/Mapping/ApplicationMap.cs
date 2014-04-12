using System.Data.Entity.ModelConfiguration;

namespace AIMApplicant.Service.Entities.Models.Mapping
{
    public class ApplicationMap : EntityTypeConfiguration<Application>
    {
        public ApplicationMap()
        {
            // Primary Key
            this.HasKey(t => t.applicationId);

            // Properties
            this.Property(t => t.preEmploymentStatement)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Applications");
            this.Property(t => t.applicationId).HasColumnName("applicationId");
            this.Property(t => t.applicantId).HasColumnName("applicantId");
            this.Property(t => t.dateCreated).HasColumnName("dateCreated");
            this.Property(t => t.preEmploymentStatement).HasColumnName("preEmploymentStatement");
            this.Property(t => t.jobId).HasColumnName("jobId");
            this.Property(t => t.status).HasColumnName("status");

            // Tracking Properties
			this.Ignore(t => t.TrackingState);
			this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.Applications)
                .HasForeignKey(d => d.applicantId);
            this.HasOptional(t => t.Job)
                .WithMany(t => t.Applications)
                .HasForeignKey(d => d.jobId);

        }
    }
}
