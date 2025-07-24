using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookShop.DataAccess.Configurations
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "MasterSchema");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.catName).IsRequired().HasMaxLength(50);

            builder.Property(c => c.catOrder).IsRequired();

            builder.Ignore(c => c.crearedDate);

            builder.Property(c => c.markedAsDeleted).HasColumnName("IsDELETED");

            
            
        }
    }
}
