using System;
using System.Collections.Generic;
using System.Text;
using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductCheckoutAttributesConfiguration : IEntityTypeConfiguration<TblProductCheckoutAttributes>
    {
        public void Configure(EntityTypeBuilder<TblProductCheckoutAttributes> builder)
        {
            
        }
    }
}
