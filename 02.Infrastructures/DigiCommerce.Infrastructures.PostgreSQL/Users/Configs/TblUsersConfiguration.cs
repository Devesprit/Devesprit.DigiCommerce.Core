﻿using DigiCommerce.Core.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Users.Configs
{
    public class TblUsersConfiguration : IEntityTypeConfiguration<TblUsers>
    {
        public void Configure(EntityTypeBuilder<TblUsers> builder)
        {
            
        }
    }
}
