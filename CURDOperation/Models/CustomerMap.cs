using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CURDOperation.Models
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityBuilder)  
        {  
            entityBuilder.HasKey(t => t.Id);              
            entityBuilder.Property(t => t.Name).IsRequired();  
            entityBuilder.Property(t => t.LastName).IsRequired();  
            entityBuilder.Property(t => t.Email).IsRequired();  
            entityBuilder.Property(t => t.MobileNo).IsRequired();             
        }  
    }
}