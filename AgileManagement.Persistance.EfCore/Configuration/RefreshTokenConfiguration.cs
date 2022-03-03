using AgileManagement.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Persistance.EfCore.Configuration
{
    public class RefreshTokenConfiguration
    {

        public void Configure(EntityTypeBuilder<UserRefreshToken> builder)
        {

            builder.Property(r => r.Code).IsRequired();


        }
    }
}
